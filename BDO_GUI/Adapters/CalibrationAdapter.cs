using BDO_GUI.Models;
using BDO_GUI.Models.Interfaces;
using System.Collections.Generic;
using System.Drawing;

namespace BDO_GUI.Adapters
{
    public static class CalibrationAdapter
    {
        public static InternalCalibrationSetup ConvertToInternalCalibrationSetup(IExternalCalibrationSetup externalSetup)
        {
            if (externalSetup == null || externalSetup.CalibrationLandMarks == null || externalSetup.CalibrationScreenZone == null)
                return null;

            InternalCalibrationSetup internalSetup = new InternalCalibrationSetup();

            internalSetup.Area.Amity = new Rectangle(externalSetup.CalibrationScreenZone.Amity?[0] ?? 0, externalSetup.CalibrationScreenZone.Amity?[1] ?? 0, externalSetup.CalibrationScreenZone.Amity?[2] ?? 0, externalSetup.CalibrationScreenZone.Amity?[3] ?? 0);
            internalSetup.Area.Left = new Rectangle(externalSetup.CalibrationScreenZone.Left?[0] ?? 0, externalSetup.CalibrationScreenZone.Left?[1] ?? 0, externalSetup.CalibrationScreenZone.Left?[2] ?? 0, externalSetup.CalibrationScreenZone.Left?[3] ?? 0);
            internalSetup.Area.Mid = new Rectangle(externalSetup.CalibrationScreenZone.Mid?[0] ?? 0, externalSetup.CalibrationScreenZone.Mid?[1] ?? 0, externalSetup.CalibrationScreenZone.Mid?[2] ?? 0, externalSetup.CalibrationScreenZone.Mid?[3] ?? 0);
            internalSetup.Area.Right = new Rectangle(externalSetup.CalibrationScreenZone.Right?[0] ?? 0, externalSetup.CalibrationScreenZone.Right?[1] ?? 0, externalSetup.CalibrationScreenZone.Right?[2] ?? 0, externalSetup.CalibrationScreenZone.Right?[3] ?? 0);

            internalSetup.Worker.BeerIcon = new Point(externalSetup.CalibrationLandMarks.BeerIcon?[0] ?? 0, externalSetup.CalibrationLandMarks.BeerIcon?[1] ?? 0);
            internalSetup.Worker.ConfirmBtn = new Point(externalSetup.CalibrationLandMarks.ConfirmBtn?[0] ?? 0, externalSetup.CalibrationLandMarks.ConfirmBtn?[1] ?? 0);
            internalSetup.Worker.MainIcon = new Point(externalSetup.CalibrationLandMarks.WorkerIcon?[0] ?? 0, externalSetup.CalibrationLandMarks.WorkerIcon?[1] ?? 0);
            internalSetup.Worker.RecoverBtn = new Point(externalSetup.CalibrationLandMarks.RecoverAllBtn?[0] ?? 0, externalSetup.CalibrationLandMarks.RecoverAllBtn?[1] ?? 0);
            internalSetup.Worker.RepeatWorkBtn = new Point(externalSetup.CalibrationLandMarks.RepeatAllBtn?[0] ?? 0, externalSetup.CalibrationLandMarks.RepeatAllBtn?[1] ?? 0);

            internalSetup.Processing.ChoppingIcon = new Point(externalSetup.CalibrationLandMarks.ChoppingIcon?[0] ?? 0, externalSetup.CalibrationLandMarks.ChoppingIcon?[1] ?? 0);
            internalSetup.Processing.HeatingIcon = new Point(externalSetup.CalibrationLandMarks.HeatingIcon?[0] ?? 0, externalSetup.CalibrationLandMarks.HeatingIcon?[1] ?? 0);
            internalSetup.Processing.ProcessBtn = new Point(externalSetup.CalibrationLandMarks.ProcessBtn?[0] ?? 0, externalSetup.CalibrationLandMarks.ProcessBtn?[1] ?? 0);
            internalSetup.Processing.StartBtn = new Point(externalSetup.CalibrationLandMarks.StartBtn?[0] ?? 0, externalSetup.CalibrationLandMarks.StartBtn?[1] ?? 0);
            internalSetup.Processing.StorageBtn = new Point(externalSetup.CalibrationLandMarks.StorageBtn?[0] ?? 0, externalSetup.CalibrationLandMarks.StorageBtn?[1] ?? 0);

            internalSetup.Tray.DisconnectBtn = new Point(externalSetup.CalibrationLandMarks.DisconnectBtn?[0] ?? 0, externalSetup.CalibrationLandMarks.DisconnectBtn?[1] ?? 0);
            internalSetup.Tray.TrayBtn = new Point(externalSetup.CalibrationLandMarks.TrayBtn?[0] ?? 0, externalSetup.CalibrationLandMarks.TrayBtn?[1] ?? 0);

            return internalSetup;
        }

