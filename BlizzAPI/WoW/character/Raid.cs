using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class Raid
    {
        public string name { get; set; }
        public int normal { get; set; }
        public int heroic { get; set; }
        public int id { get; set; }
        public List<Boss> bosses { get; set; }
    }
}
