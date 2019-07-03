using BDO_GUI.Factories;
using BDO_GUI.Models.Interfaces;
using BDO_GUI.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace BDO_GUI
{
    public partial class MainForm : Form
    {
        private static readonly Lazy<MainForm> lazy = new Lazy<MainForm>(() => new MainForm());
        public static MainForm Instance => lazy.Value;

        private IInternalConfig _config;
        private Process _pythonProcess;
        private int _timerCounter;

        private MainForm()
        {
            InitializeComponent();

            IExternalConfig extConfig = DataService.GetExternalConfig();
            IExternalProcessRoutine processRoutine = DataService.GetExternalProcessRoutine();
            _config = ConfigFactory.GetConfig(txtTargetApplicationName.Text, (int)numRepeatTimer.Value, extConfig, processRoutine);

            lblWorkerStatus.Text = _config.Worker.IsActive ? "On" : "Off";
            lblProcessingStatus.Text = _config.Processing.IsActive ? "On" : "Off";
            chkProcessingVenecil.Checked = _config.Processing.UseVenecil;
            chkProcessingVenecil.CheckState = _config.Processing.UseVenecil ? CheckState.Checked : CheckState.Unchecked;
            chkTrayApplication.Checked = _config.Tray.IsActive;
            chkTrayApplication.CheckState = _config.Tray.IsActive ? CheckState.Checked : CheckState.Unchecked;
            chkProcessingContainer.Checked = _config.Processing.UseContainer;
            chkProcessingContainer.CheckState = _config.Processing.UseContainer ? CheckState.Checked : CheckState.Unchecked;

            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "python.exe",
                Verb = "runas",
                WorkingDirectory = Helpers.GetWorkingDirectory(),
                Arguments = "BDO_auto_main.py",
            };

            _pythonProcess = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true,
            };

            // Load List Materials
            IList<IList<string>> listAvailableMats = processRoutine.Processable;
            foreach (IList<string> mats in listAvailableMats)
            {
                foreach (string mat in mats)
                {
                    lbxMaterials.Items.Add(mat.GetDisplayName());
                }
            }

            _config.Processing.Items.CollectionChanged += (s, e) =>
            {
                SetLbxProcessingMaterials();
            };
            SetLbxProcessingMaterials();
        }

        private void SetLbxProcessingMaterials()
        {
            lbxProcessingMaterials.Items.Clear();
            foreach (string mat in _config.Processing.Items)
            {
                lbxProcessingMaterials.Items.Add(mat);
            }
        }

        private void btnToggleWorker_Click(object sender, EventArgs e)
        {
            _config.Worker.IsActive = !_config.Worker.IsActive;
            if (_config.Worker.IsActive)
            {
                lblWorkerStatus.Text = "On";
                return;
            }

            lblWorkerStatus.Text = "Off";
        }

        private void btnToggleProcessing_Click(object sender, EventArgs e)
        {
            _config.Processing.IsActive = !_config.Processing.IsActive;
            if (_config.Processing.IsActive)
            {
                lblProcessingStatus.Text = "On";
                return;
            }

            lblProcessingStatus.Text = "Off";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Tuple<IExternalConfig, IExternalProcessRoutine> extConfigs = ConfigFactory.GetExternalConfigs(txtTargetApplicationName.Text, _config);
            DataService.SaveExternalConfigs(extConfigs.Item1, extConfigs.Item2);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            // Stop process when running
            if (_config.IsRunning)
            {
                btnStartStop.Text = "Start";
                timerRepeat.Stop();

                // buffer
                _timerCounter = _config.RepeatTimer;
                if (!_pythonProcess.HasExited)
                {
                    _pythonProcess.Kill();
                }

                _config.IsRunning = false;
                return;
            }

            btnStartStop.Text = "Stop";
            timerRepeat.Start();
            StartPythonProcess();
            _config.IsRunning = !_config.IsRunning;
        }

        private void timerRepeat_Tick(object sender, EventArgs e)
        {
            _timerCounter--;
            lblTimer.Text = "Counter: " + _timerCounter;

            if (_timerCounter > 0)
            {
                return;
            }

            if (_config.Tray.IsActive && Helpers.FindApplication(txtTargetApplicationName.Text).Item1 == IntPtr.Zero)
            {
                BringUpApplicationFromtray();
            }

            StartPythonProcess();
        }

        public void StartPythonProcess()
        {
            _timerCounter = _config.RepeatTimer;
            _pythonProcess.Start();
            _pythonProcess.Exited += (s, ev) =>
            {
                Helpers.User32.SetForegroundWindow(Handle);
                if (_pythonProcess.ExitCode == 0)
                {
                    return;
                }

                // Error
                timerRepeat.Stop();
                btnStartStop.Text = "Start";
                _config.IsRunning = false;
            };
            _pythonProcess.SynchronizingObject = btnStartStop;
        }

        private void BringUpApplicationFromtray()
        {
            Func<string, bool> myFunc = name => name.StartsWith(txtTargetApplicationName.Text);
            AutomationElementHelpers.InvokeButtonByName(myFunc);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkProcessingVenecil_CheckedChanged(object sender, EventArgs e)
        {
            _config.Processing.UseVenecil = chkProcessingVenecil.Checked;
        }

        private void chkProcessingContainer_CheckedChanged(object sender, EventArgs e)
        {
            _config.Processing.UseContainer = chkProcessingContainer.Checked;
        }

        private void btnProcessingAddMat_Click(object sender, EventArgs e)
        {
            if (lbxMaterials.SelectedIndex == -1)
            {
                return;
            }

            _config.Processing.Items.Add((string)lbxMaterials.SelectedItem);
        }

        private void btnProcessingRemoveMat_Click(object sender, EventArgs e)
        {
            if (lbxProcessingMaterials.SelectedIndex == -1)
            {
                return;
            }


            _config.Processing.Items.Remove((string)lbxProcessingMaterials.SelectedItem);
        }

        private void btnProcessingRemoveAllMat_Click(object sender, EventArgs e)
        {
            _config.Processing.Items.Clear();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            Hide();
            CalibrationForm.Instance.Construct(Helpers.FindApplication(txtTargetApplicationName.Text).Item1);
            CalibrationForm.Instance.Show();
        }

        private void chkTrayApplication_CheckedChanged(object sender, EventArgs e)
        {
            _config.Tray.IsActive = chkTrayApplication.Checked;
        }

        private void numRepeatTimer_ValueChanged(object sender, EventArgs e)
        {
            _config.RepeatTimer = (int)((NumericUpDown)sender).Value * 60;
        }
    }
}
