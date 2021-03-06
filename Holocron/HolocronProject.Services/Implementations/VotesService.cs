﻿using System.Linq;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class VotesService : IVotesService
    {
        private readonly ApplicationDbContext context;

        public VotesService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task VoteAsync(string threadId, string accountId, bool isUpVote)
        {
            var vote = this.context.Votes
                .FirstOrDefault(x => x.ThreadId == threadId && x.AccountId == accountId);

            if (vote != null)
            {
                vote.Type = isUpVote ? VoteType.UpVote : VoteType.DownVote;

            }
            else
            {
                vote = new Vote
                {
                    ThreadId = threadId,
                    AccountId = accountId,
                    Type = isUpVote ? VoteType.UpVote : VoteType.DownVote
                };
                await this.context.Votes.AddAsync(vote);
            }

            
            await this.context.SaveChangesAsync();
        }

        public int GetVotes(string threadId)
            => this.context.Votes
            .Where(x => x.ThreadId == threadId)
            .Sum(x => (int)x.Type);
    }
}
