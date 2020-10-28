
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using Newtonsoft.Json;

namespace HolocronProject.ConsoleApp
{
    // TODA = maybe TODO's
    // TODO: Go over the code each day
    // TODO: Don't forget about the character contest
    
    // TODO: Add view models to the services
    
    // TODO: Add DTO's to all the service implementations

    // TODO: Add more services for checking availability of certain things. Make it more clean and add more services.
    // TODO: Look over ForumNet's models
    // TODO: Finish implementing the automapper
    // TODO: Look over the services and maybe add something, else look over and polish the data layer

    public class Program
    {
        
        static async Task Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });


            var context = new HolocronDbContext();

            IClassService classService = new ClassService(context);
            ICharacterService characterService = new CharacterService(config, context);
            IRaceService raceService = new RaceService(context);
            IServerService serverService = new ServerServices(context);
            IBaseThreadService baseThreadService = new BaseThreadService(context);
            IAccountService accountService = new AccountService(config, classService, raceService, serverService, characterService, context);

            await accountService.CreateAccount("detha", "Krasitoobrat4545", "Detha");
            //await accountService.CreateCharacter("detha", "TestCharcho", 1, 1, 1, "Operative", "Human", "Darth Malgus", 1, "none", "none", "none");

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

            //-----Classes-----
            //var jsonClasses = File.ReadAllText("../../../../HolocronProject.Services/Files/classes.json");
            //var allClasses = JsonConvert.DeserializeObject<List<Class>>(jsonClasses);
            //await context.Classes.AddRangeAsync(allClasses);
            //await context.SaveChangesAsync();
            //-----Classes-----

        }
    }
}
