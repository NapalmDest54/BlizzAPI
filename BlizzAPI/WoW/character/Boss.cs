using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class Boss
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("normalKills")]
        public int NormalKills { get; set; }

        [JsonProperty("normalTimestamp")]
        public object NormalTimestamp { get; set; }

        [JsonProperty("heroicKills")]
        public int HeroicKills { get; set; }

        [JsonProperty("heroicTimestamp")]
        public long HeroicTimestamp { get; set; }

        [JsonProperty("lfrKills")]
        public int LFRKills { get; set; }

        [JsonProperty("lfrTimestamp")]
        public long LFRTimestamp { get; set; }

        [JsonProperty("flexKills")]
        public int FlexKills { get; set; }

        [JsonProperty("flexTimestamp")]
        public long FlexTimestamp { get; set; }
    }
}
