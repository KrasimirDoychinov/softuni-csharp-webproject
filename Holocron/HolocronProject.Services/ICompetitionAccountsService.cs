﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ICompetitionAccountsService
    {
        Task VoteAsync(string characterId, string competitionId, string accountId);

        Task UnVoteAsync(string competitionId, string accountId);

        string GetCharacterId(string competitionId, string accountId);

        bool DoesAccountVoteExist(string competitionId, string accountId);

        bool HasAccountVoted(string competitionId, string accountId);
    }
}
