using BDO_GUI.Models.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BDO_GUI.Models
{
    public class ExternalCalibrationSetup : IExternalCalibrationSetup
    {
        [JsonProperty("_BDO_land_marks")]
        public CalibrationLandMark CalibrationLandMarks { get; set; }

        [JsonProperty("_BDO_screen_zone")]
        public CalibrationScreenZone CalibrationScreenZone { get; set; }
    }

    public class CalibrationLandMark
    {
        [JsonProperty("worker_icon")]
        public IList<int> WorkerIcon { get; set; }

        [JsonProperty("recover_all_btn")]
        public IList<int> RecoverAllBtn { get; set; }

        [JsonProperty("confirm_btn")]
        public IList<int> ConfirmBtn { get; set; }

        [JsonProperty("beer_icon")]
        public IList<int> BeerIcon { get; set; }

        [JsonProperty("repeat_all_btn")]
        public IList<int> RepeatAllBtn { get; set; }

        [JsonProperty("storage_btn")]
        public IList<int> StorageBtn { get; set; }


        [JsonProperty("process_btn")]
        public IList<int> ProcessBtn { get; set; }


        [JsonProperty("chopping_icon")]
        public IList<int> ChoppingIcon { get; set; }


        [JsonProperty("heating_icon")]
        public IList<int> HeatingIcon { get; set; }

        [JsonProperty("start_btn")]
        public IList<int> StartBtn { get; set; }
    }

    public class CalibrationScreenZone
    {
        [JsonProperty("left_zone")]
        public IList<int> Left { get; set; }

        [JsonProperty("mid_zone")]
        public IList<int> Mid { get; set; }

        [JsonProperty("right_zone")]
        public IList<int> Right { get; set; }

        [JsonProperty("storage_amity_zone")]
        public IList<int> Amity { get; set; }
    }

}
