﻿using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.BugReports;
using HolocronProject.Web.ViewModels.Pager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class BugReportsController : Controller
    {
        private readonly IBugReportsService bugReportService;
        private readonly UserManager<Account> userManager;

        public BugReportsController(IBugReportsService bugReportService,
           UserManager<Account> userManager)
        {
            this.bugReportService = bugReportService;
            this.userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AllBugReports(int? page)
        {
            IEnumerable<BugReportListViewModel> bugReportsViewModel;

            bugReportsViewModel = this.bugReportService.GetAllAdminUnresolved<BugReportListViewModel>();

            if (bugReportsViewModel.Count() > 0)
            {
                bugReportsViewModel = bugReportsViewModel.OrderByDescending(x => x.NormalizedCreatedOn);
                var pager = new Pager(bugReportsViewModel.Count(), page);
                bugReportsViewModel = bugReportsViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
                bugReportsViewModel.FirstOrDefault().Pager = pager;
            }

            return this.View(bugReportsViewModel.ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AllResolvedBugReports(int? page)
        {
            IEnumerable<BugReportListViewModel> bugReportsViewModel;

            bugReportsViewModel = this.bugReportService.GetAllAdminResolved<BugReportListViewModel>();

            if (bugReportsViewModel.Count() > 0)
            {
                bugReportsViewModel = bugReportsViewModel.OrderByDescending(x => x.NormalizedCreatedOn);
                var pager = new Pager(bugReportsViewModel.Count(), page);
                bugReportsViewModel = bugReportsViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
                bugReportsViewModel.FirstOrDefault().Pager = pager;
            }

            return this.View(bugReportsViewModel.ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ById(string id)
        {
            var bugReportViewModel = this.bugReportService.GetBugReportByIdGeneric<BugReportViewModel>(id);

            return this.View(bugReportViewModel);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Resolve(string id)
        {
            await this.bugReportService.ResolveBugReportAsync(id);

            return this.Redirect("/BugReports/AllBugReports");
        }
    }
}