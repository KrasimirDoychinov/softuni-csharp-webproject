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

namespace HolocronProject.Web.Areas.Identity.Pages.Account
{
    using static GlobalErrorMessages;
    using static GlobalRangeConstraints;

    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Data.Models.Account> _signInManager;
        private readonly UserManager<Data.Models.Account> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment webHostEnvironment;

        public RegisterModel(
            UserManager<Data.Models.Account> userManager,
            SignInManager<Data.Models.Account> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            this.webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            [AccountEmailTaken]
            public string Email { get; set; }

            [Required]
            [Display(Name = "User name")]
            [RegularExpression(AccountConstants.UserNameRegex, ErrorMessage = AccountErrorMessages.UserNameRegexError)]
            [StringLength(AccountConstants.UserNameMaxLenght, ErrorMessage = AccountErrorMessages.UserNameLengthError, MinimumLength = AccountConstants.UserNameMinLenght)]
            public string UserName { get; set; }

            [Required]
            [StringLength(AccountConstants.PasswordMaxLength, ErrorMessage = AccountErrorMessages.PasswordLengthError, MinimumLength = AccountConstants.PasswordMinLength)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "Display name")]
            [RegularExpression(AccountConstants.DisplayNameRegex, ErrorMessage = AccountErrorMessages.DisplayNameRegexError)]
            [MaxLength(AccountConstants.DisplayNameMaxLength, ErrorMessage = AccountErrorMessages.DisplayNameLengthError)]
            [AccountDisplayNameTaken]
            public string DisplayName { get; set; }

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
            Input.AvatarImagePath = $"{Input.Email}.png";

            if (ModelState.IsValid)
            {
                if (Input.AvatarImage != null)
                {
                    using (var fs = new FileStream(
                        this.webHostEnvironment.WebRootPath + $"/Images/AvatarImages/{Input.DisplayName}.png", FileMode.Create))
                    {
                        await Input.AvatarImage.CopyToAsync(fs);
                    }
                }
                
                var user = new Data.Models.Account { UserName = Input.UserName,
                    Email = Input.Email, 
                    DisplayName = Input.DisplayName, 
                    AvatarImagePath = Input.AvatarImagePath};

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
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
