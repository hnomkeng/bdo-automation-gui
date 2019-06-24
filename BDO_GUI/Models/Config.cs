using Newtonsoft.Json;

namespace BDO_GUI
{
    public class Config
    {
        public ConfigSetting Setting { get; set; }
        public bool FeedWorker { get; set; }
        public bool ReloadProcess { get; set; }
        public string TaskFile { get; set; }
    }

    public class ConfigSetting
    {
        [JsonProperty("BDO_task_dir")]
        public string TaskDir { get; set; }

        [JsonProperty("BDO_img_dir")]
        public string ImageDir { get; set; }

        [JsonProperty("BDO_window_name")]
        public string WindowName { get; set; }

        [JsonProperty("BDO_calibration")]
        public string Calibration { get; set; }
    }
}
