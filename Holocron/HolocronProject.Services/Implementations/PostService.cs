using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class PostService : IPostService
    {
        private HolocronDbContext context;

        public PostService(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreatePost(string description, string accountId, string threadId)
        {
            var post = new Post
            {
                Description = description,
                AccountId = accountId,
                ThreadId = threadId
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();
        } 
    }
}
