using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.character.items
{
    public class EquippedItemParameters
    {

        [JsonProperty("gem0")]
        public int? Gem0 { get; set; }

        [JsonProperty("gem1")]
        public int? Gem1 { get; set; }

        [JsonProperty("gem2")]
        public int? Gem2 { get; set; }

        [JsonProperty("gem3")]
        public int? Gem3 { get; set; }

        [JsonProperty("enchant")]
        public int? Enchant { get; set; }

        [JsonProperty("set")]
        public List<int> Set { get; set; }

        [JsonProperty("reforge")]
        /// <summary>
        /// Gets or sets the reforge ID.
        /// </summary>
        public int Reforge { get; set; }

        [JsonProperty("upgrade")]
        public EquippedItemUpgrade Upgrade { get; set; }

        [JsonProperty("transmogrifyItemId")]
        public int? TransmogrifyItemId { get; set; }

        [JsonProperty("extraSocket")]
        public bool ExtraSocket { get; set; }

        [JsonProperty("tinker")]
        public int? Tinker { get; set; }

    }
}
