using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character.pets
{
    public class PetSlots
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("battlePetGuid")]
        public string BattlePetGuid { get; set; }

        [JsonProperty("isEmpty")]
        public bool IsEmpty { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("abilities")]
        public List<int> Abilities { get; set; }
    }
}
