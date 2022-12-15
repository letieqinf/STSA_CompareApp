namespace CompareApp
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.goalRichTb = new System.Windows.Forms.RichTextBox();
            this.alternativeLabel = new System.Windows.Forms.Label();
            this.addAlternativeBtn = new System.Windows.Forms.Button();
            this.estCriteriaLabel = new System.Windows.Forms.Label();
            this.estCriteriaRichTb = new System.Windows.Forms.RichTextBox();
            this.expertAmountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expertAmountTb = new System.Windows.Forms.TextBox();
            this.removeAlternativeBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(27, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(422, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "НАСТРОЙКА ИНФОРМАЦИИ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalLabel
            // 
            this.goalLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goalLabel.Location = new System.Drawing.Point(14, 94);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(210, 22);
            this.goalLabel.TabIndex = 1;
            this.goalLabel.Text = "Цель";
            this.goalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // goalRichTb
            // 
            this.goalRichTb.Location = new System.Drawing.Point(14, 119);
            this.goalRichTb.Name = "goalRichTb";
            this.goalRichTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.goalRichTb.Size = new System.Drawing.Size(210, 52);
            this.goalRichTb.TabIndex = 3;
            this.goalRichTb.Text = "";
            // 
            // alternativeLabel
            // 
            this.alternativeLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alternativeLabel.Location = new System.Drawing.Point(14, 240);
            this.alternativeLabel.Name = "alternativeLabel";
            this.alternativeLabel.Size = new System.Drawing.Size(435, 22);
            this.alternativeLabel.TabIndex = 4;
            this.alternativeLabel.Text = "Альтернативы достижения цели";
            this.alternativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addAlternativeBtn
            // 
            this.addAlternativeBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAlternativeBtn.Location = new System.Drawing.Point(14, 265);
            this.addAlternativeBtn.Name = "addAlternativeBtn";
            this.addAlternativeBtn.Size = new System.Drawing.Size(60, 27);
            this.addAlternativeBtn.TabIndex = 5;
            this.addAlternativeBtn.Text = "+";
            this.addAlternativeBtn.UseVisualStyleBackColor = true;
            this.addAlternativeBtn.Click += new System.EventHandler(this.addAlternativeBtn_Click);
            // 
            // estCriteriaLabel
            // 
            this.estCriteriaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.estCriteriaLabel.Location = new System.Drawing.Point(239, 94);
            this.estCriteriaLabel.Name = "estCriteriaLabel";
            this.estCriteriaLabel.Size = new System.Drawing.Size(210, 22);
            this.estCriteriaLabel.TabIndex = 1;
            this.estCriteriaLabel.Text = "Критерий оценивания";
            this.estCriteriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // estCriteriaRichTb
            // 
            this.estCriteriaRichTb.Location = new System.Drawing.Point(239, 119);
            this.estCriteriaRichTb.Name = "estCriteriaRichTb";
            this.estCriteriaRichTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.estCriteriaRichTb.Size = new System.Drawing.Size(210, 52);
            this.estCriteriaRichTb.TabIndex = 3;
            this.estCriteriaRichTb.Text = "";
            // 
            // expertAmountLabel
            // 
            this.expertAmountLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expertAmountLabel.Location = new System.Drawing.Point(14, 200);
            this.expertAmountLabel.Name = "expertAmountLabel";
            this.expertAmountLabel.Size = new System.Drawing.Size(173, 22);
            this.expertAmountLabel.TabIndex = 6;
            this.expertAmountLabel.Text = "Количество экспертов:";
            this.expertAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(132, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "——————————";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expertAmountTb
            // 
            this.expertAmountTb.Location = new System.Drawing.Point(193, 203);
            this.expertAmountTb.Name = "expertAmountTb";
            this.expertAmountTb.Size = new System.Drawing.Size(31, 20);
            this.expertAmountTb.TabIndex = 8;
            this.expertAmountTb.Text = "1";
            // 
            // removeAlternativeBtn
            // 
            this.removeAlternativeBtn.Enabled = false;
            this.removeAlternativeBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeAlternativeBtn.Location = new System.Drawing.Point(80, 265);
            this.removeAlternativeBtn.Name = "removeAlternativeBtn";
            this.removeAlternativeBtn.Size = new System.Drawing.Size(60, 27);
            this.removeAlternativeBtn.TabIndex = 9;
            this.removeAlternativeBtn.Text = "-";
            this.removeAlternativeBtn.UseVisualStyleBackColor = true;
            this.removeAlternativeBtn.Click += new System.EventHandler(this.removeAlternativeBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.Enabled = false;
            this.continueBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueBtn.Location = new System.Drawing.Point(14, 298);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(435, 36);
            this.continueBtn.TabIndex = 10;
            this.continueBtn.Text = "Продолжить";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(25, 26);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 29);
            this.helpButton.TabIndex = 25;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.ClientSize = new System.Drawing.Size(479, 488);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.removeAlternativeBtn);
            this.Controls.Add(this.expertAmountTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expertAmountLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.addAlternativeBtn);
            this.Controls.Add(this.alternativeLabel);
            this.Controls.Add(this.estCriteriaRichTb);
            this.Controls.Add(this.estCriteriaLabel);
            this.Controls.Add(this.goalRichTb);
            this.Controls.Add(this.goalLabel);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Групповое последовательное сравнение: Информация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button helpButton;

        private System.Windows.Forms.Button continueBtn;

        private System.Windows.Forms.Button removeAlternativeBtn;

        private System.Windows.Forms.TextBox expertAmountTb;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label expertAmountLabel;

        private System.Windows.Forms.Label estCriteriaLabel;
        private System.Windows.Forms.RichTextBox estCriteriaRichTb;

        private System.Windows.Forms.Label goalLabel;

        private System.Windows.Forms.Button addAlternativeBtn;

        private System.Windows.Forms.Label alternativeLabel;

        private System.Windows.Forms.RichTextBox goalRichTb;

        private System.Windows.Forms.Label Title;

        #endregion
    }
}