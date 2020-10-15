using System.Collections.Generic;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;

namespace HolocronProject.Services
{
    public interface ICharacterService
    {
        IEnumerable<CharacterDto> MostPopularClasses();

        Character GetCharacterByName(string characterName);

        void IsCharacterDetailsValid(string characterName, int gender, int characterType, int faction,
            string className, string raceName, string serverName,
            int forceAffiliation, string backstory);

        void IsCharacterNameTaken(string characterName);
    }
}
