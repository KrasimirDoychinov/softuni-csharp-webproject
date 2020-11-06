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
    public class TagServiceTests
    {
        private HolocronDbContext context;
        private ITagService tagService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.tagService = new TagServices(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [Test]
        public async Task CreateTagCreatesTagAndIncreaesCount()
        {
            await this.tagService.CreateTagAsync("Test");

            var actualResult = this.context.Tags
                .Count();
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
