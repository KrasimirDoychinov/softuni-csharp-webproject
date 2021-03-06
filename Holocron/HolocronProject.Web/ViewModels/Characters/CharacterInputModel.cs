﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Enums;
using HolocronProject.Data.Common;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Races;
using HolocronProject.Web.ViewModels.Servers;
using HolocronProject.Web.ViewModels.Classes;
using HolocronProject.Web.ValidationAttributes;

using Microsoft.AspNetCore.Http;

namespace HolocronProject.Web.ViewModels.Characters
{
    using static GlobalErrorMessages;
    using static GlobalRangeConstraints;

    public class CharacterInputModel : IMapFrom<Data.Models.Character>
    {
        [Required]
        [MaxLength(CharacterConstants.NameMaxLength, ErrorMessage = CharacterErrorMessages.NameMaxLengthError)]
        public string Name { get; set; }

        [MaxLength(CharacterConstants.BackstoryAndDescMaxLength, ErrorMessage = CharacterErrorMessages.BackstoryMaxLengthError)]
        public string Backstory { get; set; }

        [MaxLength(CharacterConstants.BackstoryAndDescMaxLength, ErrorMessage = CharacterErrorMessages.BackstoryMaxLengthError)]
        public string Description { get; set; }

        [MaxLength(CharacterConstants.TitleMaxLength, ErrorMessage = CharacterErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Character image")]
        [ImageValidator]
        public IFormFile Image { get; set; }

        [Required]
        [Range(1,3, ErrorMessage = CharacterErrorMessages.InvalidGenderError)]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "Character type")]
        public CharacterType CharacterType { get; set; }

        [Required]
        [Display(Name = "Force affiliation")]
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
