﻿using System;

using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Posts;

namespace HolocronProject.Web.ViewModels.PostReports
{
    public class PostReportViewModel : IMapFrom<PostReport>
    {
        public string Id { get; set; }

        public string AccountUserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public PostViewModel Post { get; set; }
    }
}
