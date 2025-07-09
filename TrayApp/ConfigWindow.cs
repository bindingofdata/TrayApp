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
    public partial class ConfigWindow : Form
    {
        private readonly ConfigManager _configManager;

        public IEnumerable<MenuItemData> ListItems
        {
            get { return appList.Items.Cast<MenuItemData>(); }
        }

        public bool StartWithWindows => startWithWindowsChkBox.Checked;

        public ConfigWindow(ConfigManager configManager)
        {
            InitializeComponent();
            _configManager = configManager;
            startWithWindowsChkBox.Checked = _configManager.StartWithWindows;
            appList.Items.AddRange(configManager.MenuItemData.ToArray());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProgramForm addProgramForm = new AddProgramForm();
            if (addProgramForm.ShowDialog() == DialogResult.OK)
            {
                MenuItemData newItem = new MenuItemData(addProgramForm.DisplayName, addProgramForm.FilePath);
                appList.Items.Add(newItem);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (object item in appList.CheckedItems.Cast<object>().ToList())
            {
                appList.Items.Remove(item);
            }
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {
            if (appList.SelectedItem == null || appList.SelectedIndex <= 0)
                return;

            int selectedIndex = appList.SelectedIndex;
            object selectedItem = appList.SelectedItem;

            appList.Items.RemoveAt(selectedIndex);
            appList.Items.Insert(selectedIndex - 1, selectedItem);
            appList.SetSelected(selectedIndex - 1, true);
        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {
            if (appList.SelectedItem == null || appList.SelectedIndex < 0 || appList.SelectedIndex >= appList.Items.Count - 1)
                return;

            int selectedIndex = appList.SelectedIndex;
            object selectedItem = appList.SelectedItem;

            appList.Items.RemoveAt(selectedIndex);
            appList.Items.Insert(selectedIndex + 1, selectedItem);
            appList.SetSelected(selectedIndex + 1, true);
        }
    }
}
