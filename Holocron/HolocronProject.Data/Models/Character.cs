using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Enums;
using HolocronProject.Data.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HolocronProject.Data.Models
{
    public class Character : BaseDeletableModel
    {
        // TODO: Edditing character info
        public Character()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.CharacterConstants.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.CharacterConstants.BackstoryMaxLength)]
        public string Backstory { get; set; } 

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

        public Class Class { get; set; }

        [Required]
        public string RaceId { get; set; }

        [Required]
        public Race Race { get; set; }

        [Required]
        public string ServerId { get; set; }

        public Server Server { get; set; }

        [Required]
        public string AccountId { get; set; }

        public Account Account { get; set; }

        public ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

        public ICollection<CompetitionCharacter> Competitions { get; set;  } = new List<CompetitionCharacter>();

    }
}