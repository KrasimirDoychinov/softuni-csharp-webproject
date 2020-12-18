using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    public class VotesServiceTests
    {
        private ApplicationDbContext context;
        private IVotesService votesService;

        [SetUp]
        public async Task SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.context = new ApplicationDbContext(optionsBuilder);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            this.votesService = new VotesService(context);

        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task VoteAsyncShouldCreateNewVoteIfThereIsNoVoteFound()
        {
            var thread = new Thread
            {
                Id = "1"
            };

            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.Threads.AddAsync(thread);
            await this.context.SaveChangesAsync();

            await this.votesService.VoteAsync("1", "1", true);

            Assert.AreEqual(1, this.context.Votes.Count());
        }

        [Test]
        public async Task VoteAsyncShouldntCreateNewVoteIfAccountVotesTwice()
        {
            var vote = new Vote
            {
                Account = new Account { Id = "1" },
                Thread = new Thread { Id = "1" },
                Type = VoteType.UpVote
            };

            await this.context.Votes.AddAsync(vote);
            await this.context.SaveChangesAsync();

            await this.votesService.VoteAsync("1", "1", true);

            Assert.AreEqual(1, this.context.Votes.Count());
        }

        [Test]
        public async Task VoteAsyncShouldChangeVoteTypeAndNotCreateAnotherVote()
        {
            var vote = new Vote
            {
                Account = new Account { Id = "1" },
                Thread = new Thread { Id = "1" },
                Type = VoteType.UpVote
            };

            await this.context.Votes.AddAsync(vote);
            await this.context.SaveChangesAsync();

            await this.votesService.VoteAsync("1", "1", false);

            Assert.AreEqual(1, this.context.Votes.Count());
            Assert.AreEqual(VoteType.DownVote, vote.Type);
        }

        [Test]
        public async Task GetVotesShouldReturnCorrectCount()
        {
            var vote = new Vote
            {
                Account = new Account { Id = "1" },
                Thread = new Thread { Id = "1" },
                Type = VoteType.UpVote
            };

            var secondVote = new Vote
            {
                Account = new Account { Id = "2" },
                ThreadId = "1",
                Type = VoteType.UpVote
            };

            await this.context.Votes.AddAsync(vote);
            await this.context.Votes.AddAsync(secondVote);
            await this.context.SaveChangesAsync();

            var voteCount = this.votesService.GetVotes("1");

            Assert.AreEqual(2, voteCount);
        }
    }
}
