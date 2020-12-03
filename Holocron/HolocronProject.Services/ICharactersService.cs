using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using HolocronProject.Services.Models.Character;
using Microsoft.AspNetCore.Http;

namespace HolocronProject.Services
{
    public interface ICharactersService
    {
        Task CreateCharacterAsync(CharacterInputDto input);

        Task DeleteCharacterAsync(string characterId);

        Character GetCharacterById(string characterId);

        IEnumerable<T> GetCurrentAccountCharacter<T>(string userId);

        IEnumerable<T> GetNewestCharacters<T>();

        T GetCharacterInfo<T>(string characterId);

        Task CreateCharacterImage(string characterName, IFormFile image);

        int TotalCharacters();

        int TotalPendingCharacters();

        Task ApproveCharacter(string characterId, string accountId);

        IEnumerable<T> GetPendingCharacters<T>(string accountId);

        IEnumerable<T> GetAllPendingCharacters<T>();

        

    }
}
