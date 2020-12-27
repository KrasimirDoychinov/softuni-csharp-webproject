using System;
using System.Linq;
using System.Threading.Tasks;

using Moq;
using AutoMapper;
using NUnit.Framework;

using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Posts;
using HolocronProject.Services.Implementations;
using HolocronProject.Web.ViewModels.PostReports;

using Microsoft.EntityFrameworkCore;

namespace HolocronProject.Tests.Services
{
    public class PostReportsServiceTests
    {
        private ApplicationDbContext context;
        private IPostReportsService postReportsService;
        private int deletedPosts;
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

            var IMockedPostsService = new Mock<IPostsService>();
            IMockedPostsService.Setup(x => x.DeletePostAsync(It.IsAny<string>()))
                .Returns(async () => this.deletedPosts++);
            this.postReportsService = new PostReportsService(context, IMockedPostsService.Object);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<PostReport, PostReportListViewModel>();
                opts.CreateMap<PostReport, PostReportViewModel>();
                opts.CreateMap<Post, PostViewModel>();
            });

            this.mapper = config.CreateMapper();

        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreatePostReportCreatesReport()
        {
            var post = new Post
            {
                Id = "1",
                Account = new Account { Id = "1" },
                Thread = new Thread { Id = "1" }
            };

            await this.postReportsService.CreatePostReportAsync("1", "1", "Test", "Test", "Test");

            var postReportCount = this.context.PostReports.Count();

            Assert.AreEqual(1, postReportCount);
        }

        [Test]
        public async Task ResolvePostReportResolvesPostReport()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1"},
                Account = new Account { Id = "1"},
                IsResolved = false
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();

            await this.postReportsService.ResolvePostReportAsync("1");

            var postReportCount = this.context.PostReports.Where(x => x.IsResolved).Count();
            var deletedPosts = this.context.Posts.Where(x => x.IsDeleted).Count();

            Assert.AreEqual(1, postReportCount);
        }

        [Test]
        public async Task DeletePostReportDeletesPost()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = false
            };
            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();

            await this.postReportsService.DeletePostReportAsync("1");

            var resolvedPostReports = this.context.PostReports.Where(x => x.IsResolved).Count();

            Assert.AreEqual(1, resolvedPostReports);
            Assert.AreEqual(1, this.deletedPosts);
        }

        [Test]
        public async Task GetAllAdminResolvedReturnsAllResolvedPostReports()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = true
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetAllAdminResolved<PostReportListViewModel>(this.mapper).ToList();

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminResolvedReturnsNothingBecauseAllAreUnresolved()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = false
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetAllAdminResolved<PostReportListViewModel>(this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminUnresolvedReturnsAllUnresolved()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = false
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetAllAdminUnresolved<PostReportListViewModel>(this.mapper).ToList();

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllAdminUnresolvedReturnsNothingBecauseAllAreResolved()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = true
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetAllAdminUnresolved<PostReportListViewModel>(this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllByAccountResolvedReturnsAllResolvedByAccount()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = true
            };

            var secondReport = new PostReport
            {
                Id = "2",
                Post = new Post { Id = "2" },
                Account = new Account { Id = "2" },
                IsResolved = true
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.PostReports.AddAsync(secondReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetAllByAccountResolved<PostReportListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllByAccountResolvedReturnsNothingBecauseAllAreUnresolved()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = false
            };

            var secondReport = new PostReport
            {
                Id = "2",
                Post = new Post { Id = "2" },
                Account = new Account { Id = "2" },
                IsResolved = true
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.PostReports.AddAsync(secondReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetAllByAccountResolved<PostReportListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllByAccountUnresolvedReturnsAllUnresolvedByAccount()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = false
            };

            var secondReport = new PostReport
            {
                Id = "2",
                Post = new Post { Id = "2" },
                Account = new Account { Id = "2" },
                IsResolved = false
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.PostReports.AddAsync(secondReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetAllByAccountUnresolved<PostReportListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetAllByAccountUnresolvedReturnsNothingBecauseAllAreResolved()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = true
            };

            var secondReport = new PostReport
            {
                Id = "2",
                Post = new Post { Id = "2" },
                Account = new Account { Id = "2" },
                IsResolved = false
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.PostReports.AddAsync(secondReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetAllByAccountUnresolved<PostReportListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetPostReportByIdGenericShouldReturnCorrectMappedEntity()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post
                {
                    Id = "1",
                    CreatedOn = DateTime.UtcNow,
                    DeletedOn = DateTime.UtcNow.AddDays(1),
                    Description = "Test",
                    IsDeleted = false,
                    Thread = new Thread { Id = "1"},
                    Account = new Account {Id= "2", 
                        UserName = "Test1", 
                        AvatarImagePath = "Test",
                        ForumSignature = "Test"}
                },
                Account = new Account { Id = "1" },
                IsResolved = true,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                Notes = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1),
                Title = "Test"
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetPostReportByIdGeneric<PostReportViewModel>("1", this.mapper);

            Assert.AreEqual(postReport.Id, mappedEntity.Id);
        }

        [Test]
        public async Task GetReportByIdReturnsCorrectPostReport()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post {Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = true,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                Notes = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1),
                Title = "Test"
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.postReportsService.GetPostReportById("1");

            Assert.AreEqual(postReport, mappedEntity);
        }

        [Test]
        public async Task TotalUnresolvedPostReportsReturnsCorrectCount()
        {
            var postReport = new PostReport
            {
                Id = "1",
                Post = new Post { Id = "1" },
                Account = new Account { Id = "1" },
                IsResolved = false,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                Notes = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1),
                Title = "Test"
            };

            var secondPostReport = new PostReport
            {
                Id = "2",
                Post = new Post { Id = "2" },
                Account = new Account { Id = "2" },
                IsResolved = true,
                CreatedOn = DateTime.UtcNow,
                Description = "Test",
                Notes = "Test",
                ResolvedOn = DateTime.UtcNow.AddDays(1),
                Title = "Test"
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.PostReports.AddAsync(secondPostReport);
            await this.context.SaveChangesAsync();

            var unresolvedPostReports = this.postReportsService.TotalUnresolvedPostReports();

            Assert.AreEqual(1, unresolvedPostReports);
        }
    }
}
