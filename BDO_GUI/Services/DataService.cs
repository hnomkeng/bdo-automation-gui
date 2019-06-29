using BDO_GUI.Models;
using BDO_GUI.Models.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace BDO_GUI.Services
{
    public static class DataService
    {
        public static IExternalConfig GetExternalConfig()
        {
            string fileName = Path.Combine(Helpers.GetWorkingDirectory(), @".config\config.json");
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<ExternalConfig>(json);
            }
        }

        public static IExternalProcessRoutine GetExternalProcessRoutine()
        {
            string fileName = Path.Combine(Helpers.GetWorkingDirectory(), @".config\process_routine.json");
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<ExternalProcessRoutine>(json);
            }
        }

        public static void SaveExternalConfigs(IExternalConfig externalConfig, IExternalProcessRoutine externalProcessRoutine)
        {
            string configJson = JsonConvert.SerializeObject(externalConfig);
            File.WriteAllText(Path.Combine(Helpers.GetWorkingDirectory(), @".config\config.json"), configJson);

            string processRoutineJson = JsonConvert.SerializeObject(externalProcessRoutine);
            File.WriteAllText(Path.Combine(Helpers.GetWorkingDirectory(), @".config\process_routine.json"), processRoutineJson);
        }

        public static IExternalCalibrationSetup GetExternalCalibrationSetup()
        {
            string fileName = Path.Combine(Helpers.GetWorkingDirectory(), @".config\calibration.json");
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<ExternalCalibrationSetup>(json);
            }
        }

        public static void SaveCalibrationSetup(IExternalCalibrationSetup config)
        {
            string fileName = Path.Combine(Helpers.GetWorkingDirectory(), @".config\calibration.json");
            string json = JsonConvert.SerializeObject(config);
            File.WriteAllText(fileName, json);
        }
    }
}
