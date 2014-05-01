using BlizzAPI.WoW.character;
using BlizzAPI.WoW.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlizzAPI.WoW
{
    public class WoWClient
    {
        private const string WOW_API = "api/wow/";
        private string baseApiUrl = "";
        private Region region;


        public WoWClient(Region region)
        {
            this.region = region;
            baseApiUrl = region.getHost() + WOW_API;
        }

        public String getBaseApiUrl()
        {
            return baseApiUrl;
        }

        public async Task<Character> getCharacter(String realm, String characterName)
        {
            return await getCharacter(realm, characterName, CharacterFields.Fields.All);
        }

        public async Task<Character> getCharacter(String realm, String characterName, params CharacterFields.Fields[] fields)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("http://");
            sb.Append(baseApiUrl);
            sb.Append("character/");
            sb.Append(realm);
            sb.Append("/");
            sb.Append(characterName);
            sb.Append("?fields=");
            StringBuilder sbFields = new StringBuilder();
            foreach (CharacterFields.Fields field in fields)
            {
                if (field == CharacterFields.Fields.All)
                {
                    sbFields.Clear();
                    foreach (String strField in CharacterFields.fieldStrings.Values)
                    {
                        sbFields.Append(strField);
                        sbFields.Append(",");
                    }
                    break;
                }

                String outFieldString = "";
                if (CharacterFields.fieldStrings.TryGetValue(field, out outFieldString))
                {
                    sbFields.Append(outFieldString);
                    sbFields.Append(",");
                }

            }
            sb.Append(sbFields.ToString());
            String json = "";
            try
            {
                json = await new HttpClient().GetStringAsync(sb.ToString());
            }
            catch (Exception)
            {
                throw new Exception("Error Connecting With Battle.net with Address: " + sb.ToString());
            }
            Character characterLoaded = JsonConvert.DeserializeObject<Character>(json);
            return characterLoaded;
        }

        public async Task<Item> getItem(int itemID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("http://");
            sb.Append(baseApiUrl);
            sb.Append("item/");
            sb.Append(itemID.ToString());

            String json = "";
            try
            {
                json = await new HttpClient().GetStringAsync(sb.ToString());
            }
            catch (Exception)
            {
                throw new Exception("Error Connecting With Battle.net with Address: " + sb.ToString());
            }

            Item itemLoaded = JsonConvert.DeserializeObject<Item>(json);
            return itemLoaded;

        }


    }
}
