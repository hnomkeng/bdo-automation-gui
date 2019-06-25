using BDO_GUI.Models.Interfaces;
using Newtonsoft.Json;

namespace BDO_GUI.Models
{
    public class ExternalConfig : IExternalConfig
    {
        [JsonProperty("Setting")]
        public ExternalConfigSetting Setting { get; set; }

        [JsonProperty("FeedWorker")]
        public bool UseWorker { get; set; }

        [JsonProperty("ReloadProcess")]
        public bool UseProcessing { get; set; }

        [JsonProperty("HideApp")]
        public bool UseTray { get; set; }

        [JsonProperty("TaskFile")]
        public string TaskFile { get; set; }
    }

    public class ExternalConfigSetting
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
