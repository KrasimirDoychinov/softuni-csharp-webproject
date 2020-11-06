using HolocronProject.Data;
using HolocronProject.Data.Models;
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
    public class AchievementServiceTests
    {
        private HolocronDbContext context;
        private IAchievementService achievementService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.achievementService = new AchievementServices(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [TestCase("Test1")]
        [TestCase("Test2")]
        [TestCase("Test3")]
        public void CreateAchievementReturnsThreeAchievements(string title)
        {
            var achievements = this.achievementService.CreateAchievement(title)
                .ToList();

            var actualResult = achievements;
            var expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult.Count());
        }
    }
}
