using System.Windows.Forms;
using XDevkit;
using XeCheater.Interfaces;
using XeCheater.Shared;

namespace XeCheater.Plugin.Screenshoter {
    public class Plugin : IPlugin {
        public string Name
        {
            get { return "Xbox Screenshoter"; }
        }

        public string Description
        {
            get { return "Create, Manage Screenshots of your Xbox"; }
        }

        public string Creator
        {
            get { return "GHOSTED"; }
        }

        public string Version
        {
            get { return "1.0.0"; }
        }

        public string DownloadURL
        {
            get { return "http://localhost/Plugin/XeCheater.Plugin.Screenshoter"; }
        }

        public Form Form
        {
            get { return new MainForm(); }
        }

        public IXboxConsole xbCon
        {
            get { return XboxVars.xbCon; }
        }

        public IXboxDebugTarget xbDebug
        {
            get { return XboxVars.xbDebug; }
        }

        public IXboxManager xbMgr
        {
            get { return XboxVars.xbMgr; }
        }

        public IXboxFiles xbFiles
        {
            get { return XboxVars.xbFiles; }
        }

        public IXboxFile xbFile
        {
            get { return XboxVars.xbFile; }
        }
    }
}
