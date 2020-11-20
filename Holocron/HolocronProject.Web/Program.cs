using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HolocronProject.Web
{
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest

    // TODO: Review the code each day at the beginning of the code session and at the end of the session

    // TODO: Fix the DateTime make another column to the BaseModel (NormalizedCreatedOn)
    // TODO: Move logic from controllers to services
    // TODO: Add some default avatars that can be picked
    // TODO: See how to make good posts and replies
    // TODO: Finish the threads and posts
    // TODO: !!!Fix the input models!!!
    // TODO: Do all views that are connected to the Account model
    // TODO: Fix the ViewModel attributes
    // TODO: Start working on the services that will display data
    // TODO: Implement a custom login page
    // TODO: Implement a good voting system
    // TODO: Implement PM messages

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
