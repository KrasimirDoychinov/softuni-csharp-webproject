using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.BugReports
{
    public class BugReportViewModel : IMapFrom<BugReport>
    {
        public string Id { get; set; }

        public string AccountUserName { get; set; }

        public string CreatedOn { get; set; }

        public string NormalizedCreatedOn { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }
    }
}
