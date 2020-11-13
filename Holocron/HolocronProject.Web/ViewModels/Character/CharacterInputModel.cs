using HolocronProject.Data.Common;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ValidationAttributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Character
{
    public class CharacterInputModel : IMapFrom<Data.Models.Character>
    {
        [Required]
        [CharacterNameInServer]
        [MaxLength(GlobalRangeConstants.CharacterConstants.NameMaxLength, ErrorMessage = GlobalErrorMessages.CharacterErrorMessages.NameMaxLengthError)]
        public string Name { get; set; }

        [MaxLength(GlobalRangeConstants.CharacterConstants.BackstoryMaxLength, ErrorMessage = GlobalErrorMessages.CharacterErrorMessages.BackstoryMaxLengthError)]
        public string Backstory { get; set; }

        [MaxLength(GlobalRangeConstants.CharacterConstants.TitleMaxLength, ErrorMessage = GlobalErrorMessages.CharacterErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }

        public string Image { get; set; }

        [Required]
        [Range(1,3, ErrorMessage = GlobalErrorMessages.CharacterErrorMessages.InvalidGenderError)]
        public Gender Gender { get; set; }

        [Required]
        [Range(1,4)]
        public CharacterType CharacterType { get; set; }

        [Required]
        [Range(1,3)]
        public ForceAffiliation ForceAffiliation { get; set; }

        [Required]
        public string Class { get; set; }

        public IEnumerable<SelectListItem> ClassList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Juggernaut", Text = "Juggernaut" },
                new SelectListItem { Value = "Marauder", Text = "Marauder" },
                new SelectListItem { Value = "Sorcerer", Text = "Sorcerer" },
                new SelectListItem { Value = "Assassin", Text = "Assassin" },
                new SelectListItem { Value = "Sniper", Text = "Sniper" },
                new SelectListItem { Value = "Operative", Text = "Operative" },
                new SelectListItem { Value = "Powertech", Text = "Powertech" },
                new SelectListItem { Value = "Mercenary", Text = "Mercenary" },
                new SelectListItem { Value = "Gunslinger", Text = "Gunslinger" },
                new SelectListItem { Value = "Scoundrel", Text = "Scoundrel" },
                new SelectListItem { Value = "Vanguard", Text = "Vanguard" },
                new SelectListItem { Value = "Commando", Text = "Commando" },
                new SelectListItem { Value = "Sage", Text = "Sage" },
                new SelectListItem { Value = "Shadow", Text = "Shadow" },
                new SelectListItem { Value = "Sentinel", Text = "Sentinel" },
                new SelectListItem { Value = "Guardian", Text = "Guardian" }
        };

        [Required]
        public string Race { get; set; }

        public IEnumerable<SelectListItem> RaceList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Chiss", Text = "Chiss" },
                new SelectListItem { Value = "Cyborg", Text = "Cyborg" },
                new SelectListItem { Value = "Human", Text = "Human" },
                new SelectListItem { Value = "Miraluka", Text = "Miraluka" },
                new SelectListItem { Value = "Mirialan", Text = "Mirialan" },
                new SelectListItem { Value = "Rattaki", Text = "Rattaki" },
                new SelectListItem { Value = "Sith Pureblood", Text = "Sith Pureblood" },
                new SelectListItem { Value = "Twi'lek", Text = "Twi'lek" },
                new SelectListItem { Value = "Zabrak", Text = "Zabrak" },
                new SelectListItem { Value = "Cathar", Text = "Cathar" },
                new SelectListItem { Value = "Togruta", Text = "Togruta" },
                new SelectListItem { Value = "Nautolan", Text = "Nautolan" }
        };

        [Required]
        public string Server { get; set; }

        public IEnumerable<SelectListItem> ServerList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Darth Malgus", Text = "Darth Malgus" },
                new SelectListItem { Value = "Star Forge", Text = "Star Forge" },
                new SelectListItem { Value = "Satele Shan", Text = "Satele Shan" },
                new SelectListItem { Value = "Tulak Hord", Text = "Tulak Hord" },
                new SelectListItem { Value = "The Leviathan", Text = "The Leviathan" }
        };
    }
}
