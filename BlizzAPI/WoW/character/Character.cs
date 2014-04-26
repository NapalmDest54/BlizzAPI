using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.character
{
    public class Character
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastModified")]
        public long LastModified { get; set; }

        [JsonProperty("realm")]
        public string Realm { get; set; }

        [JsonProperty("battlegroup")]
        public string BattleGroup { get; set; }

        [JsonProperty("class")]
        public int Class { get; set; }

        [JsonProperty("race")]
        public int Race { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("calcClass")]
        public string CalcClass { get; set; }

        [JsonProperty("totalHonorableKills")]
        public int TotalHonorableKills { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("titles")]
        public List<Title> Titles { get; set; }


        [JsonProperty("talents")]
        public List<CharacterTalents> Talents { get; set; }

        [JsonProperty("progression")]
        public Progression Progressions { get; set; }

        public string toString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented).ToString();
        }
    }
}
