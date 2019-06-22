using System;
using System.Runtime.InteropServices;

namespace BDO_GUI
{
    public class Helpers
    {
        public class User32
        {
            [DllImport("user32.dll")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);
        }
    }
}
