﻿using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadViewModel : IMapFrom<Thread>
    {
        public string Title { get; set; }

        public string CreatedOn { get; set; }

        public int PostsCount { get; set; }
    }
}