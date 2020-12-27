using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharacterToPickViewModel : CharacterListViewModel, IMapFrom<Character>
    {
        public string CompetitionId { get; set; }
    }
}
