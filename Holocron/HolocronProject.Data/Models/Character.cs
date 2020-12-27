using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Enums;
using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Character : BaseDeletableModel
    {
        public Character()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.CharacterConstants.NameMaxLength)]
        public string Name { get; set; }

        [MaxLength(GlobalRangeConstraints.CharacterConstants.BackstoryAndDescMaxLength)]
        public string Backstory { get; set; } 

        [MaxLength(GlobalRangeConstraints.CharacterConstants.BackstoryAndDescMaxLength)]
        public string Description { get; set; }

        [MaxLength(GlobalRangeConstraints.CharacterConstants.TitleMaxLength)]
        public string Title { get; set; }

        public string CharacterImagePath { get; set; } 

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public CharacterType CharacterType { get; set; }

        [Required]
        public ForceAffiliation ForceAffiliation { get; set; }

        [Required]
        public string ClassId { get; set; }

        public virtual Class Class { get; set; }

        [Required]
        public string RaceId { get; set; }

        [Required]
        public virtual Race Race { get; set; }

        [Required]
        public string ServerId { get; set; }

        public virtual Server Server { get; set; }

        [Required]
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }

        public virtual ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

        public virtual ICollection<CompetitionCharacter> Competitions { get; set;  } = new List<CompetitionCharacter>();

        public CharacterStatus CharacterStatus { get; set; } = 0;

    }
}