using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace BDO_GUI
{
    public partial class MainForm : Form
    {
        private Process _pythonProcess;
        private IntPtr _gameIntPtr;
        private WorkerSetup _workerSetup;

        public MainForm()
        {
            InitializeComponent();
            LoadData();

            _gameIntPtr = FindGameIntPtr();
            _workerSetup = new WorkerSetup();

            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "python.exe",
                Verb = "runas",
                WorkingDirectory = @"C:\Users\Duc Truong\Downloads\bdo\",
                Arguments = "BDO_auto_main.py",
            };

            _pythonProcess = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true
            };
        }

        private IntPtr FindGameIntPtr()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.ToLower()
                           .IndexOf("black desert", StringComparison.InvariantCulture) > -1)
                {
                    return process.MainWindowHandle;
                }
            }

            return IntPtr.Zero;
        }

        private void LoadData()
        {

        }

        private void btnToggleWorker_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Stop")
            {
                btnStart.Text = "Start";

                if (!_pythonProcess.HasExited)
                {
                    _pythonProcess.Kill();
                }

                return;
            }

            btnStart.Text = "Stop";
            _pythonProcess.Start();
            _pythonProcess.Exited += (s, ev) =>
            {
                btnStart.Text = "Start";
            };
            _pythonProcess.SynchronizingObject = btnStart;
        }

        private void btnWorkerIconLocation_Click(object sender, EventArgs e)
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                _workerSetup.MainIcon = TargetLocation.SelectedPoint;
                SaveData();
                Helpers.User32.SetForegroundWindow(Handle);
            };
            TargetLocation.Select(_gameIntPtr);
        }

        private void btnWorkerRecoverLocation_Click(object sender, EventArgs e)
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                _workerSetup.Recover = TargetLocation.SelectedPoint;
                SaveData();
                Helpers.User32.SetForegroundWindow(Handle);
            };
            TargetLocation.Select(_gameIntPtr);
        }

        private void btnWorkerRepeatLocation_Click(object sender, EventArgs e)
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                _workerSetup.RepeatWork = TargetLocation.SelectedPoint;
                SaveData();
                Helpers.User32.SetForegroundWindow(Handle);
            };
            TargetLocation.Select(_gameIntPtr);
        }

        private void btnWorkerConfirmLocation_Click(object sender, EventArgs e)
        {
            TargetLocation.TargetSelected += (s, ev) =>
            {
                _workerSetup.Confirm = TargetLocation.SelectedPoint;
                SaveData();
                Helpers.User32.SetForegroundWindow(Handle);
            };
            TargetLocation.Select(_gameIntPtr);
        }

        private void SaveData()
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
