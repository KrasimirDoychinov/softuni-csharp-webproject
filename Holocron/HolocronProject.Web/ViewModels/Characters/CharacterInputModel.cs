using HolocronProject.Data.Common;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ValidationAttributes;
using HolocronProject.Web.ViewModels.Classes;
using HolocronProject.Web.ViewModels.Races;
using HolocronProject.Web.ViewModels.Servers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Character
{
    using static GlobalErrorMessages;
    using static GlobalRangeConstraints;

    public class CharacterInputModel : IMapFrom<Data.Models.Character>
    {
        [CharacterNameInServer]
        [MaxLength(CharacterConstants.NameMaxLength, ErrorMessage = CharacterErrorMessages.NameMaxLengthError)]
        public string Name { get; set; }

        [MaxLength(CharacterConstants.BackstoryAndDescMaxLength, ErrorMessage = CharacterErrorMessages.BackstoryMaxLengthError)]
        public string Backstory { get; set; }

        [MaxLength(CharacterConstants.BackstoryAndDescMaxLength, ErrorMessage = CharacterErrorMessages.BackstoryMaxLengthError)]
        public string Description { get; set; }

        [MaxLength(CharacterConstants.TitleMaxLength, ErrorMessage = CharacterErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }

        [Display(Name = "Character image")]
        [CharacterImageFormat]
        public IFormFile Image { get; set; }

        [Required]
        [Range(1,3, ErrorMessage = CharacterErrorMessages.InvalidGenderError)]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "Character type")]
        [Range(1,4, ErrorMessage = CharacterErrorMessages.InvalidCharacterTypeError)]
        public CharacterType CharacterType { get; set; }

        [Required]
        [Display(Name = "Force affiliation")]
        [Range(1,3, ErrorMessage = CharacterErrorMessages.InvalidForceAffiliationError)]
        public ForceAffiliation ForceAffiliation { get; set; }

        [Required]
        [Display(Name = "Class")]
        public string ClassId { get; set; }

        public IEnumerable<ClassViewModel> Classes { get; set; }

        [Required]
        [Display(Name = "Race")]
        public string RaceId { get; set; }

        public IEnumerable<RaceViewModel> Races { get; set; }


        [Required]
        [Display(Name = "Server")]
        public string ServerId { get; set; }

        public IEnumerable<ServerViewModel> Servers { get; set; }

    }
}
