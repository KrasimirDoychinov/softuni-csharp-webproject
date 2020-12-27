using System.Threading.Tasks;

using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Votes;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HolocronProject.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VotesController : ControllerBase
    {
        private readonly IVotesService votesService;
        private readonly UserManager<Account> userManager;

        public VotesController(IVotesService votesService,
            UserManager<Account> userManager)
        {
            this.votesService = votesService;
            this.userManager = userManager;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<VoteResponseModel>> Post(VoteInputModel input)
        {
            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;

            await this.votesService.VoteAsync(input.ThreadId, accountId, input.IsUpVote);

            var votesCount = this.votesService.GetVotes(input.ThreadId);

            return new VoteResponseModel { VotesCount = votesCount };
        }
    }
}
