using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;

namespace HolocronProject.Services
{
    public interface ICharacterService
    {
        Task CreateCharacterAsync(CharacterInputDto input);

        Task DeleteCharacterAsync(string characterId);

        Character GetCharacterById(string characterId);
    }
}
