﻿using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Ganss.XSS;

using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.PostReports;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
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

        public IActionResult AllPostReports(int? page)
        {
            IEnumerable<PostReportListViewModel> postListViewModel;

            postListViewModel = this.postReportsService.GetAllAdminUnresolved<PostReportListViewModel>();

            if (postListViewModel.Count() > 0)
            {
                postListViewModel = PostListPager(page, postListViewModel);

            }

            return this.View(postListViewModel.ToList());
        }

        public IActionResult AllResolvedPostReports(int? page)
        {
            IEnumerable<PostReportListViewModel> postListViewModel;

            postListViewModel = this.postReportsService.GetAllAdminResolved<PostReportListViewModel>();

            if (postListViewModel.Count() > 0)
            {
                postListViewModel = PostListPager(page, postListViewModel);
            }

            return this.View(postListViewModel.ToList());
        }

        public IActionResult ById(string id)
        {
            var bugReportViewModel = this.postReportsService.GetPostReportByIdGeneric<PostReportViewModel>(id);

            var sanitizer = new HtmlSanitizer();

            sanitizer.AllowedTags.Add("iframe");

            bugReportViewModel.Post.SanitizedDescription = sanitizer.Sanitize(bugReportViewModel.Post.Description);
            bugReportViewModel.Post.SanitizedDescription = this.htmlSizeParser.Parse(bugReportViewModel.Post.SanitizedDescription, 100, 50);

            return this.View(bugReportViewModel);
        }

        public async Task<IActionResult> Resolve(string id)
        {
            await this.postReportsService.ResolvePostReportAsync(id);

            return this.Redirect("/Administration/PostReports/AllPostReports");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await this.postReportsService.DeletePostReportAsync(id);

            return this.Redirect("/Administration/PostReports/AllPostReports");
        }

        private static IEnumerable<PostReportListViewModel> PostListPager(int? page, IEnumerable<PostReportListViewModel> postListViewModel)
        {
            postListViewModel = postListViewModel.OrderByDescending(x => x.CreatedOn);
            var pager = new Pager(postListViewModel.Count(), page);
            postListViewModel = postListViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            postListViewModel.AsParallel().ForAll(x => x.Pager = pager);
            return postListViewModel;
        }

    }
}
