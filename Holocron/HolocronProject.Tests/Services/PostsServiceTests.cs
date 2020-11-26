using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Services.Models.Threads;
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
        private IPostsService postService;
        private IThreadsService threadService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.postService = new PostsService(context);
            this.threadService = new ThreadsService(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();

            var threadId = this.context.BaseThreads
                .Select(x => x.Id)
                .FirstOrDefault();
            var userId = this.context.Accounts
                .Select(x => x.Id)
                .FirstOrDefault();

            //await this.threadService.CreateThreadAsync(ThreadInputDto input);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        //[Test]
        //public async Task CreatePostCreatesPostAndIncreasesCount()
        //{
        //    var thread = this.context.Threads
        //        .FirstOrDefault();
        //    await this.postService.CreatePostAsync("Test description", thread.AccountId, thread.Id);

        //    var actualResult = this.context.Posts
        //        .Where(x => !x.IsDeleted)
        //        .Count();
        //    var expectedResult = 1;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}
    }
}
