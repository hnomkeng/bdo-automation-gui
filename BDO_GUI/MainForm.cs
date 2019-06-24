using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BDO_GUI
{
    public partial class MainForm : Form
    {
        private Process _pythonProcess;
        private IntPtr _gameIntPtr;
        private string _gameTitle;
        private WorkerSetup _workerSetup;
        private ProcessingSetup _processingSetup;
        private AreaCalibrationSetup _areaSetup;
        private Config _config;
        private ProcessRoutine _processRoutine;
        private string _pythonDir;

        public MainForm()
        {
            InitializeComponent();

            Tuple<IntPtr, string> applicationTuple = Helpers.FindApplication("black desert");
            _gameIntPtr = applicationTuple.Item1;
            _gameTitle = applicationTuple.Item2;

            _workerSetup = new WorkerSetup(_gameIntPtr, Handle);
            _processingSetup = new ProcessingSetup(_gameIntPtr, Handle);
            _areaSetup = new AreaCalibrationSetup(_gameIntPtr, Handle);
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

            _workerSetup.IsActive = _config.FeedWorker;
            lblWorkerStatus.Text = _workerSetup.IsActive ? "On" : "Off";
            _processingSetup.IsActive = _config.ReloadProcess;
            lblProcessingStatus.Text = _processingSetup.IsActive ? "On" : "Off";
            _processingSetup.UseVenecil = _processRoutine.Venecil;
            chkProcessingVenecil.Checked = _processRoutine.Venecil;
            chkProcessingVenecil.CheckState = _processRoutine.Venecil ? CheckState.Checked: CheckState.Unchecked;
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

            foreach(var x in _processRoutine.Items)
            {
                string name = x.First().Replace("_highlighted", string.Empty).Replace("_", " ");
                name = char.ToUpper(name[0]) + name.Substring(1);
                lbxProcessingMaterials.Items.Add(name);
            };
        }

        private void btnToggleWorker_Click(object sender, EventArgs e)
        {
            _workerSetup.IsActive = !_workerSetup.IsActive;
            if (_workerSetup.IsActive)
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
            _processingSetup.IsActive = !_processingSetup.IsActive;
            if (_processingSetup.IsActive)
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

        #region Worker Setup
        private void btnWorkerIcon_Click(object sender, EventArgs e)
        {
            _workerSetup.SetMainIcon();
        }

        private void btnWorkerRecoverBtn_Click(object sender, EventArgs e)
        {
            _workerSetup.SetRecoverBtn();
        }

        private void btnWorkerRepeatBtn_Click(object sender, EventArgs e)
        {
            _workerSetup.SetRepeatWorkBtn();
        }

        private void btnWorkerBeerIcon_Click(object sender, EventArgs e)
        {
            _workerSetup.SetBeerIcon();
        }

        private void btnWorkerConfirmBtn_Click(object sender, EventArgs e)
        {
            _workerSetup.SetConfirmBtn();
        }
        #endregion
        #region Processing Setup
        private void btnProcessingStorageBtn_Click(object sender, EventArgs e)
        {
            _processingSetup.SetStorageBtn();
        }

        private void btnProcessingStorageProcessBtn_Click(object sender, EventArgs e)
        {
            _processingSetup.SetProcessBtn();
        }

        private void btnProcessingHeatingIcon_Click(object sender, EventArgs e)
        {
            _processingSetup.SetHeatingIcon();
        }

        private void btnProcessingChoppingIcon_Click(object sender, EventArgs e)
        {
            _processingSetup.SetChoppingIcon();
        }

        private void btnProcessingStartBtn_Click(object sender, EventArgs e)
        {
            _processingSetup.SetStartBtn();
        }
        #endregion
        #region Processing Area Setup
        private void btnAmityArea_Click(object sender, EventArgs e)
        {
            _areaSetup.SetAmityArea();
        }

        private void btnLeftArea_Click(object sender, EventArgs e)
        {
            _areaSetup.SetLeftArea();
        }

        private void btnMidArea_Click(object sender, EventArgs e)
        {
            _areaSetup.SetMidArea();
        }

        private void btnRightArea_Click(object sender, EventArgs e)
        {
            _areaSetup.SetRightArea();
        }
        #endregion

        private void btnSaveCalibration_Click(object sender, EventArgs e)
        {
            string json = $"{{\"_BDO_land_marks\":{{\"worker_icon\": [{_workerSetup.MainIcon.X}, {_workerSetup.MainIcon.Y}], \"recover_all_btn\": [{_workerSetup.RecoverBtn.X}, {_workerSetup.RecoverBtn.Y}], \"confirm_btn\": [{_workerSetup.ConfirmBtn.X}, {_workerSetup.ConfirmBtn.Y}],\"beer_icon\": [{_workerSetup.BeerIcon.X}, {_workerSetup.BeerIcon.Y}],\"repeat_all_btn\": [{_workerSetup.RepeatWorkBtn.X}, {_workerSetup.RepeatWorkBtn.Y}],";
            json += $"\"storage_btn\": [{_processingSetup.StorageBtn.X}, {_processingSetup.StorageBtn.Y}],  \"process_btn\": [{_processingSetup.ProcessBtn.X}, {_processingSetup.ProcessBtn.Y}],\"chopping_icon\": [{_processingSetup.ChoppingIcon.X}, {_processingSetup.ChoppingIcon.Y}],\"heating_icon\": [{_processingSetup.HeatingIcon.X}, {_processingSetup.HeatingIcon.Y}],\"start_btn\": [{_processingSetup.StartBtn.X}, {_processingSetup.StartBtn.Y}]}},";
            json += $"\"_BDO_screen_zone\":{{\"right_zone\": [{_areaSetup.Right.X}, {_areaSetup.Right.Y}, {_areaSetup.Right.Width}, {_areaSetup.Right.Height}], \"mid_zone\": [{_areaSetup.Mid.X}, {_areaSetup.Mid.Y}, {_areaSetup.Mid.Width}, {_areaSetup.Mid.Height}],  \"left_zone\": [{_areaSetup.Left.X}, {_areaSetup.Left.Y}, {_areaSetup.Left.Width}, {_areaSetup.Left.Height}],\"storage_amity_zone\": [{_areaSetup.Amity.X}, {_areaSetup.Amity.Y}, {_areaSetup.Amity.Width}, {_areaSetup.Amity.Height}]}}}}";
            File.WriteAllText(_pythonDir + _config.Setting.Calibration, json);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkProcessingVenecil_CheckedChanged(object sender, EventArgs e)
        {
            _processingSetup.UseVenecil = chkProcessingVenecil.Checked;
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
            _config.FeedWorker = _workerSetup.IsActive;
            _config.ReloadProcess = _processingSetup.IsActive;
            string configJson = JsonConvert.SerializeObject(_config);
            File.WriteAllText(_pythonDir + ".config/config.json", configJson);

            _processRoutine.Venecil = _processingSetup.UseVenecil;
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
    }
}
