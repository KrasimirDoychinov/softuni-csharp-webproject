﻿using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Models.Character;
using HolocronProject.Web.ViewModels.Characters;
using HolocronProject.Web.ViewModels.Classes;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.Races;
using HolocronProject.Web.ViewModels.Servers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class CharactersController : Controller
    {
        private readonly IClassesService classService;
        private readonly ICharactersService characterService;
        private readonly IServersService serverService;
        private readonly IRacesService raceService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IAccountsService accountsService;
        private readonly Random random;
        private readonly UserManager<Account> userManager;

        public CharactersController(IClassesService classService,
            ICharactersService characterService,
            IServersService serverService,
            IRacesService raceService,
            IWebHostEnvironment webHostEnvironment,
            IAccountsService accountsService,
            Random random,
            UserManager<Account> userManager
            )
        {
            this.classService = classService;
            this.characterService = characterService;
            this.serverService = serverService;
            this.raceService = raceService;
            this.webHostEnvironment = webHostEnvironment;
            this.accountsService = accountsService;
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
            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;

            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

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
                AccountId = accountId
            };

            await this.characterService.CreateCharacterAsync(characterInputDto);
            await this.characterService.CreateCharacterImage(input.Name, input.Image);
            await this.accountsService.NotifyAccountOfPendingCharacters(accountId);
            return this.Redirect($"/");
        }

        [Authorize]
        public async Task<IActionResult> AllCharacters(string accountId, int? page)
        {
            var charListViewModel = this.characterService.GetCurrentAccountCharacter<CharactersViewModel>(accountId);

            if (charListViewModel.Count() > 0)
            {
                charListViewModel = CharListParserAndSanitizer(page, charListViewModel);
            }
            await this.accountsService.RemoveNotification(accountId);
            ViewData["charactersAccountId"] = accountId;

            return this.View(charListViewModel.ToList());
        }

        

        [Authorize(Roles = "Admin")]
        public IActionResult NewestCharacters(int? page)
        {
            var charListViewModel = this.characterService.GetNewestCharacters<CharactersViewModel>();

            if (charListViewModel.Count() > 0)
            {
                charListViewModel = CharListParserAndSanitizer(page, charListViewModel);
            }

            return this.View(charListViewModel.ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AllPendingCharacters(int? page)
        {
            var charListViewModel = this.characterService.GetAllPendingCharacters<CharactersViewModel>();

            if (charListViewModel.Count() > 0)
            {
                charListViewModel = CharListParserAndSanitizer(page, charListViewModel);
            }

            
            return this.View(charListViewModel.ToList());
        }

        [Authorize]
        public IActionResult CharacterInfo(string characterId)
        {
            var charViewModel = this.characterService.GetCharacterInfo<CharacterUserViewModel>(characterId);
            charViewModel.RandomImageQuery = random.NextDouble().ToString();

            if (charViewModel.ForceAffiliation == ForceAffiliation.LightSide)
            {
                charViewModel.ForceAffiliationString = "Light side";
            }
            else if (charViewModel.ForceAffiliation == ForceAffiliation.DarkSide)
            {
                charViewModel.ForceAffiliationString = "Dark side";
            }
            else if (charViewModel.ForceAffiliation == ForceAffiliation.None)
            {
                charViewModel.ForceAffiliationString = "None";
            }
            else
            {
                charViewModel.ForceAffiliationString = "Unknown";
            }

            return this.View(charViewModel);
        }

        [Authorize]
        public IActionResult PendingCharacters(string accountId, int? page)
        {
            var pendingCharacters = this.characterService.GetPendingCharacters<CharactersViewModel>(accountId);

            if (pendingCharacters.Count() > 0)
            {
                pendingCharacters = CharListParserAndSanitizer(page, pendingCharacters);
            }

            return this.View(pendingCharacters.ToList());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveCharacter(string characterId, string accountId)
        {
            await this.characterService.ApproveCharacter(characterId, accountId);

            return this.Redirect("/");
        }
        private static IEnumerable<CharactersViewModel> CharListParserAndSanitizer(int? page, IEnumerable<CharactersViewModel> charListViewModel)
        {
            charListViewModel = charListViewModel.OrderByDescending(x => x.NormalizedCreatedOn);
            var pager = new Pager(charListViewModel.Count(), page);
            charListViewModel = charListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            charListViewModel.FirstOrDefault().Pager = pager;
            return charListViewModel;
        }
    }
}
