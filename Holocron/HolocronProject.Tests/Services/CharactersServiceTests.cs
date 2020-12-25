using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Services.Models.Character;
using HolocronProject.Services.Models.Characters;
using HolocronProject.Web.ViewModels.Achievements;
using HolocronProject.Web.ViewModels.Characters;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    public class CharactersServiceTests
    {
        private ApplicationDbContext context;
        private ICharactersService charactersService;
        private IMapper mapper;
        private IFormFile file;

        [SetUp]
        public async Task SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.context = new ApplicationDbContext(optionsBuilder);
            this.file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0, "Data", "dummy.txt");
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            var IMockedAccountsService = new Mock<IAccountsService>();
            this.charactersService = new CharactersService(context, IMockedAccountsService.Object);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
                opts.CreateMap<Character, CharacterUserViewModel>();
                opts.CreateMap<Achievement, AchievementViewModel>();
            });

            this.mapper = config.CreateMapper();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateCharacterShouldCreateCharacter()
        {
            var race = new Race
            {
                Id = "1"
            };

            var server = new Server
            {
                Id = "1"
            };

            var @class = new Class
            {
                Id = "1"
            };

            var characterDto = new CharacterInputDto
            {
                AccountId = "1",
                Name = "Test",
                Backstory = "Test",
                Description = "Test",
                Title = "Test",
                Gender = Gender.Male,
                CharacterType = CharacterType.Fashion,
                ForceAffiliation = ForceAffiliation.DarkSide,
                ClassId = "1",
                RaceId = "1",
                ServerId = "1"
            };

            await context.Races.AddAsync(race);
            await context.Servers.AddAsync(server);
            await context.Classes.AddAsync(@class);
            await context.SaveChangesAsync();

            await this.charactersService.CreateCharacterAsync(characterDto);

            var characterCount = await context.Characters.CountAsync();

            Assert.AreEqual(1, characterCount);
        }

        [Test]
        public async Task GetCurrentAccountCharactersShouldReturnAllAccountCharactersAndAllApproved()
        {
            var account = new Account
            {
                Id = "1"
            };

            var character = new Character
            {
                Id = "1",
                Account = account,
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Name = "Test" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Approved
            };

            await context.Accounts.AddAsync(account);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity = this.charactersService.GetCurrentAccountCharacters<CharacterListViewModel>("1", this.mapper).ToList();

            var characterCount = await context.Characters.Where(x => x.AccountId == "1" && x.CharacterStatus == CharacterStatus.Approved).CountAsync();

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetCurrentAccountCharactersShouldReturnNothingBecauseAllArePendingOrDeleted()
        {
            var account = new Account
            {
                Id = "1"
            };

            var character = new Character
            {
                Id = "1",
                Account = account,
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Name = "Test" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Accounts.AddAsync(account);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity = charactersService.GetCurrentAccountCharacters<CharacterListViewModel>("1", mapper).ToList();

            var characterCount = await context.Characters.Where(x => x.AccountId == "1" && x.CharacterStatus == CharacterStatus.Approved).CountAsync();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetCurrentAccountCharacterForCompetitionShouldReturnCharacterThatIsNotInCompetition()
        {
            var account = new Account
            {
                Id = "1"
            };

            var competition = new Competition
            {
                Id = "1"
            };

            var character = new Character
            {
                Id = "1",
                Account = account,
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Name = "Test" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Approved
            };

            await context.Accounts.AddAsync(account);
            await context.Competitions.AddAsync(competition);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();


            var mappedEntity = charactersService.GetCurrentAccountCharacterForCompetition<CharacterListViewModel>("1", "1", mapper);

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetCurrentAccountCharacterForCompetitionShouldReturnNothingBecauseCharacterIsAlreadyInCompetition()
        {
            var competitionCharactersService = new CompetitionCharactersService(context);

            var account = new Account
            {
                Id = "1"
            };

            var competition = new Competition
            {
                Id = "1"
            };

            var character = new Character
            {
                Id = "1",
                Account = account,
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Name = "Test" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Approved
            };

            await context.Accounts.AddAsync(account);
            await context.Competitions.AddAsync(competition);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            await competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            var mappedEntity = charactersService.GetCurrentAccountCharacterForCompetition<CharacterListViewModel>("1", "1", mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetCurrentAccountCharacterForCompetitionShouldReturnNothingBecauseCharactersAreNotApproved()
        {
            var account = new Account
            {
                Id = "1"
            };

            var competition = new Competition
            {
                Id = "1"
            };

            var character = new Character
            {
                Id = "1",
                Account = account,
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Name = "Test" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Accounts.AddAsync(account);
            await context.Competitions.AddAsync(competition);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity = charactersService.GetCurrentAccountCharacterForCompetition<CharacterListViewModel>("1", "1", mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetCharacterByIdGenericShouldReturnCorrectCharacter()
        {
            var account = new Account
            {
                Id = "1"
            };
            
            var character = new Character
            {
                Id = "1",
                Account = account,
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Name = "Test" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Accounts.AddAsync(account);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity = charactersService.GetCharacterByIdGeneric<CharacterUserViewModel>("1", this.mapper);

            Assert.AreEqual(character.Id, mappedEntity.Id);
        }

        [Test]
        public async Task UpdateCharacterImageShouldUpdateCharacterImage()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1"},
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server{Id = "1"},
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var test = context.Characters
                .FirstOrDefault(x => x.Name == "Test" && x.Server.Id == "1");
            await charactersService.UpdateCharacterImageAsync("/TestFiles", "Test", "1", this.file);
            Assert.AreEqual("1(Character).png", character.CharacterImagePath);
        }

        [Test]
        public async Task GetCharacterByIdShouldReturnCorrectCharacter()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var foundCharacter = charactersService.GetCharacterById("1");

            Assert.AreEqual(character, foundCharacter);
        }
        
        [Test]
        public async Task TotalCharactersShouldReturnAllCharactersCount()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            var secondCharacter = new Character
            {
                Id = "2",
                Account = new Account { Id = "2" },
                Name = "Test",
                Class = new Class { Id = "2" },
                Race = new Race { Id = "2" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "2" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Approved
            };

            await context.Characters.AddAsync(secondCharacter);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var totalApprovedCharacters = charactersService.TotalCharacters();

            Assert.AreEqual(2, totalApprovedCharacters);
        }

        [Test]
        public async Task GetAllCharactersShouldReturnAllCharacters()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            var secondCharacter = new Character
            {
                Id = "2",
                Account = new Account { Id = "2" },
                Name = "Test",
                Class = new Class { Id = "2" },
                Race = new Race { Id = "2" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "2" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow.AddDays(1),
                DeletedOn = DateTime.UtcNow.AddDays(2),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Approved
            };

            await context.Characters.AddAsync(secondCharacter);
            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity = charactersService.GetAllCharacters<CharacterListViewModel>(mapper);


            Assert.AreEqual(2, mappedEntity.Count());
        }

        [Test]
        public async Task ApproveCharacterAsyncShouldSetCharacterStatusToApproved()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            await charactersService.ApproveCharacterAsync("1", "1");

            Assert.AreEqual(CharacterStatus.Approved, character.CharacterStatus);
        }

        [Test]
        public async Task DeleteCharacterShouldSetIsDeletedOnToTrue()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            await charactersService.DeleteCharacterAsync("1", "1");

            Assert.AreEqual(CharacterStatus.Deleted, character.CharacterStatus);
        }

        [Test]
        public async Task GetPendingCharactersShouldReturnAllPendingCharacters()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity =  charactersService.GetPendingCharacters<CharacterListViewModel>("1", mapper);

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetPendingCharactersShouldReturnNothingBecauseNoCharactersArePending()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Approved
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity = charactersService.GetPendingCharacters<CharacterListViewModel>("1", mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllPendingCharactersShouldReturnAllPendingCharacters ()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity = charactersService.GetAllPendingCharacters<CharacterListViewModel>(mapper);

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllPendingCharactersShouldReturnNothingBecauseThereAreNoPendingCharacters()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Approved
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var mappedEntity = charactersService.GetAllPendingCharacters<CharacterListViewModel>(mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task TotalPendingCharactersShouldReturnCorrectCount()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var totalPendingCharacters = charactersService.TotalPendingCharacters();

            Assert.AreEqual(1, totalPendingCharacters);
        }

        [Test]
        public async Task EditCharacterAsyncShouldEditCharacter()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var characterEditDto = new CharacterEditDto
            {
                Id = "1",
                Backstory = "New backstory"
            };

            await this.charactersService.EditCharacterAsync(characterEditDto);

            Assert.AreEqual("New backstory", character.Backstory);
        }

        [Test]
        public async Task GetDeletedCharactersByAccountReturnsAllDeletedCharactersByAccount()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = true,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var deletedCharactersCount = this.charactersService.GetDeletedCharactersByAccount("1");

            Assert.AreEqual(1, deletedCharactersCount);
        }

        [Test]
        public async Task GetNotDeletedCharactersByAccountReturnsAllNotDeletedByAccount()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var deletedCharactersCount = this.charactersService.GetNotDeletedCharactersByAccount("1");

            Assert.AreEqual(1, deletedCharactersCount);
        }

        [Test]
        public async Task IsCharacterNameTakenInSameServerReturnsCorrectValue()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test",
                Class = new Class { Name = "Test" },
                Race = new Race { Name = "Test" },
                Title = "Test",
                Gender = Gender.Male,
                CharacterImagePath = "Test",
                Server = new Server { Id = "1" },
                IsDeleted = false,
                Backstory = "Test",
                CharacterType = CharacterType.Fashion,
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ForceAffiliation = ForceAffiliation.LightSide,
                CharacterStatus = CharacterStatus.Pending
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();

            var isCharacterNameTaken = this.charactersService.IsCharacterNameTakenInSameServer("Test", "1");

            Assert.True(isCharacterNameTaken);
        }
    }
}
