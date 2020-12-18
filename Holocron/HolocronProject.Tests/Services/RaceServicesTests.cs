using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Races;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    public class RaceServicesTests
    {
        private ApplicationDbContext context;
        private IRacesService racesService;
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

            this.racesService = new RacesService(context);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Race, RaceViewModel>();
            });

            this.mapper = config.CreateMapper();

        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public void GetAllShouldReturnAllRaces()
        {
            var mappedEntity = this.racesService.GetAll<RaceViewModel>(this.mapper);

            Assert.AreEqual(this.context.Races.Count(), mappedEntity.Count());
        }
    }
}
