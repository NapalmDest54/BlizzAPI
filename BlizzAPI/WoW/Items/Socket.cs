using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI.WoW.Items
{
    public class Socket
    {
        [JsonProperty("type")]
        public SocketType Type { get; set; }

    }
}
