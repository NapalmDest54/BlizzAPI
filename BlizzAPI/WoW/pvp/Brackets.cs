using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.pvp
{
    public class Brackets
    {
        [JsonProperty("ARENA_BRACKET_2v2")]
        public Bracket Arena2v2 { get; set; }

        [JsonProperty("ARENA_BRACKET_3v3")]
        public Bracket Arena3v3 { get; set; }

        [JsonProperty("ARENA_BRACKET_5v5")]
        public Bracket Arena5v5 { get; set; }

        [JsonProperty("ARENA_BRACKET_RBG")]
        public Bracket RatedBattlegrounds { get; set; }
    }
}
