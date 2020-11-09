using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IAccountService
    {
        Task UpdateForumSignatureAsync(string accountId, string forumSignature);

        Task UpdateAvatarImageAsync(string accountId, string avatarImage);

        Task UpdateDisplayNameAsync(string accountId, string newDisplayName);

        Task UpdateAccountNameAsync(string accountId, string newAccountName);

        Account GetAccountById(string accountId);

        ForeignAccountViewModel GetForeignAccount(string accountId);

    }
}
