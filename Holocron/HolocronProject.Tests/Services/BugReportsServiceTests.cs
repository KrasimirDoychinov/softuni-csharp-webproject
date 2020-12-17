using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
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
        [Test]
        public async Task CreateBugReportShouldCreateBugReport()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

            var account = new Account
            {
                Id = "1"
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();

            await bugReportsService.CreateBugReportAsync("1", "Test", "Test", "Test");
            var bugReportsCount = await context.BugReports.CountAsync();

            var bugReport = await context.BugReports.FirstOrDefaultAsync();

            Assert.AreEqual(bugReportsCount, 1);
            Assert.False(bugReport.IsResolved);
        }

        [Test]
        public async Task ResolveBugReportShouldResolveTheBugReport()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

            var bugReport = new BugReport
            {
                Id = "1",
                IsResolved = false
            };

            await context.BugReports.AddAsync(bugReport);
            await context.SaveChangesAsync();

            await bugReportsService.ResolveBugReportAsync("1");

            Assert.True(bugReport.IsResolved);
        }

        [Test]
        public async Task GetBugReportByIdGenericShouldReturnCorrectMappedEntity()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.BugReports.AddAsync(bugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetBugReportByIdGeneric<BugReportViewModel>("1", mapper);

            Assert.AreEqual(mappedEntity.Id, bugReport.Id);
            Assert.AreEqual(mappedEntity.CreatedOn, bugReport.CreatedOn);
            Assert.AreEqual(mappedEntity.Notes, bugReport.Notes);
            Assert.AreEqual(mappedEntity.Description, bugReport.Description);
            Assert.AreEqual(mappedEntity.Title, bugReport.Title);
        }

        [Test]
        public async Task GetAllByAccountUnresolvedShouldReturnAllUnresolvedBasedOnAccountId()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.BugReports.AddAsync(bugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetAllByAccountUnresolved<BugReportListViewModel>("1", mapper).ToList();

            Assert.AreEqual(mappedEntity[0].Id, bugReport.Id);
        }

        [Test]
        public async Task GetAllByAccountUnresolvedShouldReturnNothingBecauseAllAreAreResolved()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.BugReports.AddAsync(bugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetAllByAccountUnresolved<BugReportListViewModel>("1", mapper);

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllByAccountResolvedShouldReturnAllResolvedBasedOnAccountId()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.BugReports.AddAsync(bugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetAllByAccountResolved<BugReportListViewModel>("1", mapper).ToList();

            Assert.AreEqual(mappedEntity[0].Id, bugReport.Id);
        }

        [Test]
        public async Task GetAllByAccountResolvedShouldReturnNothinBecauseAllAreAreUnresolved()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.BugReports.AddAsync(bugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetAllByAccountResolved<BugReportListViewModel>("1", mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminUnresolvedShouldReturnAllUnresolved()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.Accounts.AddAsync(secondAccount);
            await context.BugReports.AddAsync(bugReport);
            await context.BugReports.AddAsync(secondBugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetAllAdminUnresolved<BugReportListViewModel>(mapper).ToList();

            Assert.AreEqual(mappedEntity[1].Id, bugReport.Id);
            Assert.AreEqual(mappedEntity[0].Id, secondBugReport.Id);
            Assert.AreEqual(2, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminUnresolvedShouldReturnNothingBecauseAllAreAreResolved()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.Accounts.AddAsync(secondAccount);
            await context.BugReports.AddAsync(bugReport);
            await context.BugReports.AddAsync(secondBugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetAllAdminUnresolved<BugReportListViewModel>(mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminResolvedShouldReturnAllResolved()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.Accounts.AddAsync(secondAccount);
            await context.BugReports.AddAsync(bugReport);
            await context.BugReports.AddAsync(secondBugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetAllAdminResolved<BugReportListViewModel>(mapper).ToList();

            Assert.AreEqual(mappedEntity[1].Id, bugReport.Id);
            Assert.AreEqual(mappedEntity[0].Id, secondBugReport.Id);
            Assert.AreEqual(2, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminResolvedShouldReturnNothingBecauseAllAreAreUnresolved()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.Accounts.AddAsync(secondAccount);
            await context.BugReports.AddAsync(bugReport);
            await context.BugReports.AddAsync(secondBugReport);
            await context.SaveChangesAsync();

            var mappedEntity = bugReportsService.GetAllAdminResolved<BugReportListViewModel>(mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetBugReportByIdShouldReturnCorrectBugReport()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.BugReports.AddAsync(bugReport);
            await context.SaveChangesAsync();

            var foundBugReport = bugReportsService.GetBugReportById("1");

            Assert.AreEqual(bugReport, foundBugReport);
        }

        [Test]
        public async Task TotalUnresolvedBugsShouldReturnCorrectNumber()
        {
            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BugReport, BugReportListViewModel>();
            });

            var mapper = config.CreateMapper();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new ApplicationDbContext(optionsBuilder);
            var bugReportsService = new BugReportsService(context);

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

            await context.Accounts.AddAsync(account);
            await context.BugReports.AddAsync(bugReport);
            await context.BugReports.AddAsync(secondBugReport);
            await context.SaveChangesAsync();

            var totalUnresolvedBugs = bugReportsService.TotalUnresolvedBugReports();

            Assert.AreEqual(1, totalUnresolvedBugs);
        }
    }
}
