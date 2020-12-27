using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Services;
using HolocronProject.Data.Common;
using HolocronProject.Web.ValidationAttributes;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;

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
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IAccountsService userService;
        private readonly IAccountsService accountsService;
        private readonly Services.EmailSender.IEmailSender emailSender;

        public RegisterModel(
            UserManager<Data.Models.Account> userManager,
            SignInManager<Data.Models.Account> signInManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<RegisterModel> logger,
            IWebHostEnvironment webHostEnvironment,
            IAccountsService userService,
            IAccountsService accountsService,
            Services.EmailSender.IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            this.webHostEnvironment = webHostEnvironment;
            this.userService = userService;
            this.accountsService = accountsService;
            this.emailSender = emailSender;
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

            [Required]
            [Display(Name = "Email")]
            [EmailAddress]
            public string Email { get; set; }

            [Display(Name = "Avatar")]
            [ImageValidator]
            public IFormFile AvatarImage { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (this.accountsService.IsEmailTaken(Input.Email))
            {
                ModelState.AddModelError("Email", "The email is already taken.");
            }

            if (ModelState.IsValid)
            {
                var user = new Data.Models.Account { UserName = Input.UserName, Email = Input.Email };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Account created a new account with password.");

                    if (Input.AvatarImage != null)
                    {
                        await this.userService.CreateAvatarImageAsync(this.webHostEnvironment.WebRootPath, user.Id, Input.AvatarImage);
                    }

                    else
                    {
                        await this.accountsService.AddDefaultAvatarImagePathAsync(user.Id);
                    }

                    string confirmationToken = _userManager.
                    GenerateEmailConfirmationTokenAsync(user).Result;

                    string confirmationLink = Url.Action("ConfirmEmail",
                      "Accounts", new
                      {
                          userid = user.Id,
                          token = confirmationToken
                      },
                       protocol: HttpContext.Request.Scheme);

                    this.emailSender.SendConfirmationEmail(user, confirmationLink);
                    return RedirectToAction("Login", "Account");

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
