
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using Newtonsoft.Json;

namespace HolocronProject.ConsoleApp
{
    // TODA = maybe TODO's
    // TODO: Go over the code each day

    // TODO: Look over the services and maybe add something, else look over and polish the data layer

    // TODO: Fix the passowrds
    public class Program
    {
        
        static async Task Main(string[] args)
        {
            var context = new HolocronDbContext();

            IRaceService raceService = new RaceService();
            IServerService serverService = new ServerServices();
            IAccountService accountService = new AccountService();
            IBaseThreadService baseThreadService = new BaseThreadService();
            
            // Code below is for debugging purposes
            await raceService.CreateAllCurrentRaces();
            var races = CreateAllRaces();
            var json = JsonConvert.SerializeObject(races, Formatting.Indented);
            
            File.WriteAllText("../../../../HolocronProject.Services/Files/races.json", json);

            var allRaces = JsonConvert.DeserializeObject<List<Race>>(json);
            await context.Races.AddRangeAsync(allRaces);

            //await serverService.CreateAllServers();
            //await baseThreadService.CreateAllBaseThreads();


            //await accountService.Create("detasdasd", "Krasy4545", "Dethaasdasdasd");
            //await accountService.CreateCharacter("deth45", "ASdasdasd", 1, 1, 1, "Sniper", "Human", "Darth Malgus", 2);
            //await accountService.CreateThread("deth45", "Guides for inquisitor", "Guides");
            //await accountService.CreatePost("deth45", "So this is going to be my first post", "Guides for inquisitor");


            //var account = accountService.ForeignAccount("Deth");
            //if (account == null)
            //{
            //    Console.WriteLine("No account found!");
            //}
            //else
            //{
            //    Console.WriteLine(account.ToString());
            //}


            //var accounts = accountService.SearchByMostPosts(10);

            //foreach (var account in accounts)
            //{
            //    Console.WriteLine(account.ToString());
            //    Console.WriteLine(new string('-', 30));
            //}
        }

        public static List<Race> CreateAllRaces()
        {
            var currentRaces = new List<Race>();

            var chiss = new Race("Chiss",1);
            var cyborg = new Race("Cyborg",2);
            var human = new Race("Human",3);
            var miraluka = new Race("Miraluka",4);
            var mirialan = new Race("Mirialan",5);
            var rattataki = new Race("Rattaki",6);
            var sithPureblood = new Race("Sith Pureblood",7);
            var twilek = new Race("Twi'lek",8);
            var zabrak = new Race("Zabrak",9);
            var cathar = new Race("Cathar",10);
            var togruta = new Race("Togruta",11);
            var nautolan = new Race("Nautolan",12);

            currentRaces.Add(chiss);
            currentRaces.Add(cyborg);
            currentRaces.Add(human);
            currentRaces.Add(miraluka);
            currentRaces.Add(mirialan);
            currentRaces.Add(rattataki);
            currentRaces.Add(sithPureblood);
            currentRaces.Add(twilek);
            currentRaces.Add(zabrak);
            currentRaces.Add(cathar);
            currentRaces.Add(togruta);
            currentRaces.Add(nautolan);

            return currentRaces;
        }
    }
}
