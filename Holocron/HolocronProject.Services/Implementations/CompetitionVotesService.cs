using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionVotesService : ICompetitionVotesService
    {
        private readonly HolocronDbContext context;

        public CompetitionVotesService(HolocronDbContext context)
        {
            this.context = context;
        }

        public bool HasAccountVoted(string competitionCharacterId, string accountId)
            => this.context.CompetitionVotes
            .Any(x => x.CompetitionCharacterId == competitionCharacterId && x.AccountId == accountId);

        public async Task VoteForCompetition(string competitionCharacterId, string accountId)
        {

            var vote = new CompetitionVote
            {
                AccountId = accountId,
                CompetitionCharacterId = competitionCharacterId
            };

            await this.context.CompetitionVotes.AddAsync(vote);
            await this.context.SaveChangesAsync();
        }
    }
}
