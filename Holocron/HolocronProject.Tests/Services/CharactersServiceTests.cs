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
        [Test]
        public async Task CreateCharacterShouldCreateCharacter()
        {

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);

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

            await charactersService.CreateCharacterAsync(characterDto);

            var characterCount = await context.Characters.CountAsync();

            Assert.AreEqual(1, characterCount);
        }

        [Test]
        public async Task GetCurrentAccountCharactersShouldReturnAllAccountCharactersAndAllApproved()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);

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

            var mappedEntity = charactersService.GetCurrentAccountCharacters<CharacterListViewModel>("1", mapper).ToList();

            var characterCount = await context.Characters.Where(x => x.AccountId == "1" && x.CharacterStatus == CharacterStatus.Approved).CountAsync();

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetCurrentAccountCharactersShouldReturnNothingBecauseAllArePendingOrDeleted()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);

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
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);

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
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var competitionCharactersService = new CompetitionCharactersService(context);
            var charactersService = new CharactersService(context, accountsService);

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
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);

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
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterUserViewModel>();
                opts.CreateMap<Achievement, AchievementViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);

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

            var mappedEntity = charactersService.GetCharacterByIdGeneric<CharacterUserViewModel>("1", mapper);

            Assert.AreEqual(character.Id, mappedEntity.Id);
        }

        [Test]
        public async Task UpdateCharacterImageShouldUpdateCharacterImage()
        {
            IFormFile file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0, "Data", "dummy.txt");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
            await charactersService.UpdateCharacterImageAsync("Test", "1", file);
            Assert.AreEqual("1(Character).png", character.CharacterImagePath);
        }

        [Test]
        public async Task GetCharacterByIdShouldReturnCorrectCharacter()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
        public async Task TotalApprovedCharactersShouldReturnCorrectCount()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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

            var totalApprovedCharacters = charactersService.TotalApprovedCharacters();

            Assert.AreEqual(1, totalApprovedCharacters);
        }

        [Test]
        public async Task GetNewestCharactersShouldReturnNewestCharactersThatAreApproved()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();


            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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

            var mappedEntity = charactersService.GetNewestCharacters<CharacterListViewModel>(mapper);


            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task ApproveCharacterAsyncShouldSetCharacterStatusToApproved()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Character, CharacterListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var accountsService = new AccountsService(context);
            var charactersService = new CharactersService(context, accountsService);


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

            await charactersService.EditCharacterAsync(characterEditDto);

            Assert.AreEqual("New backstory", character.Backstory);
        }
    }
}
