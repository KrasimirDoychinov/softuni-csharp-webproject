using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IVotesService
    {
        Task VoteAsync(string threadId, string accountId, bool isUpVote);

        int GetVotes(string threadId);
    }
}
