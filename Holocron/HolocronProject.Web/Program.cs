using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolocronProject.Data;
using HolocronProject.Web.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HolocronProject.Web
{
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest

    // TODO: Review the code each day at the beginning of the code session and at the end of the session
    // TODO: Fix the tests to work with ASP.NET
    // TODO: Fix account entity to work with the default Asp.Net User entity
    // TODO: Clean up the DB
    // TODO: Start working on the services that will display data
    // TODO: Work with Razor
    // TODO: Implement a good voting system
    // TODO: Implement PM messages

    public class Program
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            var test = new Test();

=======
            var context = new HolocronDbContext();
>>>>>>> parent of 5d42286... Did some view model testing
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
