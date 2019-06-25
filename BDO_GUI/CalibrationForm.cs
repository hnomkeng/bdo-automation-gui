using BDO_GUI.Models;
using BDO_GUI.Adapters;
using BDO_GUI.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using BDO_GUI.Services;

namespace BDO_GUI
{
    public partial class CalibrationForm : Form
    {
        private static readonly Lazy<CalibrationForm> lazy = new Lazy<CalibrationForm>(() => new CalibrationForm());
        public static CalibrationForm Instance => lazy.Value;

        private InternalCalibrationSetup _calibrationSetup = new InternalCalibrationSetup();

        private CalibrationForm()
        {
            InitializeComponent();
        }

        public void Construct(IntPtr targetIntPtr)
        {
            IExternalCalibrationSetup calibrationSetup = DataService.GetExternalCalibrationSetup();
            _calibrationSetup = CalibrationAdapter.ConvertToInternalCalibrationSetup(calibrationSetup);
            _calibrationSetup.SetIntPtr(targetIntPtr, Handle);
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
            IExternalCalibrationSetup config = CalibrationAdapter.ConvertToExternalCalibrationSetup(_calibrationSetup);
            DataService.SaveCalibrationSetup(config);
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
