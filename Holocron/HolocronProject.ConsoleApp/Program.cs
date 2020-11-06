using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    

    public class Program
    {
        
        static async Task Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                
            });


            var context = new HolocronDbContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            IClassService classService = new ClassServices(context);

            ICharacterService characterService = new CharacterServices(context);

            IRaceService raceService = new RaceServices(context);

            IServerService serverService = new ServerServices(context);
            IBaseThreadService baseThreadService = new BaseThreadServices(context);

            IAccountService accountService = new AccountServices(context);

            IAchievementService achievementService = new AchievementServices(context);
            ICompetitionService competitionService = new CompetitionServices(context, achievementService);

            IBugReportService bugReportService = new BugReportServices(context);

            //await accountService.CreateAccount("deth45", "1234", "dasda");

            //var id = context.Accounts
            //    .Select(x => x.Id)
            //    .FirstOrDefault();
            //await bugReportService.CreateBugReport(id, "Test", "Desc");
       }
    }
}
