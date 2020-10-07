using HolocronProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using HolocronProject.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Models
{
    public class Character
    {
        public int Id { get; set; }

        [MaxLength(GlobalConstants.CharacterConstants.NameMaxLength)]
        public string Name { get; set; }

        public Gender Gender { get; set; } = 0;

        public CharacterType CharacterType { get; set; } = 0;

        public Faction Faction { get; set; } = 0;

        public int ClassId { get; set; }

        public Class Class { get; set; }

        public int RaceId { get; set; }

        public Race Race { get; set; }

        public int ServerId { get; set; }

        public Server Server { get; set; }

        public int AccountId { get; set; }

        public Account Account { get; set; }

        public string Title { get; set; } = "None";

        // TODO: Figure out how to make an image
        public string Image { get; set; }

        // TODO: Add something else if I think of something
    }
}