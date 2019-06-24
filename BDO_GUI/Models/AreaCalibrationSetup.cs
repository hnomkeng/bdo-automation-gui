using System;
using System.Drawing;

namespace BDO_GUI
{
    public class AreaCalibrationSetup
    {
        private IntPtr _targetApplication;
        private IntPtr _mainApplication;
        public AreaCalibrationSetup(IntPtr targetProcess, IntPtr mainProcess)
        {
            _targetApplication = targetProcess;
            _mainApplication = mainProcess;
        }

        public Rectangle Left { get; set; }
        public Rectangle Mid { get; set; }
        public Rectangle Right { get; set; }
        public Rectangle Amity { get; set; }

        #region Set Target Area
        public void SetAmityArea()
        {
            SnippingTool.AreaSelected += (s, ev) =>
            {
                Amity = new Rectangle(SnippingTool.Area.Location, SnippingTool.Area.Size);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            SnippingTool.Snip(_targetApplication);
        }
        public void SetLeftArea()
        {
            SnippingTool.AreaSelected += (s, ev) =>
            {
                Left = new Rectangle(SnippingTool.Area.Location, SnippingTool.Area.Size);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            SnippingTool.Snip(_targetApplication);
        }
        public void SetMidArea()
        {
            SnippingTool.AreaSelected += (s, ev) =>
            {
                Mid = new Rectangle(SnippingTool.Area.Location, SnippingTool.Area.Size);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            SnippingTool.Snip(_targetApplication);
        }
        public void SetRightArea()
        {
            SnippingTool.AreaSelected += (s, ev) =>
            {
                Right = new Rectangle(SnippingTool.Area.Location, SnippingTool.Area.Size);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            SnippingTool.Snip(_targetApplication);
        }
        #endregion
    }
}
