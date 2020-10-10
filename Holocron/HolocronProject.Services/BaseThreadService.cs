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

            var pvp = new BaseThread
            {
                Title = "Pvp"
            };

            var pve = new BaseThread
            {
                Title = "Pve"
            };

            var rp = new BaseThread
            {
                Title = "Rp"
            };

            var guides = new BaseThread
            {
                Title = "Guides"
            };

            var fashion = new BaseThread
            {
                Title = "Fashion"
            };

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
            if (baseThread != null)
            {
                Console.WriteLine("The base thread already exists!");
                return;
            }

            baseThread = new BaseThread
            {
                Title = title
            };

            context.BaseThreads.Add(baseThread);

            await context.SaveChangesAsync();
        }

        
    }
}
