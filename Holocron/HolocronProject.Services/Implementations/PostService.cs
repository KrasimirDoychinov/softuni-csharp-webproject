using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class PostService : IPostService
    {
        private HolocronDbContext context;
        public PostService(HolocronDbContext context)
        {
            this.context = context;
        }

        // TODO: Dto's
        public IEnumerable<Post> GetPostByDescription(string description)
            => this.context.Posts
            .Where(x => x.Description.Contains(description))
            .OrderByDescending(x => x.CreatedOn)
            .ToList();

        
            
    }
}
