﻿using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Characters;
using HolocronProject.Web.ViewModels.Pager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class CharactersController : Controller
    {
        private readonly ICharactersService characterService;
        private readonly Random random;

        public CharactersController( ICharactersService characterService,
            Random random)
        {
            this.characterService = characterService;
            this.random = random;
        }

        [Authorize(Roles = "Admin")]
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