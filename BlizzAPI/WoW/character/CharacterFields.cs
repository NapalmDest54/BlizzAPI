using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class CharacterFields
    {
        public enum Fields
        {
            All,
            Achievements,
            Appearance,
            Feed,
            Guild,
            HunterPets,
            Items,
            Mounts,
            Pets,
            PetSlots,
            Professions,
            Progression,
            PvP,
            Quests,
            Reputation,
            Stats,
            Talents,
            Titles,
            Audit
        }

        public static readonly Dictionary<Fields, String> fieldStrings = new Dictionary<Fields, string>
        {
            {Fields.Achievements, "achievements"},
            {Fields.Appearance, "appearance"},
            {Fields.Feed, "feed"},
            {Fields.Guild, "guild"},
            {Fields.HunterPets, "hunterPets"},
            {Fields.Items, "items"},
            {Fields.Mounts, "mounts"}, 
            {Fields.Pets, "pets"},
            {Fields.PetSlots, "petSlots"},
            {Fields.Professions, "professions"},
            {Fields.Progression, "progression"},
            {Fields.PvP, "pvp"}, 
            {Fields.Quests, "quests"},
            {Fields.Reputation, "reputation"},
            {Fields.Stats, "stats"},
            {Fields.Talents, "talents"},
            {Fields.Titles, "titles"}, 
            {Fields.Audit, "audit"}
        };


    }
}
