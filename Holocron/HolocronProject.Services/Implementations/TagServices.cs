using System;
using System.Linq;
using System.Threading.Tasks;
using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class TagServices : ITagService
    {
        private HolocronDbContext context;

        public TagServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateTagAsync(string name)
        {
            var tag = new Tag
            {
                Name = name
            };

            await this.context.Tags.AddAsync(tag);
            await this.context.SaveChangesAsync();
        }
    }
}
