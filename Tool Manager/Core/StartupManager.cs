using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Manager.Core
{

    public class StartupManager
    {
        private static readonly string StartupKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private static readonly string StartupValue = "Tool Manager";
        private static readonly RegistryKey? _rkApp = Registry.CurrentUser.OpenSubKey(StartupKey, true);

        public static void EnableStartup(bool enabled)
        {
            if (enabled)
                SetStartup();
            else
                UnsetStartup();
        }

        public static void SetStartup()
        {
            //Set the application to run at startup
            _rkApp?.SetValue(StartupValue, Application.ExecutablePath.ToString());
        }

        public static void UnsetStartup()
        {
            //Set the application to run at startup
            _rkApp?.DeleteValue(StartupValue, false);
        }

        public static bool IsStartupSet()
        {
            return _rkApp?.GetValue(StartupValue) != null;
        }
    }

}
