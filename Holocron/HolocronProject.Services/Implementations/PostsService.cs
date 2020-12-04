using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;
using HolocronProject.Services.Models.Posts;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services.Implementations
{
    public class PostsService : IPostsService
    {
        private HolocronDbContext context;

        public PostsService(HolocronDbContext context)
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

        public async Task EditPostById(string postId, string description)
        {
            var post = this.context.Posts.FirstOrDefault(x => x.Id == postId);

            post.Description = description;

            this.context.Posts.Update(post);
            await this.context.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllLastPosts<T>()
            => this.context.Posts
            .OrderByDescending(x => x.CreatedOn)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetLastPostsByAccountId<T>(string accountId)
            => this.context.Posts
            .Where(x => x.AccountId == accountId)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>()
            .ToList();

        public T GetPostById<T>(string postId)
            => this.context.Posts
            .Where(x => x.Id == postId)
            .To<T>()
            .FirstOrDefault();

        public int TotalPosts()
            => this.context.Posts
            .Count();

    }
}
