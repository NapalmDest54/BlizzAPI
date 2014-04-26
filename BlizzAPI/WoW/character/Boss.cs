using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class Boss
    {
        public int id { get; set; }
        public string name { get; set; }
        public int normalKills { get; set; }
        public object normalTimestamp { get; set; }
        public int? heroicKills { get; set; }
        public long? heroicTimestamp { get; set; }
        public int? lfrKills { get; set; }
        public long? lfrTimestamp { get; set; }
        public int? flexKills { get; set; }
        public long? flexTimestamp { get; set; }
    }
}
