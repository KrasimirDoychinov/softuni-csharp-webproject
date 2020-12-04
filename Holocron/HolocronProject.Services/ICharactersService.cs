using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using HolocronProject.Services.Models.Character;
using HolocronProject.Services.Models.Characters;
using Microsoft.AspNetCore.Http;

namespace HolocronProject.Services
{
    public interface ICharactersService
    {
        Task CreateCharacterAsync(CharacterInputDto input);

        Task EditCharacterAsync(CharacterEditDto input);

        Task DeleteCharacterAsync(string characterId);

        Character GetCharacterById(string characterId);

        IEnumerable<T> GetCurrentAccountCharacter<T>(string userId);

        IEnumerable<T> GetNewestCharacters<T>();

        T GetCharacterByIdGeneric<T>(string characterId);

        Task UpdateCharacterImage(string characterName, IFormFile image);

        int TotalCharacters();

        int TotalPendingCharacters();

        Task ApproveCharacter(string characterId, string accountId);

        IEnumerable<T> GetPendingCharacters<T>(string accountId);

        IEnumerable<T> GetAllPendingCharacters<T>();


        

    }
}
