using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;

namespace HolocronProject.Services.Implementations
{

    public class AccountServices : IAccountService
    {
        private HolocronDbContext context;
        private readonly IMapper mapper;

        public AccountServices(HolocronDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task UpdateForumSignatureAsync(string accountId, string forumSignature)
        {
            var account = GetAccountById(accountId);

            account.ForumSignature = forumSignature;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAvatarImageAsync(string accountId, string avatarImage)
        {
            var account = GetAccountById(accountId);

            account.AvatarImage = avatarImage;

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

        public Account GetAccountById(string accountId)
            => this.context.Accounts
            .FirstOrDefault(x => x.Id == accountId);

        public ForeignAccountDto GetForeignAccount(string accountId)
        {
            var foreignAcc = this.context.Accounts
            .FirstOrDefault(x => x.Id == accountId);

            return mapper.Map<ForeignAccountDto>(foreignAcc);
        }
            

        public bool IsDisplayNameTaken(string displayName)
            => this.context.Accounts
            .Any(x => x.DisplayName == displayName);
    }
}
