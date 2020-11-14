using HolocronProject.Services;
using HolocronProject.Services.Models.Character;
using HolocronProject.Web.ViewModels.Character;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class CharactersController : Controller
    {
        private readonly IClassService classService;
        private readonly ICharacterService characterService;
        private readonly IServerService serverService;
        private readonly IRaceService raceService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CharactersController(IClassService classService,
            ICharacterService characterService,
            IServerService serverService,
            IRaceService raceService,
            IWebHostEnvironment webHostEnvironment
            )
        {
            this.classService = classService;
            this.characterService = characterService;
            this.serverService = serverService;
            this.raceService = raceService;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult CreateCharacter()
        {
            var characterInputModel = new CharacterInputModel();

            return this.View(characterInputModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCharacter(CharacterInputModel character)
        {
            var accountId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var classId = this.classService.GetClassIdByName(character.Class);
            var serverId = this.serverService.GetServerIdByName(character.Server);
            var raceId = this.raceService.GetRaceIdByName(character.Race);

            if (!ModelState.IsValid)
            {
                return this.View(character);
            }

            using (var fs = new FileStream(
               this.webHostEnvironment.WebRootPath + $"/Images/CharacterImages/{character.Name}.png", FileMode.Create))
            {
                await character.Image.CopyToAsync(fs);

            }

            var imagePath = $"{character.Name}.png";
            var characterInputDto = new CharacterInputDto
            {
                Name = character.Name,
                Backstory = character.Backstory,
                Title = character.Title,
                Gender = character.Gender,
                CharacterType = character.CharacterType,
                ForceAffiliation = character.ForceAffiliation,
                ImagePath = imagePath,
                ServerId = serverId,
                RaceId = raceId,
                ClassId = classId,
                AccountId = accountId
            };

            await this.characterService.CreateCharacterAsync(characterInputDto);

            return this.Redirect("/");
        }

        public IActionResult AllCharacters()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var charListViewModel = this.characterService.GetCurrentUsersCharacter<CharacterUserViewModel>(userId);

            return this.View(charListViewModel);
        }

        public IActionResult CharacterInfo(string id)
        {
            var charViewModel = this.characterService.GetCharacterInfo<CharacterUserViewModel>(id);
            
            return this.View(charViewModel);
        }

    }
}
