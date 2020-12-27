﻿using System;

using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.PostReports
{
    public class PostReportListViewModel : IMapFrom<PostReport>
    {
        public string Id { get; set; }

        public string AccountUserName { get; set; }

        public string Title { get; set; }

        public string ShortTitle => this.Title.Length <= 50 ? this.Title : this.Title.Substring(0, 50) + "...";

        public DateTime CreatedOn { get; set; }

        public DateTime ResolvedOn { get; set; }

        public string Description { get; set; }

        public string ShortDescription => this.Description.Length > 65 ? this.Description.Substring(0, 65) + "..." : this.Description;

        public bool IsResolved { get; set; }

        public string IsResolvedString => this.IsResolved == true ? "RESOLVED" : "PENDING";

        public Pager.Pager Pager { get; set; }
    }
}
