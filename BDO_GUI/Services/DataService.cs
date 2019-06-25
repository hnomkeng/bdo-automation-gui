using BDO_GUI.Models;
using BDO_GUI.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BDO_GUI.Services
{
    public static class DataService
    {
        public static IExternalConfig GetExternalConfig()
        {
            string fileName = Helpers.GetWorkingDirectory() + ".config/config.json";
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<ExternalConfig>(json);
            }
        }

        public static IExternalProcessRoutine GetExternalProcessRoutine()
        {
            string fileName = Helpers.GetWorkingDirectory() + "BDO_process_routines/process_routine.txt";
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<ExternalProcessRoutine>(json);
            }
        }

        public static void SaveExternalConfigs(IExternalConfig externalConfig, IExternalProcessRoutine externalProcessRoutine)
        {
            string configJson = JsonConvert.SerializeObject(externalConfig);
            File.WriteAllText(Helpers.GetWorkingDirectory() + ".config/config.json", configJson);

            string processRoutineJson = JsonConvert.SerializeObject(externalProcessRoutine);
            File.WriteAllText(Helpers.GetWorkingDirectory() + "BDO_process_routines/process_routine.txt", processRoutineJson);
        }

        public static IExternalCalibrationSetup GetExternalCalibrationSetup()
        {
            string fileName = Helpers.GetWorkingDirectory() + ".config/calibration.json";
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<ExternalCalibrationSetup>(json);
            }
        }

        public static void SaveCalibrationSetup(IExternalCalibrationSetup config)
        {
            string fileName = Helpers.GetWorkingDirectory() + ".config/calibration.json";
            string json = JsonConvert.SerializeObject(config);
            File.WriteAllText(fileName, json);
        }

        public static IList<string> GetListAvailableMaterials()
        {
            string matImagePath = Helpers.GetWorkingDirectory() + "BDO_images/materials/";
            if (!Directory.Exists(matImagePath))
                return null;

            IList<string> results = new List<string>();
            string[] fileNames = Directory.GetFiles(matImagePath);
            foreach (string filename in fileNames)
                results.Add(filename.GetDisplayName());

            return results;
        }
    }
}