        public static ExternalCalibrationSetup ConvertToExternalCalibrationSetup(IInternalCalibrationSetup internalSetup)
        {
            return new ExternalCalibrationSetup
            {
                CalibrationLandMarks = new CalibrationLandMark
                {
                    BeerIcon = new List<int> { internalSetup.Worker.BeerIcon.X, internalSetup.Worker.BeerIcon.Y },
                    RecoverAllBtn = new List<int> { internalSetup.Worker.RecoverBtn.X, internalSetup.Worker.RecoverBtn.Y },
                    RepeatAllBtn = new List<int> { internalSetup.Worker.RepeatWorkBtn.X, internalSetup.Worker.RepeatWorkBtn.Y },
                    ConfirmBtn = new List<int> { internalSetup.Worker.ConfirmBtn.X, internalSetup.Worker.ConfirmBtn.Y },
                    WorkerIcon = new List<int> { internalSetup.Worker.MainIcon.X, internalSetup.Worker.MainIcon.Y },
                    StorageBtn = new List<int> { internalSetup.Processing.StorageBtn.X, internalSetup.Processing.StorageBtn.Y },
                    ChoppingIcon = new List<int> { internalSetup.Processing.ChoppingIcon.X, internalSetup.Processing.ChoppingIcon.Y },
                    HeatingIcon = new List<int> { internalSetup.Processing.HeatingIcon.X, internalSetup.Processing.HeatingIcon.Y },
                    ProcessBtn = new List<int> { internalSetup.Processing.ProcessBtn.X, internalSetup.Processing.ProcessBtn.Y },
                    StartBtn = new List<int> { internalSetup.Processing.StartBtn.X, internalSetup.Processing.StartBtn.Y },
                    DisconnectBtn = new List<int> { internalSetup.Tray.DisconnectBtn.X, internalSetup.Tray.DisconnectBtn.Y },
                    TrayBtn = new List<int> { internalSetup.Tray.TrayBtn.X, internalSetup.Tray.TrayBtn.Y }
                },
                CalibrationScreenZone = new CalibrationScreenZone
                {
                    Amity = new List<int> { internalSetup.Area.Amity.X, internalSetup.Area.Amity.Y, internalSetup.Area.Amity.Width, internalSetup.Area.Amity.Height },
                    Left = new List<int> { internalSetup.Area.Left.X, internalSetup.Area.Left.Y, internalSetup.Area.Left.Width, internalSetup.Area.Left.Height },
                    Mid = new List<int> { internalSetup.Area.Mid.X, internalSetup.Area.Mid.Y, internalSetup.Area.Mid.Width, internalSetup.Area.Mid.Height },
                    Right = new List<int> { internalSetup.Area.Right.X, internalSetup.Area.Right.Y, internalSetup.Area.Right.Width, internalSetup.Area.Right.Height },
                },
                DegreeToWidth = 6
            };
        }
    }
}
