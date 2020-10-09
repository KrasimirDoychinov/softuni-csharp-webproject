using System.Collections.Generic;

using HolocronProject.Services.Models;

namespace HolocronProject.Services
{
    public interface ICharacterService
    {
        // Search services
        IEnumerable<CharacterDto> MostPopularClasses();

    }
}
