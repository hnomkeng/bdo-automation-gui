﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BDO_GUI
{
    public partial class SnippingTool : Form
    {
        public static event EventHandler Cancel;
        public static event EventHandler AreaSelected;
        public static Image Image { get; set; }
        public static Rectangle Area { get; set; }

        private static SnippingTool[] _forms;
        private Rectangle _rectSelection;
        private Point _pointStart;

        public SnippingTool(Image screenShot, int x, int y, int width, int height)
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

        private void OnAreaSelected(EventArgs e)
        {
            AreaSelected?.Invoke(this, e);
            AreaSelected = null;
        }

        private void CloseForms()
        {
            for (int i = 0; i < _forms.Length; i++)
            {
                _forms[i].Dispose();
            }
        }

        #region Overrides
        public static void Snip(IntPtr intPtr)
        {
            List<DeviceInfo> screens = ScreenHelper.GetMonitorsInfo();
            _forms = new SnippingTool[screens.Count];
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
                _forms[i] = new SnippingTool(bmp, left, top, hRes, vRes);
                _forms[i].Show();
            }
        }

        #region Overrides
        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Start the snip on mouse down
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            _pointStart = e.Location;
            _rectSelection = new Rectangle(e.Location, new Size(0, 0));
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            // Modify the selection on mouse move
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            int x1 = Math.Min(e.X, _pointStart.X);
            int y1 = Math.Min(e.Y, _pointStart.Y);
            int x2 = Math.Max(e.X, _pointStart.X);
            int y2 = Math.Max(e.Y, _pointStart.Y);
            _rectSelection = new Rectangle(x1, y1, x2 - x1, y2 - y1);
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            // Complete the snip on mouse-up
            if (_rectSelection.Width <= 0 || _rectSelection.Height <= 0)
            {
                CloseForms();
                OnCancel(new EventArgs());
                return;
            }
            Image = new Bitmap(_rectSelection.Width, _rectSelection.Height);
            Area = _rectSelection;
            double hScale = BackgroundImage.Width / (double)Width;
            double vScale = BackgroundImage.Height / (double)Height;
            using (Graphics gr = Graphics.FromImage(Image))
            {

                gr.DrawImage(BackgroundImage,
                    new Rectangle(0, 0, Image.Width, Image.Height),
                    new Rectangle((int)(_rectSelection.X * hScale), (int)(_rectSelection.Y * vScale), (int)(_rectSelection.Width * hScale), (int)(_rectSelection.Height * vScale)),
                    GraphicsUnit.Pixel);
            }
            CloseForms();
            OnAreaSelected(new EventArgs());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw the current selection
            using (Brush br = new SolidBrush(Color.FromArgb(120, Color.White)))
            {
                int x1 = _rectSelection.X;
                int x2 = _rectSelection.X + _rectSelection.Width;
                int y1 = _rectSelection.Y;
                int y2 = _rectSelection.Y + _rectSelection.Height;
                e.Graphics.FillRectangle(br, new Rectangle(0, 0, x1, Height));
                e.Graphics.FillRectangle(br, new Rectangle(x2, 0, Width - x2, Height));
                e.Graphics.FillRectangle(br, new Rectangle(x1, 0, x2 - x1, y1));
                e.Graphics.FillRectangle(br, new Rectangle(x1, y2, x2 - x1, Height - y2));
            }
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, _rectSelection);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Allow canceling the snip with the Escape key
            if (keyData == Keys.Escape)
            {
                Image = null;
                Area = new Rectangle();
                CloseForms();
                OnCancel(new EventArgs());
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
        #endregion
    }
}
