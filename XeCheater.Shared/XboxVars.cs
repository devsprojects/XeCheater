using XDevkit;

namespace XeCheater.Shared {
    public class XboxVars {
        public static IXboxConsole xbCon { get; set; }
        public static IXboxDebugTarget xbDebug { get; set; }
        public static IXboxManager xbMgr = new XboxManager();
        public static IXboxFiles xbFiles { get; set; }
        public static IXboxFile xbFile { get; set; }
        public static bool IsConnected = false;
        public static string SelectedXbox = xbMgr.DefaultConsole;
    }
}
