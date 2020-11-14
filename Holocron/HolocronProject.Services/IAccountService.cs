using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using HolocronProject.Services.Models;

namespace HolocronProject.Services
{
    public interface IAccountService
    {
        Task UpdateForumSignatureAsync(string accountId, string forumSignature);

        Task UpdateAvatarImageAsync(string accountId, string avatarImage);

        Task UpdateDisplayNameAsync(string accountId, string newDisplayName);

        Task UpdateAccountNameAsync(string accountId, string newAccountName);

        Account GetAccountById(string accountId);

        T GetForeignAccount<T>(string accountId);

        string GetDisplayName(string accountId);

    }
}
