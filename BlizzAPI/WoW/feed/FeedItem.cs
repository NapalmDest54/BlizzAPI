using BlizzAPI.WoW.achievements;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.feed
{
    public class FeedItem
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("achievement")]
        public Achievement Achievement { get; set; }

        [JsonProperty("featOfStrength")]
        public bool FeatOfStrength { get; set; }

        [JsonProperty("criteria")]
        public AchievementCriteria Criteria { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("itemId")]
        public int ItemID { get; set; }
    }
}
