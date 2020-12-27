using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.BugReports;
using HolocronProject.Web.ViewModels.Pager;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HolocronProject.Web.Controllers
{
    [Authorize]
    public class BugReportsController : BaseController
    {
        private readonly IBugReportsService bugReportService;
        private readonly UserManager<Account> userManager;

        public BugReportsController(IBugReportsService bugReportService,
            UserManager<Account> userManager)
        {
            this.bugReportService = bugReportService;
            this.userManager = userManager;
        }

        
        public IActionResult Create()
        {
            return this.View();
        }

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

        public IActionResult AllBugReports(int? page)
        {
            IEnumerable<BugReportListViewModel> bugReportsViewModel;

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            bugReportsViewModel = this.bugReportService.GetAllByAccountUnresolved<BugReportListViewModel>(accountId, null);

            if (bugReportsViewModel.Count() > 0)
            {
                bugReportsViewModel = BugReportsPager(page, bugReportsViewModel);
            }

            return this.View(bugReportsViewModel.ToList());
        }

        public IActionResult AllResolvedBugReports(int? page)
        {
            IEnumerable<BugReportListViewModel> bugReportsViewModel;

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            bugReportsViewModel = this.bugReportService.GetAllByAccountResolved<BugReportListViewModel>(accountId, null);

            if (bugReportsViewModel.Count() > 0)
            {
                bugReportsViewModel = BugReportsPager(page, bugReportsViewModel);
            }

            return this.View(bugReportsViewModel.ToList());
        }

        private static IEnumerable<BugReportListViewModel> BugReportsPager(int? page, IEnumerable<BugReportListViewModel> bugReportsViewModel)
        {
            bugReportsViewModel = bugReportsViewModel.OrderByDescending(x => x.CreatedOn);
            var pager = new Pager(bugReportsViewModel.Count(), page);
            bugReportsViewModel = bugReportsViewModel.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            bugReportsViewModel.AsParallel().ForAll(x => x.Pager = pager);
            return bugReportsViewModel;
        }
    }
}
