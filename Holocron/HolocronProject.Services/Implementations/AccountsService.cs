using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using Microsoft.AspNetCore.Http;

namespace HolocronProject.Services.Implementations
{

    public class AccountsService : IAccountsService
    {
        private HolocronDbContext context;

        public AccountsService(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task UpdateForumSignatureAsync(string accountId, string forumSignature)
        {
            var account = GetAccountById(accountId);

            account.ForumSignature = forumSignature;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateUserNameAsync(string accountId, string newUserName)
        {
            var account = GetAccountById(accountId);

            account.UserName = newUserName;
            account.NormalizedUserName = newUserName.ToUpper();
            await UpdateAvatarImagePathAsync(accountId);

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAvatarImagePathAsync(string accountId)
        {
            var account = GetAccountById(accountId);

            account.AvatarImagePath = $"{account.Id}(Account).png";

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task CreateAvatarImageAsync(string accountId, IFormFile image)
        {
            var account = this.GetAccountById(accountId);

            account.AvatarImagePath = $"{account.Id}(Account).png";
            using (var fs = new FileStream(
                 $"wwwroot/Images/AvatarImages/{account.AvatarImagePath}", FileMode.Create))
            {

                await image.CopyToAsync(fs);
            }

            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAvatarImageAsync(string accountId, IFormFile avatarImage)
        {
            var account = this.GetAccountById(accountId);

            File.Delete($"wwwroot/Images/AvatarImages/{account.AvatarImagePath}");
            account.AvatarImagePath = $"{account.Id}(Account).png";
            using (var fs = new FileStream(
                $"wwwroot/Images/AvatarImages/{account.AvatarImagePath}", FileMode.Create))
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
        public T GetAccountByIdGeneric<T>(string accountId)
            => this.context.Accounts
            .Where(x => x.Id == accountId)
            .To<T>()
            .FirstOrDefault();

        public bool IsAvatarImageSet(string accountId)
        {
            var account = GetAccountById(accountId);

            return File.Exists($"wwwroot/Images/AvatarImages/{account.AvatarImagePath}");
        }

        
    }
}
