using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;
using HolocronProject.Services.Models.Posts;

namespace HolocronProject.Services.Implementations
{
    public class PostServices : IPostService
    {
        private HolocronDbContext context;

        public PostServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreatePostAsync(PostInputDto input)
        {
            var post = new Post
            {
                AccountId = input.AccountId,
                ThreadId = input.ThreadId,
                Description = input.Description
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();
        } 
    }
}
