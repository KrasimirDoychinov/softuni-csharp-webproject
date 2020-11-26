using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class ForeignCharactersViewModel : IMapFrom<Data.Models.Character>
    {
        public string Name { get; set; }

        public string CharacterImagePath { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

    }
}
