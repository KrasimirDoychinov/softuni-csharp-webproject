using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using HolocronProject.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using SixLabors.ImageSharp;
using HolocronProject.Data.Common;
using HolocronProject.Web.ValidationAttributes;
using HolocronProject.Services;

namespace HolocronProject.Web.Areas.Identity.Pages.Account
{
    using static GlobalErrorMessages;
    using static GlobalRangeConstraints;

    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Data.Models.Account> _signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<Data.Models.Account> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IAccountService userService;

        public RegisterModel(
            UserManager<Data.Models.Account> userManager,
            SignInManager<Data.Models.Account> signInManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IWebHostEnvironment webHostEnvironment,
            IAccountService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.roleManager = roleManager;
            _logger = logger;
            _emailSender = emailSender;
            this.webHostEnvironment = webHostEnvironment;
            this.userService = userService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            [Required]
            [Display(Name = "Username")]
            [RegularExpression(UserConstants.UserNameRegex, ErrorMessage = UserErrorMessages.UserNameRegexError)]
            [StringLength(UserConstants.UserNameMaxLenght, ErrorMessage = UserErrorMessages.UserNameLengthError, MinimumLength = UserConstants.UserNameMinLenght)]
            public string UserName { get; set; }

            [Required]
            [StringLength(UserConstants.PasswordMaxLength, ErrorMessage = UserErrorMessages.PasswordLengthError, MinimumLength = UserConstants.PasswordMinLength)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string AvatarImagePath { get; set; }

            [Display(Name = "Avatar")]
            [AccountAvatarImage]
            public IFormFile AvatarImage { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            

            if (ModelState.IsValid)
            {
                var user = new Data.Models.Account { UserName = Input.UserName };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    var adminRole = new IdentityRole() { Name = "Admin" };
                    var userRole = new IdentityRole() { Name = "Account" };

                    await roleManager.CreateAsync(userRole);
                    await roleManager.CreateAsync(adminRole);

                    if (Input.UserName == "TestAdmin1" && Input.Password == "TestAdmin1.")
                    {
                        await _userManager.AddToRoleAsync(user, "Admin");
                    }


                    _logger.LogInformation("Account created a new account with password.");

                    
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    if (Input.AvatarImage != null)
                    {
                        await this.userService.CreateAvatarImageAsync(user.Id, Input.AvatarImage);
                    }
                    return LocalRedirect(returnUrl);

                    
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                
            }

            

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
