using System;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Services;

namespace HolocronProject.ConsoleApp
{
    // Look over all the classes again
    // Add LastPostName in the UI
    //    public string LastPostName
    //{
    //    get
    //    {
    //        return this.Threads
    //            .Select(x => x.Posts
    //            .OrderByDescending(y => y.CreatedOn)
    //            .First().Title)
    //            .First();
    //    }
    //}
    // Add LastPostName in the UI

    // TODO: TODA = maybe TODO's
    // TODO: Go over the code each day
    // TODO: Fix the service methods, make them cleaner
    // TODO: Add more services
    // TODO: Code some DTO's


    // TODO: Fix the passowrds
    class Program
    {
        
        
        static async Task Main(string[] args)
        {
            var context = new HolocronDbContext();

            IRaceService raceService = new RaceService();
            IServerService serverService = new ServerServices();
            IAccountService accountService = new AccountService();
            IBaseThreadService baseThreadService = new BaseThreadService();

            // Code below is for debugging purposes
            //await raceService.CreateAllCurrentRaces();
            //await serverService.CreateAllServers();
            //await baseThreadService.CreateAllBaseThreads();


            //await accountService.Create("deth45", "krasy4545", "Deth");
            //await accountService.CreateCharacter("deth45", "Kelmala", 1, 1, 1, "Sniper", "Human", "Darth Malgus", 2);
            //await accountService.CreateThread("deth45", "Guides for inquisitor", "Guides");
            //await accountService.CreatePost("deth45", "So this is going to be my first post", "Guides for inquisitor");


            var account = accountService.ForeignAccount("Deth");
            if (account == null)
            {
                Console.WriteLine("No account found!");
            }
            else
            {
                Console.WriteLine(account.ToString());
            }


            //var accounts = accountService.SearchByMostPosts(10);

            //foreach (var account in accounts)
            //{
            //    Console.WriteLine(account.ToString());
            //    Console.WriteLine(new string('-', 30));
            //}
        }
    }
}
