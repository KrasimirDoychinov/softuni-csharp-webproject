using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;
using HolocronProject.Services.Models.Threads;
using HolocronProject.Services.Mapper;
using System;
using AutoMapper;

namespace HolocronProject.Services.Implementations
{
    public class ThreadsService : IThreadsService
    {
        private ApplicationDbContext context;
        private readonly IPostsService postsService;

        public ThreadsService(ApplicationDbContext context,
            IPostsService postsService)
        {
            this.context = context;
            this.postsService = postsService;
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

        public async Task DeleteThreadAsync(string threadId)
        {
            var thread = this.context.Threads.FirstOrDefault(x => x.Id == threadId);

            thread.IsDeleted = true;
            thread.DeletedOn = DateTime.UtcNow;

            foreach (var post in thread.Posts)
            {
                await this.postsService.DeletePostAsync(post.Id);
            }

            await this.context.SaveChangesAsync();
        }

        public async Task EditThreadAsync(string threadId, string description, string title)
        {
            var thread = this.context.Threads.FirstOrDefault(x => x.Id == threadId);

            thread.Description = description;
            thread.Title = title;

            await this.context.SaveChangesAsync();

        }

        public int TotalNotDeletedThreads()
           => this.context.Threads
           .Where(x => !x.IsDeleted)
           .Count();

        public IEnumerable<T> GetAllNotDeletedThreads<T>(IMapper mapper = null)
            => this.context.Threads
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetLastNotDeletedThreadsByAccountId<T>(string accountId, IMapper mapper = null)
            => this.context.Threads
            .Where(x => x.AccountId == accountId && !x.IsDeleted)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public T GetThreadById<T>(string threadId, IMapper mapper = null)
            => this.context.Threads
            .Where(x => x.Id == threadId && !x.IsDeleted)
            .To<T>(mapper)
            .FirstOrDefault();

        public async Task DeleteAllThreadsByAccountId(string accountId)
        {
            var threads = this.context.Threads
                .Where(x => x.AccountId == accountId)
                .ToList();

            threads.AsParallel().ForAll(x => x.IsDeleted = true);
            threads.AsParallel().ForAll(x => x.DeletedOn = DateTime.UtcNow);

            await this.context.SaveChangesAsync();
        }
    }
}
