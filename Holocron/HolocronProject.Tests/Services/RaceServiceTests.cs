using HolocronProject.Data;
using HolocronProject.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class RaceServiceTests
    {
        private HolocronDbContext context;
        private IRacesService raceService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.raceService = new RacesService(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateRaceCreatesRaceAndIncreasesCount()
        {
            await this.raceService.CreateRaceAsync("Test");

            var actualResult = this.context.Races
                .Count();
            var expectedResult = 13;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
