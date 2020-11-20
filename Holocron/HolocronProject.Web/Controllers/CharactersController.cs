using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Models.Character;
using HolocronProject.Web.ViewModels.Character;
using HolocronProject.Web.ViewModels.Classes;
using HolocronProject.Web.ViewModels.Races;
using HolocronProject.Web.ViewModels.Servers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using System;
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
        private readonly Random random;
        private readonly UserManager<Account> userManager;

        public CharactersController(IClassService classService,
            ICharacterService characterService,
            IServerService serverService,
            IRaceService raceService,
            IWebHostEnvironment webHostEnvironment,
            Random random,
            UserManager<Account> userManager
            )
        {
            this.classService = classService;
            this.characterService = characterService;
            this.serverService = serverService;
            this.raceService = raceService;
            this.webHostEnvironment = webHostEnvironment;
            this.random = random;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult CreateCharacter()
        {
            var characterInputModel = new CharacterInputModel();
            characterInputModel.Classes = this.classService.GetAll<ClassViewModel>();
            characterInputModel.Races = this.raceService.GetAll<RaceViewModel>();
            characterInputModel.Servers = this.serverService.GetAll<ServerViewModel>();
            return this.View(characterInputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateCharacter(CharacterInputModel input)
        {

            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            var userId = this.userManager.GetUserAsync(this.User).Result.Id;
            var characterInputDto = new CharacterInputDto
            {
                Name = input.Name,
                Backstory = input.Backstory,
                Description = input.Description,
                Title = input.Title,
                Gender = input.Gender,
                CharacterType = input.CharacterType,
                ForceAffiliation = input.ForceAffiliation,
                ServerId = input.ServerId,
                RaceId = input.RaceId,
                ClassId = input.ClassId,
                AccountId = userId
            };

            await this.characterService.CreateCharacterAsync(characterInputDto);
            await this.characterService.CreateCharacterImage(input.Name, input.Image);
            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult AllCharacters()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var charListViewModel = this.characterService.GetCurrentAccountCharacter<CharacterUserViewModel>(userId);

            return this.View(charListViewModel);
        }

        [Authorize]
        public IActionResult CharacterInfo(string id)
        {
            var charViewModel = this.characterService.GetCharacterInfo<CharacterUserViewModel>(id);
            charViewModel.RandomImageQuery = random.NextDouble().ToString();
            return this.View(charViewModel);
        }

    }
}
