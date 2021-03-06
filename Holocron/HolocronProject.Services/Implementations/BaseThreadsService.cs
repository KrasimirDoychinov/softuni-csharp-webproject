﻿using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using HolocronProject.Data;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services.Implementations
{
    public class BaseThreadsService : IBaseThreadsService
    {
        private ApplicationDbContext context;

        public BaseThreadsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>(IMapper mapper = null)
            => this.context.BaseThreads
            .OrderBy(x => x.Title)
            .To<T>(mapper) 
            .ToList();

        public T GetById<T>(string id, IMapper mapper)
            => this.context.BaseThreads
                .Where(x => x.Id == id)
                .To<T>(mapper)
                .FirstOrDefault();
    }
}
