using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharactersViewModel : IMapFrom<Data.Models.Character>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string CharacterImagePath { get; set; }

        public string Description { get; set; }

        public string Gender { get; set; }

        public string ClassName { get; set; }

        public string Title { get; set; }

        public string AccountId { get; set; }

        public string AccountUserName { get; set; }

        public Pager.Pager Pager { get; set; }

        public string NormalizedCreatedOn { get; set; }


    }
}
