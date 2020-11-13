using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HolocronProject.Web
{
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest

    // TODO: Review the code each day at the beginning of the code session and at the end of the session
    
    // TODO: Start working on the services that will display data
    // TODO: Implement a custom login and register page
    // TODO: Implement a good voting system
    // TODO: Implement PM messages

    // USEFUL
    // FONT AWESOME
    // var user = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
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
