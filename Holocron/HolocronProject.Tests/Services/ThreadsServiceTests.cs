using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Services.Models.Threads;
using HolocronProject.Web.ViewModels.Posts;
using HolocronProject.Web.ViewModels.Threads;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    public class ThreadsServiceTests
    {
        private ApplicationDbContext context;
        private IThreadsService threadsService;
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

            var mockedIPostsService = new Mock<IPostsService>();

            this.threadsService = new ThreadsService(context, mockedIPostsService.Object);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Thread, ThreadViewModel>();
                opts.CreateMap<Thread, ThreadListViewModel>();
                opts.CreateMap<Post, PostCountViewModel>();
            });

            this.mapper = config.CreateMapper();

        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateThreadShoulCreateThread()
        {
            var baseThread = new BaseThread
            {
                Id = "1"
            };

            var account = new Account
            {
                Id = "1"
            };

            await this.context.Accounts.AddAsync(account);
            await this.context.BaseThreads.AddAsync(baseThread);
            await this.context.SaveChangesAsync();

            var threadInputDto = new ThreadInputDto
            {
                AccountId = "1",
                BaseThreadId = "1",
                Description = "Test",
                Title = "Test"
            };

            await this.threadsService.CreateThreadAsync(threadInputDto);

            Assert.AreEqual(1, this.context.Threads.Count());
        }

        [Test]
        public async Task DeleteThreadShouldDeleteThread()
        {
            var thread = new Thread
            {
                Id = "1"
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.SaveChangesAsync();

            await this.threadsService.DeleteThreadAsync("1");

            Assert.AreEqual(0, this.context.Threads.Where(x => !x.IsDeleted).Count());
        }

        [Test]
        public async Task EditThreadShouldEditThread()
        {
            var thread = new Thread
            {
                Id = "1",
                Description = "OldDesc",
                Title = "OldTitle"
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.SaveChangesAsync();

            await this.threadsService.EditThreadAsync("1", "NewDesc", "NewTitle");

            Assert.AreEqual("NewDesc", thread.Description);
            Assert.AreEqual("NewTitle", thread.Title);
        }

        [Test]
        public async Task GetAllThreadsShouldReturnAllThreads()
        {
            var thread = new Thread
            {
                Id = "1",
            };

            var secondThread = new Thread
            {
                Id = "2",
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.Threads.AddAsync(secondThread);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.threadsService.GetAllNotDeletedThreads<ThreadListViewModel>(this.mapper).ToList();

            Assert.AreEqual(thread.Id, mappedEntity[0].Id);
        }

        [Test]
        public async Task GetAllThreadsShouldReturnNothingBecauseAllAreDeleted()
        {
            var thread = new Thread
            {
                Id = "1",
                IsDeleted = true
            };

            var secondThread = new Thread
            {
                Id = "2",
                IsDeleted =true
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.Threads.AddAsync(secondThread);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.threadsService.GetAllNotDeletedThreads<ThreadListViewModel>(this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetLastNotDeletedThreadsByAccountIdShouldReturnAllThreadsByAccount()
        {
            var thread = new Thread
            {
                Id = "1",
                IsDeleted = false,
                Account = new Account { Id = "1"}
            };

            var secondThread = new Thread
            {
                Id = "2",
                IsDeleted = true,
                Account = new Account { Id = "2"}
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.Threads.AddAsync(secondThread);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.threadsService.GetLastNotDeletedThreadsByAccountId<ThreadListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(1, mappedEntity.Count());
        }

        [Test]
        public async Task GetLastNotDeletedThreadsByAccountIdShouldReturnNothingBecauseAllAreDeleted()
        {
            var thread = new Thread
            {
                Id = "1",
                IsDeleted = true,
                Account = new Account { Id = "1" }
            };

            var secondThread = new Thread
            {
                Id = "2",
                IsDeleted = true,
                Account = new Account { Id = "2" }
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.Threads.AddAsync(secondThread);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.threadsService.GetLastNotDeletedThreadsByAccountId<ThreadListViewModel>("1", this.mapper).ToList();

            Assert.AreEqual(0, mappedEntity.Count());
        }

        [Test]
        public async Task GetThreadByIdShouldReturnCorrectMappedEntity()
        {
            var thread = new Thread
            {
                Id = "1",
                IsDeleted = true,
                Account = new Account { Id = "1" }
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.threadsService.GetThreadById<ThreadListViewModel>("1", this.mapper);

            Assert.AreEqual(thread.Id, mappedEntity.Id);
        }

        [Test]
        public async Task TotalNotDeletedThreadsShouldReturnCorrectCount()
        {
            var thread = new Thread
            {
                Id = "1",
                IsDeleted = false,
                Account = new Account { Id = "1" }
            };

            var secondThread = new Thread
            {
                Id = "2",
                IsDeleted = true,
                Account = new Account { Id = "2" }
            };

            await this.context.Threads.AddAsync(thread);
            await this.context.Threads.AddAsync(secondThread);
            await this.context.SaveChangesAsync();

            var totalNotDeletedThreads = this.threadsService.TotalNotDeletedThreads();

            Assert.AreEqual(1, totalNotDeletedThreads);
        }
    }
}

