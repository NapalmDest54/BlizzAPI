using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character.pets
{
    public class Pet
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spellId")]
        public int SpellID { get; set; }

        [JsonProperty("creatureId")]
        public int CreatureID { get; set; }

        [JsonProperty("itemId")]
        public int ItemID { get; set; }

        [JsonProperty("qualityId")]
        public int QualityID { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("stats")]
        public PetStats Stats { get; set; }

        [JsonProperty("battlePetGuid")]
        public string BattlePetGuid { get; set; }

        [JsonProperty("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("isFirstAbilitySlotSelected")]
        public bool IsFirstAbilitySlotSelected { get; set; }

        [JsonProperty("isSecondAbilitySlotSelected")]
        public bool IsSecondAbilitySlotSelected { get; set; }

        [JsonProperty("isThirdAbilitySlotSelected")]
        public bool IsThirdAbilitySlotSelected { get; set; }

        [JsonProperty("creatureName")]
        public string CreatureName { get; set; }

        [JsonProperty("canBattle")]
        public bool CanBattle { get; set; }
    }
}
