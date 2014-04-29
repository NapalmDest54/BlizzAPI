using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.Items
{
    public class WeaponDamage
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("exactMin")]
        public double ExactMin { get; set; }

        [JsonProperty("exactMax")]
        public double ExactMax { get; set; }
    }
}
