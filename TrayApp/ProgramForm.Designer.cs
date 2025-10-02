namespace TrayApp
{
    partial class ProgramForm
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
            this.displayNameLbl = new System.Windows.Forms.Label();
            this.displayNameTxtBox = new System.Windows.Forms.TextBox();
            this.filePathLbl = new System.Windows.Forms.Label();
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.argumentsLbl = new System.Windows.Forms.Label();
            this.argumentsTextBox = new System.Windows.Forms.TextBox();
            this.workingDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.workingDirectoryLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayNameLbl
            // 
            this.displayNameLbl.AutoSize = true;
            this.displayNameLbl.Location = new System.Drawing.Point(13, 15);
            this.displayNameLbl.Name = "displayNameLbl";
            this.displayNameLbl.Size = new System.Drawing.Size(72, 13);
            this.displayNameLbl.TabIndex = 0;
            this.displayNameLbl.Text = "Display Name";
            // 
            // displayNameTxtBox
            // 
            this.displayNameTxtBox.Location = new System.Drawing.Point(13, 30);
            this.displayNameTxtBox.Name = "displayNameTxtBox";
            this.displayNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.displayNameTxtBox.TabIndex = 0;
            // 
            // filePathLbl
            // 
            this.filePathLbl.AutoSize = true;
            this.filePathLbl.Location = new System.Drawing.Point(13, 60);
            this.filePathLbl.Name = "filePathLbl";
            this.filePathLbl.Size = new System.Drawing.Size(48, 13);
            this.filePathLbl.TabIndex = 2;
            this.filePathLbl.Text = "File Path";
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Location = new System.Drawing.Point(13, 75);
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(290, 20);
            this.filePathTxtBox.TabIndex = 1;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(309, 75);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select...";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okBtn.Location = new System.Drawing.Point(13, 195);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.Location = new System.Drawing.Point(93, 195);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // argumentsLbl
            // 
            this.argumentsLbl.AutoSize = true;
            this.argumentsLbl.Location = new System.Drawing.Point(13, 105);
            this.argumentsLbl.Name = "argumentsLbl";
            this.argumentsLbl.Size = new System.Drawing.Size(57, 13);
            this.argumentsLbl.TabIndex = 5;
            this.argumentsLbl.Text = "Arguments";
            // 
            // argumentsTextBox
            // 
            this.argumentsTextBox.Location = new System.Drawing.Point(13, 120);
            this.argumentsTextBox.Name = "argumentsTextBox";
            this.argumentsTextBox.Size = new System.Drawing.Size(369, 20);
            this.argumentsTextBox.TabIndex = 6;
            // 
            // workingDirectoryTextBox
            // 
            this.workingDirectoryTextBox.Location = new System.Drawing.Point(13, 165);
            this.workingDirectoryTextBox.Name = "workingDirectoryTextBox";
            this.workingDirectoryTextBox.Size = new System.Drawing.Size(369, 20);
            this.workingDirectoryTextBox.TabIndex = 8;
            // 
            // workingDirectoryLbl
            // 
            this.workingDirectoryLbl.AutoSize = true;
            this.workingDirectoryLbl.Location = new System.Drawing.Point(13, 150);
            this.workingDirectoryLbl.Name = "workingDirectoryLbl";
            this.workingDirectoryLbl.Size = new System.Drawing.Size(89, 13);
            this.workingDirectoryLbl.TabIndex = 7;
            this.workingDirectoryLbl.Text = "WorkingDirectory";
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.workingDirectoryTextBox);
            this.Controls.Add(this.workingDirectoryLbl);
            this.Controls.Add(this.argumentsTextBox);
            this.Controls.Add(this.argumentsLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.filePathTxtBox);
            this.Controls.Add(this.filePathLbl);
            this.Controls.Add(this.displayNameTxtBox);
            this.Controls.Add(this.displayNameLbl);
            this.MaximumSize = new System.Drawing.Size(410, 270);
            this.MinimumSize = new System.Drawing.Size(410, 270);
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayNameLbl;
        private System.Windows.Forms.TextBox displayNameTxtBox;
        private System.Windows.Forms.Label filePathLbl;
        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label argumentsLbl;
        private System.Windows.Forms.TextBox argumentsTextBox;
        private System.Windows.Forms.TextBox workingDirectoryTextBox;
        private System.Windows.Forms.Label workingDirectoryLbl;
    }
}