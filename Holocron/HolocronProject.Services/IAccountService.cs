﻿using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using Microsoft.AspNetCore.Http;

namespace HolocronProject.Services
{
    public interface IAccountService
    {
        Task UpdateForumSignatureAsync(string accountId, string forumSignature);

        Task UpdateUserNameAndAvatarImagePathAsync(string accountId, string newAccountName);

        Account GetAccountById(string accountId);

        Task CreateAvatarImageAsync(string accountId, IFormFile image);

        Task UpdateAvatarImageAsync(string accountId, IFormFile avatarImage);

        string GetAccountAvatarImagePath(string accountId);

        bool IsAvatarImageSet(string accountId);


    }
}
