using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAccountsService accountService;

        public AccountsController(IAccountsService accountService)
        {
            this.accountService = accountService;
        }

        [Authorize]
        public IActionResult ForeignAccount(string accountId)
        {
            var foreignAccount = this.accountService.GetAccountByIdGeneric<ForeignAccountViewModel>(accountId);

            return this.View(foreignAccount);
        }

        
    }
}
