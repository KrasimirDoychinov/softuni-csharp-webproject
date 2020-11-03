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
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest
    
    // TODO: Review the code each day at the beginning of the code session and at the end of the session
    // TODO: For tmmrw - Look into how to make a PM style of messaging service

    public class Program
    {
        
        static async Task Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });


            var context = new HolocronDbContext();

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            IClassService classService = new ClassService(context);

            ICharacterService characterService = new CharacterService(context);

            IRaceService raceService = new RaceService(context);

            IServerService serverService = new ServerServices(context);
            IBaseThreadService baseThreadService = new BaseThreadService(context);

            IAccountService accountService = new AccountService(context);

            IAchievementService achievementService = new AchievementService(context);
            ICompetitionService competitionService = new CompetitionService(context, achievementService);

            //await accountService.CreateAccount("deth45", "1234", "dasda");

            //await accountService.UpdateForumSignature("2804dc2d-539b-41ec-836c-8f4572428c54", "Test");

            //var account = accountService.GetAccountById("2804dc2d-539b-41ec-836c-8f4572428c54");
       }
    }
}
