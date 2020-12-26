using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.Areas.Administration.ViewModels.Accounts;
using HolocronProject.Web.ViewModels.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.ViewModels.Characters
{
    public class CharacterAdminViewModel : CharacterUserViewModel, IMapFrom<Character>
    {
        public bool IsApproved { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AccountUserName { get; set; }

        public int BannedCharacters { get; set; }

        public int NotBannedCharacters { get; set; }
    }
}
