using BDO_GUI.Models;
using BDO_GUI.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BDO_GUI
{
    public partial class CalibrationForm : Form
    {
        private static readonly Lazy<CalibrationForm> lazy = new Lazy<CalibrationForm>(() => new CalibrationForm());
        public static CalibrationForm Instance => lazy.Value;

        private CalibrationSetup _calibrationSetup = new CalibrationSetup();
        private string _fileFullPath;

        private CalibrationForm()
        {
            InitializeComponent();
        }

        public void Construct(string fileFullPath, IntPtr targetIntPtr)
        {
            _fileFullPath = fileFullPath;
            _calibrationSetup.Construct(targetIntPtr, Handle);
            LoadData();
        }

        private void LoadData()
        {
            using (StreamReader r = new StreamReader(_fileFullPath))
            {
                string json = r.ReadToEnd();
                Calibration config = JsonConvert.DeserializeObject<Calibration>(json);
            }
        }

        #region Worker Setup
        private void btnWorkerIcon_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Worker.SetMainIcon();
        }

        private void btnWorkerRecoverBtn_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Worker.SetRecoverBtn();
        }

        private void btnWorkerRepeatBtn_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Worker.SetRepeatWorkBtn();
        }

        private void btnWorkerBeerIcon_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Worker.SetBeerIcon();
        }

        private void btnWorkerConfirmBtn_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Worker.SetConfirmBtn();
        }
        #endregion
        #region Processing Setup
        private void btnProcessingStorageBtn_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Processing.SetStorageBtn();
        }

        private void btnProcessingStorageProcessBtn_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Processing.SetProcessBtn();
        }

        private void btnProcessingHeatingIcon_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Processing.SetHeatingIcon();
        }

        private void btnProcessingChoppingIcon_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Processing.SetChoppingIcon();
        }

        private void btnProcessingStartBtn_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Processing.SetStartBtn();
        }
        #endregion
        #region Processing Area Setup
        private void btnAmityArea_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Area.SetAmityArea();
        }

        private void btnLeftArea_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Area.SetLeftArea();
        }

        private void btnMidArea_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Area.SetMidArea();
        }

        private void btnRightArea_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Area.SetRightArea();
        }
        #endregion
        #region Tray Setup
        private void btnTrayDisconnect_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Tray.SetDisconnectBtn();
        }

        private void btnTrayTray_Click(object sender, EventArgs e)
        {
            _calibrationSetup.Tray.SetTrayBtn();
        }
        #endregion

        private void btnSaveCalibration_Click(object sender, EventArgs e)
        {
            Calibration config = new Calibration
            {
                CalibrationLandMarks = new CalibrationLandMark
                {
                    BeerIcon = new List<int> { _calibrationSetup.Worker.BeerIcon.X , _calibrationSetup.Worker.BeerIcon.Y },
                    RecoverAllBtn = new List<int> { _calibrationSetup.Worker.RecoverBtn.X, _calibrationSetup.Worker.RecoverBtn.Y },
                    RepeatAllBtn = new List<int> { _calibrationSetup.Worker.RepeatWorkBtn.X, _calibrationSetup.Worker.RepeatWorkBtn.Y },
                    ConfirmBtn = new List<int> { _calibrationSetup.Worker.ConfirmBtn.X, _calibrationSetup.Worker.ConfirmBtn.Y },
                    WorkerIcon = new List<int> { _calibrationSetup.Worker.MainIcon.X, _calibrationSetup.Worker.MainIcon.Y },
                    StorageBtn = new List<int> { _calibrationSetup.Processing.StorageBtn.X, _calibrationSetup.Processing.StorageBtn.Y },
                    ChoppingIcon = new List<int> { _calibrationSetup.Processing.ChoppingIcon.X, _calibrationSetup.Processing.ChoppingIcon.Y },
                    HeatingIcon = new List<int> { _calibrationSetup.Processing.HeatingIcon.X, _calibrationSetup.Processing.HeatingIcon.Y },
                    ProcessBtn = new List<int> { _calibrationSetup.Processing.ProcessBtn.X, _calibrationSetup.Processing.ProcessBtn.Y },
                    StartBtn = new List<int> { _calibrationSetup.Processing.StartBtn.X, _calibrationSetup.Processing.StartBtn.Y },
                },
                CalibrationScreenZone = new CalibrationScreenZone
                {
                    Amity = new List<int> { _calibrationSetup.Area.Amity.X, _calibrationSetup.Area.Amity.Y, _calibrationSetup.Area.Amity.Width, _calibrationSetup.Area.Amity.Height },
                    Left = new List<int> { _calibrationSetup.Area.Left.X, _calibrationSetup.Area.Left.Y, _calibrationSetup.Area.Left.Width, _calibrationSetup.Area.Left.Height },
                    Mid = new List<int> { _calibrationSetup.Area.Mid.X, _calibrationSetup.Area.Mid.Y, _calibrationSetup.Area.Mid.Width, _calibrationSetup.Area.Mid.Height },
                    Right = new List<int> { _calibrationSetup.Area.Right.X, _calibrationSetup.Area.Right.Y, _calibrationSetup.Area.Right.Width, _calibrationSetup.Area.Right.Height },
                }
            };
            string json = JsonConvert.SerializeObject(config);
            File.WriteAllText(_fileFullPath, json);
            Hide();
            MainForm.Instance.Show();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm.Instance.Show();
        }
    }
}
