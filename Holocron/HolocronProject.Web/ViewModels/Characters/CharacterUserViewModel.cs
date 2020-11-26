using HolocronProject.Services.Mapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharacterUserViewModel : IMapFrom<Data.Models.Character>
    {
        public string Id { get; set; }

        public string AccountUserName { get; set; }

        public string Name { get; set; }

        public string RaceName { get; set; }

        public string ServerName { get; set; }

        public string ClassName { get; set; }

        public string CharacterImagePath { get; set; }

        public string RandomImageQuery { get; set; }
    }
}
