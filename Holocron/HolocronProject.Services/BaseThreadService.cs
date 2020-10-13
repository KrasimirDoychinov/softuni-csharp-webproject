using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public class BaseThreadService : IBaseThreadService
    {
        private HolocronDbContext context;

        public BaseThreadService()
        {
            context = new HolocronDbContext();
        }

        // Admin classes
        // TODO: Add more base threads
        public async Task CreateAllCurrentBaseThreads()
        {
            var currentBaseThreads = new List<BaseThread>();

            var pvp = new BaseThread("Pvp");
            var pve = new BaseThread("Pve");
            var rp = new BaseThread("Rp");
            var guides = new BaseThread("Guides");
            var fashion = new BaseThread("Fashion");

            currentBaseThreads.Add(pvp);
            currentBaseThreads.Add(pve);
            currentBaseThreads.Add(rp);
            currentBaseThreads.Add(guides);
            currentBaseThreads.Add(fashion);

            await context.AddRangeAsync(currentBaseThreads);
            await context.SaveChangesAsync();
        }

        public async Task CreateNewBaseThread(string title)
        {
            var baseThread = context.BaseThreads.FirstOrDefault(x => x.Title == title);
            baseThread = new BaseThread(title);

            await context.BaseThreads.AddAsync(baseThread);
            await context.SaveChangesAsync();
        }
        
    }
}
