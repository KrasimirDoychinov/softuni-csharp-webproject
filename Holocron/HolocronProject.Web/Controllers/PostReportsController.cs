using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.PostReports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    [Authorize]
    public class PostReportsController : BaseController
    {
        private readonly IPostReportsService postReportsService;
        private readonly UserManager<Account> userManager;
        private readonly IHtmlSizeParser htmlSizeParser;

        public PostReportsController(IPostReportsService postReportsService,
            UserManager<Account> userManager,
            IHtmlSizeParser htmlSizeParser)
        {
            this.postReportsService = postReportsService;
            this.userManager = userManager;
            this.htmlSizeParser = htmlSizeParser;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostReportInputModel input, string postId)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            await this.postReportsService.CreatePostReportAsync(accountId, postId, input.Title, input.Description, input.Notes);

            return this.RedirectToAction(nameof(AllPostReports));
        }

        public IActionResult AllPostReports(int? page)
        {
            IEnumerable<PostReportListViewModel> postReportListViewModel;

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            postReportListViewModel = this.postReportsService.GetAllByAccountUnresolved<PostReportListViewModel>(accountId);

            if (postReportListViewModel.Count() > 0)
            {
                postReportListViewModel = PostReportsPager(page, postReportListViewModel);
            }

            return this.View(postReportListViewModel.ToList());
        }

        public IActionResult AllResolvedPostReports(int? page)
        {
            IEnumerable<PostReportListViewModel> postReportListViewModel;

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            postReportListViewModel = this.postReportsService.GetAllByAccountResolved<PostReportListViewModel>(accountId);

            if (postReportListViewModel.Count() > 0)
            {
                postReportListViewModel = PostReportsPager(page, postReportListViewModel);
            }

            return this.View(postReportListViewModel.ToList());
        }

        private static IEnumerable<PostReportListViewModel> PostReportsPager(int? page, IEnumerable<PostReportListViewModel> postReportListViewModel)
        {
            postReportListViewModel = postReportListViewModel.OrderByDescending(x => x.CreatedOn);
            var pager = new Pager(postReportListViewModel.Count(), page);
            postReportListViewModel = postReportListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            postReportListViewModel.AsParallel().ForAll(x => x.Pager = pager);
            return postReportListViewModel;
        }

    }
}
