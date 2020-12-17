using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Web.ViewModels.BugReports;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    public class BugReportsServiceTests
    {
        private ApplicationDbContext context;
        private IBugReportsService bugReportsService;
        private IMapper mapper;

        [SetUp]
        public async Task SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.context = new ApplicationDbContext(optionsBuilder);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();
            this.bugReportsService = new BugReportsService(context);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportViewModel>();
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            this.mapper = config.CreateMapper();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateBugReportShouldCreateBugReport()
        {
            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.SaveChangesAsync();

            await this.bugReportsService.CreateBugReportAsync("1", "Test", "Test", "Test");
            var bugReportsCount = await this.context.BugReports.CountAsync();

            var bugReport = await this.context.BugReports.FirstOrDefaultAsync();

            Assert.AreEqual(bugReportsCount, 1);
            Assert.False(bugReport.IsResolved);
        }

        [Test]
        public async Task ResolveBugReportShouldResolveTheBugReport()
        {
            var bugReport = new BugReport
            {
                Id = "1",
                IsResolved = false
            };

            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();

            await this.bugReportsService.ResolveBugReportAsync("1");

            Assert.True(bugReport.IsResolved);
        }

        [Test]
        public async Task GetBugReportByIdGenericShouldReturnCorrectMappedEntity()
        {
            var bugReport = new BugReport
            {
                Id = "1",
                Account = new Account { Id = "1" },
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = false,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetBugReportByIdGeneric<BugReportViewModel>("1", this.mapper);

            Assert.AreEqual(mappedEntity.Id, bugReport.Id);
            Assert.AreEqual(mappedEntity.CreatedOn, bugReport.CreatedOn);
            Assert.AreEqual(mappedEntity.Notes, bugReport.Notes);
            Assert.AreEqual(mappedEntity.Description, bugReport.Description);
            Assert.AreEqual(mappedEntity.Title, bugReport.Title);
        }

        [Test]
        public async Task GetAllByAccountUnresolvedShouldReturnAllUnresolvedBasedOnAccountId()
        {
            var account = new Account
            {
                Id = "1"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = false,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetAllByAccountUnresolved<BugReportListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(mappedEntity[0].Id, bugReport.Id);
        }

        [Test]
        public async Task GetAllByAccountUnresolvedShouldReturnNothingBecauseAllAreAreResolved()
        {
            var account = new Account
            {
                Id = "1"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = true,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetAllByAccountUnresolved<BugReportListViewModel>("1", this.mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllByAccountResolvedShouldReturnAllResolvedBasedOnAccountId()
        {
            var account = new Account
            {
                Id = "1"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = true,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetAllByAccountResolved<BugReportListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(mappedEntity[0].Id, bugReport.Id);
        }

        [Test]
        public async Task GetAllByAccountResolvedShouldReturnNothinBecauseAllAreAreUnresolved()
        {
            var account = new Account
            {
                Id = "1"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = false,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetAllByAccountResolved<BugReportListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminUnresolvedShouldReturnAllUnresolved()
        {
            var account = new Account
            {
                Id = "1"
            };

            var secondAccount = new Account
            {
                Id = "2"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = false,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            var secondBugReport = new BugReport
            {
                Id = "2",
                Account = secondAccount,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = false,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.Accounts.AddAsync(secondAccount);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.BugReports.AddAsync(secondBugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetAllAdminUnresolved<BugReportListViewModel>(this.mapper).ToList();

            Assert.AreEqual(mappedEntity[1].Id, bugReport.Id);
            Assert.AreEqual(mappedEntity[0].Id, secondBugReport.Id);
            Assert.AreEqual(2, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminUnresolvedShouldReturnNothingBecauseAllAreAreResolved()
        {
            var account = new Account
            {
                Id = "1"
            };

            var secondAccount = new Account
            {
                Id = "2"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = true,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            var secondBugReport = new BugReport
            {
                Id = "2",
                Account = secondAccount,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = true,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.Accounts.AddAsync(secondAccount);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.BugReports.AddAsync(secondBugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetAllAdminUnresolved<BugReportListViewModel>(this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminResolvedShouldReturnAllResolved()
        {
            var account = new Account
            {
                Id = "1"
            };

            var secondAccount = new Account
            {
                Id = "2"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = true,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            var secondBugReport = new BugReport
            {
                Id = "2",
                Account = secondAccount,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = true,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.Accounts.AddAsync(secondAccount);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.BugReports.AddAsync(secondBugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetAllAdminResolved<BugReportListViewModel>(this.mapper).ToList();

            Assert.AreEqual(mappedEntity[1].Id, bugReport.Id);
            Assert.AreEqual(mappedEntity[0].Id, secondBugReport.Id);
            Assert.AreEqual(2, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminResolvedShouldReturnNothingBecauseAllAreAreUnresolved()
        {
            var account = new Account
            {
                Id = "1"
            };

            var secondAccount = new Account
            {
                Id = "2"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = false,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            var secondBugReport = new BugReport
            {
                Id = "2",
                Account = secondAccount,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = false,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.Accounts.AddAsync(secondAccount);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.BugReports.AddAsync(secondBugReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.bugReportsService.GetAllAdminResolved<BugReportListViewModel>(this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetBugReportByIdShouldReturnCorrectBugReport()
        {
            var account = new Account
            {
                Id = "1"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = true,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();

            var foundBugReport = this.bugReportsService.GetBugReportById("1");

            Assert.AreEqual(bugReport, foundBugReport);
        }

        [Test]
        public async Task TotalUnresolvedBugsShouldReturnCorrectNumber()
        {
            var account = new Account
            {
                Id = "1"
            };

            var bugReport = new BugReport
            {
                Id = "1",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = true,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            var secondBugReport = new BugReport
            {
                Id = "2",
                Account = account,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                IsResolved = false,
                Notes = "test",
                Title = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1)
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.BugReports.AddAsync(bugReport);
            await this.context.BugReports.AddAsync(secondBugReport);
            await this.context.SaveChangesAsync();

            var totalUnresolvedBugs = this.bugReportsService.TotalUnresolvedBugReports();

            Assert.AreEqual(1, totalUnresolvedBugs);
        }
    }
}
