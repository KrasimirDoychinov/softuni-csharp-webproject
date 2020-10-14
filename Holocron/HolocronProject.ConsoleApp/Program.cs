
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using Newtonsoft.Json;

namespace HolocronProject.ConsoleApp
{
    // TODA = maybe TODO's
    // TODO: Go over the code each day

    // TODO: Look over ForumNet's models
    // TODO: Finish implementing the automapper
    // TODO: Look over the services and maybe add something, else look over and polish the data layer

    // TODO: Fix the passowrds
    public class Program
    {
        
        static async Task Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            
            var context = new HolocronDbContext();
            
            IRaceService raceService = new RaceService();
            IServerService serverService = new ServerServices();
            IAccountService accountService = new AccountService(config);
            IBaseThreadService baseThreadService = new BaseThreadService();

            var list = accountService.SearchByMostPosts(10);

            foreach (var account in list)
            {
                System.Console.WriteLine(account.ToString());
            }



            // Code below is to create initial races and servers

            //-----Races-----
            //var jsonRaces = File.ReadAllText("../../../../HolocronProject.Services/Files/races.json");
            //var allRaces = JsonConvert.DeserializeObject<List<Race>>(jsonRaces);
            //context.Races.AddRange(allRaces);
            //context.SaveChanges();
            //-----Races-----

            //-----Server-----
            //var jsonServers = File.ReadAllText("../../../../HolocronProject.Services/Files/servers.json");
            //var allServers = JsonConvert.DeserializeObject<List<Server>>(jsonServers);
            //await context.Servers.AddRangeAsync(allServers);
            //await context.SaveChangesAsync();
            //-----Server-----

            //-----Base Threads-----
            //var jsonBaseThreads = File.ReadAllText("../../../../HolocronProject.Services/Files/baseThreads.json");
            //var allBaseThreads = JsonConvert.DeserializeObject<List<BaseThread>>(jsonBaseThreads);
            //await context.BaseThreads.AddRangeAsync(allBaseThreads);
            //await context.SaveChangesAsync();
            //-----Base Threads-----


        }
    }
}
