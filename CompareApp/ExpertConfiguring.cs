using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CompareApp
{
    public partial class ExpertConfiguring : Form
    {
        private readonly Start _startForm;

        public struct Alternatives
        {
            public RichTextBox Alternative { get; set; }
            public TextBox Estimation { get; set; }
            public CheckBox RelativePriority { get; set; }
        }

        public struct ExpertEstimation
        {
            public string Alternative { get; set; }
            public double Estimation { get; set; }
            public bool RelativePriority { get; set; }
        }

        public struct Expert
        {
            public string Name { get; set; }
            public ExpertEstimation[] AltList { get; set; }
            public double Weight { get; set; }
        }

        private Alternatives[] AltList { get; set; } = Array.Empty<Alternatives>();
        public Expert[] ExpertsArray { get; private set; }

        private int _current = 0;
        
        public ExpertConfiguring(Start startForm)
        {
            _startForm = startForm;
            ExpertsArray = Array.Empty<Expert>();

            for (var i = 0; i < _startForm.ExpertAmount; i++)
            {
                ExpertsArray = ExpertsArray.Append(new Expert()
                {
                    Name = $"Эксперт {i + 1}",
                    AltList = Array.Empty<ExpertEstimation>(),
                    Weight = 0.0
                }).ToArray();
            }
            
            InitializeComponent();

            relativePriorityLabel.Cursor = Cursors.Help;
            var relativeToolTip = new ToolTip();
            relativeToolTip.SetToolTip(relativePriorityLabel, 
                "Является ли данный объект приоритетнее всех остальных вместе взятых");

            goalRichTb.Text = _startForm.Goal;
            criteriaRichTb.Text = _startForm.Criteria;
            
            if (_current + 1 == ExpertsArray.Length)
                nextBtn.Enabled = false;
            
            if (_current == 0)
                previousBtn.Enabled = false;
            
            var altList = Array.Empty<Alternatives>();

            foreach (var alternative in startForm.AltList)
            {
                var altTextBox = new RichTextBox();
                altTextBox.Text = alternative.Text;
                altTextBox.ReadOnly = true;
                
                altTextBox.Location = new Point(
                    alternativeLabel.Location.X,
                    (AltList.Length > 0
                        ? AltList.Last().Alternative.Location.Y + AltList.Last().Alternative.Size.Height
                        : alternativeLabel.Location.Y + alternativeLabel.Size.Height) + 10
                    );

                altTextBox.Size = new Size(
                    alternativeLabel.Size.Width,
                    52
                    );

                var altPriority = new TextBox();
                altPriority.Size = new Size(
                    priorityLabel.Size.Width - 40,
                    altPriority.Size.Height
                    );
                
                altPriority.Location = new Point(
                    priorityLabel.Location.X + priorityLabel.Size.Width / 2 - altPriority.Size.Width / 2,
                    altTextBox.Location.Y + altTextBox.Size.Height / 2 - altPriority.Size.Height / 2
                    );

                var altRelativePriority = new CheckBox();

                altRelativePriority.Size = new Size(
                    altRelativePriority.Size.Height,
                    altRelativePriority.Size.Height
                    );

                altRelativePriority.Location = new Point(
                    relativePriorityLabel.Location.X
                        + relativePriorityLabel.Size.Width / 2
                        - altRelativePriority.Size.Width / 2,
                    altTextBox.Location.Y + altTextBox.Size.Height / 2 - altRelativePriority.Size.Height / 2
                    );

                Controls.Add(altTextBox);
                Controls.Add(altPriority);
                Controls.Add(altRelativePriority);

                var altNode = new Alternatives()
                {
                    Alternative = altTextBox,
                    Estimation = altPriority,
                    RelativePriority = altRelativePriority
                };

                AltList = AltList.Append(altNode).ToArray();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            _current++;
            expertLabel.Text = ExpertsArray[_current].Name;
            weightTb.Text = ExpertsArray[_current].Weight.ToString(CultureInfo.InvariantCulture);

            ResetInformation();
            GetExpertData();
            
            if (!previousBtn.Enabled)
                previousBtn.Enabled = true;
            
            if (_current + 1 == ExpertsArray.Length)
                nextBtn.Enabled = false;
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            _current--;
            expertLabel.Text = ExpertsArray[_current].Name;
            weightTb.Text = ExpertsArray[_current].Weight.ToString(CultureInfo.InvariantCulture);

            ResetInformation();
            GetExpertData();
            
            if (!nextBtn.Enabled)
                nextBtn.Enabled = true;
            
            if (_current == 0)
                previousBtn.Enabled = false;
        }

        private void ResetInformation()
        {
            foreach (var alternative in AltList)
            {
                alternative.Estimation.Text = string.Empty;
                alternative.RelativePriority.Checked = false;
            }
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (expertLabel.Text == string.Empty)
                        throw new FormatException("Имя эксперта не может быть пустым.");

                    if (weightTb.Text == string.Empty 
                        || double.Parse(weightTb.Text) <= 0
                        || double.Parse(weightTb.Text) > 1)
                        throw new FormatException("Вес эксперта задан некорректно.");

                    if (AltList.Any(alternative => alternative.Estimation.Text == string.Empty))
                        throw new FormatException("Приоритет должен быть задан числом с плавающей точкой.");

                    if (AltList.Any(alternative =>
                            double.Parse(alternative.Estimation.Text) < 0.0
                            || double.Parse(alternative.Estimation.Text) > 1.0))
                        throw new DataException("Приоритет должен быть задан в диапазоне [0.0; 1.0].");
                }
                catch (FormatException exception)
                {
                    throw new Exception(exception.Message);
                }
                catch (DataException exception)
                {
                    throw new Exception(exception.Message);
                }

                var expert = ExpertsArray[_current];
                expert.Name = expertLabel.Text;
                expert.Weight = double.Parse(weightTb.Text);
                if (expert.AltList.Length == 0)
                {
                    foreach (var alternative in AltList)
                    {
                        expert.AltList = expert.AltList.Append(new ExpertEstimation()
                        {
                            Alternative = alternative.Alternative.Text,
                            Estimation = double.Parse(alternative.Estimation.Text),
                            RelativePriority = alternative.RelativePriority.Checked
                        }).ToArray();
                    }
                }
                else
                {
                    for (var i = 0; i < expert.AltList.Length; i++)
                    {
                        expert.AltList[i].Estimation = double.Parse(AltList[i].Estimation.Text);
                        expert.AltList[i].RelativePriority = AltList[i].RelativePriority.Checked;
                    }
                }

                ExpertsArray[_current] = expert;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetExpertData()
        {
            var expert = ExpertsArray[_current];
            if (expert.AltList.Length == 0)
                return;

            for (var i = 0; i < AltList.Length; i++)
            {
                AltList[i].Estimation.Text = expert.AltList[i].Estimation.ToString(CultureInfo.CurrentCulture);
                if (expert.AltList[i].RelativePriority)
                    AltList[i].RelativePriority.CheckState = CheckState.Checked;
            }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpertsArray.Any(expert => expert.AltList.Length == 0))
                    throw new Exception("Значения заданы не для всех экспертов.");

                var weightSum = ExpertsArray.Sum(expert => expert.Weight);
                if (weightSum != 1.0)
                    throw new Exception("Сумма весов экспертов не равна 1.");

                // Enabled = false;
                var nextForm = new EvaluatingPriorities(this);
                nextForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var instructions = new ExpertInstructions(this);
            instructions.Show();
        }
    }
}