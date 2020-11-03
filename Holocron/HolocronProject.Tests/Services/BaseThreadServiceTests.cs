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
    public class BaseThreadServiceTests
    {
        private HolocronDbContext context;
        private IBaseThreadService baseThreadService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.baseThreadService = new BaseThreadService(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [Test]
        public async Task CreateBaseThreadCreatesBaseThread()
        {
            await this.baseThreadService.CreateBaseThread("Test");

            var actualResult = this.context.BaseThreads.Count();
            var expectedResult = 6;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task DeleteBaseThreadDeletesBaseThread()
        {
            await this.baseThreadService.CreateBaseThread("Test");
            var baseThread = this.context.BaseThreads
                .FirstOrDefault(x => x.Title == "Test");

            await this.baseThreadService.DeleteBaseThreadById(baseThread.Id);

            var actualResult = this.context.BaseThreads
                .Where(x => !x.IsDeleted)
                .Count();
            var expectedResult = 5;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
