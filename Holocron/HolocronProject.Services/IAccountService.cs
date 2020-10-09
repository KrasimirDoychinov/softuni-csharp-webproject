using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IAccountService
    {
        Task Create(string accountName, string password, string displayName);

        Task CreateCharacter(string accountName, string characterName,
            int gender, int characterType, int faction,
            string className, string raceName, string serverName, int forceAffiliation, string backstory = "none");

        Task CreatePost(string accountName, string description, string threadName);

        Task CreateThread(string accountName, string title, string baseThreadTitle);

        Task DeleteCharacter(string characterName);

        // Search services
        IEnumerable<AccountDto> SearchByMostPosts(int ammountOfAccounts);

        IEnumerable<AccountDto> SearchOldestAccounts(int ammountOfAccounts);

        ForeignAccountDto ForeignAccount(string displayName);
    }
}
