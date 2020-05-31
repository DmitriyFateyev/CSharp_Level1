namespace BelieveOrNotBelieve
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cboxTrue = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveQuest = new System.Windows.Forms.Button();
            this.tboxQuestion = new System.Windows.Forms.TextBox();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.toolStripSeparator1,
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(180, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.MiNew_Click_1);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(180, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.MiOpen_Click_1);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(180, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.MiSave_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(180, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.MiExit_Click_1);
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(330, 235);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(54, 20);
            this.nudNumber.TabIndex = 1;
            this.nudNumber.ValueChanged += new System.EventHandler(this.NudNumber_ValueChanged_1);
            // 
            // cboxTrue
            // 
            this.cboxTrue.AutoSize = true;
            this.cboxTrue.Location = new System.Drawing.Point(417, 235);
            this.cboxTrue.Name = "cboxTrue";
            this.cboxTrue.Size = new System.Drawing.Size(48, 17);
            this.cboxTrue.TabIndex = 2;
            this.cboxTrue.Text = "True";
            this.cboxTrue.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // btnSaveQuest
            // 
            this.btnSaveQuest.Location = new System.Drawing.Point(249, 234);
            this.btnSaveQuest.Name = "btnSaveQuest";
            this.btnSaveQuest.Size = new System.Drawing.Size(75, 23);
            this.btnSaveQuest.TabIndex = 5;
            this.btnSaveQuest.Text = "Save Quest";
            this.btnSaveQuest.UseVisualStyleBackColor = true;
            this.btnSaveQuest.Click += new System.EventHandler(this.BtnSaveQuest_Click_1);
            // 
            // tboxQuestion
            // 
            this.tboxQuestion.Location = new System.Drawing.Point(12, 27);
            this.tboxQuestion.Multiline = true;
            this.tboxQuestion.Name = "tboxQuestion";
            this.tboxQuestion.Size = new System.Drawing.Size(453, 201);
            this.tboxQuestion.TabIndex = 6;
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(180, 22);
            this.miSaveAs.Text = "Save as";
            this.miSaveAs.Click += new System.EventHandler(this.MiSaveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 267);
            this.Controls.Add(this.tboxQuestion);
            this.Controls.Add(this.btnSaveQuest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxTrue);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beleive or Not Beleive";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.CheckBox cboxTrue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveQuest;
        private System.Windows.Forms.TextBox tboxQuestion;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

