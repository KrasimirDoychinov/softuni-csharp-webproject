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
using HolocronProject.Web.Areas.Administration.ViewModels.Threads;
using System;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
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

        public IActionResult NewestThreads(int? page)
        {
            var lastThreads = this.threadService.GetAllThreads<NewestThreadsViewModel>();

            lastThreads.AsParallel().ForAll(x => x.TotalThreads = lastThreads.Count());
            lastThreads.AsParallel().ForAll(x => x.DeletedThreads = lastThreads.Where(x => x.IsDeleted).Count());
            lastThreads.AsParallel().ForAll(x => x.NotDeletedThreads = lastThreads.Where(x => !x.IsDeleted).Count());
            lastThreads.AsParallel().ForAll(x => x.ThreadsMadeToday = lastThreads.Where(x => x.CreatedOn.DayOfYear == DateTime.UtcNow.DayOfYear).Count());


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

        public async Task<IActionResult> Delete(string threadId)
        {
            await this.threadService.DeleteThreadAsync(threadId);
            return this.RedirectToAction(nameof(NewestThreads));
        }

        private static IEnumerable<NewestThreadsViewModel> LastThreadsPager(int? page, IEnumerable<NewestThreadsViewModel> lastThreads)
        {
            var pager = new Pager(lastThreads.Count(), page);
            lastThreads = lastThreads.OrderByDescending(x => x.CreatedOn);
            lastThreads = lastThreads.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            lastThreads.AsParallel().ForAll(x => x.Pager = pager);
            return lastThreads;
        }

        private void LastThreadsSanitizer(IEnumerable<NewestThreadsViewModel> lastThreads)
        {
            var sanitizer = new HtmlSanitizer();
            sanitizer.AllowedTags.Add("iframe");

            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastThreads.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));
        }
    }
}
