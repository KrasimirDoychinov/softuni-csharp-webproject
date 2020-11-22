using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.BugReports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class BugReportsController : Controller
    {
        private readonly IBugReportService bugReportService;
        private readonly UserManager<Account> userManager;

        public BugReportsController(IBugReportService bugReportService,
            UserManager<Account> userManager)
        {
            this.bugReportService = bugReportService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(BugReportInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            await this.bugReportService.CreateBugReportAsync(accountId, input.Title, input.Description, input.Notes);

            return this.RedirectToAction(nameof(AllBugReports));
        }

        [Authorize]
        public IActionResult AllBugReports()
        {
            IEnumerable<BugReportListViewModel> bugReportsViewModel;
            if (this.User.IsInRole("Admin"))
            {
                bugReportsViewModel = this.bugReportService.GetAllAdminUnresolved<BugReportListViewModel>();
            }
            else
            {
                var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
                bugReportsViewModel = this.bugReportService.GetAllByAccountUnresolved<BugReportListViewModel>(accountId);

            }

            return this.View(bugReportsViewModel);
        }

        [Authorize]
        public IActionResult AllResolvedBugReports()
        {
            IEnumerable<BugReportListViewModel> bugReportsViewModel;
            if (this.User.IsInRole("Admin"))
            {
                bugReportsViewModel = this.bugReportService.GetAllAdminResolved<BugReportListViewModel>();
            }
            else
            {
                var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
                bugReportsViewModel = this.bugReportService.GetAllByAccountResolved<BugReportListViewModel>(accountId);
            }

            return this.View(bugReportsViewModel);
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

            return this.RedirectToAction(nameof(AllBugReports));
        }
    }
}
