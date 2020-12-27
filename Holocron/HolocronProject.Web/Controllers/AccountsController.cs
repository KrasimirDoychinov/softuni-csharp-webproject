using System.Linq;
using System.Threading.Tasks;

using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Accounts;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

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
            await this.accountService.RemoveNotificationAsync(accountId);

            return this.Redirect("/");
        }

        public IActionResult ConfirmEmail(string userid, string token)
        {
            var user = userManager.FindByIdAsync(userid).Result;
            var result = userManager.
                        ConfirmEmailAsync(user, token).Result;

            if (result.Succeeded)
            {
                ViewBag.Message = "Email confirmed successfully!";
                return View("SuccessfulEmailConfirmation");
            }
            else
            {
                ViewBag.Message = "Error while confirming your email!";
                return View("UnSuccessfulEmailConfirmation");
            }
        }
    }
}
