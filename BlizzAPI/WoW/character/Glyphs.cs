using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class Glyphs
    {
        [JsonProperty("major")]
        public List<Glyph> major { get; set; }

        [JsonProperty("minor")]
        public List<Glyph> minor { get; set; }
    }
}
