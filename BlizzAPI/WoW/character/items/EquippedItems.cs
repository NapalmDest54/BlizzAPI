using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character.items
{
    public class EquippedItems
    {
        [JsonProperty("averageItemLevel")]
        public int AverageItemLevel { get; set; }

        [JsonProperty("averageItemLevelEquipped")]
        public int AverageItemLevelEquipped { get; set; }

        [JsonProperty("head")]
        public EquippedItem Head { get; set; }

        [JsonProperty("neck")]
        public EquippedItem Neck { get; set; }

        [JsonProperty("shoulder")]
        public EquippedItem Shoulder { get; set; }

        [JsonProperty("back")]
        public EquippedItem Back { get; set; }

        [JsonProperty("chest")]
        public EquippedItem Chest { get; set; }

        [JsonProperty("wrist")]
        public EquippedItem Wrist { get; set; }

        [JsonProperty("hands")]
        public EquippedItem Hands { get; set; }

        [JsonProperty("waist")]
        public EquippedItem Waist { get; set; }

        [JsonProperty("legs")]
        public EquippedItem Legs { get; set; }

        [JsonProperty("feet")]
        public EquippedItem Feet { get; set; }

        [JsonProperty("finger1")]
        public EquippedItem Finger1 { get; set; }

        [JsonProperty("finger2")]
        public EquippedItem Finger2 { get; set; }

        [JsonProperty("trinket1")]
        public EquippedItem Trinket1 { get; set; }

        [JsonProperty("trinket2")]
        public EquippedItem Trinket2 { get; set; }

        [JsonProperty("mainHand")]
        public EquippedItem MainHand { get; set; }

        [JsonProperty("offHand")]
        public EquippedItem OffHand { get; set; }

        [JsonProperty("shirt")]
        public EquippedItem Shirt { get; set; }

        [JsonProperty("tabard")]
        public EquippedItem Tabard { get; set; }
    }
}
