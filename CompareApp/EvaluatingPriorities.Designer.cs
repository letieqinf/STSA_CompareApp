using System.ComponentModel;

namespace CompareApp
{
    partial class EvaluatingPriorities
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
            this.divider1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.expertLabel = new System.Windows.Forms.TextBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.alternativeLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // divider1
            // 
            this.divider1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divider1.Location = new System.Drawing.Point(289, 54);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(210, 22);
            this.divider1.TabIndex = 10;
            this.divider1.Text = "——————————";
            this.divider1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(182, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(422, 36);
            this.Title.TabIndex = 9;
            this.Title.Text = "ПОДСЧЕТ ПРИОРИТЕТОВ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previousBtn
            // 
            this.previousBtn.Enabled = false;
            this.previousBtn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousBtn.Location = new System.Drawing.Point(12, 97);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(47, 20);
            this.previousBtn.TabIndex = 22;
            this.previousBtn.Text = "<<<";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.Location = new System.Drawing.Point(303, 98);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(47, 20);
            this.nextBtn.TabIndex = 21;
            this.nextBtn.Text = ">>>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // expertLabel
            // 
            this.expertLabel.Location = new System.Drawing.Point(65, 97);
            this.expertLabel.Name = "expertLabel";
            this.expertLabel.ReadOnly = true;
            this.expertLabel.Size = new System.Drawing.Size(135, 20);
            this.expertLabel.TabIndex = 20;
            this.expertLabel.Text = "Эксперт 1";
            // 
            // priorityLabel
            // 
            this.priorityLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityLabel.Location = new System.Drawing.Point(166, 129);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(150, 22);
            this.priorityLabel.TabIndex = 24;
            this.priorityLabel.Text = "Рассчет приоритета";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // alternativeLabel
            // 
            this.alternativeLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alternativeLabel.Location = new System.Drawing.Point(14, 129);
            this.alternativeLabel.Name = "alternativeLabel";
            this.alternativeLabel.Size = new System.Drawing.Size(135, 22);
            this.alternativeLabel.TabIndex = 23;
            this.alternativeLabel.Text = "Альтернатива";
            this.alternativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightLabel
            // 
            this.weightLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.Location = new System.Drawing.Point(206, 98);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 19);
            this.weightLabel.TabIndex = 26;
            this.weightLabel.Text = "Вес:";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightTb
            // 
            this.weightTb.Location = new System.Drawing.Point(253, 98);
            this.weightTb.Name = "weightTb";
            this.weightTb.ReadOnly = true;
            this.weightTb.Size = new System.Drawing.Size(44, 20);
            this.weightTb.TabIndex = 25;
            this.weightTb.Text = "0.0";
            // 
            // EvaluatingPriorities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightTb);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.alternativeLabel);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.expertLabel);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.Title);
            this.Name = "EvaluatingPriorities";
            this.Text = "Групповое последовательное сравнение: Подсчет приоритетов";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTb;

        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label alternativeLabel;

        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox expertLabel;

        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label Title;

        #endregion
    }
}