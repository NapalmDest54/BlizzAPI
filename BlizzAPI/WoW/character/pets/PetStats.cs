using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.character.pets
{
    public class PetStats
    {
        [JsonProperty("speciesId")]
        public int SpeciesID { get; set; }

        [JsonProperty("breedId")]
        public int BreedID { get; set; }

        [JsonProperty("petQualityId")]
        public int PetQualityID { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("health")]
        public int Health { get; set; }

        [JsonProperty("power")]
        public int Power { get; set; }

        [JsonProperty("speed")]
        public int Speed { get; set; }
    }
}
