using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class BaseThreadServices : IBaseThreadService
    {
        private HolocronDbContext context;

        public BaseThreadServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateBaseThreadAsync(string title)
        {
            var baseThread = new BaseThread
            {
                Title = title
            };

            await this.context.BaseThreads.AddAsync(baseThread);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteBaseThreadByIdAsync(string baseThreadId)
        {
            var baseThread = GetBaseThreadById(baseThreadId);

            baseThread.IsDeleted = true;

            this.context.BaseThreads.Update(baseThread);
            await this.context.SaveChangesAsync();
        }

        public BaseThread GetBaseThreadById(string baseThreadId)
            => this.context.BaseThreads
                .FirstOrDefault(x => x.Id == baseThreadId);
    }
}
