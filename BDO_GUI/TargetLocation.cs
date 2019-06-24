using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BDO_GUI
{
    public partial class TargetLocation : Form
    {
        public static event EventHandler Cancel;
        public static event EventHandler TargetSelected;
        public static Point SelectedPoint;

        private static TargetLocation[] _forms;

        public TargetLocation(Image screenShot, int x, int y, int width, int height)
        {
            InitializeComponent();
            BackgroundImage = screenShot;
            BackgroundImageLayout = ImageLayout.Stretch;
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            SetBounds(x, y, width, height);
            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;
            Cursor = Cursors.Cross;
            TopMost = true;
        }

        private void OnCancel(EventArgs e)
        {
            Cancel?.Invoke(this, e);
        }

        private void OnTargetSelected(EventArgs e)
        {
            TargetSelected?.Invoke(this, e);
            TargetSelected = null;
        }

        private void CloseForms()
        {
            for (int i = 0; i < _forms.Length; i++)
            {
                _forms[i].Dispose();
            }
        }

        public static void Select(IntPtr intPtr)
        {
            List<DeviceInfo> screens = ScreenHelper.GetMonitorsInfo();
            _forms = new TargetLocation[screens.Count];
            for (int i = 0; i < screens.Count; i++)
            {
                int hRes = screens[i].HorizontalResolution;
                int vRes = screens[i].VerticalResolution;
                int top = screens[i].MonitorArea.Top;
                int left = screens[i].MonitorArea.Left;
                Bitmap bmp = new Bitmap(hRes, vRes, PixelFormat.Format32bppPArgb);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Helpers.User32.SetForegroundWindow(intPtr);
                    Thread.Sleep(100);
                    g.CopyFromScreen(left, top, 0, 0, bmp.Size);
                }
                _forms[i] = new TargetLocation(bmp, left, top, hRes, vRes);
                _forms[i].Show();
            }
        }

        #region Overrides
        protected override void OnMouseUp(MouseEventArgs e)
        {
            SelectedPoint = e.Location;
            CloseForms();
            OnTargetSelected(new EventArgs());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Allow canceling the snip with the Escape key
            if (keyData == Keys.Escape)
            {
                SelectedPoint = new Point();
                CloseForms();
                OnCancel(new EventArgs());
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }

    public class DeviceInfo
    {
        public string DeviceName { get; set; }
        public int VerticalResolution { get; set; }
        public int HorizontalResolution { get; set; }
        public Rectangle MonitorArea { get; set; }
    }
    public static class ScreenHelper
    {
        private const int DektopVertRes = 117;
        private const int DesktopHorzRes = 118;
        [StructLayout(LayoutKind.Sequential)]
        internal struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct MONITORINFOEX
        {
            public int Size;
            public Rect Monitor;
            public Rect WorkArea;
            public uint Flags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DeviceName;
        }
        private delegate bool MonitorEnumDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData);
        [DllImport("user32.dll")]
        private static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumDelegate lpfnEnum, IntPtr dwData);
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFOEX lpmi);
        [DllImport("User32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);
        [DllImport("gdi32.dll")]
        private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        private static List<DeviceInfo> _result;

        public static List<DeviceInfo> GetMonitorsInfo()
        {
            _result = new List<DeviceInfo>();
            EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, MonitorEnum, IntPtr.Zero);
            return _result;
        }

        private static bool MonitorEnum(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData)
        {
            MONITORINFOEX mi = new MONITORINFOEX
            {
                Size = Marshal.SizeOf(typeof(MONITORINFOEX))
            };
            bool success = GetMonitorInfo(hMonitor, ref mi);
            if (success)
            {
                IntPtr dc = CreateDC(mi.DeviceName, mi.DeviceName, null, IntPtr.Zero);
                DeviceInfo di = new DeviceInfo
                {
                    DeviceName = mi.DeviceName,
                    MonitorArea = new Rectangle(mi.Monitor.left, mi.Monitor.top, mi.Monitor.right - mi.Monitor.right, mi.Monitor.bottom - mi.Monitor.top),
                    VerticalResolution = GetDeviceCaps(dc, DektopVertRes),
                    HorizontalResolution = GetDeviceCaps(dc, DesktopHorzRes)
                };
                ReleaseDC(IntPtr.Zero, dc);
                _result.Add(di);
            }
            return true;
        }
    }
}
