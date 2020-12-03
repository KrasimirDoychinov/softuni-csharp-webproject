using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Implementations;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Tests.Services
{
    [TestFixture]
    public class CharacterServiceTests
    {
        private HolocronDbContext context;
        private ICharactersService characterService;


        [SetUp]
        public async Task SetUp()
        {
            this.context = new HolocronDbContext();
            //this.characterService = new CharactersService(context);

            await this.context.Database.EnsureDeletedAsync();
            await this.context.Database.EnsureCreatedAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.DisposeAsync();
        }

        //[Test]
        //public async Task CreateCharacterCreatesCharacter()
        //{
        //    var accountId = this.context.Accounts
        //        .Select(x => x.Id)
        //        .FirstOrDefault();
        //    var classId = this.context.Classes
        //        .Select(x => x.Id)
        //        .FirstOrDefault();
        //    var raceId = this.context.Races
        //        .Select(x => x.Id)
        //        .FirstOrDefault();
        //    var serverId = this.context.Servers
        //        .Select(x => x.Id)
        //        .FirstOrDefault();

        //    var character = new Character
        //    {
        //        AccountId = accountId,
        //        Name = "Test name",
        //        Backstory = "Test backstory",
        //        Title = "Test title",
        //        Image = "Test image",
        //        Gender = Gender.Male,
        //        CharacterType = CharacterType.PVE,
        //        ForceAffiliation = ForceAffiliation.DarkSide,
        //        ClassId = classId,
        //        RaceId = raceId,
        //        ServerId = serverId
        //    };

        //    await this.characterService.CreateCharacterAsync(character);

        //    var actualResult = this.context.Characters
        //        .Where(x => !x.IsDeleted)
        //        .Count();
        //    var expectedResult = 2;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[Test]
        //public async Task DeleteCharacterSoftDeletesCharater()
        //{
        //    var characterId = this.context.Characters
        //        .Select(x => x.Id)
        //        .FirstOrDefault();

        //    await this.characterService.DeleteCharacterAsync(characterId);

        //    var actualResult = this.context.Characters
        //        .Where(x => x.IsDeleted)
        //        .Count();
        //    var expectedResult = 1;

        //    Assert.AreEqual(expectedResult, actualResult);
        //}
    }
}
