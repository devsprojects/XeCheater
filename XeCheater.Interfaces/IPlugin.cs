using System.Windows.Forms;
using XDevkit;

namespace XeCheater.Interfaces
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        string Creator { get; }
        string Version { get; }
        string DownloadURL { get; }
        Form Form { get; }

        /* xDevkit */
        IXboxConsole xbCon { get; }
        IXboxDebugTarget xbDebug { get; }
        IXboxManager xbMgr { get; }
        IXboxFiles xbFiles { get; }
        IXboxFile xbFile { get; }
    }
}
