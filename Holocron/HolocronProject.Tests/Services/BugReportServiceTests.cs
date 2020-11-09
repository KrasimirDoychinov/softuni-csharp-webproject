using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Web;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class BugReportServiceTests
    {
        private HolocronDbContext context;
        private IBugReportService bugReportService;
        private IAccountService accountService;
        private MapperConfiguration config;
        private Account testAccount;

        [SetUp]
        public async Task SetUp()
        {

            this.context = new HolocronDbContext();
            this.bugReportService = new BugReportServices(context);
            this.accountService = new AccountServices(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();

            //await this.accountService.CreateAccount("Test", "Test", "Test");
            testAccount = this.context.Accounts.FirstOrDefault();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateBugReportIncreasesBugReportCount()
        {
            await this.bugReportService.CreateBugReportAsync(testAccount.Id, "Test", "Test");

            var actualResult = this.context.BugReports
                .Where(x => !x.IsResolved)
                .Count();
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public async Task ResolveBugReportResolvesBugreport()
        {
            await this.bugReportService.CreateBugReportAsync(testAccount.Id, "Test", "Test");
            var id = this.context.BugReports
                .Select(x => x.Id)
                .FirstOrDefault();

            await this.bugReportService.ResolveBugReportAsync(id);

            var actualResult = this.context.BugReports
                .Where(x => x.IsResolved)
                .Count();
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
