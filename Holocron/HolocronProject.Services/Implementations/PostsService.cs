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

        public IEnumerable<T> GetLast10PostsByAccountId<T>(string accountId)
            => this.context.Posts
            .Where(x => x.AccountId == accountId)
            .OrderByDescending(x => x.CreatedOn)
            .Take(10)
            .To<T>()
            .ToList();
    }
}
