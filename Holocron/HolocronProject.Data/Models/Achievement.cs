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
        [MaxLength(GlobalConstants.AchievementConstants.NameMaxLength)]
        public string Name { get; set; }

        public string CharacterId { get; set; }

        public Character Character { get; set; }

        public string CompetitionId { get; set; }

        public Competition Competition { get; set; }

    }
}
