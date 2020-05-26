namespace task2
{
    partial class Form1
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
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btnUserInput = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbTooltip = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(157, 67);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(50, 20);
            this.tbAnswer.TabIndex = 1;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAnswer.TextChanged += new System.EventHandler(this.TbAnswer_TextChanged);
            // 
            // btnUserInput
            // 
            this.btnUserInput.Location = new System.Drawing.Point(213, 65);
            this.btnUserInput.Name = "btnUserInput";
            this.btnUserInput.Size = new System.Drawing.Size(75, 23);
            this.btnUserInput.TabIndex = 2;
            this.btnUserInput.Text = "Ввод";
            this.btnUserInput.UseVisualStyleBackColor = true;
            this.btnUserInput.Click += new System.EventHandler(this.BtnUserInput_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 91);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(300, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tbTooltip
            // 
            this.tbTooltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTooltip.Location = new System.Drawing.Point(12, 12);
            this.tbTooltip.Multiline = true;
            this.tbTooltip.Name = "tbTooltip";
            this.tbTooltip.ReadOnly = true;
            this.tbTooltip.Size = new System.Drawing.Size(276, 42);
            this.tbTooltip.TabIndex = 4;
            this.tbTooltip.Text = "Угадай число от 0 до 100";
            this.tbTooltip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 113);
            this.Controls.Add(this.tbTooltip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUserInput);
            this.Controls.Add(this.tbAnswer);
            this.Name = "Form1";
            this.Text = "Угадай число!";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnUserInput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox tbTooltip;
    }
}

