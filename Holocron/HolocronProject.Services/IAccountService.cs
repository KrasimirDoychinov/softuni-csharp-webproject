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

        Task UpdateUserNameAsync(string accountId, string newAccountName);

        Account GetAccountById(string accountId);


    }
}
