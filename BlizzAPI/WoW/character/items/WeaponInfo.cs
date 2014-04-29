using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.character.items
{
    public class WeaponInfo
    {
        [JsonProperty("damage")]
        public WeaponDamage Damage { get; set; }

        [JsonProperty("weaponSpeed")]
        public double WeaponSpeed { get; set; }

        [JsonProperty("dps")]
        public double DPS { get; set; }
    }
}
