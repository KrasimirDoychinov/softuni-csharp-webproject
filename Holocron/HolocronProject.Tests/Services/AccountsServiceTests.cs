using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

using Moq;
using AutoMapper;
using NUnit.Framework;

using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Accounts;
using HolocronProject.Services.Implementations;
using HolocronProject.Web.Areas.Administration.ViewModels.Accounts;

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class AccountsServiceTests
    {
        private ApplicationDbContext context;
        private IAccountsService accountService;
        private IFormFile file;
        private string testRootFilePath = "/TestFiles";

        private int postCount = 10;
        private int threadCount = 10;
        private int competitionAccountsCount = 10;
        private int competitionCharactersCount = 10;

        [SetUp]
        public async Task SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.context = new ApplicationDbContext(optionsBuilder);

            var mockedIPostsService = new Mock<IPostsService>();
            var mockedIThreadsService = new Mock<IThreadsService>();
            var mockedICompetitionsAccountsService = new Mock<ICompetitionAccountsService>();
            var mockedICompetitionsCharactersService = new Mock<ICompetitionCharactersService>();

            mockedIPostsService.Setup(x => x.DeleteAllPostsByAccountIdAsync(It.IsAny<string>()))
                .Returns(async () => this.postCount = 0);

            mockedIThreadsService.Setup(x => x.DeleteAllThreadsByAccountId(It.IsAny<string>()))
                .Returns(async () => this.threadCount = 0);

            mockedICompetitionsAccountsService.Setup(x => x.DeleteAllCompetitionAccountsByAccountId(It.IsAny<string>()))
                .Returns(async () => this.competitionAccountsCount = 0);

            mockedICompetitionsCharactersService.Setup(x => x.DeleteAllCompetitionCharactersByAccountId(It.IsAny<string>()))
               .Returns(async () => this.competitionCharactersCount = 0);

            this.accountService = new AccountsService(context, mockedIPostsService.Object, 
                mockedIThreadsService.Object, 
                mockedICompetitionsAccountsService.Object,
                mockedICompetitionsCharactersService.Object);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            this.file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0, "Data", "dummy.txt");
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task UpdateForumSignatureShouldUpdateForumSignature()
        {
            var account = new Account
            {
                Id = "1",
                ForumSignature = "None"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.UpdateForumSignatureAsync("1", "New sigs");

            Assert.AreEqual("New sigs", account.ForumSignature);
        }

        [Test]
        public async Task UpdateUserNameShouldUptadeUserName()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Oldusername",
                NormalizedUserName = "OLDUSERNAME"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.UpdateUserNameAsync("1", "Newusername");

            Assert.AreEqual("Newusername", account.UserName);
            Assert.AreEqual("NEWUSERNAME", account.NormalizedUserName);
        }

        [Test]
        public async Task UpdateAvatarImagePathShouldUpdateAvatarImagePath()
        {
            var account = new Account
            {
                Id = "1",
                AvatarImagePath = "None"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.UpdateAvatarImagePathAsync("1");

            Assert.AreEqual("1(Account).png", account.AvatarImagePath);
        }

        [Test]
        public async Task CreateAvatarImageShouldCreateImageInWwwrootImagesAvatarImagesLocation()
        {
            var account = new Account
            {
                Id = "1",
                AvatarImagePath = "None"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.CreateAvatarImageAsync(this.testRootFilePath, "1", this.file);

            Assert.AreEqual("1(Account).png", account.AvatarImagePath);
        }

        [Test]
        public async Task UpdateAvatarImageShouldUpdateAvatarImage()
        {
            var account = new Account
            {
                Id = "1",
                AvatarImagePath = "None"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.UpdateAvatarImageAsync(this.testRootFilePath, "1", this.file);

            Assert.AreEqual("1(Account).png", account.AvatarImagePath);
        }

        [Test]
        public async Task GetAccountByIdShouldReturnCorrectAccount()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test username"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            var newAccount = this.accountService.GetAccountById("1");

            Assert.AreEqual(newAccount, account);
        }

        [Test]
        public async Task GetAccountAvatarImagePathShouldReturnCorrectPath()
        {
            var account = new Account
            {
                Id = "1",
                AvatarImagePath = "Test path"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            var path = this.accountService.GetAccountAvatarImagePath("1");

            Assert.AreEqual(path, account.AvatarImagePath);
        }

        [Test]
        public async Task IsAvatarImageSetShouldReturnTrueIfSet()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.CreateAvatarImageAsync(this.testRootFilePath, "1", this.file);
            var isSet = accountService.IsAvatarImageSet(this.testRootFilePath, "1");

            Assert.True(isSet);
        }

        [Test]
        public async Task IsAvatarImageSetShouldReturnFlaseIfNotSet()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            var isSet = this.accountService.IsAvatarImageSet(null, "1");

            Assert.False(isSet);
        }

        [Test]
        public async Task NotifyAccountOfApprovedCharactersShouldSetNotificationStatusToHasApproved()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.NotifyAccountOfApprovedCharactersAsync("1");

            Assert.AreEqual(NotificationStatus.HasApprovedCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task NotifyAccountOfPendingCharactersShouldSetNotificationStatusToHasPending()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.NotifyAccountOfPendingCharactersAsync("1");

            Assert.AreEqual(NotificationStatus.HasPendingCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task NotifyAccountOfApprovedCharactersShouldSetNotificationStatusToHasApprovedWhenCharacterIsApprovedByAdmin()
        {
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

            await this.context.Accounts.AddAsync(account);
            await this.context.Characters.AddAsync(character);
            await this.context.SaveChangesAsync();

            await characterService.ApproveCharacterAsync("1", "1");

            Assert.AreEqual(NotificationStatus.HasApprovedCharacters, account.NotificationStatus);
            Assert.AreEqual(CharacterStatus.Approved, character.CharacterStatus);
        }

        [Test]
        public async Task NotifyAccountOfDeletedCharactersShouldSetNotificationStatusToHasDeleted()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.NotifyAccountOfDeletedCharactersAsync("1");

            Assert.AreEqual(NotificationStatus.HasDeletedCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task NotifyAccountOfDeletedCharactersShouldSetNotificationStatusToHasDeletedWhenCharacterIsDeletedByAdmin()
        {
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

            await this.context.Accounts.AddAsync(account);
            await this.context.Characters.AddAsync(character);
            await this.context.SaveChangesAsync();

            await characterService.DeleteCharacterAsync("1", "1");

            Assert.AreEqual(NotificationStatus.HasDeletedCharacters, account.NotificationStatus);
            Assert.AreEqual(CharacterStatus.Deleted, character.CharacterStatus);
        }

        [Test]
        public async Task IsUserNotifiedShouldReturnCorrectNotificationStatus()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await accountService.NotifyAccountOfApprovedCharactersAsync("1");
            var status = accountService.IsUserNotified("1");

            Assert.AreEqual(status, account.NotificationStatus);
        }

        [Test]
        public async Task RemoveNotificationShouldSetNotificationStatusToHasNoPendingOrApproved()
        {

            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.RemoveNotificationAsync("1");

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

            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            var mappedModel = accountService.GetAccountByIdGeneric<ForeignAccountViewModel>("1", mapper);

            Assert.AreEqual(NotificationStatus.HasNoPendingOrApprovedCharacters, account.NotificationStatus);
        }

        [Test]
        public async Task TotalAccountsShouldReturnCorrectValue()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            var serviceAccountCount = this.accountService.TotalAccounts();

            Assert.AreEqual(1, serviceAccountCount);
        }

        [Test]
        public async Task BanAccountBansAccount()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.BanAccountAsync("1");

            Assert.True(account.IsBanned);
            Assert.AreEqual(0, this.postCount);
            Assert.AreEqual(0, this.threadCount);
            Assert.AreEqual(0, this.competitionAccountsCount);
        }

        [Test]
        public async Task AddDefaultAvatarImagePathAddsDefaultAvatarAsImagePath()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.AddDefaultAvatarImagePathAsync("1");

            Assert.AreEqual("defaultAvatar.jpg", account.AvatarImagePath);
        }

        [Test]
        public async Task GetAllAccountsReturnsAllAccountsExceptGivenOne()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Account, NewestAccountsViewModel>();
            });

            var mapper = config.CreateMapper();

            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            var mappedEntity =  this.accountService.GetAllAccounts<NewestAccountsViewModel>("1", mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task IsAccountBannedReturnsCorrectValue()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Account, NewestAccountsViewModel>();
            });

            var mapper = config.CreateMapper();

            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.BanAccountAsync("1");
            var isAccountBanned = this.accountService.IsAccountBanned("Test");

            Assert.True(isAccountBanned);
        }

        [Test]
        public async Task IsEmailTakenShouldReturnCorrectValue()
        {
            var account = new Account
            {
                Id = "1",
                Email = "Test@gmail.com"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.accountService.BanAccountAsync("1");
            var isEmailTaken = this.accountService.IsEmailTaken("Test@gmail.com");

            Assert.True(isEmailTaken);
        }
    }
}
