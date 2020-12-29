using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharacterEditViewModel : CharacterInputModel, IMapFrom<Character>
    {
        public string CharacterId { get; set; }
    }
}
