using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class Progression
    {
        [JsonProperty("raids")]
        public List<Raid> Raids { get; set; }
    }
}
