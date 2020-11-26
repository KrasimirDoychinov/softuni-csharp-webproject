using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using NUnit.Framework;

using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class BaseThreadServiceTests
    {
        private HolocronDbContext context;
        private IBaseThreadsService baseThreadService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.baseThreadService = new BaseThreadsService(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [Test]
        public async Task CreateBaseThreadCreatesBaseThread()
        {
            await this.baseThreadService.CreateBaseThreadAsync("Test");

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
            await this.baseThreadService.CreateBaseThreadAsync("Test");
            var baseThread = this.context.BaseThreads
                .FirstOrDefault(x => x.Title == "Test");

            await this.baseThreadService.DeleteBaseThreadByIdAsync(baseThread.Id);

            var actualResult = this.context.BaseThreads
                .Where(x => !x.IsDeleted)
                .Count();
            var expectedResult = 5;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
