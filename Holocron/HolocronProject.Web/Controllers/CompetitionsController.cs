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
    [Authorize]
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


        public IActionResult All(int? page)
        {
            var competitions = this.competitionsService.GetAll<CompetitionListViewModel>();

            if (competitions.Count() > 0)
            {
                competitions = AllCompetitionsPaging(page, competitions);
                CompetitionsUTCToLocalTime(competitions);
            }
            
            return this.View(competitions);
        }

        public IActionResult AllFinished(int? page)
        {
            var competitions = this.competitionsService.GetAllFinished<CompetitionListViewModel>();

            if (competitions.Count() > 0)
            {
                competitions = AllCompetitionsPaging(page, competitions);
                CompetitionsUTCToLocalTime(competitions);
            }

            return this.View(competitions);
        }

        public IActionResult ById(string competitionId, int? page)
        {
            var competition = this.competitionsService.GetCompetitionByIdGeneric<CompetitionViewModel>(competitionId);

            if (competition.IsFinished)
            {
                return this.Redirect($"/Competitions/ByIdFinished/?competitionId={competitionId}");
            }

            var loggedInUserId = this.userManager.GetUserAsync(this.User).Result.Id;

            competition.HasAccountVoted = this.competitionAccountsService.DoesAccountVoteExist(competitionId, loggedInUserId);
            competition.DoesAccountVoteExist = this.competitionAccountsService.HasAccountVoted(competitionId, loggedInUserId);
            AllCompetitionCharactersPaging(page, competition);
            CompetitionUTCToLocalTime(competition);

            return this.View(competition);
        }

        public IActionResult ByIdFinished(string competitionId, int? page)
        {
            var competition = this.competitionsService.GetCompetitionByIdGeneric<CompetitionViewModel>(competitionId);

            AllCompetitionCharactersPaging(page, competition);

            competition.Characters = competition.Characters
                .OrderByDescending(x => x.Votes);
            CompetitionUTCToLocalTime(competition);

            return this.View(competition);
        }

        public async Task<IActionResult> Pick(string characterId, string competitionId)
        {
            await this.competitionCharactersService.AddCharacterToCompetitionAsync(characterId, competitionId);

            return this.Redirect($"/Competitions/ById?competitionId={competitionId}");
        }

        private static void AllCompetitionCharactersPaging(int? page, CompetitionViewModel competition)
        {
            var pager = new Pager(competition.Characters.Count(), page);
            competition.Characters = competition.Characters.OrderByDescending(x => x.Character.NormalizedCreatedOn);
            competition.Characters = competition.Characters.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            competition.Pager = pager;
        }

        private static IEnumerable<CompetitionListViewModel> AllCompetitionsPaging(int? page, IEnumerable<CompetitionListViewModel> competitions)
        {
            var pager = new Pager(competitions.Count(), page);
            competitions = competitions.OrderByDescending(x => x.NormalizedStartDate);
            competitions = competitions.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            competitions.AsParallel().ForAll(x => x.Pager = pager);
            return competitions.ToList();
        }

        private static void CompetitionsUTCToLocalTime(IEnumerable<CompetitionListViewModel> competitions)
        {
            competitions.AsParallel().ForAll(x => x.NormalizedStartDate = x.StartDate.ToLocalTime().ToString("MM/dd/yyyy h:mm tt"));
            competitions.AsParallel().ForAll(x => x.NormalizedEndDate = x.EndDate.ToLocalTime().ToString("MM/dd/yyyy h:mm tt"));
        }

        private static void CompetitionUTCToLocalTime(CompetitionViewModel competition)
        {
            competition.NormalizedStartDate = competition.StartDate.ToLocalTime().ToString("MM/dd/yyyy h:mm tt");
            competition.NormalizedEndDate = competition.EndDate.ToLocalTime().ToString("MM/dd/yyyy h:mm tt");
        }
    }
}
