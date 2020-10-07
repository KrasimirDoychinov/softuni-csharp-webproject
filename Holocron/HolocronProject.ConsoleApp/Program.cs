using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            IBaseThreadService baseThreadService = new BaseThreadService();

            await baseThreadService.Create("PVP");
        }
    }
}
