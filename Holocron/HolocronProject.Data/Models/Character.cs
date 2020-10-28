using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Enums;
using HolocronProject.Data.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HolocronProject.Data.Models
{
    public class Character
    {
        // TODO: Edditing character info
        public Character()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CharacterConstants.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CharacterConstants.BackstoryMaxLength)]
        public string Backstory { get; set; } = "None";

        [MaxLength(GlobalConstants.CharacterConstants.TitleMaxLength)]
        public string Title { get; set; } = "None";

        // TODO: Figure out how to make an image
        public string Image { get; set; } = "Placeholder image";

        [Required]
        public Gender Gender { get; set; } = 0;

        [Required]
        public CharacterType CharacterType { get; set; } = 0;

        [Required]
        public ForceAffiliation ForceAffiliation { get; set; }

        public string ClassId { get; set; }

        public Class Class { get; set; }

        public string RaceId { get; set; }

        public Race Race { get; set; }

        public string ServerId { get; set; }

        public Server Server { get; set; }

        public string AccountId { get; set; }

        public Account Account { get; set; }

        public ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

        public ICollection<CompetitionCharacter> Competitions { get; set;  } = new List<CompetitionCharacter>();

        // TODO: Add something else if I think of something

        public bool IsDeleted { get; set; } = false;
    }
}