using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.ViewModelsTemp;

namespace HolocronProject.Services
{
    public interface ICharacterService
    {
        Task CreateCharacter(CharacterInputModel input);

        Task DeleteCharacter(string characterId);
    }
}
