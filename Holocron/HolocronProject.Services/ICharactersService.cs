using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
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

        Character GetCharacterById(string characterId);

        IEnumerable<T> GetCurrentAccountCharacters<T>(string accountId, IMapper mapper = null);

        IEnumerable<T> GetCurrentAccountCharacterForCompetition<T>(string accountId, string competitionId, IMapper mapper = null);

        IEnumerable<T> GetAllCharacters<T>(IMapper mapper = null);

        T GetCharacterByIdGeneric<T>(string characterId, IMapper mapper = null);

        Task UpdateCharacterImageAsync(string webRootPath, string characterName, string serverId, IFormFile image);

        int TotalCharacters();

        int DeletedCharactersByAccount(string accountId);

        int NotDeletedCharactersByAccount(string accountId);

        int TotalPendingCharacters();

        Task ApproveCharacterAsync(string characterId, string accountId);

        Task DeleteCharacterAsync(string characterId, string accountId);

        IEnumerable<T> GetPendingCharacters<T>(string accountId, IMapper mapper = null);

        IEnumerable<T> GetAllPendingCharacters<T>(IMapper mapper = null);

    }
}
