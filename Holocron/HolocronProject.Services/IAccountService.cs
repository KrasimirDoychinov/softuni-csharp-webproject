using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Services.Models;

namespace HolocronProject.Services
{
    public interface IAccountService
    {
        Task CreateAccount(string accountName, string password, string displayName,
            string avatarImage = "Placeholder");

        Task CreateCharacter(string accountName, string characterName,
            int gender, int characterType, int faction,
            string className, string raceName, string serverName, int forceAffiliation, string backstory,
            string title, string image);

        Task CreatePost(string accountName, string description, string threadName);

        Task CreateThread(string accountName, string title, string baseThreadTitle);

        Task DeleteCharacter(string characterName);

        // Search services
        IEnumerable<AccountDto> SearchByMostPosts(int amountOfAccounts);

        IEnumerable<AccountDto> SearchOldestAccounts(int amountOfAccounts);

        IEnumerable<AccountDto> SearchAccountsWithMostCharacters(int amountOfAccounts);

        ForeignAccountDto SearchForeignAccount(string displayName);

    }
}
