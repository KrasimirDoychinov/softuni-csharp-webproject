using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Web.ViewModels.Competitions;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    public class CompetitionsServiceTests
    {
        private ApplicationDbContext context;
        private ICompetitionsService competitionsService;
        private IMapper mapper;
        private Mock<IAchievementsService> mockIAchievementsService = new Mock<IAchievementsService>();
        private Mock<ICompetitionCharactersService> mockICompetitionCharactersService = new Mock<ICompetitionCharactersService>();

        private List<Achievement> achievements = new List<Achievement>()
        {
            new Achievement {Name = "First place"},
            new Achievement {Name = "Second place"},
            new Achievement {Name = "Third place"}
        };

        private List<CompetitionCharacter> oneWinner = new List<CompetitionCharacter>()
        {
            new CompetitionCharacter {Character = new Character {Id = "1", IsDeleted = false, Name = "Test"}}
        };

        private List<CompetitionCharacter> twoWinners = new List<CompetitionCharacter>()
        {
            new CompetitionCharacter {Character = new Character {Id = "3", IsDeleted = false}},
            new CompetitionCharacter {Character = new Character {Id = "4", IsDeleted = false}}
        };

        private List<CompetitionCharacter> threeWinners = new List<CompetitionCharacter>()
        {
            new CompetitionCharacter {Character = new Character {Id = "5", IsDeleted = false}},
            new CompetitionCharacter {Character = new Character {Id = "6", IsDeleted = false}},
            new CompetitionCharacter {Character = new Character {Id = "7", IsDeleted = false}}
        };

        [SetUp]
        public async Task SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.context = new ApplicationDbContext(optionsBuilder);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            mockIAchievementsService.Setup(x => x.CreateAchievement(It.IsAny<string>()))
                .Returns(this.achievements);
            
            mockICompetitionCharactersService.Setup(x => x.GetAllNotDeletedCharacters(It.IsAny<string>()))
                .Returns(this.threeWinners);

            this.competitionsService = new CompetitionsService(context,
                mockIAchievementsService.Object,
                mockICompetitionCharactersService.Object);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Competition, CompetitionListViewModel>();
            });

            this.mapper = config.CreateMapper();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateCompetitionCreatesCompetitionAndIncreasesCompetitionCount()
        {
            await this.competitionsService.CreateCompetitionAsync("Test", "Test", DateTime.UtcNow, DateTime.UtcNow);

            Assert.AreEqual(1, this.context.Competitions.Count());
        }

        [Test]
        public async Task FinishCompetitionFinishesCompetition()
        {
            var competition = new Competition
            {
                Id = "1",
                Achievements = this.achievements
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionsService.FinishCompetitionAsync("1");

            Assert.AreEqual(1, this.context.Competitions.Where(x => x.IsFinished).Count());
            Assert.True(competition.IsFinished);
        }

        [Test]
        public async Task FinishCompetitionAwardsOneWinner()
        {
            this.mockICompetitionCharactersService.Setup(x => x.GetAllNotDeletedCharacters(It.IsAny<string>()))
                .Returns(this.oneWinner);

            var competition = new Competition
            {
                Id = "1",
                Achievements = this.achievements
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionsService.FinishCompetitionAsync(competition.Id);

            Assert.AreEqual(1, this.context.Competitions.Where(x => x.IsFinished).Count());
            Assert.True(competition.IsFinished);
            Assert.AreEqual(1, competition.Characters.Select(x => x.Character.Achievements).Count());
        }

        [Test]
        public async Task FinishCompetitionAwardsTwoWinners()
        {
            this.mockICompetitionCharactersService.Setup(x => x.GetAllNotDeletedCharacters(It.IsAny<string>()))
                .Returns(this.twoWinners);

            var competition = new Competition
            {
                Id = "2",
                Achievements = this.achievements
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionsService.FinishCompetitionAsync(competition.Id);

            Assert.AreEqual(2, competition.Characters.Select(x => x.Character.Achievements).Count());
        }

        [Test]
        public async Task FinishCompetitionAwardsThreeWinners()
        {
            this.mockICompetitionCharactersService.Setup(x => x.GetAllNotDeletedCharacters(It.IsAny<string>()))
                .Returns(this.threeWinners);

            var competition = new Competition
            {
                Id = "3",
                Achievements = this.achievements
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionsService.FinishCompetitionAsync(competition.Id);

            Assert.AreEqual(3, competition.Characters.Select(x => x.Character.Achievements).Count());
        }

        [Test]
        public async Task GetAllOngoingReturnsAllOngoing()
        {
            var competition = new Competition
            {
                Id = "1",
                IsFinished = false
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            var mappedEntity =  this.competitionsService.GetAllOngoing<CompetitionListViewModel>(this.mapper);

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllFinishedReturnsNothingIfNoCharactersArePresent()
        {
            var competition = new Competition
            {
                Id = "1",
                IsFinished = true
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.competitionsService.GetAllFinished<CompetitionListViewModel>(this.mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllFinishedReturnsAllFinished()
        {
            var competition = new Competition
            {
                Id = "1",
                Achievements = this.achievements
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionsService.FinishCompetitionAsync("1");
            var mappedEntity = this.competitionsService.GetAllFinished<CompetitionListViewModel>(this.mapper);

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetCompetitionByIdGenericShouldReturnCorrectMappedEntity()
        {
            var competition = new Competition
            {
                Id = "1",
                Achievements = this.achievements
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionsService.FinishCompetitionAsync("1");
            var mappedEntity = this.competitionsService.GetCompetitionByIdGeneric<CompetitionListViewModel>("1", this.mapper);

            Assert.AreEqual(competition.Id, mappedEntity.Id);
        }

        [Test]
        public async Task GetWinnerReturnsCharacterWithMostVotes()
        {
            this.mockICompetitionCharactersService.Setup(x => x.GetAllNotDeletedCharacters(It.IsAny<string>()))
                .Returns(this.oneWinner);

            var competition = new Competition
            {
                Id = "1",
                Achievements = this.achievements
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionsService.FinishCompetitionAsync("1");
            var winnerName = this.competitionsService.GetWinner("1");

            Assert.AreEqual("Test", winnerName);
        }

        [Test]
        public async Task GetWinnerThrowsExceptionIfCompetitionhasNoCharacters()
        {
            this.mockICompetitionCharactersService.Setup(x => x.GetAllNotDeletedCharacters(It.IsAny<string>()))
                .Returns(new List<CompetitionCharacter>());

            var competition = new Competition
            {
                Id = "1",
                Achievements = this.achievements
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            await this.competitionsService.FinishCompetitionAsync("1");
            
            Assert.Throws<ArgumentNullException>(() => this.competitionsService.GetWinner("1"),
                $"There are no characters in competition with ID {competition.Id}");
        }

        [Test]
        public async Task GetCharactersSignedUpReturnsCorrectCount()
        {
            var competition = new Competition
            {
                Id = "1",
                Achievements = this.achievements,
                Characters = this.threeWinners
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            
            var charactersSignedUp = this.competitionsService.GetCharactersSignedUp("1");

            Assert.AreEqual(this.threeWinners.Count(), charactersSignedUp);
        }
    }
}
