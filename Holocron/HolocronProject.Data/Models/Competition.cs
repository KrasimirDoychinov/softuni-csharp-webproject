using HolocronProject.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class Competition
    {
        // TODO: Implement services
        // TODO: Make sure IsFinished works
        // TODO: Make sure everything works
        // TODO: View services
        public Competition()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CompetitionConstants.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CompetitionConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<CompetitionCharacter> Characters { get; set; } = new List<CompetitionCharacter>();

        public ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

        public bool IsFinished => this.EndDate > this.StartDate ? true : false;

    }
}
