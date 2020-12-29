using System;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;
using HolocronProject.Web.Areas.Administration.ValidationAttributes;

namespace HolocronProject.Web.Areas.Administration.ViewModels.Competitions
{
    public class CompetitionInputModel 
    {
        [Required]
        [MaxLength(GlobalRangeConstraints.CompetitionConstants.TitleMaxLength, ErrorMessage = GlobalErrorMessages.CompetitionErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.CompetitionConstants.DescriptionMaxLength, ErrorMessage = GlobalErrorMessages.CompetitionErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }

        public DateTime StartDate => DateTime.UtcNow;

        [Required]
        [CompetitionEndDateAfterStartDate]
        public DateTime EndDate { get; set; }

    }
}
