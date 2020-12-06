using Ganss.XSS;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.Controllers;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.PostReports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    public class PostReportsController : BaseAdminController
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

        [Authorize(Roles = "Admin")]
        public IActionResult AllPostReports(int? page)
        {
            IEnumerable<PostReportListViewModel> postListViewModel;

            postListViewModel = this.postReportsService.GetAllAdminUnresolved<PostReportListViewModel>();

            if (postListViewModel.Count() > 0)
            {
                postListViewModel = postListViewModel.OrderByDescending(x => x.NormalizedCreatedOn);
                var pager = new Pager(postListViewModel.Count(), page);
                postListViewModel = postListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
                postListViewModel.FirstOrDefault().Pager = pager;

            }

            return this.View(postListViewModel.ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AllResolvedPostReports(int? page)
        {
            IEnumerable<PostReportListViewModel> postListViewModel;

            postListViewModel = this.postReportsService.GetAllAdminResolved<PostReportListViewModel>();

            if (postListViewModel.Count() > 0)
            {
                postListViewModel = postListViewModel.OrderByDescending(x => x.NormalizedCreatedOn);
                var pager = new Pager(postListViewModel.Count(), page);
                postListViewModel = postListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
                postListViewModel.FirstOrDefault().Pager = pager;
            }


            return this.View(postListViewModel.ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ById(string id)
        {
            var bugReportViewModel = this.postReportsService.GetPostReportByIdGeneric<PostReportViewModel>(id);

            var sanitizer = new HtmlSanitizer();

            sanitizer.AllowedTags.Add("iframe");

            bugReportViewModel.Post.SanitizedDescription = sanitizer.Sanitize(bugReportViewModel.Post.Description);
            bugReportViewModel.Post.SanitizedDescription = this.htmlSizeParser.Parse(bugReportViewModel.Post.SanitizedDescription, 100, 50);


            return this.View(bugReportViewModel);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Resolve(string id)
        {
            await this.postReportsService.ResolvePostReportAsync(id);

            return this.Redirect("/Administration/PostReports/AllPostReports");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id, string postId)
        {
            await this.postReportsService.DeletePostReportAsync(id, postId);

            return this.Redirect("/Administration/PostReports/AllPostReports");
        }
    }
}
