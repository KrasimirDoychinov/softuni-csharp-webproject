﻿using System;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{

    public class BugReport : BaseResolvableModel
    {
        public BugReport()
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

        public string Notes { get; set; }

        [Required]
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }


    }
}
