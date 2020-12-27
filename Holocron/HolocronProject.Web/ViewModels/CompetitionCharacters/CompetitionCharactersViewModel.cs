using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Characters;

namespace HolocronProject.Web.ViewModels.CompetitionCharacters
{
    public class CompetitionCharactersViewModel : IMapFrom<CompetitionCharacter>
    {
        public virtual CharacterListViewModel Character { get; set; }

        public int Votes { get; set; }
    }
}
