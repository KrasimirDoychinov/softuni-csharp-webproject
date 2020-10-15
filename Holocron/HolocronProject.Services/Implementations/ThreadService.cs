using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolocronProject.Services.Implementations
{
    public class ThreadService : IThreadService
    {
        private HolocronDbContext context;
        public ThreadService(HolocronDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Thread> GetThreadsByTitle(string title)
            => this.context.Threads
            .Where(x => x.Title.Contains(title))
            .OrderByDescending(x => x.CreatedOn)
            .ToList();
    }
}
