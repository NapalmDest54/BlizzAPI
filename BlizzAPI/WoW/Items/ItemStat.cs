using BlizzAPI.WoW.Items;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.Items
{
    public class ItemStat
    {

        [JsonProperty("stat")]
        public ItemStats.ItemStatType StatType { get; set; }


        [JsonProperty("amount")]
        public int Amount { get; set; }


        [JsonProperty("reforged")]
        public bool IsReforge { get; set; }

        [JsonProperty("reforgedAmount")]
        public int ReforgedAmount { get; set; }
    }
}
