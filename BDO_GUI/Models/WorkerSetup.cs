using System;
using System.Drawing;

namespace BDO_GUI
{
    public class WorkerSetup
    {
        private IntPtr _targetApplication;
        private IntPtr _mainApplication;
        public WorkerSetup(IntPtr targetProcess, IntPtr mainProcess)
        {
            _targetApplication = targetProcess;
            _mainApplication = mainProcess;
        }

        public bool IsActive { get; set; }
        public Point MainIcon { get; set; }
        public Point RecoverBtn { get; set; }
        public Point RepeatWorkBtn { get; set; }
        public Point ConfirmBtn { get; set; }
        public Point BeerIcon { get; set; }

        #region Set Target Location
        public void SetMainIcon()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                MainIcon = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetRecoverBtn()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                RecoverBtn = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetRepeatWorkBtn()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                RepeatWorkBtn = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetBeerIcon()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                BeerIcon = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetConfirmBtn()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                ConfirmBtn = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }
        #endregion
    }
}
