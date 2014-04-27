using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.achievements
{
    public class Achievements
    {
        [JsonProperty("achievementsCompleted")]
        public List<int> AchievementsCompleted { get; set; }

        [JsonProperty("achievementsCompletedTimestamp")]
        public List<long> AchievementsCompletedTimestamp { get; set; }

        [JsonProperty("criteria")]
        public List<int> Criteria { get; set; }

        [JsonProperty("criteriaQuantity")]
        public List<long> CriteriaQuantity { get; set; }

        [JsonProperty("criteriaTimestamp")]
        public List<long> CriteriaTimestamp { get; set; }

        [JsonProperty("criteriaCreated")]
        public List<long> CriteriaCreated { get; set; }
    }
}
