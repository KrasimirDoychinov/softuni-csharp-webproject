using System;
using System.Linq;

using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class TagService : ITagService
    {
        private HolocronDbContext context;

        public TagService(HolocronDbContext context)
        {
            this.context = context;
        }

        public Tag GetTagByName(string tagName)
            => this.context.Tags.FirstOrDefault(x => x.Name == tagName);

        public bool IsTagNameTaken(string tagName)
        {
            return this.context.Tags
                .Any(x => x.Name == tagName);
        }
    }
}
