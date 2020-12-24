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
    [Authorize]
    public class PostsController : BaseController
    {
        private readonly IPostsService postService;
        private readonly UserManager<Account> userManager;
        private readonly IHtmlSizeParser htmlSizeParser;

        public PostsController(IPostsService postService,
            UserManager<Account> userManager,
            IHtmlSizeParser htmlSizeParser)
        {
            this.postService = postService;
            this.userManager = userManager;
            this.htmlSizeParser = htmlSizeParser;
        }

        public IActionResult Create()
        {
            return this.View();
        }

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

        public IActionResult Edit(string postId)
        {
            var postViewModel = this.postService.GetNotDeletedPostById<PostEditViewModel>(postId);

            return this.View(postViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostEditViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.postService.EditPostByIdAsync(input.PostId, input.Description);

            return this.Redirect($"/Threads/ById?threadId={input.ThreadId}");
        }

        public IActionResult LastPosts(string accountId, int? page)
        {
            var lastPosts = this.postService.GetLastNotDeletedPostsByAccountId<LastPostsViewModel>(accountId);

            if (lastPosts.Count() > 0)
            {
                lastPosts = LastPostsPager(page, lastPosts);
                LastPostsSanitizer(lastPosts);
                lastPosts.AsParallel().ForAll(x => x.NormalizedCreatedOn = x.CreatedOn.ToLocalTime().ToString("MM/dd/yyyy h:mm tt"));
            }

            return this.View(lastPosts.ToList());
        }

        private static IEnumerable<LastPostsViewModel> LastPostsPager(int? page, IEnumerable<LastPostsViewModel> lastPosts)
        {
            var pager = new Pager(lastPosts.Count(), page);
            lastPosts = lastPosts.OrderByDescending(x => x.CreatedOn);
            lastPosts = lastPosts.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            lastPosts.AsParallel().ForAll(x => x.Pager = pager);
            return lastPosts;
        }

        private void LastPostsSanitizer(IEnumerable<LastPostsViewModel> lastPosts)
        {
            var sanitizer = new HtmlSanitizer();
            sanitizer.AllowedTags.Add("iframe");

            lastPosts.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastPosts.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));
        }
    }
}
