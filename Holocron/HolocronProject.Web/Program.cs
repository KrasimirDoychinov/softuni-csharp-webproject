using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HolocronProject.Web
{
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest

    // TODO: Review the code each day at the beginning of the code session and at the end of the session

    // TODO: !!!Add competitions and achievements!!!
    // TODO: Add stats view
    // TODO: Fix all the User views and Admin views to look better
    // TODO: !!!Tmmrw look over the admin panel and see if there is something to be added!!!
    // TODO: Look over all the services and controllers and see if u can fix syntax problems in the code 
    // TODO: Make a js script that opens the edit menu for the forum signature

    // -----USEFUL-----
    // DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
    // class="container"
    // style="background-color: #1a1818;
    // font awesome
    // var user = this.Account.FindFirstValue(ClaimTypes.NameIdentifier);
    // .AsParallel().ForAll() -- applies to every single element inside the array
    // -----USEFUL-----
    public class Program
    { 
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }                                                                                    

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
