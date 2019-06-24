using Newtonsoft.Json;
using System.Collections.Generic;

namespace BDO_GUI
{
    public class ProcessRoutine
    {
        public bool Venecil { get; set; }

        [JsonProperty("items2process")]
        public IList<IList<string>> Items { get; set; }
    }
}
