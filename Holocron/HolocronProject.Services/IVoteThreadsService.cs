using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IVoteThreadsService
    {
        Task VoteAsync(string threadId, string userId, bool isUpVote);

        int GetVotes(string threadId);
    }
}
