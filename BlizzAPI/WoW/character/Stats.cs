using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class Stats
    {
        [JsonProperty("health")]
        public int Health { get; set; }

        [JsonProperty("powerType")]
        public string PowerType { get; set; }

        [JsonProperty("Power")]
        public int Power { get; set; }

        [JsonProperty("str")]
        public int Strength { get; set; }

        [JsonProperty("agi")]
        public int Agility { get; set; }

        [JsonProperty("sta")]
        public int Stamina { get; set; }

        [JsonProperty("int")]
        public int Intellect { get; set; }

        [JsonProperty("spr")]
        public int Spirit { get; set; }

        [JsonProperty("attackPower")]
        public int AttackPower { get; set; }

        [JsonProperty("rangedAttackPower")]
        public int RangedAttackPower { get; set; }

        [JsonProperty("pvpResilienceBonus")]
        public double PvPResilienceBonus { get; set; }

        [JsonProperty("mastery")]
        public double Mastery { get; set; }

        [JsonProperty("masteryRating")]
        public int MasteryRating { get; set; }

        [JsonProperty("crit")]
        public double Crit { get; set; }

        [JsonProperty("critRating")]
        public int CritRating { get; set; }

        [JsonProperty("hitPercent")]
        public double HitPercent { get; set; }

        [JsonProperty("hitRating")]
        public int HitRating { get; set; }

        [JsonProperty("haste")]
        public double Haste { get; set; }

        [JsonProperty("hasteRating")]
        public int HasteRating { get; set; }

        [JsonProperty("hasteRatingPercent")]
        public double HasteRatingPercent { get; set; }

        [JsonProperty("expertiseRating")]
        public int ExpertiseRating { get; set; }

        [JsonProperty("spellPower")]
        public int SpellPower { get; set; }

        [JsonProperty("spellPen")]
        public int SpellPenetration { get; set; }

        [JsonProperty("spellCrit")]
        public double SpellCrit { get; set; }

        [JsonProperty("spellCritRating")]
        public int SpellCritRating { get; set; }

        [JsonProperty("spellHitPercent")]
        public double SpellHitPercent { get; set; }

        [JsonProperty("spellHitRating")]
        public int SpellHitRating { get; set; }

        [JsonProperty("mana5")]
        public double ManaPer5Seconds { get; set; }

        [JsonProperty("mana5Combat")]
        public double ManaCombatPer5Seconds { get; set; }

        [JsonProperty("spellHaste")]
        public double SpellHaste { get; set; }

        [JsonProperty("spellHasteRating")]
        public int SpellHasteRating { get; set; }

        [JsonProperty("spellHasteRatingPercent")]
        public double SpellHasteRatingPercent { get; set; }

        [JsonProperty("armor")]
        public int Armor { get; set; }

        [JsonProperty("dodge")]
        public double Dodge { get; set; }

        [JsonProperty("dodgeRating")]
        public int DodgeRating { get; set; }

        [JsonProperty("parry")]
        public double Parry { get; set; }

        [JsonProperty("parryRating")]
        public int parryRating { get; set; }

        [JsonProperty("block")]
        public double Block { get; set; }

        [JsonProperty("blockRating")]
        public int BlockRating { get; set; }

        [JsonProperty("pvpResilience")]
        public double PvPResilience { get; set; }

        [JsonProperty("pvpResilienceRating")]
        public int PvPResilienceRating { get; set; }

        [JsonProperty("mainHandDmgMin")]
        public double MainHandDmgMin { get; set; }

        [JsonProperty("mainHandDmgMax")]
        public double MainHandDmgMax { get; set; }

        [JsonProperty("mainHandSpeed")]
        public double MainHandSpeed { get; set; }

        [JsonProperty("mainHandDps")]
        public double MainHandDps { get; set; }

        [JsonProperty("mainHandExpertise")]
        public double MainHandExpertise { get; set; }

        [JsonProperty("offHandDmgMin")]
        public double OffHandDmgMin { get; set; }

        [JsonProperty("offHandDmgMax")]
        public double OffHandDmgMax { get; set; }

        [JsonProperty("offHandSpeed")]
        public double OffHandSpeed { get; set; }

        [JsonProperty("offHandDps")]
        public double OffHandDps { get; set; }

        [JsonProperty("offHandExpertise")]
        public double OffHandExpertise { get; set; }

        [JsonProperty("rangedDmgMin")]
        public double RangedDmgMin { get; set; }

        [JsonProperty("rangedDmgMax")]
        public double RangedDmgMax { get; set; }

        [JsonProperty("rangedSpeed")]
        public double RangedSpeed { get; set; }

        [JsonProperty("rangedDps")]
        public double RangedDps { get; set; }

        [JsonProperty("rangedExpertise")]
        public double RangedExpertise { get; set; }

        [JsonProperty("rangedCrit")]
        public double RangedCrit { get; set; }

        [JsonProperty("rangedCritRating")]
        public int RangedCritRating { get; set; }

        [JsonProperty("rangedHitPercent")]
        public double RangedHitPercent { get; set; }

        [JsonProperty("rangedHitRating")]
        public int RangedHitRating { get; set; }

        [JsonProperty("rangedHaste")]
        public double RangedHaste { get; set; }

        [JsonProperty("rangedHasteRating")]
        public int RangedHasteRating { get; set; }

        [JsonProperty("rangedHasteRatingPercent")]
        public double RangedHasteRatingPercent { get; set; }

        [JsonProperty("pvpPower")]
        public double PvPPower { get; set; }

        [JsonProperty("pvpPowerRating")]
        public int PvPPowerRating { get; set; }

        [JsonProperty("pvpPowerDamage")]
        public double PvPPowerDamage { get; set; }

        [JsonProperty("pvpPowerHealing")]
        public double PvPPowerHealing { get; set; }
    }
}
