using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using Ganss.XSS;

using HolocronProject.Services;
using HolocronProject.Data.Common;
using HolocronProject.Web.ValidationAttributes;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolocronProject.Web.Areas.Identity.Pages.Account.Manage
{
    using static GlobalRangeConstraints;
    using static GlobalErrorMessages;
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<Data.Models.Account> _userManager;
        private readonly SignInManager<Data.Models.Account> _signInManager;
        private readonly IAccountsService accountService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly Random random;

        public IndexModel(
            UserManager<Data.Models.Account> userManager,
            SignInManager<Data.Models.Account> signInManager,
            IAccountsService accountService,
            IWebHostEnvironment webHostEnvironment,
            Random random
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.accountService = accountService;
            this.webHostEnvironment = webHostEnvironment;
            this.random = random;
        }

        [Display(Name = "Username")]
        [StringLength(UserConstants.UserNameMaxLenght, MinimumLength = UserConstants.UserNameMinLenght, ErrorMessage = UserErrorMessages.UserNameLengthError)]
        [RegularExpression(UserConstants.UserNameRegex, ErrorMessage = UserErrorMessages.UserNameRegexError)]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "Forum signature")]
        [MaxLength(UserConstants.ForumSignatureMaxLength, ErrorMessage = UserErrorMessages.ForumSignatureLengthError)]
        public string ForumSignature { get; set; }

        public string SanitizedForumSignature => new HtmlSanitizer().Sanitize(this.ForumSignature);

        public DateTime CreatedOn { get; set; }

        public string AvatarImagePath { get; set; }
        
        [ImageValidator]
        public IFormFile AvatarImage { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        private async Task LoadAsync(Data.Models.Account user)
        {
            var userName = await _userManager.GetUserNameAsync(user);

            ViewData["random"] = random.NextDouble().ToString();

            UserName = userName;
            AvatarImagePath = user.AvatarImagePath;
            ForumSignature = user.ForumSignature;
            CreatedOn = user.CreatedOn;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            ViewData["random"] = random.NextDouble().ToString();

            AvatarImagePath = user.AvatarImagePath;
            ForumSignature = user.ForumSignature;
            CreatedOn = user.CreatedOn;

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string userName, string forumSignature, IFormFile avatarImage)
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

            
            await this.accountService.UpdateUserNameAsync(user.Id, userName);
            if (avatarImage != null)
            {
                await this.accountService.UpdateAvatarImageAsync(this.webHostEnvironment.WebRootPath, user.Id, avatarImage);
            }

            
            if (user.ForumSignature != forumSignature)
            {
                await this.accountService.UpdateForumSignatureAsync(user.Id, forumSignature);
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
