using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.ViewModels.Characters
{
    public class NewestCharactersViewModel : CharacterListViewModel, IMapFrom<Character>
    {
        public int TotalCharacters { get; set; }

        public int DeletedCharacters { get; set; }

        public int NotDeletedCharacters { get; set; }

        public int ApprovedCharacters { get; set; }

        public int PendingCharacters { get; set; }

        public int CharactersMadeToday { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DeletedOn { get; set; }

        public CharacterStatus CharacterStatus { get; set; }
        
        public bool AccountIsBanned { get; set; }
    }
}
