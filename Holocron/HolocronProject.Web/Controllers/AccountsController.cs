using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class AccountsController : BaseController
    {
        private readonly IAccountsService accountService;
        private readonly UserManager<Account> userManager;

        public AccountsController(IAccountsService accountService,
            UserManager<Account> userManager)
        {
            this.accountService = accountService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult ForeignAccount(string accountId)
        {
            if (this.userManager.GetUserAsync(this.User).Result.Id == accountId)
            {
                return this.Redirect("/Identity/Account/Manage");
            }

            var foreignAccount = this.accountService.GetAccountByIdGeneric<ForeignAccountViewModel>(accountId);

            var account = this.accountService.GetAccountById(accountId);
            foreignAccount.Role = this.userManager.GetRolesAsync(account).Result.FirstOrDefault();

            return this.View(foreignAccount);
        }

        [Authorize]
        public async Task<IActionResult> RemoveNotification(string accountId)
        {
            await this.accountService.RemoveNotification(accountId);

            return this.Redirect("/");
        }
    }
}
