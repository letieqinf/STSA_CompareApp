using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CompareApp
{
    public partial class Final : Form
    {
        private EvaluatingPriorities _evaluatingForm;
        
        public Final(EvaluatingPriorities evaluatingForm)
        {
            _evaluatingForm = evaluatingForm;
            
            InitializeComponent();

            var aggregated = new double[_evaluatingForm.NormalizedVector[0].Length];
            for (var i = 0; i < _evaluatingForm.NormalizedVector.Length; i++)
            {
                var expert = _evaluatingForm.NormalizedVector[i];
                for (var j = 0; j < aggregated.Length; j++)
                    aggregated[j] += expert[j] * _evaluatingForm.Weights[i];
            }

            var agreement = CountAgreement();

            agreementTb.Text = "Слабая";
            agreementTb.BackColor = Color.IndianRed;

            if (agreement >= 0.3 && agreement < 0.5)
            {
                agreementTb.Text = "Умеренная";
                agreementTb.BackColor = Color.DarkOrange;
            }
            else if (agreement >= 0.5 && agreement < 0.7)
            {
                agreementTb.Text = "Заметная";
                agreementTb.BackColor = Color.Yellow;
            }
            else if (agreement >= 0.7 && agreement < 0.9)
            {
                agreementTb.Text = "Высокая";
                agreementTb.BackColor = Color.YellowGreen;
            }
            else if (agreement >= 0.9)
            {
                agreementTb.Text = "Очень высокая";
                agreementTb.BackColor = Color.DarkSeaGreen;
            }

            var max = 0;
            for (var i = 0; i < aggregated.Length; i++)
            {
                if (aggregated[max] < aggregated[i])
                    max = i;
            }

            mostPriorityLabel.Text = $"Наиболее предпочтительной является альтернатива {max+ 1}\r\n";

            for (var i = 0; i < aggregated.Length; i++)
            {
                var richTextBox = new RichTextBox();
                richTextBox.Text = _evaluatingForm.Alternatives[i];
                
                if (i == max)
                    richTextBox.BackColor = Color.DarkSeaGreen;
                
                richTextBox.ReadOnly = true;
                richTextBox.Size = new Size(alternativeLabel.Size.Width, 52);
                richTextBox.Location = new Point(
                    alternativeLabel.Location.X + alternativeLabel.Size.Width / 2 - richTextBox.Size.Width / 2,
                    alternativeLabel.Location.Y + alternativeLabel.Size.Height + 10
                        + i * (richTextBox.Size.Height + 10)
                    );
                
                Controls.Add(richTextBox);

                var textBox = new TextBox();
                textBox.Text = Math.Round(aggregated[i], 3).ToString("0.000");

                if (i == max)
                    textBox.BackColor = Color.DarkSeaGreen;
                
                textBox.ReadOnly = true;
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.Size = new Size(50, 20);
                textBox.Location = new Point(
                    priorityLabel.Location.X + priorityLabel.Size.Width / 2 - textBox.Size.Width / 2,
                    richTextBox.Location.Y + richTextBox.Size.Height / 2 - textBox.Size.Height / 2
                    );
                
                Controls.Add(textBox);
            }

            mostPriorityRichTb.Text = _evaluatingForm.Alternatives[max];
        }

        private double CountAgreement()
        {
            var ranks = GetRanks();
            var mathExpectation = CountMathExpectation(ranks);
            var T = CountConnectedRank();

            var expertsAmount = _evaluatingForm.NormalizedVector.Length;
            var objectsAmount = _evaluatingForm.NormalizedVector[0].Length;

            var sums = new double[objectsAmount];
            for (var i = 0; i < expertsAmount; i++)
            {
                for (var j = 0; j < objectsAmount; j++)
                    sums[j] += ranks[i][j];
            }

            return 12 * sums.Sum(value => Math.Pow(value - mathExpectation, 2))
                   / (Math.Pow(expertsAmount, 2) * (Math.Pow(objectsAmount, 3) - objectsAmount) - expertsAmount * T);
        }

        private double[][] GetRanks()
        {
            var ranks = Array.Empty<double[]>();
            
            foreach (var expert in _evaluatingForm.NormalizedVector)
            {
                var pos = 0;

                var result = expert.Join(expert
                    .GroupBy(g => g)
                    .OrderByDescending(o => o.Key)
                    .Select(s =>
                    {
                        pos += s.Count();
                        return new
                        {
                            Score = s.Key,
                            Rank = ((double)2 * pos - s.Count() + 1) / 2
                        };
                    }),
                    i => i, 
                    o => o.Score, 
                    (o, i) => i.Rank).ToArray();
                
                ranks = ranks.Append(result).ToArray();
            }

            return ranks;
        }

        private static double CountMathExpectation(double[][] ranks)
            => ranks.Sum(t => t.Sum()) / ranks[0].Length;

        private double CountConnectedRank()
        {
            return (from expert in _evaluatingForm.NormalizedVector 
                let normalizedDistinct = expert.Distinct().ToArray() 
                let distinctLength = normalizedDistinct.Length 
                from value in normalizedDistinct select expert.Count(t => t == value) 
                into countInEntry select Math.Pow(countInEntry, 3) - countInEntry).Sum();
        }
    }
}