using HolocronProject.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HolocronProject.Data.Models
{

    public class BugReport
    {
        // TODO: View services
        public BugReport()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstants.ReportConstants.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstants.ReportConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public string AccountId { get; set; }

        public Account Account { get; set; }

        public bool IsResolved { get; set; } = false;

    }
}
