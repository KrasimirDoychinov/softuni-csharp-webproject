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
    public class PostsServiceTests
    {
        private HolocronDbContext context;
        private IPostService postService;
        private IThreadService threadService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.postService = new PostServices(context);
            this.threadService = new ThreadServices(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();

            var threadId = this.context.BaseThreads
                .Select(x => x.Id)
                .FirstOrDefault();
            var accountId = this.context.Accounts
                .Select(x => x.Id)
                .FirstOrDefault();

            await this.threadService.CreateThreadAsync("Test thread", threadId, accountId);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreatePostCreatesPostAndIncreasesCount()
        {
            var thread = this.context.Threads
                .FirstOrDefault();
            await this.postService.CreatePostAsync("Test description", thread.AccountId, thread.Id);

            var actualResult = this.context.Posts
                .Where(x => !x.IsDeleted)
                .Count();
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
