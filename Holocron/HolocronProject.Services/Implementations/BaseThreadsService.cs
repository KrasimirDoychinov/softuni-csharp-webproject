using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services.Implementations
{
    public class BaseThreadsService : IBaseThreadsService
    {
        private HolocronDbContext context;

        public BaseThreadsService(HolocronDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>()
            =>this.context.BaseThreads
            .OrderBy(x => x.Title)
            .To<T>() 
            .ToList();

        public T GetById<T>(string id)
            => this.context.BaseThreads
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
    }
}
