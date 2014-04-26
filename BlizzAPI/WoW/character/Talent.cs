using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW
{
    public class Talent
    {

        [JsonProperty("tier")]
        public int tier { get; set; }

        [JsonProperty("column")]
        public int column { get; set; }

        [JsonProperty("spell")]
        public Spell spell { get; set; }
    }
}
