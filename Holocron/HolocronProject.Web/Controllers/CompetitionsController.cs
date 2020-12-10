using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Characters;
using HolocronProject.Web.ViewModels.Competitions;
using HolocronProject.Web.ViewModels.Pager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class CompetitionsController : BaseController
    {
        private readonly ICompetitionsService competitionsService;
        private readonly ICompetitionCharactersService competitionCharactersService;
        private readonly ICompetitionAccountsService competitionAccountsService;
        private readonly UserManager<Account> userManager;

        public CompetitionsController(ICompetitionsService competitionsService,
            ICompetitionCharactersService competitionCharactersService,
            ICompetitionAccountsService competitionAccountsService,
            UserManager<Account> userManager)
        {
            this.competitionsService = competitionsService;
            this.competitionCharactersService = competitionCharactersService;
            this.competitionAccountsService = competitionAccountsService;
            this.userManager = userManager;
        }


        [Authorize]
        public IActionResult All()
        {
            var competitions = this.competitionsService.GetAll<CompetitionListViewModel>();

            return this.View(competitions);
        }

        [Authorize]
        public IActionResult ById(string competitionId, int? page)
        {
            var competition = this.competitionsService.GetCompetitionByIdGeneric<CompetitionViewModel>(competitionId);
            var loggedInUserId = this.userManager.GetUserAsync(this.User).Result.Id;

            competition.HasAccountVoted = this.competitionAccountsService.DoesAccountVoteExist(competitionId, loggedInUserId);
            competition.DoesAccountVoteExist = this.competitionAccountsService.HasAccountVoted(competitionId, loggedInUserId);
            var pager = new Pager(competition.Characters.Count(), page);
            competition.Characters = competition.Characters.OrderByDescending(x => x.Character.NormalizedCreatedOn);
            competition.Characters = competition.Characters.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            competition.Pager = pager;

            return this.View(competition);
        }

        [Authorize]
        public async Task<IActionResult> Pick(string characterId, string competitionId)
        {
            await this.competitionCharactersService.AddCharacterToCompetitionAsync(characterId, competitionId);

            return this.Redirect($"/Competitions/ById?competitionId={competitionId}");
        }

    }
}
