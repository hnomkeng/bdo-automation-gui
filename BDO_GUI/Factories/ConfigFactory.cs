using BDO_GUI.Models;
using BDO_GUI.Models.Interfaces;
using BDO_GUI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BDO_GUI.Factories
{
    public static class ConfigFactory
    {
        public static IInternalConfig GetConfig(string applicationName, int numRepeatTimerInMinutes, IExternalConfig externalConfig, IExternalProcessRoutine externalProcessRoutine)
        {
            Tuple<IntPtr, string> targetApplication = Helpers.FindApplication(applicationName);
            ObservableCollection<string> listMats = new ObservableCollection<string>();
            foreach (List<string> mat in externalProcessRoutine.Items)
            {
                listMats.Add(mat.FirstOrDefault().GetDisplayName());
            }

            IInternalConfig config = new InternalConfig
            {
                TargetApplicationPtr = targetApplication.Item1,
                TargetApplicationPartialName = applicationName,
                RepeatTimer = numRepeatTimerInMinutes * 60,
                Worker = new WorkerConfig { IsActive = externalConfig.UseProcessing },
                Processing = new ProcessingConfig { IsActive = externalConfig.UseProcessing, UseVenecil = externalProcessRoutine.UseVenecil, Items = listMats },
                Tray = new TrayConfig { IsActive = externalConfig.UseTray }
            };
            return config;
        }

        public static Tuple<IExternalConfig, IExternalProcessRoutine> GetExternalConfigs(string applicationName, IInternalConfig config)
        {
            IExternalConfig externalConfig = DataService.GetExternalConfig();
            externalConfig.UseWorker = config.Worker.IsActive;
            externalConfig.UseProcessing = config.Processing.IsActive;
            externalConfig.UseTray = config.Tray.IsActive;
            externalConfig.Setting.WindowName = Helpers.FindApplication(applicationName).Item2;

            IExternalProcessRoutine externalProcessRoutine = DataService.GetExternalProcessRoutine();
            IList<IList<string>> list = new List<IList<string>>();
            for (int a = 0; a < config.Processing.Items.Count; a++)
            {
                string name = config.Processing.Items[a].ToString();
                name = name.Replace(" ", "_").ToLower();
                name += "_highlighted";
                list.Add(new List<string> { name });
            }
            externalProcessRoutine.Items = list;
            return new Tuple<IExternalConfig, IExternalProcessRoutine>(externalConfig, externalProcessRoutine);
        }
    }
}
