using HolocronProject.Services;
using HolocronProject.Web.Areas.Administration.Models.Competitions;
using HolocronProject.Web.Controllers;
using HolocronProject.Web.ViewModels.Competitions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    public class CompetitionsController : BaseAdminController
    {
        private readonly ICompetitionsService competitionsService;
        private readonly IAchievementsService achievementsService;

        public CompetitionsController(ICompetitionsService competitionsService,
            IAchievementsService achievementsService)
        {
            this.competitionsService = competitionsService;
            this.achievementsService = achievementsService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var competition = new CompetitionInputModel();

            return this.View(competition);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(CompetitionInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.competitionsService.CreateCompetitionAsync(input.Title, input.Description, input.StartDate, input.EndDate);

            return this.Redirect("/");
        }
    }
}

