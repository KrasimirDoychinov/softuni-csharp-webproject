using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using HolocronProject.Services.Models.Character;
using Microsoft.AspNetCore.Http;

namespace HolocronProject.Services
{
    public interface ICharacterService
    {
        Task CreateCharacterAsync(CharacterInputDto input);

        Task DeleteCharacterAsync(string characterId);

        Character GetCharacterById(string characterId);

        IEnumerable<T> GetCurrentAccountCharacter<T>(string userId);

        T GetCharacterInfo<T>(string characterId);

        Task CreateCharacterImage(string characterName, IFormFile image);

    }
}
