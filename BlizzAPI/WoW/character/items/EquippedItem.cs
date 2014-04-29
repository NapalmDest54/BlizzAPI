using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character.items
{
    public class EquippedItem
    {

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("quality")]
        public int Quality { get; set; }

        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }

        [JsonProperty("tooltipParams")]
        public EquippedItemParameters TooltipParams { get; set; }

        [JsonProperty("stats")]
        public List<ItemStat> Stats { get; set; }

        [JsonProperty("armor")]
        public int Armor { get; set; }

        [JsonProperty("weaponInfo")]
        public WeaponInfo WeaponInfo { get; set; }
    }
}
