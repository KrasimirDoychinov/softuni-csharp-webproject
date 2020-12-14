using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Threads;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Ganss.XSS;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.Controllers;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    public class ThreadsController : BaseAdminController
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

        [Authorize(Roles = "Admin")]
        public IActionResult NewestThreads(int? page)
        {
            var lastThreads = this.threadService.GetAllLastThreads<ThreadViewModel>();

            if (lastThreads.Count() > 0)
            {
                lastThreads = LastThreadsPager(page, lastThreads);
                LastThreadsSanitizer(lastThreads);

                foreach (var thread in lastThreads)
                {
                    thread.PostsCount = thread.Posts.Where(x => !x.IsDeleted).Count();
                }
            }

            return this.View(lastThreads.ToList());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string threadId)
        {
            await this.threadService.DeleteThreadAsync(threadId);
            return this.RedirectToAction(nameof(NewestThreads));
        }

        private static IEnumerable<ThreadViewModel> LastThreadsPager(int? page, IEnumerable<ThreadViewModel> lastThreads)
        {
            var pager = new Pager(lastThreads.Count(), page);
            lastThreads = lastThreads.OrderByDescending(x => x.CreatedOn);
            lastThreads = lastThreads.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            lastThreads.FirstOrDefault().Pager = pager;
            return lastThreads;
        }

        private void LastThreadsSanitizer(IEnumerable<ThreadViewModel> lastThreads)
        {
            var sanitizer = new HtmlSanitizer();
            sanitizer.AllowedTags.Add("iframe");

            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));
        }
    }
}
