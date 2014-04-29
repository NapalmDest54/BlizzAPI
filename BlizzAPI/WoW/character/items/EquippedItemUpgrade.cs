using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.character.items
{
    public class EquippedItemUpgrade
    {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("itemLevelIncrement")]
        public int ItemLevelIncrement { get; set; }
    }
}
