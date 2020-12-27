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
    public class CompetitionChararactersServiceTests
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
        public async Task AddCharacterToCompetitionShouldAddCharacterCorrectly()
        {
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
            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");

            var competitionCharactersCount = this.context.CompetitionsCharacters.Count();

            Assert.AreEqual(1, competitionCharactersCount);
        }

        [Test]
        public async Task GetTotalVotesCountShouldReturn1WhenUpvoted()
        {
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

            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Competitions.AddAsync(competition);
            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");

            var votesCount = this.competitionCharactersService.GetVotesCount("1", "1");

            Assert.AreEqual(1, votesCount);
        }

        [Test]
        public async Task GetTotalVotesCountShouldReturn0WhenUpvotedThenDownvoted()
        {
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

            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Competitions.AddAsync(competition);
            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");
            await this.competitionAccountsService.UnVoteAsync("1", "1");

            var votesCount = this.competitionCharactersService.GetVotesCount("1", "1");

            Assert.AreEqual(0, votesCount);
        }

        [Test]
        public async Task GetTotalVotesCountShouldReturn2WhenUpvotedTwice()
        {
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

            var account = new Account
            {
                Id = "1",
                UserName = "Test"
            };

            var secondAccount = new Account
            {
                Id = "2",
                UserName = ""
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Competitions.AddAsync(competition);
            await this.context.Accounts.AddAsync(account);
            await this.context.Accounts.AddAsync(secondAccount);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "1");
            await this.competitionAccountsService.VoteAsync("1", "1", "2");

            var votesCount = this.competitionCharactersService.GetVotesCount("1", "1");

            Assert.AreEqual(2, votesCount);
        }

        [Test]
        public async Task DeleteAllCompetitionCharactersByAccountIdDeletesAll()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id ="1"},
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            var secondAccount = new Account
            {
                Id = "2",
                UserName = ""
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Competitions.AddAsync(competition);
            await this.context.Accounts.AddAsync(secondAccount);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            await this.competitionCharactersService.DeleteAllCompetitionCharactersByAccountId("1");

            Assert.AreEqual(1, this.context.CompetitionsCharacters.Where(x => x.IsDeleted).Count());
        }

        [Test]
        public async Task GetAllNotDeletedCharactersReturnsAllNotDeleted()
        {
            var character = new Character
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Name = "Test"
            };

            var competition = new Competition
            {
                Id = "1",
                Title = "Test"
            };

            var secondAccount = new Account
            {
                Id = "2",
                UserName = ""
            };

            await this.context.Characters.AddAsync(character);
            await this.context.Competitions.AddAsync(competition);
            await this.context.Accounts.AddAsync(secondAccount);
            await this.context.SaveChangesAsync();

            await this.competitionCharactersService.AddCharacterToCompetitionAsync("1", "1");
            var allNotDeletedCharacters = this.competitionCharactersService.GetAllNotDeletedCharacters("1");

            Assert.AreEqual(1, allNotDeletedCharacters.Count());
        }
    }
}
