using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace HolocronProject.Web.Controllers
{
    public class AccountsController : Controller
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

            return this.View(foreignAccount);
        }
    }
}
