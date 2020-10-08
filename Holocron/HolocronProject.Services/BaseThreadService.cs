using System;
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

        public async Task Create(string title)
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
