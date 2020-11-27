using Ganss.XSS;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostsService postService;
        private readonly UserManager<Account> userManager;
        private readonly IHtmlSizeParser htmlSizeParser;
        private readonly Random random;

        public PostsController(IPostsService postService,
            UserManager<Account> userManager,
            IHtmlSizeParser htmlSizeParser,
            Random random)
        {
            this.postService = postService;
            this.userManager = userManager;
            this.htmlSizeParser = htmlSizeParser;
            this.random = random;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(PostInputModel input, string threadId)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            var accountId = this.userManager.GetUserAsync(this.User).Result.Id;
            await this.postService.CreatePostAsync(input.Description, threadId, accountId);

            return this.Redirect($"/Threads/ById?threadId={threadId}");
        } 

        [Authorize]
        public IActionResult LastPosts(string accountId)
        {
            var lastPost = this.postService.GetLast10PostsByAccountId<LastPostsViewModel>(accountId);
            var sanitizer = new HtmlSanitizer();

            sanitizer.AllowedTags.Add("iframe");

            lastPost.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastPost.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));

            return this.View(lastPost);
        }
        
    }
}
