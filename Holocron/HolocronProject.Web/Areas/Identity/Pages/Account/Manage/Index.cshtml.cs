using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolocronProject.Web.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<Data.Models.Account> _userManager;
        private readonly SignInManager<Data.Models.Account> _signInManager;
        private readonly IAccountService accountService;

        public IndexModel(
            UserManager<Data.Models.Account> userManager,
            SignInManager<Data.Models.Account> signInManager,
            IAccountService accountService
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.accountService = accountService;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [Display(Name = "Display name")]
        public string DisplayName { get; set; }

        private async Task LoadAsync(Data.Models.Account user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var displayName = this.accountService.GetDisplayName(user.Id);

            Username = userName;
            DisplayName = displayName;

        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string displayName)
        {
            var user = await _userManager.GetUserAsync(User);
            
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            await this.accountService.UpdateDisplayNameAsync(user.Id, displayName);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
