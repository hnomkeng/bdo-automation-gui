using System;
using System.Drawing;

namespace BDO_GUI
{
    public class ProcessingSetup
    {
        private IntPtr _targetApplication;
        private IntPtr _mainApplication;
        public ProcessingSetup(IntPtr targetProcess, IntPtr mainProcess)
        {
            _targetApplication = targetProcess;
            _mainApplication = mainProcess;
        }

        public bool IsActive { get; set; }
        public Point StorageBtn { get; set; }
        public Point ProcessBtn { get; set; }
        public Point HeatingIcon { get; set; }
        public Point ChoppingIcon { get; set; }
        public Point StartBtn { get; set; }
        public bool UseVenecil { get; set; }


        #region Set Target Location
        public void SetStorageBtn()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                StorageBtn = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetProcessBtn()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                ProcessBtn = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetHeatingIcon()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                HeatingIcon = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetChoppingIcon()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                ChoppingIcon = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetStartBtn()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                StartBtn = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }
        #endregion
    }
}
