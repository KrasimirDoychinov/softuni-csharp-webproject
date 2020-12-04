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

namespace HolocronProject.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
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

        [Authorize(Roles = "Admin")]
        public IActionResult NewestPosts(int? page)
        {
            var lastPosts = this.postService.GetAllLastPosts<LastPostsViewModel>();

            if (lastPosts.Count() > 0)
            {
                lastPosts = PostParserAndSanitizer(page, lastPosts);
            }


            return this.View(lastPosts.ToList());
        }

        private IEnumerable<LastPostsViewModel> PostParserAndSanitizer(int? page, IEnumerable<LastPostsViewModel> lastPosts)
        {
            var sanitizer = new HtmlSanitizer();

            var pager = new Pager(lastPosts.Count(), page);
            lastPosts = lastPosts.OrderByDescending(x => x.CreatedOn);
            lastPosts = lastPosts.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            lastPosts.FirstOrDefault().Pager = pager;

            sanitizer.AllowedTags.Add("iframe");

            lastPosts.AsParallel().ForAll(x => x.SanitizedDescription = sanitizer.Sanitize(x.Description));
            lastPosts.AsParallel().ForAll(x => x.SanitizedDescription = this.htmlSizeParser.Parse(x.SanitizedDescription, 100, 50));
            return lastPosts;
        }
    }
}
