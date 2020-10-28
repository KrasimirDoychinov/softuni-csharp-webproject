using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography;

using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;

using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace HolocronProject.Services
{

    public class AccountService : IAccountService
    {
        private IConfigurationProvider config;
        private HolocronDbContext context;

        public AccountService(IConfigurationProvider config,
            HolocronDbContext context)
        {
            this.context = context;
            this.config = config;
        }

        

        public async Task CreateAccount(string accountName, string password, string displayName)
        {
            var account = new Account
            {
                AccountName = accountName,
                Password = HashPassword(password),
                DisplayName = displayName
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateForumSignature(string accountId, string forumSignature)
        {
            var account = GetAccountById(accountId);

            account.ForumSignature = forumSignature;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UptadeImage(string accountId, string avatarImage)
        {
            var account = GetAccountById(accountId);

            account.AvatarImage = avatarImage;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdatePassword(string accountId, string newPassword)
        {
            var account = GetAccountById(accountId);

            account.Password = HashPassword(newPassword);

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateDisplayName(string accountId, string newDisplayName)
        {
            var account = GetAccountById(accountId);

            account.DisplayName = newDisplayName;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAccountName(string accountId, string newAccountName)
        {
            var account = GetAccountById(accountId);

            account.AccountName = newAccountName;

            this.context.Accounts.Update(account);
            await this.context.SaveChangesAsync();
        }

        public Account GetAccountById(string accountId)
            => this.context.Accounts
            .FirstOrDefault(x => x.Id == accountId);

        public Account GetAccountByIdAndPassword(string accountId, string password)
            => this.context.Accounts
            .FirstOrDefault(x => x.Id == accountId && x.Password == HashPassword(password));

        private static string HashPassword(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

        

    }
}
