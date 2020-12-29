using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Ganss.XSS;

using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.Threads;
using HolocronProject.Services.Models.Threads;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HolocronProject.Web.Controllers
{
    [Authorize]
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

        public IActionResult Create(string baseThreadId)
        {
            return this.View();
        }

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

        public IActionResult Edit(string threadId)
        {
            var threadViewModel = this.threadService.GetThreadById<ThreadEditModel>(threadId);

            return this.View(threadViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ThreadEditModel input, string threadId)
        {
            if (!ModelState.IsValid)
            {
                var threadViewModel = this.threadService.GetThreadById<ThreadEditModel>(threadId);
                return this.View(threadViewModel);
            }

            await this.threadService.EditThreadAsync(input.ThreadId, input.Description, input.Title);

            return this.Redirect($"/Threads/ById?threadId={input.ThreadId}");
        }

        public IActionResult ById(string threadId, int? page)
        {
            var threadViewModel = this.threadService.GetThreadById<ThreadViewModel>(threadId);

            threadViewModel.Posts = threadViewModel.Posts.Where(x => !x.IsDeleted);
            threadViewModel.PostsCount = threadViewModel.Posts.Where(x => !x.IsDeleted).Count();

            ThreadPager(page, threadViewModel);
            ThreadSanitizer(threadViewModel);


            return this.View(threadViewModel);
        }

        public IActionResult LastThreads(string accountId, int? page)
        {
            var lastThreads = this.threadService.GetLastNotDeletedThreadsByAccountId<ThreadViewModel>(accountId);
            lastThreads.AsParallel().ForAll(x => x.PostsCount = x.Posts.Where(x => !x.IsDeleted).Count());

            if (lastThreads.Count() > 0)
            {
                lastThreads = ThreadListPager(page, lastThreads);
                ThreadListSanitizer(lastThreads);
            }

            return this.View(lastThreads.ToList());
        }
        
        private static void ThreadPager(int? page, ThreadViewModel threadViewModel)
        {
            var pager = new Pager(threadViewModel.PostsCount, page);
            threadViewModel.Posts = threadViewModel.Posts.OrderBy(x => x.CreatedOn);
            threadViewModel.Posts = threadViewModel.Posts.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            threadViewModel.Pager = pager;
        }

        private void ThreadSanitizer(ThreadViewModel threadViewModel)
        {
            var sanitizer = new HtmlSanitizer();

            sanitizer.AllowedTags.Add("iframe");

            threadViewModel.SanitizedDescription = sanitizer.Sanitize(threadViewModel.Description);

            threadViewModel.SanitizedDescription = this.htmlSizeParser.Parse(threadViewModel.SanitizedDescription, 100, 50);

            threadViewModel.Posts.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            threadViewModel.Posts.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));
        }

        private static IEnumerable<ThreadViewModel> ThreadListPager(int? page, IEnumerable<ThreadViewModel> lastThreads)
        {
            var pager = new Pager(lastThreads.Count(), page);
            lastThreads = lastThreads.OrderByDescending(x => x.CreatedOn);
            lastThreads = lastThreads.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            lastThreads.AsParallel().ForAll(x => x.Pager = pager);
            return lastThreads;
        }

        private void ThreadListSanitizer(IEnumerable<ThreadViewModel> lastThreads)
        {
            var sanitizer = new HtmlSanitizer();

            sanitizer.AllowedTags.Add("iframe");

            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));
        }
    }
}
