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
using HolocronProject.Web.ViewModels.Pager;

namespace HolocronProject.Web.Controllers
{
    public class ThreadsController : BaseController
    {
        private readonly IThreadsService threadService;
        private readonly UserManager<Account> userManager;
        private readonly IHtmlSizeParser htmlSizeParser;

        public ThreadsController(IThreadsService threadService,
            UserManager<Account> userManager,
            IHtmlSizeParser htmlSizeParser)
        {
            this.threadService = threadService;
            this.userManager = userManager;
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
            return this.Redirect($"/BaseThreads/ById/?threadId={baseThreadId}");
        }
        [Authorize]
        public IActionResult Edit(string threadId)
        {
            var threadViewModel = this.threadService.GetThreadsById<ThreadEditModel>(threadId);

            return this.View(threadViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(ThreadEditModel input)
        {
            await this.threadService.EditThreadAsync(input.ThreadId, input.Description, input.Title);

            return this.Redirect($"/Threads/ById?threadId={input.ThreadId}");
        }

        public IActionResult ById(string threadId, int? page)
        {
            var threadViewModel = this.threadService.GetThreadsById<ThreadViewModel>(threadId);

            threadViewModel.Posts = threadViewModel.Posts.Where(x => !x.IsDeleted);
            threadViewModel.PostsCount = threadViewModel.Posts.Where(x => !x.IsDeleted).Count();
            ThreadByIdParserAndSanitizer(page, threadViewModel);

            return this.View(threadViewModel);
        }

        [Authorize]
        public IActionResult LastThreads(string accountId, int? page)
        {
            var lastThreads = this.threadService.GetLastThreadsByAccountId<ThreadViewModel>(accountId);

            if (lastThreads.Count() > 0)
            {
                lastThreads = ThreadListParserAndSanitizer(page, lastThreads);
            }

            return this.View(lastThreads.ToList());
        }

        private void ThreadByIdParserAndSanitizer(int? page, ThreadViewModel threadViewModel)
        {
            var pager = new Pager(threadViewModel.PostsCount, page);
            threadViewModel.Posts = threadViewModel.Posts.OrderBy(x => x.CreatedOn);
            threadViewModel.Posts = threadViewModel.Posts.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            threadViewModel.Pager = pager;

            var sanitizer = new HtmlSanitizer();

            sanitizer.AllowedTags.Add("iframe");

            threadViewModel.SanitizedDescription = sanitizer.Sanitize(threadViewModel.Description);
            threadViewModel.SanitizedDescription = this.htmlSizeParser.Parse(threadViewModel.SanitizedDescription, 100, 50);

            threadViewModel.Posts.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            threadViewModel.Posts.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));

        }

        private IEnumerable<ThreadViewModel> ThreadListParserAndSanitizer(int? page, IEnumerable<ThreadViewModel> lastThreads)
        {
            var sanitizer = new HtmlSanitizer();

            var pager = new Pager(lastThreads.Count(), page);
            lastThreads = lastThreads.OrderByDescending(x => x.CreatedOn);
            lastThreads = lastThreads.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            lastThreads.FirstOrDefault().Pager = pager;

            sanitizer.AllowedTags.Add("iframe");

            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));

            return lastThreads;
        }
    }
}
