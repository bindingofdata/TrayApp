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
    public partial class AddProgramForm : Form
    {
        public string DisplayName => displayNameTxtBox.Text;
        public string FilePath => filePathTxtBox.Text;

        public AddProgramForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += AddProgramForm_KeyDown;
        }

        private void AddProgramForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter
                && !string.IsNullOrWhiteSpace(DisplayName)
                && !string.IsNullOrWhiteSpace(FilePath))
            {
                addBtn_Click(sender, e);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
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
