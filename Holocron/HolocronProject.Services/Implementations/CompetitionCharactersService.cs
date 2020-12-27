using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionCharactersService : ICompetitionCharactersService
    {
        private readonly ApplicationDbContext context;

        public CompetitionCharactersService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteAllCompetitionCharactersByAccountId(string accountId)
        {
            var competitionCharacters = this.context.CompetitionsCharacters
                .Where(x => x.Character.AccountId == accountId)
                .ToList();

            competitionCharacters.AsParallel().ForAll(x => x.IsDeleted = true);
            competitionCharacters.AsParallel().ForAll(x => x.DeletedOn = DateTime.UtcNow);

            await this.context.SaveChangesAsync();
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

        public IEnumerable<CompetitionCharacter> GetAllNotDeletedCharacters(string competitionId)
            => this.context.CompetitionsCharacters
            .Where(x => x.CompetitionId == competitionId && !x.IsDeleted)
            .ToList();

        public int GetVotesCount(string characterId, string competitionId)
            => this.context.CompetitionsCharacters
            .FirstOrDefault(x => x.CharacterId == characterId && x.CompetitionId == competitionId)
            .Votes;
    }
}
