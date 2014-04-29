using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.Items
{
    public class ItemStats
    {
        public enum ItemStatType
        {
            Default = 0,
            Health = 1,
            Agility = 3,
            Strength = 4,
            Intellect = 5,
            Spirit = 6,
            Stamina = 7,
            DefenseSkillRating = 12,
            DodgeRating = 13,
            ParryRating = 14,
            BlockRating = 15,
            HitMeleeRating = 16,
            HitRangedRating = 17,
            HitSpellRating = 18,
            CritMeleeRating = 19,
            CritRangedRating = 20,
            CritSpellRating = 21,
            HitMeleeTakenRating = 22,
            HitRangedTakenRating = 23,
            HitSpellTakenRating = 24,
            CritMeleeTakenRating = 25,
            CritRangedTakenRating = 26,
            CritSpellTakenRating = 27,
            HasteMeleeRating = 28,
            HasteRangedRating = 29,
            HasteSpellRating = 30,
            HitRating = 31,
            CritRating = 32,
            HitTakenRating = 33,
            CritTakenRating = 34,
            PvpResilienceRating = 35,
            HasteRating = 36,
            ExpertiseRating = 37,
            AttackPower = 38,
            RangedAttackPower = 39,
            FeralAttackPower = 40,
            SpellHealingDone = 41,
            SpellDamageDone = 42,
            ManaRegeneration = 43,
            ArmorPenetrationRating = 44,
            SpellPower = 45,
            HealthRegeneration = 46,
            SpellPenetration = 47,
            BlockValue = 48,
            MasteryRating = 49,
            ExtraArmor = 50,
            FireResistance = 51,
            FrostResistance = 52,
            ShadowResistance = 54,
            NatureResistance = 55,
            ArcaneResistance = 56,
            PvpPowerRating = 57
        }

    }
}
