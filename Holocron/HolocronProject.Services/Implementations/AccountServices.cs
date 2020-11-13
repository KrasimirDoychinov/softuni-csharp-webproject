using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Services.Models;

namespace HolocronProject.Services.Implementations
{

    public class AccountServices : IAccountService
    {
        private HolocronDbContext context;

        public AccountServices(HolocronDbContext context)
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

        public async Task UpdateAvatarImageAsync(string accountId, string avatarImagePath)
        {
            var account = GetAccountById(accountId);

            account.AvatarImagePath = avatarImagePath;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateDisplayNameAsync(string accountId, string newDisplayName)
        {
            var account = GetAccountById(accountId);

            account.DisplayName = newDisplayName;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAccountNameAsync(string accountId, string newUserName)
        {
            var account = GetAccountById(accountId);

            account.UserName = newUserName;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public T GetForeignAccount<T>(string accountId)
        {
            return this.context.Accounts
                .Where(x => x.Id == accountId)
                .To<T>()
                .FirstOrDefault();
        }
            
        public bool IsDisplayNameTaken(string displayName)
            => this.context.Accounts
            .Any(x => x.DisplayName == displayName);

        public Account GetAccountById(string accountId)
            => this.context.Accounts
            .FirstOrDefault(x => x.Id == accountId);
    }
}
