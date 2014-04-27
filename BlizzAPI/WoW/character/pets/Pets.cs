using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character.pets
{
    public class Pets
    {
        [JsonProperty("numCollected")]
        public int NumCollected { get; set; }

        [JsonProperty("numNotCollected")]
        public int NumNotCollected { get; set; }

        [JsonProperty("collected")]
        public List<Pet> Collected { get; set; }
    }
}
