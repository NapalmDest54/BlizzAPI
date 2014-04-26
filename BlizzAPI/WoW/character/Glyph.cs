using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class Glyph
    {
        [JsonProperty("glyph")]
        public int ID { get; set; }

        [JsonProperty("item")]
        public int ItemID { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }
    }
}
