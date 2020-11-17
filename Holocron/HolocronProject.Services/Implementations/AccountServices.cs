using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Services.Models;
using Microsoft.AspNetCore.Http;

namespace HolocronProject.Services.Implementations
{

    public class AccountServices : IAccountService
    {
        private HolocronDbContext context;

        public AccountServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task UpdateForumSignatureAsync(string userId, string forumSignature)
        {
            var account = GetAccountById(userId);

            account.ForumSignature = forumSignature;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateUserNameAndAvatarImagePathAsync(string userId, string newUserName)
        {
            var user = GetAccountById(userId);

            user.UserName = newUserName;
            user.NormalizedUserName = newUserName.ToUpper();
            user.AvatarImagePath = $"{user.Id}(Account).png";

            this.context.Accounts.Update(user);
            await this.context.SaveChangesAsync();
        }

        public async Task CreateAvatarImageAsync(string userId, IFormFile image)
        {
            var user = this.GetAccountById(userId);

            user.AvatarImagePath = $"{user.Id}(Account).png";
            using (var fs = new FileStream(
                 $"wwwroot/Images/AvatarImages/{user.AvatarImagePath}", FileMode.Create))
            {

                await image.CopyToAsync(fs);
            }

            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAvatarImageAsync(string userId, IFormFile avatarImage)
        {
            var user = this.GetAccountById(userId);

            File.Delete($"wwwroot/Images/AvatarImages/{user.AvatarImagePath}.png");
            user.AvatarImagePath = $"{user.Id}(Account).png";
            using (var fs = new FileStream(
                $"wwwroot/Images/AvatarImages/{user.AvatarImagePath}", FileMode.Create))
            {
                await avatarImage.CopyToAsync(fs);
            }

            await this.context.SaveChangesAsync();
        }

        public Account GetAccountById(string userId)
           => this.context.Accounts
               .FirstOrDefault(x => x.Id == userId);

        public string GetAccountAvatarImagePath(string userId)
        {
            var user = this.GetAccountById(userId);

            return user.AvatarImagePath;
        }
    }
}
