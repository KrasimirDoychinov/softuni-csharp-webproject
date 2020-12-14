﻿using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.Controllers;
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
    [Authorize(Roles = "Admin")]
    public class CharactersController : BaseAdminController
    {
        private readonly ICharactersService characterService;

        public CharactersController( ICharactersService characterService)
        {
            this.characterService = characterService;
        }

        public IActionResult CharacterInfo(string characterId)
        {
            var charViewModel = this.characterService.GetCharacterByIdGeneric<CharacterUserViewModel>(characterId);

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

        public IActionResult NewestCharacters(int? page)
        {
            var charListViewModel = this.characterService.GetNewestCharacters<CharacterListViewModel>();

            if (charListViewModel.Count() > 0)
            {
                charListViewModel = CharListPager(page, charListViewModel);
                CharListUTCToLocalTime(charListViewModel);
            }

            return this.View(charListViewModel.ToList());
        }

        public IActionResult AllPendingCharacters(int? page)
        {
            var charListViewModel = this.characterService.GetAllPendingCharacters<CharacterListViewModel>();

            if (charListViewModel.Count() > 0)
            {
                charListViewModel = CharListPager(page, charListViewModel);
                CharListUTCToLocalTime(charListViewModel);
            }

            return this.View(charListViewModel.ToList());
        }

        public async Task<IActionResult> ApproveCharacter(string characterId, string accountId)
        {
            await this.characterService.ApproveCharacter(characterId, accountId);

            return this.Redirect("/");
        }

        public async Task<IActionResult> DeleteCharacter(string characterId, string accountId)
        {
            await this.characterService.DeleteCharacter(characterId, accountId);

            return this.Redirect("/");
        }

        private static IEnumerable<CharacterListViewModel> CharListPager(int? page, IEnumerable<CharacterListViewModel> charListViewModel)
        {
            charListViewModel = charListViewModel.OrderByDescending(x => x.NormalizedCreatedOn);
            var pager = new Pager(charListViewModel.Count(), page);
            charListViewModel = charListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            charListViewModel.FirstOrDefault().Pager = pager;
            return charListViewModel;
        }

        private static void CharListUTCToLocalTime(IEnumerable<CharacterListViewModel> charList)
        {
            charList.AsParallel().ForAll(x => x.NormalizedCreatedOn = x.CreatedOn.ToLocalTime().ToString("MM/dd/yyyy h:mm tt"));
        }
    }
}
