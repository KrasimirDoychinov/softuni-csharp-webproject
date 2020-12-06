using Ganss.XSS;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.PostReports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
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

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
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

        [Authorize]
        public IActionResult AllPostReports(int? page)
        {
            IEnumerable<PostReportListViewModel> postListViewModel;

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            postListViewModel = this.postReportsService.GetAllByAccountUnresolved<PostReportListViewModel>(accountId);

            if (postListViewModel.Count() > 0)
            {
                postListViewModel = postListViewModel.OrderByDescending(x => x.CreatedOn);
                var pager = new Pager(postListViewModel.Count(), page);
                postListViewModel = postListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
                postListViewModel.FirstOrDefault().Pager = pager;

            }

            return this.View(postListViewModel.ToList());
        }

        [Authorize]
        public IActionResult AllResolvedPostReports(int? page)
        {
            IEnumerable<PostReportListViewModel> postListViewModel;

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            postListViewModel = this.postReportsService.GetAllByAccountResolved<PostReportListViewModel>(accountId);


            if (postListViewModel.Count() > 0)
            {
                postListViewModel = postListViewModel.OrderByDescending(x => x.ResolvedOn);
                var pager = new Pager(postListViewModel.Count(), page);
                postListViewModel = postListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
                postListViewModel.FirstOrDefault().Pager = pager;
            }


            return this.View(postListViewModel.ToList());
        }
    }
}
