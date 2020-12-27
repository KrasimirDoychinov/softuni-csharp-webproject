using System;
using System.Linq;
using System.Threading.Tasks;

using NUnit.Framework;

using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Services.Implementations;

using Microsoft.EntityFrameworkCore;

namespace HolocronProject.Tests.Services
{
    public class CompetitionAccountsServiceTests
    {
        private ApplicationDbContext context;
        private ICompetitionAccountsService competitionAccountsService;
        private ICompetitionCharactersService competitionCharactersService;

        [SetUp]
        public async Task SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.context = new ApplicationDbContext(optionsBuilder);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            this.competitionAccountsService = new CompetitionAccountsService(context);
            this.competitionCharactersService = new CompetitionCharactersService(context);

        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task VoteShouldIncreaseVoteCount()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");
            var competitionAccount = this.context.CompetitionAccounts.FirstOrDefault();
            var competitionCharacter = this.context.CompetitionsCharacters.FirstOrDefault();

            Assert.True(competitionAccount.HasVoted);
            Assert.AreEqual(1, competitionCharacter.Votes);
        }

        [Test]
        public async Task VoteShouldntIncreaseIfAccountHasAlreadyVoted()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");
            var competitionAccount = this.context.CompetitionAccounts.FirstOrDefault();
            var competitionCharacter = this.context.CompetitionsCharacters.FirstOrDefault();

            Assert.True(competitionAccount.HasVoted);
            Assert.AreEqual(1, competitionCharacter.Votes);
        }

        [Test]
        public async Task UnVoteShouldDecreaseVoteCountAndDeleteCompetitonAccount()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");
            await this.competitionAccountsService.UnVoteAsync("1", "1");
            var competitionCharacter = this.context.CompetitionsCharacters.FirstOrDefault();
            var competitionAccountsCount = this.context.CompetitionAccounts.Count();

            Assert.AreEqual(0, competitionAccountsCount);
            Assert.AreEqual(0, competitionCharacter.Votes);
        }

        [Test]
        public async Task UnVoteShouldShouldThrowArgumentNullExceptionIfCompetitionCharacterCharacterIsntFound()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");

            Assert.Throws<ArgumentNullException>
                (() => this.competitionAccountsService.UnVoteAsync("2", "2").GetAwaiter().GetResult(), "There is no vote found to unvote.");
        }

        [Test]
        public async Task GetCompetitionCharacterCharacterIdShouldReturnCorrectValue()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");
            var characterId = this.competitionAccountsService.GetCompetitionCharacterCharacterId("1", "1");

            Assert.AreEqual(character.Id, characterId);
        }

        [Test]
        public async Task GetCompetitionCharacterCharacterIdShouldThrowArgumentNullExceptionIfCompetitionCharacterCharacterIsntFound()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            var characterId = string.Empty;

            Assert.Throws<ArgumentNullException>(
                () => characterId = this.competitionAccountsService.GetCompetitionCharacterCharacterId("1", "1"), "There is no vote found to unvote.");
        }

        [Test]
        public async Task HasAccountVotedReturnsTrueIfAccountHasVoted()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");

            var doesAccountVoteExist = this.competitionAccountsService.HasAccountVoted("1", "1");

            Assert.True(doesAccountVoteExist);
        }

        [Test]
        public async Task HasAccountVotedReturnsFalseIfAccountHasntVoted()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");

            var doesAccountVoteExist = this.competitionAccountsService.HasAccountVoted("1", "1");

            Assert.True(doesAccountVoteExist);
        }

        [Test]
        public async Task DeleteAllCompetitionAccountsByAccountIdDeletesAll()
        {
            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var character = new Character
            {
                Id = "1",
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Accounts.AddAsync(account);
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");
            await this.competitionAccountsService.DeleteAllCompetitionAccountsByAccountId("1");

            Assert.AreEqual(0, this.context.CompetitionAccounts.Where(x => !x.IsDeleted).Count());
        }
    }
}
