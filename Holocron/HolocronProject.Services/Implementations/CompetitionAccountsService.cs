using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionAccountsService : ICompetitionAccountsService
    {
        private readonly HolocronDbContext context;

        public CompetitionAccountsService(HolocronDbContext context)
        {
            this.context = context;
        }

        public bool DoesAccountVoteExist(string competitionId, string accountId)
            => this.context.CompetitionAccounts
            .Any(x => x.AccountId == accountId && x.CompetitionId == competitionId);

        public bool HasAccountVoted(string competitionId, string accountId)
           => this.context.CompetitionAccounts
           .Any(x => x.AccountId == accountId && x.CompetitionId == competitionId && x.HasVoted);

        public async Task VoteAsync(string characterId, string competitionId, string accountId)
        {
            if (this.DoesAccountVoteExist(competitionId,accountId))
            {
                var competitionAccount = this.context.CompetitionAccounts
                    .FirstOrDefault(x => x.CompetitionId == competitionId && x.AccountId == accountId);

                competitionAccount.HasVoted = true;
            }
            else
            {
                var competitionCharacter = this.context.CompetitionsCharacters
                    .FirstOrDefault(x => x.CompetitionId == competitionId && x.CharacterId == characterId);

                var competitionAccount = new CompetitionAccount
                {
                    CompetitionId = competitionId,
                    AccountId = accountId,
                    CompetitionCharacterId = characterId,
                    HasVoted = true
                };

                competitionCharacter.CompetitionAccounts.Add(competitionAccount);
                competitionCharacter.Votes++;

                await this.context.CompetitionAccounts.AddAsync(competitionAccount);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task UnVoteAsync(string competitionId, string accountId)
        {
            var competitionAccount = this.context.CompetitionAccounts
                .FirstOrDefault(x => x.CompetitionId == competitionId && x.AccountId == accountId);
            var characterId = competitionAccount.CompetitionCharacter.CharacterId;

            var competitionCharacter = this.context.CompetitionsCharacters
                   .FirstOrDefault(x => x.CompetitionId == competitionId && x.CharacterId == characterId);

            competitionCharacter.CompetitionAccounts.Remove(competitionAccount);
            competitionCharacter.Votes--;
            this.context.CompetitionAccounts.Remove(competitionAccount);
            await this.context.SaveChangesAsync();
        }
    }
}
