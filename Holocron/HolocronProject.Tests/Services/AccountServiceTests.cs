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
using HolocronProject.Services.Implementations;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class AccountServiceTests
    {
        private Account testAccount;
        private HolocronDbContext context;
        private IAccountsService accountService;

        //[SetUp]
        //public async Task SetUp()
        //{
        //    this.context = new HolocronDbContext();
        //    this.accountService = new AccountsService(context);

        //    await this.context.Database.EnsureDeletedAsync();
        //    await this.context.Database.EnsureCreatedAsync();

        //    testAccount = this.context.Accounts
        //        .Where(x => x.UserName == "TestSetup")
        //        .FirstOrDefault();
        //}

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }


        [TestCase("Test Signature1")]
        [TestCase("Test Signature2")]
        [TestCase("Test Signature3")]
        public async Task UpdateForumSignatureUpdatesSignature(string forumSignature)
        {
            await this.accountService.UpdateForumSignatureAsync(testAccount.Id, forumSignature);

            var actualResult = testAccount.ForumSignature;
            var expectedResult = forumSignature;

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestCase("Avatar Image1")]
        //[TestCase("Avatar Image2")]
        //[TestCase("Avatar Image3")]
        //public async Task UpdateAvatarImageShouldChangeAvatarImage(string avatarImagePath)
        //{
        //    await this.accountService.UpdateAvatarImageAsync(testAccount.Id, avatarImagePath);

        //    var actualResult = testAccount.AvatarImagePath;
        //    var expectedResult = avatarImagePath;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestCase("Test DisplayName1")]
        //[TestCase("Test DisplayName2")]
        //[TestCase("Test DisplayName3")]
        //public async Task UpdateDisplayNameShouldChangeDisplayName(string displayName)
        //{
        //    await this.accountService.UpdateDisplayNameAsync(testAccount.Id, displayName);

        //    var actualResult = testAccount.DisplayName;
        //    var expectedResult = displayName;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        
        [TestCase("Test AccountName1")]
        [TestCase("Test AccountName2")]
        [TestCase("Test AccountName3")]
        public async Task UpdateAccountNameChangesAccountName(string newUserName)
        {
            await this.accountService.UpdateUserNameAsync(testAccount.Id, newUserName);

            var actualResult = testAccount.UserName;
            var expectedResult = newUserName;

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
