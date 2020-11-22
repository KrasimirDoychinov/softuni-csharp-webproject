using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadViewModel : IMapFrom<Thread>
    {
        public string Id { get; set; }

        public string AccountId { get; set; }

        public string AccountUserName { get; set; }

        public string AccountAvatarImagePath { get; set; }

        public string Title { get; set; }

        public string CreatedOn { get; set; }

        public int PostsCount { get; set; }

        public string Description { get; set; }


        public string RandomImageQuery { get; set; }

        public IEnumerable<PostViewModel> Posts { get; set; }

    }
}
