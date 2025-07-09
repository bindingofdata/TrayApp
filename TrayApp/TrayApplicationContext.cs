using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TrayApp
{
    public sealed class TrayApplicationContext : ApplicationContext
    {
        private readonly MenuItem _configMenuItem;
        private readonly MenuItem _exitMenuItem;
        private readonly ConfigManager _configManager;
        private readonly NotifyIcon _notifyIcon;
        private ConfigWindow _configWindow;

        public TrayApplicationContext()
        {
            _configMenuItem = new MenuItem("Settings", new EventHandler(ShowConfig));
            _exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));
            _configManager = new ConfigManager();

            _notifyIcon = new NotifyIcon();
            // Load the icon from embedded resources
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("TrayApp.TrayApp.ico"))
            {
                if (stream != null)
                {
                    _notifyIcon.Icon = new Icon(stream);
                }
            }
            _notifyIcon.ContextMenu = LoadMenuItems();
            _notifyIcon.Visible = true;
        }

        private ContextMenu LoadMenuItems()
        {
            ContextMenu menu = new ContextMenu();
            for (int i = 0; i < _configManager.MenuItemData.Count; i++)
            {
                MenuItemData menuItemData = _configManager.MenuItemData[i];
                menu.MenuItems.Add(new MenuItem(menuItemData.DisplayName, ApplicationClick));
            }
            menu.MenuItems.Add(_configMenuItem);
            menu.MenuItems.Add(_exitMenuItem);
            return menu;
        }

        private void ApplicationClick(object sender, EventArgs e)
        {
            if (!(sender is MenuItem menuItem))
                return;

            // Find the corresponding MenuItemData by DisplayName
            MenuItemData appData = _configManager.MenuItemData.FirstOrDefault(a => a.DisplayName == menuItem.Text);
            if (appData == null)
                return;

            Keys modifiers = Control.ModifierKeys;
            if ((modifiers & Keys.Control) == Keys.Control)
            {
                // Kill all processes with the same executable name
                try
                {
                    string exeName = Path.GetFileNameWithoutExtension(appData.FilePath);
                    foreach (Process proc in Process.GetProcessesByName(exeName))
                    {
                        proc.Kill();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to kill process:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Run the application
                try
                {
                    Process.Start(appData.FilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to start application:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowConfig(object sender, EventArgs e)
        {
            if (_configWindow?.Visible == true)
            {
                _configWindow.Activate();
            }
            else
            {
                _configWindow = new ConfigWindow(_configManager);
                if (_configWindow.ShowDialog() == DialogResult.OK)
                {
                    _configManager.StartWithWindows = _configWindow.StartWithWindows;
                    _configManager.MenuItemData = _configWindow.ListItems.ToList();
                    _configManager.SaveSettings();

                    _notifyIcon.ContextMenu = LoadMenuItems();
                }
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            // Hiding the icon before exiting removes the icon from the tray
            //   without the user having to mouse over it first.
            _notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}
