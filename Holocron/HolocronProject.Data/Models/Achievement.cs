using HolocronProject.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class Achievement
    {
        // TODO: Service to win achievement
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
