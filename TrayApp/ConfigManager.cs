using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrayApp
{
    public sealed class ConfigManager
    {
        public bool StartWithWindows { get; set; } = true;
        public List<MenuItemData> MenuItemData { get; set; } = new List<MenuItemData>();

        public ConfigManager()
        {
            LoadSettings();
        }

        public void LoadSettings()
        {
            if (!File.Exists(_settingsFilePath))
            {
                SaveSettings();
                return;
            }

            // Open the target file and iterate through each line
            string[] lines = File.ReadAllLines(_settingsFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lineData = lines[i].Split(_separatorChar);
                switch (lineData[0])
                {
                    case _startWithWindowsString:
                        StartWithWindows = bool.Parse(lineData[1]);
                        break;
                    default:
                        MenuItemData.Add(new MenuItemData(lineData[0], lineData[1]));
                        break;
                }
            }
        }

        public void SaveSettings()
        {
            if (!Directory.Exists(_settingsDirectoryPath))
            {
                Directory.CreateDirectory(_settingsDirectoryPath);
            }

            StringBuilder settingsString = new StringBuilder();
            settingsString.AppendLine($"{_startWithWindowsString}{_separatorChar}{StartWithWindows}");

            for (int i = 0; i < MenuItemData.Count; i++)
            {
                MenuItemData file = MenuItemData[i];
                settingsString.AppendLine($"{file.DisplayName}{_separatorChar}{file.FilePath}");
            }

            File.WriteAllText(_settingsFilePath, settingsString.ToString());
        }

        private const string _startWithWindowsString = "StartWithWindows";
        private const string _settingsFileDirectoryName = "TrayApp";
        private const string _settingsFileName = "config.txt";
        private readonly string _settingsDirectoryPath = Path.Combine(
            Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%"),
            _settingsFileDirectoryName);
        private readonly string _settingsFilePath = Path.Combine(
            Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%"),
            _settingsFileDirectoryName,
            _settingsFileName);
        private const char _separatorChar = '>';
    }

    public sealed class MenuItemData
    {
        public MenuItemData(string displayName, string filePath)
        {
            DisplayName = displayName;
            FilePath = filePath;
        }

        public string DisplayName { get; set; }
        public string FilePath { get; set; }

        public override string ToString() =>
            $"{DisplayName} - {FilePath}";
    }
}
