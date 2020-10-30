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
    // TODO: Don't forget about the character contest
    
    // TODO: Review the code each day at the beginning of the code session and at the end of the session
    // TODO: For tmmrw - finish up the services and start adding more "search like" methods to the services

    public class Program
    {
        
        static async Task Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });


            var context = new HolocronDbContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            IClassService classService = new ClassService(context);
            ICharacterService characterService = new CharacterService(context);
            IRaceService raceService = new RaceService(context);
            IServerService serverService = new ServerServices(context);
            IBaseThreadService baseThreadService = new BaseThreadService(context);
            IAccountService accountService = new AccountService(config, context);

            //await accountService.CreateAccount("detha", "Krasitoobrat4545", "Detha");
            //await accountService.CreateCharacter();

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
