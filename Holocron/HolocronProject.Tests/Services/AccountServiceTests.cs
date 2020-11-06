using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using HolocronProject.Data;
using HolocronProject.Services;
using System.Linq;
using HolocronProject.Data.Models;
using System.Security.Cryptography;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class AccountServiceTests
    {
        private Account testAccount;
        private HolocronDbContext context;
        private IAccountService accountService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.accountService = new AccountServices(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();

            await this.accountService.CreateAccount("TestSetup", "TestSetup", "TestSetup");
            testAccount = this.context.Accounts
                .Where(x => x.AccountName == "TestSetup")
                .FirstOrDefault();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [TestCase("TestAccountName1", "TestPass1", "TestDisplayName1")]
        [TestCase("TestAccountName2", "TestPass2", "TestDisplayName2")]
        [TestCase("TestAccountName3", "TestPass3", "TestDisplayName3")]
        public async Task CreateAccountCreatesAccountAndIncreasesAccountsCount(string accountName, string password, string displayName)
        {
            await this.accountService.CreateAccount(accountName, password, displayName);

            var actualResult = this.context.Accounts.Count();
            var expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Test Signature1")]
        [TestCase("Test Signature2")]
        [TestCase("Test Signature3")]
        public async Task UpdateForumSignatureUpdatesSignature(string forumSignature)
        {
            await this.accountService.UpdateForumSignature(testAccount.Id, forumSignature);

            var actualResult = testAccount.ForumSignature;
            var expectedResult = forumSignature;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Avatar Image1")]
        [TestCase("Avatar Image2")]
        [TestCase("Avatar Image3")]
        public async Task UpdateAvatarImageShouldChangeAvatarImage(string avatarImage)
        {
            await this.accountService.UpdateAvatarImage(testAccount.Id, avatarImage);

            var actualResult = testAccount.AvatarImage;
            var expectedResult = avatarImage;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Test DisplayName1")]
        [TestCase("Test DisplayName2")]
        [TestCase("Test DisplayName3")]
        public async Task UpdateDisplayNameShouldChangeDisplayName(string displayName)
        {
            await this.accountService.UpdateDisplayName(testAccount.Id, displayName);

            var actualResult = testAccount.DisplayName;
            var expectedResult = displayName;

            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestCase("Test AccountName1")]
        [TestCase("Test AccountName2")]
        [TestCase("Test AccountName3")]
        public async Task UpdateAccountNameChangesAccountName(string accountName)
        {
            await this.accountService.UpdateAccountName(testAccount.Id, accountName);

            var actualResult = testAccount.AccountName;
            var expectedResult = accountName;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Test Password1")]
        [TestCase("Test Password2")]
        [TestCase("Test Password3")]
        public async Task UpdatePasswordChangesPassword(string password)
        {
            await this.accountService.UpdatePassword(testAccount.Id, password);

            var actualResult = testAccount.Password;
            var expectedResult = HashPassword(password);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("TestSetup", "TestSetup")]
        public void GetAccountByNameAndPasswordReturnsCorrectAccount(string username, string password) 
        {
            var account = this.accountService.GetAccountByNameAndPassword(username, password);

            var actualResult = account.AccountName;
            var expectedResult = testAccount.AccountName;

            Assert.AreEqual(expectedResult, actualResult);

        }

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
