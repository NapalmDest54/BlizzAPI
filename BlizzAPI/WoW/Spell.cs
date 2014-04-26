using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW
{
    public class Spell
    {
        private string description = "";
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value.Replace("\n", Environment.NewLine);
            }
        }

        [JsonProperty("castTime")]
        public string CastTime { get; set; }

        [JsonProperty("cooldown")]
        public string Cooldown { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }
    }
}
