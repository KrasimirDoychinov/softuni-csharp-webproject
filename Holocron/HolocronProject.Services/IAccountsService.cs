using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using Microsoft.AspNetCore.Http;
using HolocronProject.Data.Enums;
using AutoMapper;

namespace HolocronProject.Services
{
    public interface IAccountsService
    {
        Task BanAccountAsync(string accountId);

        Task UpdateForumSignatureAsync(string accountId, string forumSignature);

        Task UpdateUserNameAsync(string accountId, string newAccountName);

        Task UpdateAvatarImagePathAsync(string accountId);

        Task NotifyAccountOfApprovedCharactersAsync(string accountId);

        Task NotifyAccountOfPendingCharactersAsync(string accountId);

        Task NotifyAccountOfDeletedCharactersAsync(string accountId);

        Task RemoveNotificationAsync(string accountId);
        
        Task CreateAvatarImageAsync(string accountId, IFormFile image);

        Task UpdateAvatarImageAsync(string accountId, IFormFile avatarImage);

        Task AddDefaultAvatarImagePathAsync(string accountId);

        Account GetAccountById(string accountId);

        T GetAccountByIdGeneric<T>(string accountId, IMapper mapper = null);

        IEnumerable<T> GetLatestAccounts<T>(string accountId, IMapper mapper = null);

        NotificationStatus IsUserNotified(string accountId);

        string GetAccountAvatarImagePath(string accountId);

        bool IsAvatarImageSet(string accountId);

        bool IsAccountBanned(string accountId);

        int TotalAccounts();
    }
}
