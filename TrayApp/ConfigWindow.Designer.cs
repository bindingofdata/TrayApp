namespace TrayApp
{
    partial class ConfigWindow
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
            this.startWithWindowsChkBox = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okayBtn = new System.Windows.Forms.Button();
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.appList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // startWithWindowsChkBox
            // 
            this.startWithWindowsChkBox.AutoSize = true;
            this.startWithWindowsChkBox.Location = new System.Drawing.Point(13, 13);
            this.startWithWindowsChkBox.Name = "startWithWindowsChkBox";
            this.startWithWindowsChkBox.Size = new System.Drawing.Size(179, 17);
            this.startWithWindowsChkBox.TabIndex = 1;
            this.startWithWindowsChkBox.Text = "Start App When Windows Starts";
            this.startWithWindowsChkBox.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.Location = new System.Drawing.Point(12, 317);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add...";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeBtn.Location = new System.Drawing.Point(93, 317);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(441, 317);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okayBtn
            // 
            this.okayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okayBtn.Location = new System.Drawing.Point(360, 317);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(75, 23);
            this.okayBtn.TabIndex = 5;
            this.okayBtn.Text = "Okay";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Click += new System.EventHandler(this.okayBtn_Click);
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUpBtn.Location = new System.Drawing.Point(522, 35);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(25, 25);
            this.moveUpBtn.TabIndex = 6;
            this.moveUpBtn.Text = "▲";
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.Click += new System.EventHandler(this.moveUpBtn_Click);
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDownBtn.Location = new System.Drawing.Point(522, 65);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(25, 25);
            this.moveDownBtn.TabIndex = 7;
            this.moveDownBtn.Text = "▼";
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.Click += new System.EventHandler(this.moveDownBtn_Click);
            // 
            // appList
            // 
            this.appList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appList.FormattingEnabled = true;
            this.appList.Location = new System.Drawing.Point(12, 36);
            this.appList.Name = "appList";
            this.appList.Size = new System.Drawing.Size(504, 274);
            this.appList.TabIndex = 0;
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 351);
            this.Controls.Add(this.moveDownBtn);
            this.Controls.Add(this.moveUpBtn);
            this.Controls.Add(this.okayBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.startWithWindowsChkBox);
            this.Controls.Add(this.appList);
            this.MinimumSize = new System.Drawing.Size(575, 390);
            this.Name = "ConfigWindow";
            this.Text = "ConfigWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox startWithWindowsChkBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okayBtn;
        private System.Windows.Forms.Button moveUpBtn;
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.CheckedListBox appList;
    }
}