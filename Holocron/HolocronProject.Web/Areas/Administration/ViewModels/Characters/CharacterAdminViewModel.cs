using System;

using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Characters;

namespace HolocronProject.Web.Areas.Administration.ViewModels.Characters
{
    public class CharacterAdminViewModel : CharacterViewModel, IMapFrom<Character>
    {
        public bool IsApproved { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AccountUserName { get; set; }

        public int BannedCharacters { get; set; }

        public int NotBannedCharacters { get; set; }
    }
}
