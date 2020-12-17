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
    public class ServerServiceTests
    {
        private HolocronDbContext context;
        private IServersService serverService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.serverService = new ServersService(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        //[Test]
        //public async Task CreateRaceCreatesRaceAndIncreasesCount()
        //{
        //    await this.serverService.CreateServerAsync("Test");

        //    var actualResult = this.context.Servers
        //        .Count();
        //    var expectedResult = 6;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}
    }
}
