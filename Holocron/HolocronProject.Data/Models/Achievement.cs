using System;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Achievement
    {
        public Achievement()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.AchievementConstants.NameMaxLength)]
        public string Name { get; set; }

        public string CharacterId { get; set; }

        public virtual Character Character { get; set; }

        [Required]
        public string CompetitionId { get; set; }

        public virtual Competition Competition { get; set; }

    }
}
