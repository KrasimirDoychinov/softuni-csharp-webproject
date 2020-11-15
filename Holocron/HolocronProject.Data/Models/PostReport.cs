using HolocronProject.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class PostReport
    {
        // TODO: Implement services
        // TODO: Resolve service
        // TODO: View services
        public PostReport()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.ReportConstants.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.ReportConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]

        public string AccountId { get; set; }

        public Account Account { get; set; }

        [Required]

        public string PostId { get; set; }

        public Post Post { get; set; }

        

    }
}
