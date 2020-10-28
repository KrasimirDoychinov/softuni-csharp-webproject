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

        public BaseThreadService(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateNewBaseThread(string title)
        {
            var baseThread = new BaseThread
            {
                Title = title
            };

            await this.context.BaseThreads.AddAsync(baseThread);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteBaseThread(string baseThreadId)
        {
            var baseThread = this.context.BaseThreads
                .FirstOrDefault(x => x.Id == baseThreadId);

            baseThread.IsDeleted = true;

            this.context.BaseThreads.Update(baseThread);
            await this.context.SaveChangesAsync();
        }
    }
}
