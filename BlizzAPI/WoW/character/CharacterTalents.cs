using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class CharacterTalents
    {

        [JsonProperty("talents")]
        public List<Talent> Build { get; set; }

        [JsonProperty("glyphs")]
        public Glyphs Glyphs { get; set; }

        [JsonProperty("spec")]
        public Spec Spec { get; set; }

        [JsonProperty("calcTalent")]
        public string CalcTalent { get; set; }

        [JsonProperty("calcSpec")]
        public string CalcSpec { get; set; }

        [JsonProperty("calcGlyph")]
        public string CalcGlyph { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }
    }
}
