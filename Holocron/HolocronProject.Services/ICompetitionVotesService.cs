using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ICompetitionVotesService
    {
        Task VoteForCompetition(string competitionCharacterId, string accountId);

        bool HasAccountVoted(string competitionCharacterId, string accountId);
    }
}
