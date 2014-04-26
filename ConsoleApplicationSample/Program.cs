using BlizzAPI;
using BlizzAPI.WoW;
using BlizzAPI.WoW.character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            WoWClient client = new WoWClient(new Region(Region.Regions.US));
            Task<Character> characterAsync = client.getCharacter("area-52", "napalmuid");
            characterAsync.Wait();
            Character character = characterAsync.Result;
            String characterString = character.toString();


            System.IO.StreamWriter file = new System.IO.StreamWriter("./printOut.txt");
            file.WriteLine(character.toString());
            file.Flush();
            file.Close();

            System.Console.WriteLine("Press any button to continue...");
            System.Console.ReadKey();
        }


    }
}
