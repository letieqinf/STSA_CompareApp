using System.ComponentModel;

namespace CompareApp
{
    partial class Final
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
            this.priorityLabel = new System.Windows.Forms.Label();
            this.alternativeLabel = new System.Windows.Forms.Label();
            this.mostPriorityLabel = new System.Windows.Forms.Label();
            this.mostPriorityRichTb = new System.Windows.Forms.RichTextBox();
            this.agreementTb = new System.Windows.Forms.TextBox();
            this.agreementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divider1
            // 
            this.divider1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divider1.Location = new System.Drawing.Point(95, 60);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(210, 22);
            this.divider1.TabIndex = 12;
            this.divider1.Text = "——————————";
            this.divider1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(10, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(376, 36);
            this.Title.TabIndex = 11;
            this.Title.Text = "РЕЗУЛЬТАТ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityLabel.Location = new System.Drawing.Point(208, 226);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(152, 22);
            this.priorityLabel.TabIndex = 26;
            this.priorityLabel.Text = "Приоритет\r\n";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alternativeLabel
            // 
            this.alternativeLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alternativeLabel.Location = new System.Drawing.Point(37, 226);
            this.alternativeLabel.Name = "alternativeLabel";
            this.alternativeLabel.Size = new System.Drawing.Size(165, 22);
            this.alternativeLabel.TabIndex = 25;
            this.alternativeLabel.Text = "Альтернатива";
            this.alternativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mostPriorityLabel
            // 
            this.mostPriorityLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mostPriorityLabel.Location = new System.Drawing.Point(65, 87);
            this.mostPriorityLabel.Name = "mostPriorityLabel";
            this.mostPriorityLabel.Size = new System.Drawing.Size(269, 45);
            this.mostPriorityLabel.TabIndex = 27;
            this.mostPriorityLabel.Text = "Наиболее предпочтительной является альтернатива 1\r\n";
            this.mostPriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mostPriorityRichTb
            // 
            this.mostPriorityRichTb.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.mostPriorityRichTb.Location = new System.Drawing.Point(37, 139);
            this.mostPriorityRichTb.Name = "mostPriorityRichTb";
            this.mostPriorityRichTb.ReadOnly = true;
            this.mostPriorityRichTb.Size = new System.Drawing.Size(323, 50);
            this.mostPriorityRichTb.TabIndex = 28;
            this.mostPriorityRichTb.Text = "";
            // 
            // agreementTb
            // 
            this.agreementTb.Location = new System.Drawing.Point(252, 194);
            this.agreementTb.Name = "agreementTb";
            this.agreementTb.ReadOnly = true;
            this.agreementTb.Size = new System.Drawing.Size(107, 20);
            this.agreementTb.TabIndex = 30;
            this.agreementTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agreementLabel
            // 
            this.agreementLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agreementLabel.Location = new System.Drawing.Point(37, 192);
            this.agreementLabel.Name = "agreementLabel";
            this.agreementLabel.Size = new System.Drawing.Size(209, 22);
            this.agreementLabel.TabIndex = 29;
            this.agreementLabel.Text = "Согласованность экспертов:";
            this.agreementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.agreementTb);
            this.Controls.Add(this.agreementLabel);
            this.Controls.Add(this.mostPriorityRichTb);
            this.Controls.Add(this.mostPriorityLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.alternativeLabel);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.Title);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Final";
            this.Text = "Групповое последовательное сравнение: Результат";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox agreementTb;
        private System.Windows.Forms.Label agreementLabel;

        private System.Windows.Forms.RichTextBox mostPriorityRichTb;

        private System.Windows.Forms.Label mostPriorityLabel;

        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label alternativeLabel;

        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label Title;

        #endregion
    }
}