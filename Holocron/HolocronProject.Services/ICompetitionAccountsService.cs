using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ICompetitionAccountsService
    {
        Task DeleteAllCompetitionAccountsByAccountId(string accountId);

        Task VoteAsync(string characterId, string competitionId, string accountId);

        Task UnVoteAsync(string competitionId, string accountId);

        string GetCompetitionCharacterCharacterId(string competitionId, string accountId);

        bool HasAccountVoted(string competitionId, string accountId);
    }
}
