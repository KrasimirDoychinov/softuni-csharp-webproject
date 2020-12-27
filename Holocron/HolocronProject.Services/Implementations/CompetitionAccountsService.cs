using System;
using System.Linq;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionAccountsService : ICompetitionAccountsService
    {
        private readonly ApplicationDbContext context;

        public CompetitionAccountsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool HasAccountVoted(string competitionId, string accountId)
           => this.context.CompetitionAccounts
           .Any(x => x.AccountId == accountId && x.CompetitionId == competitionId && x.HasVoted && !x.IsDeleted);

        public async Task VoteAsync(string characterId, string competitionId, string accountId)
        {
            if (!this.HasAccountVoted(competitionId, accountId))
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

                object lockObj = new object();
                lock (lockObj)
                {
                    competitionCharacter.CompetitionAccounts.Add(competitionAccount);
                    competitionCharacter.Votes++;
                }

                await this.context.CompetitionAccounts.AddAsync(competitionAccount);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task UnVoteAsync(string competitionId, string accountId)
        {
            var competitionAccount = this.context.CompetitionAccounts
                .FirstOrDefault(x => x.CompetitionId == competitionId && x.AccountId == accountId);

            var characterId = this.GetCompetitionCharacterCharacterId(competitionId, accountId);

            var competitionCharacter = this.context.CompetitionsCharacters
                   .FirstOrDefault(x => x.CompetitionId == competitionId && x.CharacterId == characterId);

            object lockObj = new object();
            lock (lockObj)
            {
                competitionCharacter.CompetitionAccounts.Remove(competitionAccount);
                competitionCharacter.Votes--;
                this.context.CompetitionAccounts.Remove(competitionAccount);
            }

            await this.context.SaveChangesAsync();
        }

        public string GetCompetitionCharacterCharacterId(string competitionId, string accountId)
        {
            var competitionAccount = this.context.CompetitionAccounts
            .FirstOrDefault(x => x.CompetitionId == competitionId && x.AccountId == accountId);

            if (competitionAccount == null)
            {
                throw new ArgumentNullException("There is no vote found to unvote.");
            }

            return competitionAccount.CompetitionCharacter.CharacterId;
        }

        public async Task DeleteAllCompetitionAccountsByAccountId(string accountId)
        {
            var competitionAccounts = this.context.CompetitionAccounts
                .Where(x => x.AccountId == accountId)
                .ToList();

            competitionAccounts.AsParallel().ForAll(x => x.IsDeleted = true);
            competitionAccounts.AsParallel().ForAll(x => x.DeletedOn = DateTime.UtcNow);

            await this.context.SaveChangesAsync();
        }
    }
}
