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
    public class ServerServiceTests
    {
        private HolocronDbContext context;
        private IServerService serverService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.serverService = new ServerServices(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [Test]
        public async Task CreateRaceCreatesRaceAndIncreasesCount()
        {
            await this.serverService.CreateServer("Test");

            var actualResult = this.context.Servers
                .Count();
            var expectedResult = 6;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
