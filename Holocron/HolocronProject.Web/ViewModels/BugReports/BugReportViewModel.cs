using System;

using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.BugReports
{
    public class BugReportViewModel : IMapFrom<BugReport>
    {
        public string Id { get; set; }

        public string AccountUserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

    }
}
