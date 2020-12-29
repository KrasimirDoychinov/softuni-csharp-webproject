using System;

using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharacterListViewModel : CharacterViewModel, IMapFrom<Data.Models.Character>
    {
        public string AccountUserName { get; set; }

        public Pager.Pager Pager { get; set; }
        
        public DateTime CreatedOn { get; set; }

    }
}
