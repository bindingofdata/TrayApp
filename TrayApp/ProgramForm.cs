using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayApp
{
    public partial class ProgramForm : Form
    {
        public string DisplayName => displayNameTxtBox.Text;
        public string FilePath => filePathTxtBox.Text;
        public string Arguments => argumentsTextBox.Text;
        public string WorkingDirectory => workingDirectoryTextBox.Text;

        public ProgramForm()
        {
            InitializeComponent();
            Text = "AddProgramForm";
            okBtn.Text = "Add";
            KeyPreview = true;
            KeyDown += AddProgramForm_KeyDown;
        }

        public ProgramForm(MenuItemData initItem)
        {
            InitializeComponent();
            Text = "EditProgramForm";
            okBtn.Text = "Edit";
            KeyPreview = true;
            KeyDown += AddProgramForm_KeyDown;

            displayNameTxtBox.Text = initItem.DisplayName;
            filePathTxtBox.Text = initItem.FilePath;
            argumentsTextBox.Text = initItem.Arguments;
            workingDirectoryTextBox.Text = initItem.WorkingDirectory;
        }

        private void AddProgramForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter
                && !string.IsNullOrWhiteSpace(DisplayName)
                && !string.IsNullOrWhiteSpace(FilePath))
            {
                okBtn_Click(sender, e);
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            displayNameTxtBox.Text = displayNameTxtBox.Text.Trim('"');
            filePathTxtBox.Text = filePathTxtBox.Text.Trim('"');
            argumentsTextBox.Text = argumentsTextBox.Text.Trim('"');
            workingDirectoryTextBox.Text = workingDirectoryTextBox.Text.Trim('"');
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Program File";
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePathTxtBox.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
