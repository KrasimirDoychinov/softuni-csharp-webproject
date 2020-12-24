using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.Areas.Administration.ViewModels.Accounts;
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
    [Authorize(Roles = "Admin")]
    public class AccountsController : BaseAdminController
    {
        private readonly IAccountsService accountsService;
        private readonly UserManager<Account> userManager;

        public AccountsController(IAccountsService accountsService,
            UserManager<Account> userManager)
        {
            this.accountsService = accountsService;
            this.userManager = userManager;
        }

        public IActionResult NewestAccounts(int? page)
        {
            var loggedInAccountId = this.userManager.GetUserAsync(this.User).Result.Id;
            var accounts = this.accountsService.GetAllAccounts<NewestAccountsViewModel>(loggedInAccountId);

            accounts.AsParallel().ForAll(x => x.TotalAccounts = accounts.Count());
            accounts.AsParallel().ForAll(x => x.BannedAccounts = accounts.Where(x => x.IsBanned).Count());
            accounts.AsParallel().ForAll(x => x.NotBannedAccounts = accounts.Where(x => !x.IsBanned).Count());
            accounts.AsParallel().ForAll(x => x.AccountsMadeToday = accounts.Where(x => x.CreatedOn.DayOfYear == DateTime.UtcNow.DayOfYear).Count());
            accounts.AsParallel().ForAll(x => x.ConfirmedAccounts = accounts.Where(x => x.EmailConfirmed).Count());
            accounts.AsParallel().ForAll(x => x.PendingAccounts = accounts.Where(x => !x.EmailConfirmed).Count());
            
            accounts = NewestAccountsPager(page, accounts);
            return this.View(accounts);
        }

        public async Task<IActionResult> Ban(string accountId)
        {
            await this.accountsService.BanAccountAsync(accountId);

            return this.RedirectToAction(nameof(NewestAccounts));
        }

        private static IEnumerable<NewestAccountsViewModel> NewestAccountsPager(int? page, IEnumerable<NewestAccountsViewModel> newestAccounts)
        {
            newestAccounts = newestAccounts.OrderByDescending(x => x.CreatedOn);
            var pager = new Pager(newestAccounts.Count(), page);
            newestAccounts = newestAccounts.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            newestAccounts.AsParallel().ForAll(x => x.Pager = pager);
            return newestAccounts.ToList();
        }
    }
}
