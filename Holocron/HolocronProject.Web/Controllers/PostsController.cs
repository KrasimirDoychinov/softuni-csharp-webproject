using Ganss.XSS;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Pager;
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
        public IActionResult LastPosts(string accountId, int? page)
        {
            var lastPosts = this.postService.GetLastPostsByAccountId<LastPostsViewModel>(accountId);
            var sanitizer = new HtmlSanitizer();

            var pager = new Pager(lastPosts.Count(), page);
            lastPosts = lastPosts.OrderByDescending(x => x.CreatedOn);
            lastPosts = lastPosts.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            lastPosts.FirstOrDefault().Pager = pager;

            sanitizer.AllowedTags.Add("iframe");

            lastPosts.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastPosts.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));

            return this.View(lastPosts.ToList());
        }
        
    }
}
