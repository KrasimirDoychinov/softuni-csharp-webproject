﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Ganss.XSS;

using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.Posts;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

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
            var lastPosts = this.postService.GetAllPosts<LastPostsViewModel>();

            lastPosts.AsParallel().ForAll(x => x.TotalPosts = lastPosts.Count());
            lastPosts.AsParallel().ForAll(x => x.PostsMadeToday = lastPosts.Where(x => x.CreatedOn.DayOfYear == DateTime.UtcNow.DayOfYear).Count());
            lastPosts.AsParallel().ForAll(x => x.DeletedPosts = lastPosts.Where(x => x.IsDeleted).Count());
            lastPosts.AsParallel().ForAll(x => x.NotDeletedPosts = lastPosts.Where(x => !x.IsDeleted).Count());

            if (lastPosts.Count() > 0)
            {
                lastPosts = LastPostsPager(page, lastPosts);
                LastPostsSanitizer(lastPosts);
            }

            return this.View(lastPosts.ToList());
        }

        public async Task<IActionResult> Delete(string postId)
        {
            await this.postService.DeletePostAsync(postId);

            return RedirectToAction(nameof(NewestPosts));
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
