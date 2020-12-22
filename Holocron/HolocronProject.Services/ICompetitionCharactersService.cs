using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ICompetitionCharactersService
    {
        Task DeleteAllCompetitionCharactersByAccountId(string accountId);

        Task AddCharacterToCompetitionAsync(string characterId, string competitionId);

        Task RemoveCharacterFromCompetitionAsync(string characterId, string competitionId);

        IEnumerable<CompetitionCharacter> GetAllNotDeletedCharacters(string competitionId);

        int GetVotesCount(string characterId, string competitionId);

    }
}
