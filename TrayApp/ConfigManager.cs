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
        public List<MenuItemData> MenuItemDataList { get; set; } = new List<MenuItemData>();

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
                        MenuItemData menuItem = new MenuItemData()
                        {
                            DisplayName = lineData[0],
                            FilePath = lineData[1],
                            Arguments = lineData[2],
                            WorkingDirectory = lineData[3],
                        };

                        MenuItemDataList.Add(menuItem);
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

            for (int i = 0; i < MenuItemDataList.Count; i++)
            {
                MenuItemData file = MenuItemDataList[i];
                settingsString.AppendLine($"{file.DisplayName}{_separatorChar}{file.FilePath}{_separatorChar}{file.Arguments ?? string.Empty}{_separatorChar}{file.WorkingDirectory ?? string.Empty}");
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
        public string DisplayName { get; set; }
        public string FilePath { get; set; }
        public string Arguments { get; set; }
        public string WorkingDirectory { get; set; }

        public override string ToString() =>
            $"{DisplayName} - {FilePath}";
    }
}
