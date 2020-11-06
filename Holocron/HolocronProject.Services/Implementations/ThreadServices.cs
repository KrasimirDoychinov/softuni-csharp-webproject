using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class ThreadServices : IThreadService
    {
        private HolocronDbContext context;
        public ThreadServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateThreadAsync(string title, string baseThreadId, string accountId)
        {
            var thread = new Thread
            {
                Title = title,
                BaseThreadId = baseThreadId,
                AccountId = accountId
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.SaveChangesAsync();
        }
    }
}
