using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.pvp
{
    public class Bracket
    {

        [JsonProperty("slug")]
        public string Type { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("weeklyPlayed")]
        public int WeeklyPlayed { get; set; }

        [JsonProperty("weeklyWon")]
        public int WeeklyWon { get; set; }

        [JsonProperty("weeklyLost")]
        public int WeeklyLost { get; set; }

        [JsonProperty("seasonPlayed")]
        public int SeasonPlayed { get; set; }

        [JsonProperty("seasonWon")]
        public int SeasonWon { get; set; }

        [JsonProperty("seasonLost")]
        public int SeasonLost { get; set; }
    }
}
