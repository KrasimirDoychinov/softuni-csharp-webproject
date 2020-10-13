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

        // Admin class
        public async Task CreateNewBaseThread(string title)
        {
            var baseThread = context.BaseThreads.FirstOrDefault(x => x.Title == title);
            baseThread = new BaseThread(title);

            await context.BaseThreads.AddAsync(baseThread);
            await context.SaveChangesAsync();
        }
        
    }
}
