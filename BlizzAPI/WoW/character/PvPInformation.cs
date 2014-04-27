using BlizzAPI.WoW.pvp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class PvPInformation
    {
        [JsonProperty("brackets")]
        public Brackets Brackets { get; set; }
    }
}
