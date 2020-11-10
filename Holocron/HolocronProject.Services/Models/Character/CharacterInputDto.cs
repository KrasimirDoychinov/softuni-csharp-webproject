using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services.Models.Character
{
    public class CharacterInputDto
    {
        public string Name { get; set; }

        public string Backstory { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public Gender Gender { get; set; }

        public CharacterType CharacterType { get; set; }

        public ForceAffiliation ForceAffiliation { get; set; }

        public string ClassId { get; set; }

        public string RaceId { get; set; }

        public string ServerId { get; set; }

        public string AccountId  { get; set; }
    }
}
