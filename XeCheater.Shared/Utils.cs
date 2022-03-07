using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace XeCheater.Shared {
    public class Utils {
        private static NotifyIcon _notify = new NotifyIcon();

        public static void Notify(string title, string body, ToolTipIcon icon, int duration = 3000) {
            _notify.Visible = true;
            _notify.BalloonTipTitle = "XeCheater: " + title;
            _notify.BalloonTipText = body;
            _notify.BalloonTipIcon = icon;
            _notify.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            _notify.ShowBalloonTip(duration);
        }

        public static string RandomString(int length) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }

    public class INI
    {
        private string Path;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public INI(string IniPath = null)
        {
            Path = IniPath;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }

        public bool DefaultConfig() {
            Write("Auto Connect", "false", "Xbox Connection");
            Write("Default Console", XboxVars.xbMgr.DefaultConsole, "Xbox Connection");
            return true;
        }
    }
}
