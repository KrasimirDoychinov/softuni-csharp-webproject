using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Services.Models;
using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IAccountService
    {
        Task CreateAccount(string accountName, string password, string displayName);

        Task UpdateForumSignature(string accountId, string forumSignature);

        Task UptadeImage(string accountId, string avatarImage);

        Task UpdatePassword(string accountId, string newPassword);

        Task UpdateDisplayName(string accountId, string newDisplayName);

        Task UpdateAccountName(string accountId, string newAccountName);

        Account GetAccountById(string accountId);

    }
}
