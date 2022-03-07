using System;
using System.IO;

namespace XeCheater.Shared {
    public class Constants {
        public static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string PluginFolder  = Path.Combine(AppData, "XeCheater", "Plugins");
    }
}
