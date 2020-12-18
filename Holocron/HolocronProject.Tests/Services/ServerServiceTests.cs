using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Web.ViewModels.Servers;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
