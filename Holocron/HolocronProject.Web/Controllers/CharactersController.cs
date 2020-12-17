﻿using Hangfire;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Models.Character;
using HolocronProject.Services.Models.Characters;
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
    [Authorize]
    public class CharactersController : BaseController
    {
        private readonly IClassesService classService;
        private readonly ICharactersService characterService;
        private readonly IServersService serverService;
        private readonly IRacesService raceService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IAccountsService accountsService;
        private readonly UserManager<Account> userManager;

        public CharactersController(IClassesService classService,
            ICharactersService characterService,
            IServersService serverService,
            IRacesService raceService,
            IWebHostEnvironment webHostEnvironment,
            IAccountsService accountsService,
            UserManager<Account> userManager
            )
        {
            this.classService = classService;
            this.characterService = characterService;
            this.serverService = serverService;
            this.raceService = raceService;
            this.webHostEnvironment = webHostEnvironment;
            this.accountsService = accountsService;
            this.userManager = userManager;
        }

        public IActionResult CreateCharacter()
        {
            var characterInputModel = new CharacterInputModel();
            characterInputModel.Classes = this.classService.GetAll<ClassViewModel>();
            characterInputModel.Races = this.raceService.GetAll<RaceViewModel>();
            characterInputModel.Servers = this.serverService.GetAll<ServerViewModel>();
            return this.View(characterInputModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCharacter(CharacterInputModel input)
        {
            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;

            if (!ModelState.IsValid)
            {
                input.Classes = this.classService.GetAll<ClassViewModel>();
                input.Races = this.raceService.GetAll<RaceViewModel>();
                input.Servers = this.serverService.GetAll<ServerViewModel>();
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
            await this.characterService.UpdateCharacterImageAsync(input.Name, input.Image);

            BackgroundJob.Schedule(
               () => this.accountsService.RemoveNotificationAsync(accountId), TimeSpan.FromSeconds(180));

            await this.accountsService.NotifyAccountOfPendingCharactersAsync(accountId);
            return this.Redirect($"/");
        }

        public IActionResult Edit(string characterId)
        {
            var characterEditModel = this.characterService.GetCharacterByIdGeneric<CharacterEditViewModel>(characterId);

            characterEditModel.Classes = this.classService.GetAll<ClassViewModel>();
            characterEditModel.Races = this.raceService.GetAll<RaceViewModel>();
            characterEditModel.Servers = this.serverService.GetAll<ServerViewModel>();

            return this.View(characterEditModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CharacterEditViewModel input)
        {
            if (!ModelState.IsValid)
            {
                input.Classes = this.classService.GetAll<ClassViewModel>();
                input.Races = this.raceService.GetAll<RaceViewModel>();
                input.Servers = this.serverService.GetAll<ServerViewModel>();

                return this.View(input);
            }

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;

            var characterInputDto = new CharacterEditDto
            {
                Id = input.CharacterId,
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

            await this.characterService.EditCharacterAsync(characterInputDto);
            await this.characterService.UpdateCharacterImageAsync(input.Name, input.Image);
            return this.Redirect($"/Characters/AllCharacters?accountId={accountId}");
        }

        public async Task<IActionResult> AllCharacters(string accountId, int? page)
        {
            var charListViewModel = this.characterService.GetCurrentAccountCharacter<CharacterListViewModel>(accountId);

            if (charListViewModel.Count() > 0)
            {
                charListViewModel = CharListPager(page, charListViewModel);
                CharListUTCToLocalTime(charListViewModel);
            }
            await this.accountsService.RemoveNotificationAsync(accountId);
            ViewData["charactersAccountId"] = accountId;
           
            return this.View(charListViewModel.ToList());
        }

        public IActionResult CharacterInfo(string characterId, string accountId)
        {
            var charViewModel = this.characterService.GetCharacterByIdGeneric<CharacterUserViewModel>(characterId);
            ViewData["charactersAccountId"] = accountId;

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

            charViewModel.NormalizedCreatedOn = charViewModel.CreatedOn.ToLocalTime().ToString("MM/dd/yyyy h:mm tt");

            return this.View(charViewModel);
        }

        public IActionResult PendingCharacters(string accountId, int? page)
        {
            var pendingCharacters = this.characterService.GetPendingCharacters<CharacterListViewModel>(accountId);

            if (pendingCharacters.Count() > 0)
            {
                pendingCharacters = CharListPager(page, pendingCharacters);
                pendingCharacters.AsParallel().ForAll(x => x.NormalizedCreatedOn = x.CreatedOn.ToLocalTime().ToString("MM/dd/yyyy h:mm tt"));
            }

            ViewData["charactersAccountId"] = accountId;
            return this.View(pendingCharacters.ToList());
        }


        
        public IActionResult CharactersToPick(string accountId, string competitionId, int? page)
        {
            var charListViewModel = this.characterService.GetCurrentAccountCharacterForCompetition<CharacterToPickViewModel>(accountId, competitionId);

            charListViewModel.AsParallel().ForAll(x => x.CompetitionId = competitionId);
            if (charListViewModel.Count() > 0)
            {
                charListViewModel = CharListToPickPager(page, charListViewModel);
                CharListUTCToLocalTime(charListViewModel);
            }

            ViewData["charactersAccountId"] = accountId;
            return this.View(charListViewModel.ToList());
        }

        private static IEnumerable<CharacterListViewModel> CharListPager(int? page, IEnumerable<CharacterListViewModel> charListViewModel)
        {
            charListViewModel = charListViewModel.OrderByDescending(x => x.NormalizedCreatedOn);
            var pager = new Pager(charListViewModel.Count(), page);
            charListViewModel = charListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            charListViewModel.FirstOrDefault().Pager = pager;
            return charListViewModel;
        }

        private static IEnumerable<CharacterToPickViewModel> CharListToPickPager(int? page, IEnumerable<CharacterToPickViewModel> charListViewModel)
        {
            charListViewModel = charListViewModel.OrderByDescending(x => x.NormalizedCreatedOn);
            var pager = new Pager(charListViewModel.Count(), page);
            charListViewModel = charListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            charListViewModel.FirstOrDefault().Pager = pager;
            return charListViewModel;
        }

        private static void CharListUTCToLocalTime(IEnumerable<CharacterListViewModel> charListViewModel)
        {
            charListViewModel.AsParallel().ForAll(x => x.NormalizedCreatedOn = x.CreatedOn.ToLocalTime().ToString("MM/dd/yyyy h:mm tt"));
        }
    }
}
