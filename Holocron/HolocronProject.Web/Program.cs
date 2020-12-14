using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HolocronProject.Web
{
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest

    // TODO: Review the code each day at the beginning of the code session and at the end of the session

    // TODO: Show all date time in local timezone
    // TODO: Look over every single service and controller and fix anything that is wrong
    // TODO: Look over all the views as well
    // TODO: Add stats view
    // TODO: !!!Add signalR timer!!!

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
