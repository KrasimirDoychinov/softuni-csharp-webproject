using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Enums;
using HolocronProject.Data.Common;


namespace HolocronProject.Data.Models
{
    public class Character
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CharacterConstants.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CharacterConstants.BackstoryMaxLength)]
        public string Backstory { get; set; } = "None";

        [Required]
        public Gender Gender { get; set; } = 0;

        [Required]
        public CharacterType CharacterType { get; set; } = 0;

        [Required]
        public Faction Faction { get; set; } = 0;

        [Required]
        public ForceAffiliation ForceAffiliation { get; set; }

        public int ClassId { get; set; }

        public Class Class { get; set; }

        public int RaceId { get; set; }

        public Race Race { get; set; }

        public int ServerId { get; set; }

        public Server Server { get; set; }

        public int AccountId { get; set; }

        public Account Account { get; set; }

        [MaxLength(GlobalConstants.CharacterConstants.TitleMaxLength)]
        public string Title { get; set; } = "None";

        // TODO: Figure out how to make an image
        public string Image { get; set; } = "Placeholder image";

        // TODO: Add something else if I think of something

        public bool IsDeleted { get; set; } = false;
    }
}