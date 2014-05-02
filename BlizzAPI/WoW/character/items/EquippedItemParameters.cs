// Copyright (C) 2011 by Sherif Elmetainy (Grendiser@Kazzak-EU)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BlizzAPI.WoW.character.items
{
    public class EquippedItemParameters
    {
        private static readonly Dictionary<int, BlizzAPI.WoW.Items.ItemStats.ItemStatType[]> reforgeIds = InitializeReforgeIds();

        private static Dictionary<int, BlizzAPI.WoW.Items.ItemStats.ItemStatType[]> InitializeReforgeIds()
        {
            var reforgeIds = new Dictionary<int, BlizzAPI.WoW.Items.ItemStats.ItemStatType[]>();
            var statTypes = new BlizzAPI.WoW.Items.ItemStats.ItemStatType[] { 
                BlizzAPI.WoW.Items.ItemStats.ItemStatType.Spirit, 
                BlizzAPI.WoW.Items.ItemStats.ItemStatType.DodgeRating, 
                BlizzAPI.WoW.Items.ItemStats.ItemStatType.ParryRating,
                BlizzAPI.WoW.Items.ItemStats.ItemStatType.HitRating,
                BlizzAPI.WoW.Items.ItemStats.ItemStatType.CritRating,
                BlizzAPI.WoW.Items.ItemStats.ItemStatType.HasteRating,
                BlizzAPI.WoW.Items.ItemStats.ItemStatType.ExpertiseRating,
                BlizzAPI.WoW.Items.ItemStats.ItemStatType.MasteryRating
            };
            var startReforgeId = 113;
            for (int i = 0; i < statTypes.Length; i++)
            {
                for (int j = 0; j < statTypes.Length; j++)
                {
                    if (i != j)
                    {
                        reforgeIds.Add(startReforgeId++, new BlizzAPI.WoW.Items.ItemStats.ItemStatType[] { statTypes[i], statTypes[j] });
                    }
                }
            }
            return reforgeIds;
        }

        [JsonProperty("gem0")]
        public int? Gem0 { get; set; }

        [JsonProperty("gem1")]
        public int? Gem1 { get; set; }

        [JsonProperty("gem2")]
        public int? Gem2 { get; set; }

        [JsonProperty("gem3")]
        public int? Gem3 { get; set; }

        [JsonProperty("enchant")]
        public int? Enchant { get; set; }

        [JsonProperty("set")]
        public List<int> Set { get; set; }

        [JsonProperty("reforge")]
        public int? Reforge { get; set; }

        [JsonProperty("upgrade")]
        public EquippedItemUpgrade Upgrade { get; set; }

        [JsonProperty("transmogrifyItemId")]
        public int? TransmogrifyItemId { get; set; }

        [JsonProperty("extraSocket")]
        public bool ExtraSocket { get; set; }

        [JsonProperty("tinker")]
        public int? Tinker { get; set; }

        /// <summary>
        /// Gets the reforged from stat
        /// </summary>
        public BlizzAPI.WoW.Items.ItemStats.ItemStatType? ReforgedFromStat
        {
            get
            {
                if (!Reforge.HasValue)
                    return null;
                return reforgeIds[Reforge.Value][0];
            }
        }

        /// <summary>
        /// Gets the reforged to stat
        /// </summary>
        public BlizzAPI.WoW.Items.ItemStats.ItemStatType? ReforgedToStat
        {
            get
            {
                if (!Reforge.HasValue)
                    return null;
                return reforgeIds[Reforge.Value][1];
            }
        }
    }
}
