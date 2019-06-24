using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BDO_GUI
{
    public class Helpers
    {
        public class User32
        {
            [DllImport("user32.dll")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);
        }

        public static Tuple<IntPtr, string> FindApplication(string name)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.ToLower()
                           .IndexOf(name.ToLower(), StringComparison.InvariantCulture) > -1)
                {
                    return new Tuple<IntPtr, string>(process.MainWindowHandle, process.MainWindowTitle);
                }
            }

            return new Tuple<IntPtr, string>(IntPtr.Zero, string.Empty);
        }
    }
}
