﻿using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Web.ViewModels.PostReports
{
    using static Data.Common.GlobalErrorMessages;
    using static Data.Common.GlobalRangeConstraints;
    public class PostReportInputModel
    {
        [Required]
        [MaxLength(ReportConstants.TitleMaxLength, ErrorMessage = ReportErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }

        [Required]
        [MaxLength(ReportConstants.DescriptionMaxLength, ErrorMessage = ReportErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }

        [MaxLength(ReportConstants.NotesMaxLength, ErrorMessage = ReportErrorMessages.NotesMaxLengthError)]
        public string Notes { get; set; }
    }
}
