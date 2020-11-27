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
using Ganss.XSS;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace HolocronProject.Web.Controllers
{
    public class ThreadsController : Controller
    {
        private readonly IThreadsService threadService;
        private readonly UserManager<Account> userManager;
        private readonly Random random;
        private readonly IHtmlSizeParser htmlSizeParser;

        public ThreadsController(IThreadsService threadService,
            UserManager<Account> userManager,
            Random random,
            IHtmlSizeParser htmlSizeParser)
        {
            this.threadService = threadService;
            this.userManager = userManager;
            this.random = random;
            this.htmlSizeParser = htmlSizeParser;
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
            var threadViewModel = this.threadService.GetThreadsById<ThreadViewModel>(threadId);

            var sanitizer = new HtmlSanitizer();

            sanitizer.AllowedTags.Add("iframe");

            threadViewModel.SanitizedDescription = sanitizer.Sanitize(threadViewModel.Description);
            threadViewModel.SanitizedDescription = this.htmlSizeParser.Parse(threadViewModel.SanitizedDescription, 100, 50);

            threadViewModel.Posts = threadViewModel.Posts.OrderBy(x => x.CreatedOn);
            threadViewModel.Posts.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            threadViewModel.Posts.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));

            threadViewModel.RandomImageQuery = random.NextDouble().ToString();
            
            return this.View(threadViewModel);
        }

        [Authorize]
        public IActionResult LastThreads(string accountId)
        {
            var lastThreads = this.threadService.GetLast10ThreadsByAccountId<ThreadViewModel>(accountId);
            var sanitizer = new HtmlSanitizer();

            sanitizer.AllowedTags.Add("iframe");

            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));

            lastThreads.AsParallel().ForAll(x => x.RandomImageQuery = random.NextDouble().ToString());

            return this.View(lastThreads);
        }
    }
}
