using System;

using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.BugReports
{
    public class BugReportListViewModel : BugReportViewModel, IMapFrom<BugReport>
    {
        public string ShortTitle => this.Title.Length <= 50 ? this.Title : this.Title.Substring(0, 50) + "...";

        public DateTime ResolvedOn { get; set; }

        public string ShortDescription => this.Description.Length > 65 ? this.Description.Substring(0, 65) + "..." : this.Description;

        public bool IsResolved { get; set; }

        public string IsResolvedString => this.IsResolved == true ? "RESOLVED" : "PENDING";

        public Pager.Pager Pager { get; set; }
    }
}
