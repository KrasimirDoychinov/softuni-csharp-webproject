using HolocronProject.Data;
using HolocronProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolocronProject.Services
{
    public class CharacterService : ICharacterService
    {
        private HolocronDbContext context;

        public CharacterService()
        {
            context = new HolocronDbContext();
        }

        public IEnumerable<CharacterDto> MostPopularClasses()
        {
            var characters = context.Characters
                .Select(x => new CharacterDto
                {
                    AccountDisplayName = x.Account.DisplayName,
                    Name = x.Name,
                    Class = x.Class,
                    RaceName = x.Race.Name,
                    ServerName = x.Server.Name,
                    Faction = x.Faction.ToString(),
                    ForceAffiliation = x.ForceAffiliation.ToString(),
                    CharacterType = x.CharacterType.ToString(),
                    Gender = x.Gender.ToString()
                })
                .OrderByDescending(x => x.Class)
                .ToList();

            return characters;

        }
    }
}
