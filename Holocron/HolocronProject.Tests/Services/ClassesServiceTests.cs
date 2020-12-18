using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using HolocronProject.Web.ViewModels.Classes;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    public class ClassesServiceTests
    {
        private ApplicationDbContext context;
        private IClassesService classesService;
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

            this.classesService = new ClassesService(context);

            var config = new MapperConfiguration(opts =>
            {
                opts.CreateMap<Class, ClassViewModel>();
            });

            this.mapper = config.CreateMapper();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        [Test]
        public async Task GetAllReturnsAllClasses()
        {
            var @class = new Class
            {
                Id = "1",
                Name = "Test",
                Faction = Faction.Empire
            };

            await this.context.Classes.AddAsync(@class);
            await this.context.SaveChangesAsync();

            var mappedEntity = this.classesService.GetAll<ClassViewModel>(this.mapper);

            Assert.AreEqual(17, mappedEntity.Count());
        }
    }
}
