using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlizzAPI
{
    public class Region
    {
        public enum Regions
        {
            US,
            EUROPE,
            KOREA,
            TAIWAN,
            CHINA
        }


        private static Dictionary<Regions, String> hostLookup = new Dictionary<Regions, string>
        {
            {Regions.US, "us.battle.net/"},
            {Regions.EUROPE, "eu.battle.net/"},
            {Regions.KOREA, "kr.battle.net/"},  
            {Regions.TAIWAN, "tw.battle.net/"},
            {Regions.CHINA, "www.battlenet.com.cn/"}
        };

        private Regions region;

        public Region(Regions region)
        {
            this.region = region;
        }

        public String getHost()
        {
            String host = "";
            if (!hostLookup.TryGetValue(region, out host))
            {
                throw new Exception("Host for Region not found: " + region);
            }
            return host;
        }

        public String getLocal(String region)
        {
            return "";
        }
    }
}
