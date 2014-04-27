using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.achievements
{
    public class AchievementCriteria
    {

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("orderIndex")]
        public int OrderIndex { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }
}
