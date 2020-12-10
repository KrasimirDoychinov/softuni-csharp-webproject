using HolocronProject.Data.Common;
using HolocronProject.Web.Areas.Administration.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.Models.Competitions
{
    public class CompetitionInputModel 
    {
        [Required]
        [MaxLength(GlobalRangeConstraints.CompetitionConstants.TitleMaxLength, ErrorMessage = GlobalErrorMessages.CompetitionErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.CompetitionConstants.DescriptionMaxLength, ErrorMessage = GlobalErrorMessages.CompetitionErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }

        [Required]
        [CompetitionEndDateAfterStartDate]
        public DateTime EndDate { get; set; }

    }
}
