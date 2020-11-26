using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IVotesService
    {
        Task VoteAsync(string postId, string accountId, bool isUpVote);

        int GetVotes(string postId);
    }
}
