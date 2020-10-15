using System.Collections.Generic;

using HolocronProject.Services.Models;

namespace HolocronProject.Services
{
    public interface ICharacterService
    {

        void IsCharacterDetailsValid(string characterName, int gender, int characterType, int faction,
            string className, string raceName, string serverName,
            int forceAffiliation, string backstory);

        void IsCharacterNameTaken(string characterName);

        // Search services
        IEnumerable<CharacterDto> MostPopularClasses();

    }
}
