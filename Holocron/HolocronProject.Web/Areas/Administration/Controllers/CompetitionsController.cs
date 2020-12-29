using System;
using System.Threading.Tasks;

using Hangfire;

using HolocronProject.Services;
using HolocronProject.Web.Areas.Administration.ViewModels.Competitions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CompetitionsController : BaseAdminController
    {
        private readonly ICompetitionsService competitionsService;
        private readonly IAchievementsService achievementsService;
        private readonly IRacesService racesService;

        public CompetitionsController(ICompetitionsService competitionsService,
            IAchievementsService achievementsService,
            IRacesService racesService)
        {
            this.competitionsService = competitionsService;
            this.achievementsService = achievementsService;
            this.racesService = racesService;
        }

        public IActionResult Create()
        {
            var competition = new CompetitionInputModel();

            return this.View(competition);
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(CompetitionInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            var endDate = input.EndDate.Subtract(TimeSpan.FromHours(2)); //--- Use in Azure because servers are in Germany
            //var endDate = input.EndDate.ToUniversalTime(); // -- Use localy

            var competitionId = await this.competitionsService.CreateCompetitionAsync(input.Title, input.Description, input.StartDate, endDate);
            var totalSeconds = (endDate - input.StartDate).TotalSeconds;

            BackgroundJob.Schedule(
                () => this.competitionsService.FinishCompetitionAsync(competitionId), TimeSpan.FromSeconds(totalSeconds));

            return this.Redirect("/Competitions/All");
        }

        public async Task<IActionResult> Finish(string competitionId)
        {
            await this.competitionsService.FinishCompetitionAsync(competitionId);

            return this.Redirect("/Competitions/All");
        }
    }
}

