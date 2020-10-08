using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Services;
namespace HolocronProject.ConsoleApp
{
    // TODO: Look over all the classes again
    // TODO: Add LastPostName in the UI
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
    // TODO: Add LastPostName in the UI


    // TODO: Add light/dark side for chars
    // TODO: Short backstory if the player wants
    // TODO: Add new model: GUILDS
    // TODO: Think more about the tables that you'll need

    class Program
    {
        
        static async Task Main(string[] args)
        {
            var context = new HolocronDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //IAccountService accountService = new AccountService();
            //IBaseThreadService baseThreadService = new BaseThreadService();

            //await baseThreadService.Create("PVP");
            //await accountService.Create("deth45", "krasitoobrat4545", "Deth");
            //await accountService.CreateThread("deth45", "Tips for PVP", "PVP");
            //await accountService.CreatePost("deh45", "First post for tips for PVP", "Tips for PVP");




        }
    }
}
