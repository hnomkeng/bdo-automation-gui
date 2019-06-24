using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Automation;
using System.Windows.Forms;

namespace BDO_GUI
{
    public partial class MainForm : Form
    {
        private static readonly Lazy<MainForm> lazy = new Lazy<MainForm>(() => new MainForm());
        public static MainForm Instance => lazy.Value;

        private Process _pythonProcess;
        private IntPtr _gameIntPtr;
        private string _gameTitle;
        private Config _config;
        private ProcessRoutine _processRoutine;
        private string _pythonDir;
        private int _timerCounter = 900;

        private MainForm()
        {
            InitializeComponent();

            Tuple<IntPtr, string> applicationTuple = Helpers.FindApplication("black desert");
            _gameIntPtr = applicationTuple.Item1;
            _gameTitle = applicationTuple.Item2;

            LoadData();

            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "python.exe",
                Verb = "runas",
                WorkingDirectory = _pythonDir,
                Arguments = "BDO_auto_main.py",
            };

            _pythonProcess = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true
            };
        }

        private void LoadData()
        {
            _pythonDir = "C:/Users/Duc Truong/Downloads/bdo/";
            if (!Directory.Exists(_pythonDir))
            {
                _pythonDir = Directory.GetCurrentDirectory();
            }

            string configFile = _pythonDir + ".config/config.json";

            using (StreamReader r = new StreamReader(configFile))
            {
                string json = r.ReadToEnd();
                _config = JsonConvert.DeserializeObject<Config>(json);
            }

            string processRoutineFile = _pythonDir + _config.Setting.TaskDir.Replace("./", string.Empty) + _config.TaskFile;
            using (StreamReader r = new StreamReader(processRoutineFile))
            {
                string json = r.ReadToEnd();
                _processRoutine = JsonConvert.DeserializeObject<ProcessRoutine>(json);
            }

            LoadListMats();
            
            lblWorkerStatus.Text = _config.FeedWorker ? "On" : "Off";
            lblProcessingStatus.Text = _config.ReloadProcess ? "On" : "Off";
            chkProcessingVenecil.Checked = _processRoutine.Venecil;
            chkProcessingVenecil.CheckState = _processRoutine.Venecil ? CheckState.Checked : CheckState.Unchecked;
        }

        private void LoadListMats()
        {
            string matImagePath = _pythonDir + "BDO_images/materials/";
            if (!Directory.Exists(matImagePath))
            {
                return;
            }

            string[] fileNames = Directory.GetFiles(matImagePath);
            foreach (string filename in fileNames)
            {
                string name = filename.Replace(matImagePath, string.Empty).Replace(".png", string.Empty).Replace("_", " ");
                name = char.ToUpper(name[0]) + name.Substring(1);
                lbxMaterials.Items.Add(name);
            }

            foreach (IList<string> x in _processRoutine.Items)
            {
                string name = x.First().Replace("_highlighted", string.Empty).Replace("_", " ");
                name = char.ToUpper(name[0]) + name.Substring(1);
                lbxProcessingMaterials.Items.Add(name);
            };
        }

        private void btnToggleWorker_Click(object sender, EventArgs e)
        {
            _config.FeedWorker = !_config.FeedWorker;
            if (_config.FeedWorker)
            {
                lblWorkerStatus.Text = "On";
            }
            else
            {
                lblWorkerStatus.Text = "Off";
            }
        }

        private void btnToggleProcessing_Click(object sender, EventArgs e)
        {
            _config.ReloadProcess = !_config.ReloadProcess;
            if (_config.ReloadProcess)
            {
                lblProcessingStatus.Text = "On";
            }
            else
            {
                lblProcessingStatus.Text = "Off";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Stop")
            {
                btnStart.Text = "Start";
                timerRepeat.Stop();

                if (!_pythonProcess.HasExited)
                {
                    _pythonProcess.Kill();
                }

                return;
            }

            btnStart.Text = "Stop";
            timerRepeat.Start();
            _pythonProcess.Start();
            _pythonProcess.Exited += (s, ev) =>
            {
                btnStart.Text = "Start";
            };
            _pythonProcess.SynchronizingObject = btnStart;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkProcessingVenecil_CheckedChanged(object sender, EventArgs e)
        {
            _processRoutine.Venecil = chkProcessingVenecil.Checked;
        }

        private void btnProcessingAddMat_Click(object sender, EventArgs e)
        {
            if (lbxMaterials.SelectedIndex == -1)
            {
                return;
            }

            lbxProcessingMaterials.Items.Add(lbxMaterials.SelectedItem);
        }

        private void btnProcessingRemoveMat_Click(object sender, EventArgs e)
        {
            if (lbxProcessingMaterials.SelectedIndex == -1)
            {
                return;
            }

            lbxProcessingMaterials.Items.RemoveAt(lbxProcessingMaterials.SelectedIndex);
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            _config.Setting.WindowName = _gameTitle;
            string configJson = JsonConvert.SerializeObject(_config);
            File.WriteAllText(_pythonDir + ".config/config.json", configJson);

            IList<IList<string>> list = new List<IList<string>>();
            for (int a = 0; a < lbxProcessingMaterials.Items.Count; a++)
            {
                string name = lbxProcessingMaterials.Items[a].ToString();
                name = name.Replace(" ", "_").ToLower();
                name += "_highlighted";
                list.Add(new List<string>
                {
                    name
                });
            }
            _processRoutine.Items = list;
            string processRoutineJson = JsonConvert.SerializeObject(_processRoutine);
            File.WriteAllText(_pythonDir + _config.Setting.TaskDir.Replace("./", string.Empty) + _config.TaskFile, processRoutineJson);
        }

        private void timerRepeat_Tick(object sender, EventArgs e)
        {
            _timerCounter--;
            lblTimer.Text = "Counter: " + _timerCounter;

            if (_timerCounter >= 0)
            {
                return;
            }

            _timerCounter = 900;
            _pythonProcess.Start();
            _pythonProcess.Exited += (s, ev) =>
            {
                btnStart.Text = "Start";
            };
            _pythonProcess.SynchronizingObject = btnStart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<AutomationElement> icons = EnumNotificationIcons();
            foreach (AutomationElement icon in icons)
            {
                string name = icon.GetCurrentPropertyValue(AutomationElement.NameProperty) as string;
                if (name.StartsWith("Black Desert"))
                {
                    icon.InvokeButton();
                    break;
                }
            }
        }

        public static IEnumerable<AutomationElement> EnumNotificationIcons()
        {
            foreach (AutomationElement button in AutomationElement.RootElement.Find(
                            "User Promoted Notification Area").EnumChildButtons())
            {
                yield return button;
            }

            foreach (AutomationElement button in AutomationElement.RootElement.Find(
                          "System Promoted Notification Area").EnumChildButtons())
            {
                yield return button;
            }

            AutomationElement chevron = AutomationElement.RootElement.Find("Notification Chevron");
            if (chevron != null && chevron.InvokeButton())
            {
                foreach (AutomationElement button in AutomationElement.RootElement.Find(
                                   "Overflow Notification Area").EnumChildButtons())
                {
                    yield return button;
                }
            }
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            Hide();
            CalibrationForm.Instance.Construct(_pythonDir + _config.Setting.Calibration, _gameIntPtr);
            CalibrationForm.Instance.Show();
        }
    }
}
