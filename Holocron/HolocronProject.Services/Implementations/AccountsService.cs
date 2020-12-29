using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

using Microsoft.AspNetCore.Http;

namespace HolocronProject.Services.Implementations
{

    public class AccountsService : IAccountsService
    {
        private ApplicationDbContext context;
        private readonly IPostsService postsService;
        private readonly IThreadsService threadsService;
        private readonly ICompetitionAccountsService competitionAccountsService;
        private readonly ICompetitionCharactersService competitionCharactersService;

        public AccountsService(ApplicationDbContext context,
            IPostsService postsService,
            IThreadsService threadsService,
            ICompetitionAccountsService competitionAccountsService,
            ICompetitionCharactersService competitionCharactersService)
        {
            this.context = context;
            this.postsService = postsService;
            this.threadsService = threadsService;
            this.competitionAccountsService = competitionAccountsService;
            this.competitionCharactersService = competitionCharactersService;
        }

        public async Task BanAccountAsync(string accountId)
        {
            var account = this.GetAccountById(accountId);

            account.IsBanned = true;
            account.BannedOn = DateTime.UtcNow;

            await this.postsService.DeleteAllPostsByAccountIdAsync(accountId);
            await this.threadsService.DeleteAllThreadsByAccountId(accountId);
            await this.competitionCharactersService.DeleteAllCompetitionCharactersByAccountId(accountId);
            await this.competitionAccountsService.DeleteAllCompetitionAccountsByAccountId(accountId);

            await this.context.SaveChangesAsync();
        }

        public async Task UpdateForumSignatureAsync(string accountId, string forumSignature)
        {
            var account = GetAccountById(accountId);

            account.ForumSignature = forumSignature;

            await this.context.SaveChangesAsync();
        }

        public async Task UpdateUserNameAsync(string accountId, string newUserName)
        {
            var account = GetAccountById(accountId);

            account.UserName = newUserName;
            account.NormalizedUserName = newUserName.ToUpper();

            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAvatarImagePathAsync(string accountId)
        {
            var account = GetAccountById(accountId);

            account.AvatarImagePath = $"{account.Id}(Account).png";

            await this.context.SaveChangesAsync();
        }

        public async Task CreateAvatarImageAsync(string webRootFolder, string accountId, IFormFile image)
        {
            var account = this.GetAccountById(accountId);

            account.AvatarImagePath = $"{account.Id}(Account).png";
            using (var fs = new FileStream(
                 $"{webRootFolder}/Images/AvatarImages/{account.AvatarImagePath}", FileMode.Create))
            {
                await image.CopyToAsync(fs);
            }

            await this.context.SaveChangesAsync();
        }

        public async Task AddDefaultAvatarImagePathAsync(string accountId)
        {
            var account = this.GetAccountById(accountId);

            account.AvatarImagePath = "defaultAvatar.jpg";

            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAvatarImageAsync(string webRootFolder, string accountId, IFormFile avatarImage)
        {
            var account = this.GetAccountById(accountId);

            if (account.AvatarImagePath != "defaultAvatar.jpg")
            {
                if (File.Exists($"{webRootFolder}/Images/AvatarImages/{account.AvatarImagePath}"))
                {
                    File.Delete($"{webRootFolder}/Images/AvatarImages/{account.AvatarImagePath}");
                }
            }

            account.AvatarImagePath = $"{account.Id}(Account).png";
            using (var fs = new FileStream(
                $"{webRootFolder}/Images/AvatarImages/{account.AvatarImagePath}", FileMode.Create))
            {
                await avatarImage.CopyToAsync(fs);
            }

            await this.context.SaveChangesAsync();
        }

        public Account GetAccountById(string accountId)
           => this.context.Accounts
               .FirstOrDefault(x => x.Id == accountId);

        public string GetAccountAvatarImagePath(string accountId)
        {
            var account = this.GetAccountById(accountId);

            return account.AvatarImagePath;
        }

        public bool IsAvatarImageSet(string webRootFolder, string accountId)
        {
            var account = GetAccountById(accountId);

            return File.Exists($"{webRootFolder}/Images/AvatarImages/{account.AvatarImagePath}");
        }

        public async Task NotifyAccountOfApprovedCharactersAsync(string accountId)
        {
            var account = this.GetAccountById(accountId);

            account.NotificationStatus = NotificationStatus.HasApprovedCharacters;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task NotifyAccountOfPendingCharactersAsync(string accountId)
        {
            var account = this.GetAccountById(accountId);

            account.NotificationStatus = NotificationStatus.HasPendingCharacters;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task NotifyAccountOfDeletedCharactersAsync(string accountId)
        {
            var account = this.GetAccountById(accountId);

            account.NotificationStatus = NotificationStatus.HasDeletedCharacters;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task RemoveNotificationAsync(string accountId)
        {
            var account = this.GetAccountById(accountId);

            account.NotificationStatus = NotificationStatus.HasNoPendingOrApprovedCharacters;
            
            await this.context.SaveChangesAsync();
        }

        public NotificationStatus IsUserNotified(string accountId)
            => this.context.Accounts
            .Where(x => x.Id == accountId)
            .FirstOrDefault()
            .NotificationStatus;

        public T GetAccountByIdGeneric<T>(string accountId, IMapper mapper = null)
            => this.context.Accounts
            .Where(x => x.Id == accountId)
            .To<T>(mapper)
            .FirstOrDefault();

        public IEnumerable<T> GetAllAccounts<T>(string accountId, IMapper mapper = null)
            => this.context.Accounts
            .Where(x => x.Id != accountId)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public int TotalAccounts()
            => this.context.Accounts
            .Count();

        public bool IsAccountBanned(string accountId)
            => this.context.Accounts
            .Any(x => x.UserName == accountId && x.IsBanned);

        public bool IsEmailTaken(string email)
            => this.context.Accounts
            .Any(x => x.Email == email);
    }
}
