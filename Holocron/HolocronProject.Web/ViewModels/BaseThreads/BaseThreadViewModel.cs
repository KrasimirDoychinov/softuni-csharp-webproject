using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Threads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.BaseThreads
{
    public class BaseThreadViewModel : IMapFrom<BaseThread>
    {

        public string Id { get; set; }

        public string Title { get; set; }

        public int ThreadsCount { get; set; }

        public int ThreadsPostsCount { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
        
        public ICollection<ThreadViewModel> Threads { get; set; }

        
    }
}
