using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.VoteThreads;
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
    [Route("api/votes")]
    public class VotesController : ControllerBase
    {
        private readonly IVoteThreadsService votesService;
        private readonly UserManager<Account> userManager;

        public VotesController(
            IVoteThreadsService votesService,
            UserManager<Account> userManager)
        {
            this.votesService = votesService;
            this.userManager = userManager;
        }

        // POST /api/votes
        // Request body: {"postId":1,"isUpVote":true}
        // Response body: {"votesCount":16}
        [HttpPost]
        public async Task<ActionResult<VoteThreadResponseModel>> Post(VoteThreadInputModel input)
        {
            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            await this.votesService.VoteAsync(input.ThreadId, accountId, input.IsUpVote);
            var votes = this.votesService.GetVotes(input.ThreadId);
            return new VoteThreadResponseModel { VotesCount = votes };
        }
    }
}
