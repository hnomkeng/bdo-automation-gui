using BDO_GUI.Models.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BDO_GUI.Models
{
    public class ExternalProcessRoutine : IExternalProcessRoutine
    {
        [JsonProperty("Venecil")]
        public bool UseVenecil { get; set; }

        [JsonProperty("items2process")]
        public IList<IList<string>> Items { get; set; }
    }
}
