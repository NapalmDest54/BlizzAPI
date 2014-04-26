using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW.character
{
    public class Title
    {
        private string name;

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.Replace("%s", "").Trim();
            }
        }

        [JsonProperty("selected")]
        public bool IsSelected { get; set; }

    }
}
