using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using SixLabors.ImageSharp;

using HolocronProject.Services;
using HolocronProject.Data.Enums;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.Areas.Administration.ViewModels.Characters;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CharactersController : BaseAdminController
    {
        private readonly ICharactersService characterService;

        public CharactersController(ICharactersService characterService)
        {
            this.characterService = characterService;
        }

        public IActionResult CharacterInfo(string characterId)
        {
            var character = this.characterService.GetCharacterByIdGeneric<CharacterAdminViewModel>(characterId);
            

            if (character.ForceAffiliation == ForceAffiliation.LightSide)
            {
                character.ForceAffiliationString = "Light side";
            }
            else if (character.ForceAffiliation == ForceAffiliation.DarkSide)
            {
                character.ForceAffiliationString = "Dark side";
            }
            else if (character.ForceAffiliation == ForceAffiliation.None)
            {
                character.ForceAffiliationString = "None";
            }
            else
            {
                character.ForceAffiliationString = "Unknown";
            }

            character.BannedCharacters = this.characterService.GetDeletedCharactersByAccount(character.AccountId);
            character.NotBannedCharacters = this.characterService.GetNotDeletedCharactersByAccount(character.AccountId);

            return this.View(character);
        }

        public IActionResult NewestCharacters(int? page)
        {
            var characters = this.characterService.GetAllCharacters<NewestCharactersViewModel>();

            characters.AsParallel().ForAll(x => x.TotalCharacters = characters.Count());
            characters.AsParallel().ForAll(x => x.DeletedCharacters = characters.Where(x => x.IsDeleted).Count());
            characters.AsParallel().ForAll(x => x.NotDeletedCharacters = characters.Where(x => !x.IsDeleted).Count());
            characters.AsParallel().ForAll(x => x.ApprovedCharacters = characters.Where(x => x.CharacterStatus == CharacterStatus.Approved).Count());
            characters.AsParallel().ForAll(x => x.PendingCharacters = characters.Where(x => x.CharacterStatus == CharacterStatus.Pending).Count());
            characters.AsParallel().ForAll(x => x.CharactersMadeToday = characters.Where(x => x.CreatedOn.DayOfYear == DateTime.UtcNow.DayOfYear).Count());

            if (characters.Count() > 0)
            {
                characters = CharListPager(page, characters);
            }

            return this.View(characters.ToList());
        }

        public IActionResult AllPendingCharacters(int? page)
        {
            var charListViewModel = this.characterService.GetAllPendingCharacters<NewestCharactersViewModel>();

            if (charListViewModel.Count() > 0)
            {
                charListViewModel = CharListPager(page, charListViewModel);
            }

            return this.View(charListViewModel.ToList());
        }

        public async Task<IActionResult> ApproveCharacter(string characterId, string accountId)
        {
            await this.characterService.ApproveCharacterAsync(characterId, accountId);

            return this.RedirectToAction(nameof(AllPendingCharacters));
        }

        public async Task<IActionResult> DeleteCharacter(string characterId, string accountId)
        {
            await this.characterService.DeleteCharacterAsync(characterId, accountId);

            return this.RedirectToAction(nameof(AllPendingCharacters));
        }

        private static IEnumerable<NewestCharactersViewModel> CharListPager(int? page, IEnumerable<NewestCharactersViewModel> charListViewModel)
        {
            charListViewModel = charListViewModel.OrderByDescending(x => x.CreatedOn);
            var pager = new Pager(charListViewModel.Count(), page);
            charListViewModel = charListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            charListViewModel.AsParallel().ForAll(x => x.Pager = pager);
            return charListViewModel;
        }

    }
}
