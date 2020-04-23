using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CompactGUI
{
    internal class RCMenu
    {
        public static void WriteLocRegistry()
        {
            My.MyProject.Computer.Registry.SetValue(@"HKEY_CURRENT_USER\software\CompactGUI", "Executable Path", System.IO.Directory.GetCurrentDirectory());
        }

        public static void WriteRCMenuRegistry()
        {
            My.MyProject.Computer.Registry.SetValue(@"HKEY_CURRENT_USER\Software\Classes\Directory\shell\CompactGUI", "", "Compact Folder");
            My.MyProject.Computer.Registry.SetValue(@"HKEY_CURRENT_USER\Software\Classes\Directory\shell\CompactGUI", "Icon", Application.ExecutablePath);
            My.MyProject.Computer.Registry.SetValue(@"HKEY_CURRENT_USER\Software\Classes\Directory\shell\CompactGUI\command", "", Application.ExecutablePath + " " + "\"%1\"");
            My.Settings.Default.IsContextMenuEnabled = true;
        }

        public static void DeleteRCMenuRegistry()
        {
            My.MyProject.Computer.Registry.CurrentUser.DeleteSubKey(@"Software\\Classes\\Directory\\shell\\CompactGUI\command");
            My.MyProject.Computer.Registry.CurrentUser.DeleteSubKey(@"Software\\Classes\\Directory\\shell\\CompactGUI");
            My.Settings.Default.IsContextMenuEnabled = false;
        }

        public static void RunAsAdmin()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };
            Process.Start(startInfo);
            Application.Exit();
        }
    }
}