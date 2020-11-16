using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using Microsoft.AspNetCore.Http;

namespace HolocronProject.Services
{
    public interface IAccountService
    {
        Task UpdateForumSignatureAsync(string userId, string forumSignature);

        Task UpdateUserNameAndAvatarImagePathAsync(string userId, string newAccountName);

        Account GetAccountById(string userId);

        Task CreateAvatarImageAsync(string userId, IFormFile image);

        Task UpdateAvatarImageAsync(string userId, IFormFile avatarImage);


    }
}
