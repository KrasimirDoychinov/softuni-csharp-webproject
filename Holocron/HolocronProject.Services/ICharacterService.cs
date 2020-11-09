using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface ICharacterService
    {
        Task CreateCharacterAsync(CharacterInputModel input);

        Task DeleteCharacterAsync(string characterId);

        Character GetCharacterById(string characterId);
    }
}
