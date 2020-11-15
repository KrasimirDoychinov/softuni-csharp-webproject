using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HolocronProject.Data.Common;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolocronProject.Web.Areas.Identity.Pages.Account.Manage
{
    using static GlobalRangeConstraints;
    using static GlobalErrorMessages;
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<Data.Models.Account> _userManager;
        private readonly SignInManager<Data.Models.Account> _signInManager;
        private readonly IAccountService accountService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public IndexModel(
            UserManager<Data.Models.Account> userManager,
            SignInManager<Data.Models.Account> signInManager,
            IAccountService accountService,
            IWebHostEnvironment webHostEnvironment
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.accountService = accountService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [StringLength(AccountConstants.UserNameMaxLenght, MinimumLength = AccountConstants.UserNameMinLenght, ErrorMessage = AccountErrorMessages.UserNameLengthError)]
        [RegularExpression(AccountConstants.UserNameRegex, ErrorMessage = AccountErrorMessages.UserNameRegexError)]
        public string UserName { get; set; }

        public string AvatarImagePath { get; set; }

        public IFormFile AvatarImage { get; set; }

        [TempData]
        public string StatusMessage { get; set; }


        private async Task LoadAsync(Data.Models.Account user)
        {
            var userName = await _userManager.GetUserNameAsync(user);

            UserName = userName;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            
            var user = await _userManager.GetUserAsync(User);
            AvatarImagePath = user.AvatarImagePath;
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string userName, IFormFile avatarImage)
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

            if (avatarImage != null)
            {
                user.AvatarImagePath = $"{user.Id}(Account).png";
                if (user.AvatarImagePath != null)
                {
                    System.IO.File.Delete(webHostEnvironment.WebRootPath + $"/Images/AvatarImages/{user.AvatarImagePath}.png");
                }

                
                using (var fs = new FileStream(
                    this.webHostEnvironment.WebRootPath + $"/Images/AvatarImages/{user.AvatarImagePath}", FileMode.Create))
                {
                    
                    await avatarImage.CopyToAsync(fs);
                }
            }
            
            
            await this.accountService.UpdateUserNameAsync(user.Id, userName);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
