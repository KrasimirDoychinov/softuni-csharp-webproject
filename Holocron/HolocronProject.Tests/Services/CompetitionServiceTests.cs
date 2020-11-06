using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class CompetitionServiceTests
    {
        private HolocronDbContext context;
        private ICompetitionService competitionService;
        private IAchievementService achievementService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.achievementService = new AchievementServices(context);
            this.competitionService = new CompetitionServices(context, this.achievementService);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateCompetitionCreatesCompetitionAndIncreasesCount()
        {
            await this.competitionService.CreateCompetition("Test", "Test", DateTime.UtcNow, DateTime.UtcNow.AddHours(20));

            var actualResult = this.context.Competitions
                .ToList()
                .Where(x => !x.IsFinished)
                .Count();
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public async Task FinishCompetitionFinishesTheCompetition()
        {
            await this.competitionService.CreateCompetition("Test", "Test", DateTime.UtcNow, DateTime.UtcNow.AddHours(20));
            var competitionId = this.context.Competitions
                .Select(x => x.Id)
                .FirstOrDefault();

            await this.competitionService.FinishCompetition(competitionId);

            var actualResult = this.context.Competitions
                .Where(x => x.IsFinished)
                .Count();
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
