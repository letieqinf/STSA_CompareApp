using System.ComponentModel;

namespace CompareApp
{
    partial class ExpertConfiguring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.goalLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goalRichTb = new System.Windows.Forms.RichTextBox();
            this.criteriaRichTb = new System.Windows.Forms.RichTextBox();
            this.criteriaLabel = new System.Windows.Forms.Label();
            this.expertLabel = new System.Windows.Forms.TextBox();
            this.alternativeLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.relativePriorityLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.writeBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.weightTb = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goalLabel
            // 
            this.goalLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goalLabel.Location = new System.Drawing.Point(538, 102);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(210, 22);
            this.goalLabel.TabIndex = 2;
            this.goalLabel.Text = "Цель";
            this.goalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(173, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(422, 36);
            this.Title.TabIndex = 3;
            this.Title.Text = "НАСТРОЙКА ЭКСПЕРТНОЙ ГРУППЫ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(267, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "——————————";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalRichTb
            // 
            this.goalRichTb.BackColor = System.Drawing.SystemColors.Control;
            this.goalRichTb.Location = new System.Drawing.Point(538, 127);
            this.goalRichTb.Name = "goalRichTb";
            this.goalRichTb.ReadOnly = true;
            this.goalRichTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.goalRichTb.Size = new System.Drawing.Size(210, 106);
            this.goalRichTb.TabIndex = 9;
            this.goalRichTb.Text = "";
            // 
            // criteriaRichTb
            // 
            this.criteriaRichTb.BackColor = System.Drawing.SystemColors.Control;
            this.criteriaRichTb.Location = new System.Drawing.Point(538, 261);
            this.criteriaRichTb.Name = "criteriaRichTb";
            this.criteriaRichTb.ReadOnly = true;
            this.criteriaRichTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.criteriaRichTb.Size = new System.Drawing.Size(210, 106);
            this.criteriaRichTb.TabIndex = 11;
            this.criteriaRichTb.Text = "";
            // 
            // criteriaLabel
            // 
            this.criteriaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.criteriaLabel.Location = new System.Drawing.Point(538, 236);
            this.criteriaLabel.Name = "criteriaLabel";
            this.criteriaLabel.Size = new System.Drawing.Size(210, 22);
            this.criteriaLabel.TabIndex = 10;
            this.criteriaLabel.Text = "Критерий оценивания";
            this.criteriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expertLabel
            // 
            this.expertLabel.Location = new System.Drawing.Point(65, 102);
            this.expertLabel.Name = "expertLabel";
            this.expertLabel.Size = new System.Drawing.Size(135, 20);
            this.expertLabel.TabIndex = 13;
            this.expertLabel.Text = "Эксперт 1";
            // 
            // alternativeLabel
            // 
            this.alternativeLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alternativeLabel.Location = new System.Drawing.Point(11, 176);
            this.alternativeLabel.Name = "alternativeLabel";
            this.alternativeLabel.Size = new System.Drawing.Size(135, 22);
            this.alternativeLabel.TabIndex = 15;
            this.alternativeLabel.Text = "Альтернатива";
            this.alternativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityLabel.Location = new System.Drawing.Point(158, 176);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(87, 22);
            this.priorityLabel.TabIndex = 16;
            this.priorityLabel.Text = "Приоритет";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relativePriorityLabel
            // 
            this.relativePriorityLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.relativePriorityLabel.Location = new System.Drawing.Point(267, 166);
            this.relativePriorityLabel.Name = "relativePriorityLabel";
            this.relativePriorityLabel.Size = new System.Drawing.Size(200, 42);
            this.relativePriorityLabel.TabIndex = 17;
            this.relativePriorityLabel.Text = "Предпочтительнее других\r\nс меньшим приоритетом?";
            this.relativePriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.Location = new System.Drawing.Point(298, 102);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(47, 20);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = ">>>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Enabled = false;
            this.previousBtn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousBtn.Location = new System.Drawing.Point(12, 102);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(47, 20);
            this.previousBtn.TabIndex = 19;
            this.previousBtn.Text = "<<<";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // writeBtn
            // 
            this.writeBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeBtn.Location = new System.Drawing.Point(11, 127);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(334, 27);
            this.writeBtn.TabIndex = 20;
            this.writeBtn.Text = "Записать";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueBtn.Location = new System.Drawing.Point(538, 383);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(210, 55);
            this.continueBtn.TabIndex = 21;
            this.continueBtn.Text = "Продолжить";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // weightTb
            // 
            this.weightTb.Location = new System.Drawing.Point(248, 102);
            this.weightTb.Name = "weightTb";
            this.weightTb.Size = new System.Drawing.Size(44, 20);
            this.weightTb.TabIndex = 22;
            this.weightTb.Text = "0.0";
            // 
            // weightLabel
            // 
            this.weightLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.Location = new System.Drawing.Point(201, 102);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 19);
            this.weightLabel.TabIndex = 23;
            this.weightLabel.Text = "Вес:";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(25, 22);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 29);
            this.helpButton.TabIndex = 24;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // ExpertConfiguring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightTb);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.relativePriorityLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.alternativeLabel);
            this.Controls.Add(this.expertLabel);
            this.Controls.Add(this.criteriaRichTb);
            this.Controls.Add(this.criteriaLabel);
            this.Controls.Add(this.goalRichTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.goalLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ExpertConfiguring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Групповое последовательное сравнение: Экспертная группа";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button helpButton;

        private System.Windows.Forms.Label weightLabel;

        private System.Windows.Forms.TextBox weightTb;

        private System.Windows.Forms.Button continueBtn;

        private System.Windows.Forms.Button writeBtn;

        private System.Windows.Forms.Button nextBtn;

        private System.Windows.Forms.Button previousBtn;

        private System.Windows.Forms.Label relativePriorityLabel;

        private System.Windows.Forms.Label priorityLabel;

        private System.Windows.Forms.Label alternativeLabel;

        private System.Windows.Forms.TextBox expertLabel;

        private System.Windows.Forms.RichTextBox criteriaRichTb;
        
        private System.Windows.Forms.Label criteriaLabel;

        private System.Windows.Forms.RichTextBox goalRichTb;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label Title;

        private System.Windows.Forms.Label goalLabel;

        #endregion
    }
}