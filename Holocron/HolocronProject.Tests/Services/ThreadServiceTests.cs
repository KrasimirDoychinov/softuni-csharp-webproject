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
    public class ThreadServiceTests
    {
        private HolocronDbContext context;
        private IThreadService threadService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.threadService = new ThreadServices(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [Test]
        public async Task CreateThreadCreatesThreadAndIncreaesCount()
        {
            var accountId = this.context.Accounts
                .Select(x => x.Id)
                .FirstOrDefault();
            var baseThreadId = this.context.BaseThreads
                .Select(x => x.Id)
                .FirstOrDefault();

            await this.threadService.CreateThreadAsync("Test", baseThreadId, accountId);

            var actualResult = this.context.Threads
                .Count();
            var expectedResult = 2;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
