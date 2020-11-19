﻿using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;
using HolocronProject.Services.Models.Threads;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services.Implementations
{
    public class ThreadServices : IThreadService
    {
        private HolocronDbContext context;

        public ThreadServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateThreadAsync(ThreadInputDto input)
        {
            var thread = new Thread()
            {
                Title = input.Title,
                AccountId = input.AccountId,
                BaseThreadId = input.BaseThreadId,
                Description = input.Description
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.SaveChangesAsync();
        }

        public T GetThreadById<T>(string threadId)
            => this.context.Threads
            .Where(x => x.Id == threadId)
            .To<T>()
            .FirstOrDefault();
    }
}
