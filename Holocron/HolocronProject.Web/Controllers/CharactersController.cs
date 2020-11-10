
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Models;
using HolocronProject.Services.Models.Character;
using HolocronProject.Web.ViewModels;
using HolocronProject.Web.ViewModels.Character;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public CharactersController(IClassService classService,
            ICharacterService characterService,
            IServerService serverService,
            IRaceService raceService
            )
        {
            this.classService = classService;
            this.characterService = characterService;
            this.serverService = serverService;
            this.raceService = raceService;
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

            var characterInputDto = new CharacterInputDto
            {
                Name = character.Name,
                Backstory = character.Backstory,
                Title = character.Title,
                Gender = character.Gender,
                CharacterType = character.CharacterType,
                ForceAffiliation = character.ForceAffiliation,
                Image = character.Image,
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
            var charListDto = this.characterService.GetCurrentUsersCharacter(userId);

            var charListViewModel = charListDto
                .Select(x => new CharacterUserViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ServerName = x.ServerName,
                    ClassName = x.ClassName,
                    RaceName = x.RaceName
                })
                .ToList();

            return this.View(charListViewModel);
        }

        public IActionResult CharacterInfo(string id)
        {
            var charDto = this.characterService.GetCharacterInfo(id);
            var charViewModel = new CharacterUserViewModel()
            {
                Id = charDto.Id,
                Name = charDto.Name,
                ClassName = charDto.ClassName,
                RaceName = charDto.RaceName,
                ServerName = charDto.ServerName
            };

            return this.View(charViewModel);

        }

    }
}
