using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Services.Models.Posts;
using HolocronProject.Services.Models.Threads;
using HolocronProject.Web.ViewModels.Threads;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Threading;

namespace HolocronProject.Web.Controllers
{
    public class ThreadsController : Controller
    {
        private readonly IThreadsService threadService;
        private readonly UserManager<Account> userManager;
        private readonly Random random;

        public ThreadsController(IThreadsService threadService,
            UserManager<Account> userManager,
            Random random)
        {
            this.threadService = threadService;
            this.userManager = userManager;
            this.random = random;
        }

        [Authorize]
        public IActionResult Create(string baseThreadId)
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(ThreadInputModel input, string baseThreadId)
        {
            var accountId = this.userManager.GetUserId(this.User);

            if (!ModelState.IsValid)
            {
                return this.View();
            }

            var threadInputModel = new ThreadInputDto
            {
                AccountId = accountId,
                BaseThreadId = baseThreadId,
                Title = input.Title,
                Description = input.Description
            };

            await this.threadService.CreateThreadAsync(threadInputModel);
            return this.Redirect($"/BaseThreads/ById/?id={baseThreadId}");
        }

        public IActionResult ById(string threadId)
        {
            var threadViewModel = this.threadService.GetThreadById<ThreadViewModel>(threadId);

            threadViewModel.Posts = threadViewModel.Posts.OrderBy(x => x.CreatedOn);
            threadViewModel.RandomImageQuery = random.NextDouble().ToString();

            return this.View(threadViewModel);
        }
    }
}
