using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.BugReports;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BugReportsController : BaseAdminController
    {
        private readonly IBugReportsService bugReportService;
        private readonly UserManager<Account> userManager;

        public BugReportsController(IBugReportsService bugReportService,
           UserManager<Account> userManager)
        {
            this.bugReportService = bugReportService;
            this.userManager = userManager;
        }

        public IActionResult AllBugReports(int? page)
        {
            IEnumerable<BugReportListViewModel> bugReportsList;

            bugReportsList = this.bugReportService.GetAllAdminUnresolved<BugReportListViewModel>(null);

            if (bugReportsList.Count() > 0)
            {
                bugReportsList = BugReportsListPager(page, bugReportsList);
            }

            return this.View(bugReportsList.ToList());
        }

        public IActionResult AllResolvedBugReports(int? page)
        {
            IEnumerable<BugReportListViewModel> bugReportsList;

            bugReportsList = this.bugReportService.GetAllAdminResolved<BugReportListViewModel>(null);

            if (bugReportsList.Count() > 0)
            {
                bugReportsList = BugReportsListPager(page, bugReportsList);
            }
            
            return this.View(bugReportsList.ToList());
        }

        public IActionResult ById(string id)
        {
            var bugReportViewModel = this.bugReportService.GetBugReportByIdGeneric<BugReportViewModel>(id, null);

            return this.View(bugReportViewModel);
        }

        public async Task<IActionResult> Resolve(string id)
        {
            await this.bugReportService.ResolveBugReportAsync(id);

            return this.Redirect("/Administration/BugReports/AllBugReports");
        }

        private static IEnumerable<BugReportListViewModel> BugReportsListPager(int? page, IEnumerable<BugReportListViewModel> bugReportsList)
        {
            bugReportsList = bugReportsList.OrderByDescending(x => x.CreatedOn);
            var pager = new Pager(bugReportsList.Count(), page);
            bugReportsList = bugReportsList.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            bugReportsList.AsParallel().ForAll(x => x.Pager = pager);
            return bugReportsList;
        }

    }
}
