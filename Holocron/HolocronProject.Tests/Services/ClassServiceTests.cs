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
    public class ClassServiceTests
    {
        private HolocronDbContext context;
        private IClassesService classService;

        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            this.classService = new ClassesService(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public void GetClassByIdReturnsCorrectClass()
        {
            var classId = this.context.Classes
                .Select(x => x.Id)
                .FirstOrDefault();

            var @class = this.classService.GetClassById(classId);

            var actualResult = @class.Id;
            var expectedResult = classId;

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[Test]
        //public void GetClassByNameReturnsCorrectClass()
        //{
        //    var className = this.context.Classes
        //        .Select(x => x.Name)
        //        .FirstOrDefault();

        //    var @class = this.classService.GetClassByName(className);

        //    var actualResult = @class.Name;
        //    var expectedResult = className;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}
    }
}
