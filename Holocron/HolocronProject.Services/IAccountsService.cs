using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using Microsoft.AspNetCore.Http;
using HolocronProject.Data.Enums;

namespace HolocronProject.Services
{
    public interface IAccountsService
    {
        Task UpdateForumSignatureAsync(string accountId, string forumSignature);

        Task UpdateUserNameAsync(string accountId, string newAccountName);

        Task UpdateAvatarImagePathAsync(string accountId);

        Account GetAccountById(string accountId);

        Task CreateAvatarImageAsync(string accountId, IFormFile image);

        Task UpdateAvatarImageAsync(string accountId, IFormFile avatarImage);

        string GetAccountAvatarImagePath(string accountId);

        T GetAccountByIdGeneric<T>(string accountId);

        bool IsAvatarImageSet(string accountId);

        int TotalAccounts();

        Task NotifyAccountOfApprovedCharacters(string accountId);

        Task NotifyAccountOfPendingCharacters(string accountId);

        Task NotifyAccountOfDeletedCharacters(string accountId);

        Task RemoveNotification(string accountId);

        NotificationStatus IsUserNotified(string accountId);

    }
}
