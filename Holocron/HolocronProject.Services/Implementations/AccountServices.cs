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


        public async Task UpdateUserNameAsync(string accountId, string newUserName)
        {
            var account = GetAccountById(accountId);

            account.UserName = newUserName;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public Account GetAccountById(string accountId)
            => this.context.Accounts
                .FirstOrDefault(x => x.Id == accountId);


    }
}
