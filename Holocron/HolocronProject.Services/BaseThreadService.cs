
using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public class BaseThreadService : IBaseThreadService
    {
        private HolocronDbContext context;
        public BaseThreadService()
        {
            context = new HolocronDbContext();
        }

        public async Task Create(string title)
        {
            var baseThread = new BaseThread
            {
                Title = title
            };

            context.BaseThreads.Add(baseThread);

            await context.SaveChangesAsync();
        }
    }
}
