using BDO_GUI.Models.Interfaces;
using System;
using System.Drawing;

namespace BDO_GUI.Models
{
    public class InternalCalibrationSetup : IInternalCalibrationSetup
    {
        public InternalCalibrationSetup()
        {
            Worker = new WorkerCalibrationSetup();
            Processing = new ProcessingCalibrationSetup();
            Area = new AreaCalibrationSetup();
            Tray = new TrayCalibrationSetup();
        }

        public void SetIntPtr(IntPtr targetProcess, IntPtr mainProcess)
        {
            Worker.SetIntPtr(targetProcess, mainProcess);
            Processing.SetIntPtr(targetProcess, mainProcess);
            Area.SetIntPtr(targetProcess, mainProcess);
            Tray.SetIntPtr(targetProcess, mainProcess);
        }

        public WorkerCalibrationSetup Worker { get; private set; }
        public ProcessingCalibrationSetup Processing { get; private set; }
        public AreaCalibrationSetup Area { get; private set; }
        public TrayCalibrationSetup Tray { get; private set; }
    }

    public class AreaCalibrationSetup
    {
        private IntPtr _targetApplication;
        private IntPtr _mainApplication;
        public void SetIntPtr(IntPtr targetProcess, IntPtr mainProcess)
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

    public class ProcessingCalibrationSetup
    {
        private IntPtr _targetApplication;
        private IntPtr _mainApplication;
        public void SetIntPtr(IntPtr targetProcess, IntPtr mainProcess)
        {
            _targetApplication = targetProcess;
            _mainApplication = mainProcess;
        }

        public Point StorageBtn { get; set; }
        public Point ProcessBtn { get; set; }
        public Point HeatingIcon { get; set; }
        public Point ChoppingIcon { get; set; }
        public Point StartBtn { get; set; }


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

    public class WorkerCalibrationSetup
    {
        private IntPtr _targetApplication;
        private IntPtr _mainApplication;
        public void SetIntPtr(IntPtr targetProcess, IntPtr mainProcess)
        {
            _targetApplication = targetProcess;
            _mainApplication = mainProcess;
        }

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

    public class TrayCalibrationSetup
    {
        private IntPtr _targetApplication;
        private IntPtr _mainApplication;
        public void SetIntPtr(IntPtr targetProcess, IntPtr mainProcess)
        {
            _targetApplication = targetProcess;
            _mainApplication = mainProcess;
        }

        public Point DisconnectBtn { get; set; }
        public Point TrayBtn { get; set; }

        #region Set Target Location
        public void SetDisconnectBtn()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                DisconnectBtn = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }

        public void SetTrayBtn()
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                TrayBtn = new Point(TargetLocation.SelectedPoint.X, TargetLocation.SelectedPoint.Y);
                Helpers.User32.SetForegroundWindow(_mainApplication);
            };
            TargetLocation.Select(_targetApplication);
        }
        #endregion
    }
}
