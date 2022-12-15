using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CompareApp
{
    public partial class Start : Form
    {
        public string Goal { get; private set; } = string.Empty;
        public string Criteria { get; private set; } = string.Empty;
        public int ExpertAmount { get; private set; }
        public RichTextBox[] AltList { get; private set; } = Array.Empty<RichTextBox>();

        public Start()
        {
            InitializeComponent();
            
            var welcome = new Welcome(this);
            welcome.Show();
        }

        private void addAlternativeBtn_Click(object sender, EventArgs e)
        {
            var alternative = new RichTextBox();
            alternative.ScrollBars = RichTextBoxScrollBars.Vertical;
            alternative.Location = addAlternativeBtn.Location;
            alternative.Size = new Size(
                    435,
                    24
                );

            AltList = AltList.Append(alternative).ToArray();
            Controls.Add(alternative);
            
            addAlternativeBtn.Location = new Point(
                addAlternativeBtn.Location.X, 
                addAlternativeBtn.Location.Y + alternative.Size.Height + 10
                );
            
            removeAlternativeBtn.Location = new Point(
                removeAlternativeBtn.Location.X,
                removeAlternativeBtn.Location.Y + alternative.Size.Height + 10
                );
            
            continueBtn.Location = new Point(
                continueBtn.Location.X,
                continueBtn.Location.Y + alternative.Size.Height + 10
                );

            if (AltList.Length != 1) return;
            
            removeAlternativeBtn.Enabled = true;
            continueBtn.Enabled = true;
        }

        private void removeAlternativeBtn_Click(object sender, EventArgs e)
        {
            Controls.Remove(AltList.Last());
            
            addAlternativeBtn.Location = new Point(
                addAlternativeBtn.Location.X,
                addAlternativeBtn.Location.Y - AltList.Last().Size.Height - 10
                );
            
            removeAlternativeBtn.Location = new Point(
                removeAlternativeBtn.Location.X,
                removeAlternativeBtn.Location.Y - AltList.Last().Size.Height - 10
                );
            
            continueBtn.Location = new Point(
                continueBtn.Location.X,
                continueBtn.Location.Y - AltList.Last().Size.Height - 10
                );
            
            AltList = AltList.Where(textBox => textBox != AltList.Last()).ToArray();

            if (AltList.Length != 0) return;
            
            removeAlternativeBtn.Enabled = false;
            continueBtn.Enabled = false;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Goal = goalRichTb.Text;
                if (Goal == string.Empty)
                    throw new Exception("Вы должны задать цель.");

                Criteria = estCriteriaRichTb.Text;
                if (Criteria == string.Empty)
                    throw new Exception("Вы должны задать критерий оценивания альтернатив.");

                try
                {
                    ExpertAmount = int.Parse(expertAmountTb.Text);
                }
                catch (Exception exception)
                {
                    throw new Exception("Количество экспертов должно быть целым числом.");
                }

                if (ExpertAmount < 1)
                    throw new Exception("Количество экспертов не может быть меньше нуля.");

                if (AltList.Any(textBox => textBox.Text == string.Empty))
                    throw new Exception("Не все альтернативы указаны верно.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nextFrame = new ExpertConfiguring(this);
            nextFrame.Show();
            Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var instructions = new StartInstructions(this);
            instructions.Show();
        }
    }
}