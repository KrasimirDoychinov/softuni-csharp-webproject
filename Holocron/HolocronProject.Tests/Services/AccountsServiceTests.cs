using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Microsoft.AspNetCore.Http;
using System.IO;
using HolocronProject.Web.ViewModels.Accounts;
using AutoMapper;
using Moq;
using HolocronProject.Services.Mapper;
using HolocronProject.Data.Enums;
using HolocronProject.Services.Models.Character;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class AccountsServiceTests
    {
        [Test]
        public async Task UpdateForumSignatureShouldUpdateForumSignature()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1",
                ForumSignature = "None"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.UpdateForumSignatureAsync("1", "New sigs");

            Assert.AreEqual("New sigs", account.ForumSignature);
        }

        [Test]
        public async Task UpdateUserNameShouldUptadeUserName()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1",
                UserName = "Oldusername",
                NormalizedUserName = "OLDUSERNAME"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.UpdateUserNameAsync("1", "Newusername");

            Assert.AreEqual("Newusername", account.UserName);
            Assert.AreEqual("NEWUSERNAME", account.NormalizedUserName);
        }

        [Test]
        public async Task UpdateAvatarImagePathShouldUpdateAvatarImagePath()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1",
                AvatarImagePath = "None"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.UpdateAvatarImagePathAsync("1");

            Assert.AreEqual("1(Account).png", account.AvatarImagePath);
        }

        [Test]
        public async Task CreateAvatarImageShouldCreateImageInWwwrootImagesAvatarImagesLocation()
        {
            IFormFile file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0, "Data", "dummy.txt");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1",
                AvatarImagePath = "None"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.CreateAvatarImageAsync("1", file);

            Assert.AreEqual("1(Account).png", account.AvatarImagePath);
        }

        [Test]
        public async Task UpdateAvatarImageShouldUpdateAvatarImage()
        {
            IFormFile file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0, "Data", "dummy.txt");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1",
                AvatarImagePath = "None"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.UpdateAvatarImageAsync("1", file);

            Assert.AreEqual("1(Account).png", account.AvatarImagePath);
        }

        [Test]
        public async Task GetAccountByIdShouldReturnCorrectAccount()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1",
                UserName = "Test username"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            var newAccount = accountService.GetAccountById("1");

            Assert.AreEqual(newAccount, account);
        }

        [Test]
        public async Task GetAccountAvatarImagePathShouldReturnCorrectPath()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1",
                AvatarImagePath = "Test path"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            var path = accountService.GetAccountAvatarImagePath("1");

            Assert.AreEqual(path, account.AvatarImagePath);
        }

        [Test]
        public async Task IsAvatarImageSetShouldReturnTrueIfSet()
        {
            IFormFile file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0, "Data", "dummy.txt");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase(Guid.NewGuid().ToString())
               .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.CreateAvatarImageAsync("1", file);
            var isSet = accountService.IsAvatarImageSet("1");

            Assert.True(isSet);
        }

        [Test]
        public async Task IsAvatarImageSetShouldReturnFlaseIfNotSet()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase(Guid.NewGuid().ToString())
               .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            var isSet = accountService.IsAvatarImageSet("1");

            Assert.False(isSet);
        }

        [Test]
        public async Task NotifyAccountOfApprovedCharactersShouldSetNotificationStatusToHasApproved()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.NotifyAccountOfApprovedCharactersAsync("1");

            Assert.AreEqual(NotificationStatus.HasApprovedCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task NotifyAccountOfPendingCharactersShouldSetNotificationStatusToHasPending()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.NotifyAccountOfPendingCharactersAsync("1");

            Assert.AreEqual(NotificationStatus.HasPendingCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task NotifyAccountOfApprovedCharactersShouldSetNotificationStatusToHasApprovedWhenCharacterIsApprovedByAdmin()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);
            var characterService = new CharactersService(context, accountService);

            var account = new Account
            {
                Id = "1",
                NotificationStatus = NotificationStatus.HasNoPendingOrApprovedCharacters
            };

            var character = new Character
            {
                Id = "1",
                Account = account,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Accounts.AddAsync(account);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            await characterService.ApproveCharacterAsync("1", "1");

            Assert.AreEqual(NotificationStatus.HasApprovedCharacters, account.NotificationStatus);
            Assert.AreEqual(CharacterStatus.Approved, character.CharacterStatus);
        }

        [Test]
        public async Task NotifyAccountOfDeletedCharactersShouldSetNotificationStatusToHasDeleted()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.NotifyAccountOfDeletedCharactersAsync("1");

            Assert.AreEqual(NotificationStatus.HasDeletedCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task NotifyAccountOfDeletedCharactersShouldSetNotificationStatusToHasDeletedWhenCharacterIsDeletedByAdmin()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);
            var characterService = new CharactersService(context, accountService);

            var account = new Account
            {
                Id = "1",
                NotificationStatus = NotificationStatus.HasNoPendingOrApprovedCharacters
            };

            var character = new Character
            {
                Id = "1",
                Account = account,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Accounts.AddAsync(account);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            await characterService.DeleteCharacterAsync("1", "1");

            Assert.AreEqual(NotificationStatus.HasDeletedCharacters, account.NotificationStatus);
            Assert.AreEqual(CharacterStatus.Deleted, character.CharacterStatus);
        }

        [Test]
        public async Task IsUserNotifiedShouldReturnCorrectNotificationStatus()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.NotifyAccountOfApprovedCharactersAsync("1");
            var status = accountService.IsUserNotified("1");

            Assert.AreEqual(status, account.NotificationStatus);
        }

        [Test]
        public async Task RemoveNotificationShouldSetNotificationStatusToHasNoPendingOrApproved()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await accountService.RemoveNotificationAsync("1");

            Assert.AreEqual(NotificationStatus.HasNoPendingOrApprovedCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task GetAccountByIdGenericShouldReturnCorrectMappedEntity()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Account, ForeignAccountViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            var mappedModel = accountService.GetAccountByIdGeneric<ForeignAccountViewModel>("1", mapper);

            Assert.AreEqual(NotificationStatus.HasNoPendingOrApprovedCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task TotalAccountsShouldReturnCorrectValue()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountService = new AccountsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            var serviceAccountCount = accountService.TotalAccounts();
            var contextAccountCount = await context.Accounts.CountAsync();

            Assert.AreEqual(contextAccountCount, serviceAccountCount);
        }
    }
}
