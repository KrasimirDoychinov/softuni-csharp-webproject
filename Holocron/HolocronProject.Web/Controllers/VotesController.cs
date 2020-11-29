using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Votes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        // POST: /api/votes
        //  {"postId": 1, "isUpVote": true}
        //  {"votesCount": 16}
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
