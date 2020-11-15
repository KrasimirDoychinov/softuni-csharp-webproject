using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using HolocronProject.Services.Models.Character;

namespace HolocronProject.Services
{
    public interface ICharacterService
    {
        Task CreateCharacterAsync(CharacterInputDto input);

        Task DeleteCharacterAsync(string characterId);

        Character GetCharacterById(string characterId);

        IEnumerable<T> GetCurrentUsersCharacter<T>(string accountId);

        T GetCharacterInfo<T>(string characterId);

    }
}
