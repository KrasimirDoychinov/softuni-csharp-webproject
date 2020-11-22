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
        private readonly IPostService postService;
        private readonly UserManager<Account> userManager;

        public PostsController(IPostService postService,

            UserManager<Account> userManager)
        {
            this.postService = postService;
            this.userManager = userManager;
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
        
    }
}
