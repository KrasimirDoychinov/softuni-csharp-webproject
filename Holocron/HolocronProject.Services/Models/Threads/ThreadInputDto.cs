using HolocronProject.Services.Mapper;
using HolocronProject.Services.Models.Posts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HolocronProject.Services.Models.Threads
{
    public class ThreadInputDto
    {
        public string Title { get; set; }

        public string BaseThreadId { get; set; }

        public string AccountId { get; set; }

        public string Description { get; set; }

    }
}
