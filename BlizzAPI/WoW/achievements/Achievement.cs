using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.achievements
{
    public class Achievement
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rewardItems")]
        public List<object> RewardItems { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("criteria")]
        public List<AchievementCriteria> Criteria { get; set; }

        [JsonProperty("accountWide")]
        public bool AccountWide { get; set; }

        [JsonProperty("factionId")]
        public int CactionID { get; set; }
    }
}
