using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Competition
    {
        public Competition()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.CompetitionConstants.TitleMaxLength, ErrorMessage = GlobalErrorMessages.CompetitionErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.CompetitionConstants.DescriptionMaxLength, ErrorMessage = GlobalErrorMessages.CompetitionErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public virtual ICollection<CompetitionCharacter> Characters { get; set; } = new List<CompetitionCharacter>();

        public virtual ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

        public bool IsFinished { get; set; } = false;

        public DateTime? FinishedOn { get; set; }
    }
}
