using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Web.ViewModels.BaseThreads;
using HolocronProject.Web.ViewModels.Posts;
using HolocronProject.Web.ViewModels.Threads;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    public class BaseThreadsServiceTests
    {
        private ApplicationDbContext context;
        private IBaseThreadsService baseThreadsService;
        private IMapper mapper;

        [SetUp]
        public async Task SetUp()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.context = new ApplicationDbContext(optionsBuilder);
            this.baseThreadsService = new BaseThreadsService(context);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();


            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<BaseThread, BaseThreadViewModel>();
                opts.CreateMap<Thread, ThreadViewModel>();
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
        public async Task GetAllShouldReturnCorrectCount()
        {
            var baseThread = new BaseThread
            {
                Id = "1",
                CreatedOn = DateTime.UtcNow,
                DeletedOn = DateTime.UtcNow.AddDays(1),
                Description = "Test",
                ImageUrl = "Test",
                IsDeleted = false,
                Threads = new List<Thread>(),
                Title = "Test"
            };

            await this.context.BaseThreads.AddAsync(baseThread);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.baseThreadsService.GetById<BaseThreadViewModel>("1", this.mapper);

            Assert.AreEqual(baseThread.Id, mappedEntity.Id);
        }
    }
}
