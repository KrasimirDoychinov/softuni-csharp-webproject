using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.CompetitionCharacters
{
    public class CompetitionCharactersViewModel : IMapFrom<CompetitionCharacter>
    {
        public virtual CharacterListViewModel Character { get; set; }

        public int VotesCount { get; set; }
    }
}
