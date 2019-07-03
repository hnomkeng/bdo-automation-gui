using BDO_GUI.Models.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BDO_GUI.Models
{
    public class ExternalProcessRoutine : IExternalProcessRoutine
    {
        [JsonProperty("Venecil")]
        public bool UseVenecil { get; set; }

        [JsonProperty("Container")]
        public bool UseContainer { get; set; }

        [JsonProperty("processable")]
        public IList<IList<string>> Processable { get; set; }

        [JsonProperty("items2process")]
        public IList<IList<string>> Items { get; set; }

        public ExternalProcessRoutine()
        {
            Processable = new List<IList<string>>()
            {
                new List<string> { "acacia_timber" },
                new List<string> { "cedar_timber" },
                new List<string> { "white_cedar_timber" },
                new List<string> { "birch_timber" },
                new List<string> { "fir_timber" },
                new List<string> { "pine_timber" },
                new List<string> { "maple_timber" },
                new List<string> { "ash_timber" },
                new List<string> { "zinc_ore" },
                new List<string> { "tin_ore" },
                new List<string> { "copper_ore" },
                new List<string> { "iron_ore" },
                new List<string> { "melted_copper_shard", "melted_zinc_shard" },
                new List<string> { "melted_copper_shard", "melted_tin_shard" },
                new List<string> { "melted_iron_shard", "coal" },
            };
        }
    }
}
