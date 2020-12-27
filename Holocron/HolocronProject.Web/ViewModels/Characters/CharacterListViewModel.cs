using System;

using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharacterListViewModel : IMapFrom<Data.Models.Character>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string CharacterImagePath { get; set; }

        public string Gender { get; set; }

        public string ClassName { get; set; }

        public string Title { get; set; }

        public string AccountId { get; set; }

        public string AccountUserName { get; set; }

        public Pager.Pager Pager { get; set; }
        
        public DateTime CreatedOn { get; set; }

    }
}
