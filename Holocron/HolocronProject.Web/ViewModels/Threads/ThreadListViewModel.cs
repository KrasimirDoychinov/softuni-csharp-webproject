using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadListViewModel : IMapFrom<Thread>
    {
        public string Id { get; set; }

        public string AccountUserName { get; set; }

        public string Title { get; set; }

        public string ShortenedTitle => this.Title.Length <= 50 ? this.Title : this.Title.Substring(0, 50) + "...";

        public DateTime CreatedOn { get; set; }

        public string NormalizedCreatedOn { get; set; }

        public int PostsCount { get; set; }

        public IEnumerable<PostCountViewModel> Posts { get; set; }

        public int VotesCount { get; set; }

        public bool IsDeleted { get; set; }
    }
}
