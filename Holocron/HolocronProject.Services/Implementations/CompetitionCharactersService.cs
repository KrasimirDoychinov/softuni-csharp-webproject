using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionCharactersService : ICompetitionCharactersService
    {
        private readonly HolocronDbContext context;

        public CompetitionCharactersService(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task AddCharacterToCompetitionAsync(string characterId, string competitionId)
        {
            var compCharacter = new CompetitionCharacter
            {
                CharacterId = characterId,
                CompetitionId = competitionId
            };

            await this.context.CompetitionsCharacters.AddAsync(compCharacter);
            await this.context.SaveChangesAsync();
        }

        public string GetCompetitionCharactersId(string characterId, string competitionId)
            => this.context.CompetitionsCharacters
            .FirstOrDefault(x => x.CharacterId == characterId && x.CompetitionId == competitionId)
            .Id;
    }
}
