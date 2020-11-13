using HolocronProject.Services.Mapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadInputModel 
    {
        public string Title { get; set; }

        public string BaseThreadId { get; set; }

        public string AccountId { get; set; }

        public int PostsCount { get; set; }
    }
}
