
using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class VoteThreadsService : IVoteThreadsService
    {
        private readonly HolocronDbContext context;

        public VoteThreadsService(HolocronDbContext context)
        {
            this.context = context;
        }

        public int GetVotes(string threadId)
        {
            var votes = this.context.VotesThreads
                .Where(x => x.ThreadId == threadId).Sum(x => (int)x.Type);
            return votes;
        }

        public async Task VoteAsync(string threadId, string accountId, bool isUpVote)
        {
            var vote = this.context.VotesThreads
                .FirstOrDefault(x => x.ThreadId == threadId && x.AccountId == accountId);

            if (vote != null) 
            {
                vote.Type = isUpVote ? VoteType.UpVote : VoteType.DownVote;
            }
            else
            {
                vote = new VoteThread
                {
                    ThreadId = threadId,
                    AccountId = accountId,
                    Type = isUpVote ? VoteType.UpVote : VoteType.DownVote,
                };

                await this.context.VotesThreads.AddAsync(vote);
            }

            await this.context.SaveChangesAsync();
        }
    }
}
