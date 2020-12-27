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
            
            var competitionId = await this.competitionsService.CreateCompetitionAsync(input.Title, input.Description, DateTime.Now, input.EndDate);
            var totalSeconds = (input.EndDate - DateTime.Now).TotalSeconds;

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

