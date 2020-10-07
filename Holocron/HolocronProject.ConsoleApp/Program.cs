using HolocronProject.Data;
using HolocronProject.Data.Models;
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

    class Program
    {
        static async Task Main(string[] args)
        {
            var context = new HolocronDbContext();

            context.Database.EnsureDeleted();
        }
    }
}
