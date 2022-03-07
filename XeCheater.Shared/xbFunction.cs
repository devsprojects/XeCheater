using JRPC_Client;
using XDevkit;

namespace XeCheater.Shared {
    public class xbFunction {
        private static bool PoolConnection() {
            try { return (XboxVars.xbCon.GetMemory(0x81AA2200, 1).Length > 0); }
            catch { return false; }
        }

        public static bool Connect() {
            XboxVars.xbCon = XboxVars.xbMgr.OpenConsole(XboxVars.SelectedXbox);
            XboxVars.xbDebug = XboxVars.xbCon.DebugTarget;
            XboxVars.xbDebug.ConnectAsDebugger("XeCheater", XboxDebugConnectFlags.Force);

            if (PoolConnection()) {
                XboxVars.IsConnected = true;
                return true;
            } else {
                XboxVars.IsConnected = true;
                return false;
            }
        }

        public static void Disconnect() {
            try {
                XboxVars.xbCon.DebugTarget.DisconnectAsDebugger();
                XboxVars.xbCon = null;
                XboxVars.xbMgr = null;
                XboxVars.IsConnected = false;
            }
            catch { }
        }
    }
}
