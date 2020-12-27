using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface ICompetitionCharactersService
    {
        Task DeleteAllCompetitionCharactersByAccountId(string accountId);

        Task AddCharacterToCompetitionAsync(string characterId, string competitionId);

        IEnumerable<CompetitionCharacter> GetAllNotDeletedCharacters(string competitionId);

        int GetVotesCount(string characterId, string competitionId);

    }
}
