using System;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using NUnit.Framework;

using HolocronProject.Data;
using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Servers;
using HolocronProject.Services.Implementations;

using Microsoft.EntityFrameworkCore;

namespace HolocronProject.Tests.Services
{
    public class ServerServiceTests
    {
        private ApplicationDbContext context;
        private IServersService serversService;
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

            this.serversService = new ServersService(context);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Server, ServerViewModel>();
            });

            this.mapper = config.CreateMapper();

        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public void GetAllShouldReturnAllServers()
        {
            var mappedEntity = this.serversService.GetAll<ServerViewModel>(this.mapper);

            Assert.AreEqual(this.context.Servers.Count(), mappedEntity.Count());
        }
    }
}
