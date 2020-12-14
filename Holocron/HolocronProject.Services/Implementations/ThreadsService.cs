using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;
using HolocronProject.Services.Models.Threads;
using HolocronProject.Services.Mapper;
using System;

namespace HolocronProject.Services.Implementations
{
    public class ThreadsService : IThreadsService
    {
        private HolocronDbContext context;
        private readonly IPostsService postsService;

        public ThreadsService(HolocronDbContext context,
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

        public IEnumerable<T> GetAllLastThreads<T>()
            => this.context.Threads
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetLastThreadsByAccountId<T>(string accountId)
            => this.context.Threads
            .Where(x => x.AccountId == accountId && !x.IsDeleted)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>()
            .ToList();

        public T GetThreadsById<T>(string threadId)
            => this.context.Threads
            .Where(x => x.Id == threadId && !x.IsDeleted)
            .To<T>()
            .FirstOrDefault();

        public int TotalThreads()
            => this.context.Threads
            .Where(x => !x.IsDeleted)
            .Count();

       
    }
}
