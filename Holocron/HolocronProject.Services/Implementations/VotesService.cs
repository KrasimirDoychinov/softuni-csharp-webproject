using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class VotesService : IVotesService
    {
        private readonly HolocronDbContext context;

        public VotesService(HolocronDbContext context)
        {
            this.context = context;
        }

        public int GetVotes(string postId)
            => this.context.Votes
            .Where(x => x.ThreadId == postId)
            .Sum(x => (int)x.Type);

        public async Task VoteAsync(string threadId, string accountId, bool isUpVote)
        {
            var vote = this.context.Votes
                .FirstOrDefault(x => x.ThreadId == threadId && x.AccountId == accountId);

            if (vote != null)
            {
                vote.Type = isUpVote ? VoteType.UpVote : VoteType.DownVote;

                this.context.Votes.Update(vote);
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
    }
}
