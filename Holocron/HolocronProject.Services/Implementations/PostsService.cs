using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;
using HolocronProject.Services.Models.Posts;
using HolocronProject.Services.Mapper;
using System;
using AutoMapper;

namespace HolocronProject.Services.Implementations
{
    public class PostsService : IPostsService
    {
        private ApplicationDbContext context;

        public PostsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreatePostAsync(string description, string threadId, string accountId)
        {
            var post = new Post
            {
                AccountId = accountId,
                ThreadId = threadId,
                Description = description
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();
        }

        public async Task DeletePostAsync(string postId)
        {
            var post = this.context.Posts
                .FirstOrDefault(x => x.Id ==postId);

            post.IsDeleted = true;
            post.DeletedOn = DateTime.UtcNow;

            await this.context.SaveChangesAsync();
        }

        public async Task EditPostByIdAsync(string postId, string description)
        {
            var post = this.context.Posts.FirstOrDefault(x => x.Id == postId);

            post.Description = description;

            this.context.Posts.Update(post);
            await this.context.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllNotDeletedPosts<T>(IMapper mapper = null)
            => this.context.Posts
            .OrderByDescending(x => x.CreatedOn)
            .Where(x => !x.IsDeleted)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetLastNotDeletedPostsByAccountId<T>(string accountId, IMapper mapper = null)
            => this.context.Posts
            .Where(x => x.AccountId == accountId && !x.IsDeleted)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public T GetNotDeletedPostById<T>(string postId, IMapper mapper = null)
            => this.context.Posts
            .Where(x => x.Id == postId && !x.IsDeleted)
            .To<T>(mapper)
            .FirstOrDefault();

        public int TotalNotDeletedPosts()
            => this.context.Posts
            .Where(x => !x.IsDeleted)
            .Count();

        public int TotalNotDeletedPostInThread(string threadId)
            => this.context.Posts
            .Where(x => x.ThreadId == threadId && !x.IsDeleted)
            .Count();

    }
}
