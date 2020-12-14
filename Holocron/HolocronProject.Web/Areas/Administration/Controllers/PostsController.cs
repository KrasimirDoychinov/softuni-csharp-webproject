using Ganss.XSS;
using HolocronProject.Data.Models;
using HolocronProject.Services;
using HolocronProject.Web.Controllers;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PostsController : BaseAdminController
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

        public IActionResult NewestPosts(int? page)
        {
            var lastPosts = this.postService.GetAllLastPosts<LastPostsViewModel>();

            if (lastPosts.Count() > 0)
            {
                lastPosts = LastPostsPager(page, lastPosts);
                LastPostsSanitizer(lastPosts);
            }

            return this.View(lastPosts.ToList());
        }

        private static IEnumerable<LastPostsViewModel> LastPostsPager(int? page, IEnumerable<LastPostsViewModel> lastPosts)
        {
            var pager = new Pager(lastPosts.Count(), page);
            lastPosts = lastPosts.OrderByDescending(x => x.CreatedOn);
            lastPosts = lastPosts.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            lastPosts.FirstOrDefault().Pager = pager;
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
