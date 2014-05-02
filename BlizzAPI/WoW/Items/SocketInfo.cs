using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.Items
{
    public class SocketInfo
    {
        [JsonProperty("socketBonus")]
        public string SocketBonus { get; set; }

        [JsonProperty("sockets")]
        public List<Socket> Sockets { get; set; }

    }
}
