using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HolocronProject.Web
{
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest

    // TODO: Review the code each day at the beginning of the code session and at the end of the session

    // TODO: !!!Look over all the views and see if I missed anything!!!
    // TODO: !!!Look over all the tests and fix small bugs and try to add edge cases!!
    // TODO: Look over all controllers and views

    // -----USEFUL-----
    //var config = new MapperConfiguration(opts =>
    //{
    //    opts.CreateMap<Account, ForeignAccountViewModel>();
    //});
    //var mapper = config.CreateMapper(); 

    // Use this mapper to instantiate your class
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
