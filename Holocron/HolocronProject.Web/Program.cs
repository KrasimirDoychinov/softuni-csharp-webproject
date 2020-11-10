using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolocronProject.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using HolocronProject.Services;

namespace HolocronProject.Web
{
    // TODA = maybe TODO's
    // TODO: Don't forget about the character contest

    // TODO: Review the code each day at the beginning of the code session and at the end of the session
    // TODO: Use attributes to validate date in the Data layer
    // TODO: Add validation to the service layer
    // TODO: Completely implement AutoMapper
    // TODO: Start working on the services that will display data
    // TODO: Implement a custom login and register page
    // TODO: Implement a good voting system
    // TODO: Implement PM messages

    // USEFUL CODE
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
