namespace TrayApp
{
    partial class AddProgramForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.displayNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Name";
            // 
            // displayNameTxtBox
            // 
            this.displayNameTxtBox.Location = new System.Drawing.Point(13, 30);
            this.displayNameTxtBox.Name = "displayNameTxtBox";
            this.displayNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.displayNameTxtBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Path";
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Location = new System.Drawing.Point(12, 79);
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(290, 20);
            this.filePathTxtBox.TabIndex = 1;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(308, 77);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select...";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(13, 105);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(94, 105);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 136);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.filePathTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayNameTxtBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(410, 175);
            this.MinimumSize = new System.Drawing.Size(410, 175);
            this.Name = "AddProgramForm";
            this.Text = "AddProgramForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}