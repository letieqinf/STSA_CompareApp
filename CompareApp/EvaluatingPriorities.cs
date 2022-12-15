using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareApp
{
    public partial class EvaluatingPriorities : Form
    {
        private readonly ExpertConfiguring _expertForm;
        private int _current;
        
        public double[][] NormalizedVector = Array.Empty<double[]>();
        public readonly double[] Weights = Array.Empty<double>();
        public readonly string[] Alternatives = Array.Empty<string>();
        
        private double[][][] _evaluatedValues = Array.Empty<double[][]>();
        
        
        public EvaluatingPriorities(ExpertConfiguring expertForm)
        {
            _expertForm = expertForm;
            _current = 0;
            foreach (var expert in _expertForm.ExpertsArray)
                Weights = Weights.Append(expert.Weight).ToArray();
            foreach (var alternatives in _expertForm.ExpertsArray[0].AltList)
                Alternatives = Alternatives.Append(alternatives.Alternative).ToArray();

            InitializeComponent();

            expertLabel.Text = _expertForm.ExpertsArray[0].Name;
            if (_expertForm.ExpertsArray.Length == 1)
                nextBtn.Enabled = false;
            weightTb.Text = _expertForm.ExpertsArray[0].Weight.ToString(CultureInfo.InvariantCulture);

            for (var i = 0; i < _expertForm.ExpertsArray[0].AltList.Length; i++)
            {
                var alternative = new RichTextBox();
                alternative.Text = _expertForm.ExpertsArray[0].AltList[i].Alternative;
                alternative.ReadOnly = true;
                alternative.Name = $"alternativeRichTb{i + 1}";

                alternative.Size = new Size(
                    alternativeLabel.Size.Width,
                    52
                );
                
                alternative.Location = new Point(
                    alternativeLabel.Location.X,
                    alternativeLabel.Location.Y 
                    + alternativeLabel.Size.Height 
                    + i * (alternative.Size.Height + 10) + 10
                );
                
                Controls.Add(alternative);
            }
            
            EvaluatePriorities();
            Normalize();
            
            CreateTable(0);

            var finalForm = new Final(this);
            finalForm.Show();
        }

        private void CreateTable(int expertId)
        {
            for (var i = 0; i < _expertForm.ExpertsArray[expertId].AltList.Length; i++)
            {
                var alternative = Controls[$"alternativeRichTb{i + 1}"];

                var estimation = new TextBox();
                estimation.ReadOnly = true;
                estimation.TextAlign = HorizontalAlignment.Center;
                estimation.Name = $"estimationTb{i + 1}";
                estimation.Text = _expertForm
                    .ExpertsArray[expertId]
                    .AltList[i]
                    .Estimation
                    .ToString(CultureInfo.InvariantCulture);

                estimation.Size = new Size(50, 20);

                estimation.Location = new Point(
                    priorityLabel.Location.X,
                    alternative.Location.Y + alternative.Size.Height / 2 - estimation.Size.Height / 2
                );

                for (var j = 0; j < _evaluatedValues[expertId].Length; j++)
                {
                    var evaluation = new TextBox();
                    evaluation.Text = Math.Round(_evaluatedValues[expertId][j][i], 3).ToString("0.000");
                    evaluation.TextAlign = HorizontalAlignment.Center;
                    evaluation.ReadOnly = true;
                    evaluation.Size = estimation.Size;
                    evaluation.Name = $"evaluationTb{j + _evaluatedValues[expertId].Length * i + 1}";
                    
                    evaluation.Location = new Point(
                        estimation.Location.X + j * (evaluation.Size.Width + 10) + estimation.Size.Width + 10,
                        estimation.Location.Y
                    );
                    
                    Controls.Add(evaluation);
                }
                
                Controls.Add(estimation);

                var block = _evaluatedValues[expertId].Length == 0
                    ? estimation
                    : Controls[$"evaluationTb{_evaluatedValues[expertId].Length * (i + 1)}"];

                var normLabel = new Label();
                normLabel.Text = "Нормированные значения";
                normLabel.Size = new Size(200, 22);
                normLabel.TextAlign = ContentAlignment.MiddleCenter;
                normLabel.Font = new Font("Candara", 
                    12F,
                    FontStyle.Bold, 
                    GraphicsUnit.Point, 
                    ((byte)(204)));
                normLabel.Name = "normLabel";

                normLabel.Location = new Point(
                    (priorityLabel.Location.X + priorityLabel.Size.Width - block.Location.X - block.Size.Width > 0)
                    ? priorityLabel.Location.X + priorityLabel.Size.Width + 10
                    : block.Location.X + block.Size.Width + 10,
                    priorityLabel.Location.Y
                    );
                
                Controls.Add(normLabel);

                var norm = new TextBox();
                norm.Text = Math.Round(NormalizedVector[expertId][i], 3).ToString("0.000");
                norm.TextAlign = HorizontalAlignment.Center;
                norm.BackColor = Color.DarkSeaGreen;
                norm.ReadOnly = true;
                norm.Size = block.Size;
                norm.Name = $"normTb{i + 1}";

                norm.Location = new Point(
                    normLabel.Location.X + normLabel.Size.Width / 2 - norm.Size.Width / 2,
                    block.Location.Y
                );
                    
                Controls.Add(norm);
            }
        }

        private struct Element<T1, T2>
        {
            public T1 Field1 { get; set; }
            public T2 Field2 { get; set; }
        }

        private void EvaluatePriorities()
        {
            foreach (var expert in _expertForm.ExpertsArray)
            {
                var revaluationsList = Array.Empty<double[]>();
                
                var revaluation = Array.Empty<double>();
                var relativePriority = Array.Empty<bool>();
                    
                foreach (var expertEstimation in expert.AltList)
                {
                    revaluation = revaluation.Append(expertEstimation.Estimation).ToArray();
                    relativePriority = relativePriority.Append(expertEstimation.RelativePriority).ToArray();
                }
                
                var sorted = SortArray(revaluation, relativePriority);
                Array.Reverse(revaluation);
                Array.Reverse(sorted);
                    
                relativePriority = Array.Empty<bool>();
                var primaryIndices = Array.Empty<int>();
                    
                foreach (var element in sorted)
                {
                    relativePriority = relativePriority.Append(element.Field1).ToArray();
                    primaryIndices = primaryIndices.Append(element.Field2).ToArray();
                }
                
                while (!IsCorrect(revaluation, relativePriority))
                {
                    for (var altIndex = 0; altIndex < revaluation.Length; altIndex++)
                    {
                        var sum = revaluation.Where((t, k) => k > altIndex).Sum();
                        if (sum == 0)
                            continue;

                        if (relativePriority[altIndex])
                        {
                            if (revaluation[altIndex] > sum)
                                continue;

                            revaluation[altIndex] = sum + 0.1;
                            continue;
                        }
                        
                        if (revaluation[altIndex] < sum)
                            continue;

                        revaluation[altIndex] = sum / 2;
                    }

                    var revaluationTmp = new double[revaluation.Length];
                    revaluation.CopyTo(revaluationTmp, 0);

                    var indicesCopy = new int[primaryIndices.Length];
                    primaryIndices.CopyTo(indicesCopy, 0);
                    
                    Array.Sort(indicesCopy, revaluationTmp);
                    revaluationsList = revaluationsList.Append(revaluationTmp).ToArray();
                }

                _evaluatedValues = _evaluatedValues.Append(revaluationsList).ToArray();
            }
        }

        private static Element<bool, int>[] SortArray(double[] estimation, bool[] priority)
        {
            var result = Array.Empty<Element<bool, int>>();
            for (var i = 0; i < estimation.Length; i++)
            {
                result = result.Append(new Element<bool, int>()
                {
                    Field1 = priority[i],
                    Field2 = i
                }).ToArray();
            }

            for (var i = 0; i < estimation.Length; i++)
            {
                for (var j = i + 1; j < estimation.Length; j++)
                {
                    if (!(estimation[i] > estimation[j])) 
                        continue;
                    
                    (estimation[i], estimation[j]) = (estimation[j], estimation[i]);
                    (result[i], result[j]) = (result[j], result[i]);
                }
            }

            return result;
        }

        private static bool IsCorrect(double[] estimation, bool[] relativePriority)
        {
            var isCorrect = true;

            var estimationCopy = new double[estimation.Length];
            estimation.CopyTo(estimationCopy, 0);

            var relativePriorityCopy = new bool[relativePriority.Length];
            relativePriority.CopyTo(relativePriorityCopy, 0);
            
            for (var i = 0; i < estimationCopy.Length; i++)
            {
                var sum = estimationCopy.Where((t, k) => k > i).Sum();
                
                if (relativePriorityCopy[i])
                {
                    isCorrect = isCorrect && (estimationCopy[i] > sum);
                    continue;
                }

                isCorrect = isCorrect && (estimationCopy[i] < sum || sum == 0);
            }

            return isCorrect;
        }

        private void Normalize()
        {
            if (_evaluatedValues.All(expert => expert.Length != 0))
            {
                foreach (var expert in _evaluatedValues)
                {
                    var normalized = Array.Empty<double>();
                    var max = expert[expert.Length - 1].Max();
                    foreach (var alternative in expert[expert.Length - 1])
                        normalized = normalized.Append(alternative / max).ToArray();
                    NormalizedVector = NormalizedVector.Append(normalized).ToArray();
                }

                return;
            }

            foreach (var expert in _expertForm.ExpertsArray)
            {
                var normalized = Array.Empty<double>();
                var max = expert.AltList[0].Estimation;
                max = expert.AltList
                    .Select(alternative => alternative.Estimation)
                    .Prepend(max)
                    .Max();

                foreach (var alternative in expert.AltList)
                    normalized = normalized.Append(alternative.Estimation / max).ToArray();

                NormalizedVector = NormalizedVector.Append(normalized).ToArray();
            }
        }

        private void ResetInformation(int index)
        {
            for (var i = 0; i < NormalizedVector[index].Length; i++)
            {
                var norm = Controls[$"normTb{i + 1}"];
                Controls.Remove(norm);
            }
            Controls.Remove(Controls["normLabel"]);
            
            for (var i = 0; i < _expertForm.ExpertsArray.Length; i++)
            {
                var estimation = Controls[$"estimationTb{i + 1}"];
                Controls.Remove(estimation);
            }

            if (_evaluatedValues[index].Length == 0) return;

            for (var i = 0; i < _evaluatedValues[index].Length * _evaluatedValues[index][0].Length; i++)
            {
                var evaluation = Controls[$"evaluationTb{i + 1}"];
                Controls.Remove(evaluation);
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            _current--;
            expertLabel.Text = _expertForm.ExpertsArray[_current].Name;
            weightTb.Text = _expertForm.ExpertsArray[_current].Weight.ToString(CultureInfo.InvariantCulture);
            
            ResetInformation(_current + 1);
            CreateTable(_current);
            
            if (!nextBtn.Enabled)
                nextBtn.Enabled = true;
            
            if (_current == 0)
                previousBtn.Enabled = false;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            _current++;
            expertLabel.Text = _expertForm.ExpertsArray[_current].Name;
            weightTb.Text = _expertForm.ExpertsArray[_current].Weight.ToString(CultureInfo.InvariantCulture);
            
            ResetInformation(_current - 1);
            CreateTable(_current);
            
            if (!previousBtn.Enabled)
                previousBtn.Enabled = true;
            
            if (_current == _evaluatedValues.Length - 1)
                nextBtn.Enabled = false;
        }
    }
}