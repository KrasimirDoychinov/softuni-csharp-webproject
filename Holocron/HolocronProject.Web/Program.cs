using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HolocronProject.Web
{
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest

    // TODO: Review the code each day at the beginning of the code session and at the end of the session

    // TODO: Fix the voting system
    // TODO: Add foreign account view
    // TODO: Make a js script that opens the edit menu for the forum signature
    // TODO: !!!Fix the input models!!!
    // TODO: Move logic from controllers to services
    // TODO: Add some default avatars that can be picked
    // TODO: See how to make good posts and replies
    // TODO: Finish the threads and posts

    // -----USEFUL-----
    // class="container"
    // style="background-color: #1a1818;
    // font awesome
    // var user = this.Account.FindFirstValue(ClaimTypes.NameIdentifier);
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
