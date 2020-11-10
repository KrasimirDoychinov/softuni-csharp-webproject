using AutoMapper;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Models;
using HolocronProject.Web.ViewModels;
using HolocronProject.Web.ViewModels.Character;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        private readonly IMapper mapper;

        public CharactersController(IClassService classService,
            IMapper mapper,
            ICharacterService characterService,
            IServerService serverService,
            IRaceService raceService
            )
        {
            this.classService = classService;
            this.characterService = characterService;
            this.serverService = serverService;
            this.raceService = raceService;
            this.mapper = mapper;
        }

        public IActionResult CreateCharacter()
        {
            var characterInputModel = new CharacterInputModel();

            return this.View(characterInputModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCharacter(CharacterInputModel character)
        {
            var @class = this.classService.GetClassIdByName(character.Class);
            var server = this.serverService.GetServerIdByName(character.Server);
            var race = this.raceService.GetRaceIdByName(character.Race);

            var characterInputDto = new CharacterInputDto
            {

                Name = character.Name,
                Backstory = character.Backstory,
                Title = character.Title,
                Gender = character.Gender,
                CharacterType = character.CharacterType,
                ForceAffiliation = character.ForceAffiliation,
                Image = character.Image,
                Server = server,
                Race = race,
                Class = @class,
                AccountId = this.User.FindFirstValue(ClaimTypes.NameIdentifier)
            };

            this.characterService.CreateCharacterAsync(characterInputDto);

            return this.Redirect("/");
        }

    }
}
