using HolocronProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class ThreadsController : Controller
    {
        private readonly IThreadService threadService;

        public ThreadsController(IThreadService threadService)
        {
            this.threadService = threadService;
        }

        [Authorize]
        public IActionResult Create(string baseThreadId)
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(string baseThreadId, string title)
        {
            var accountId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!ModelState.IsValid)
            {
                return this.View(new { title });
            }

            await this.threadService.CreateThreadAsync(title, baseThreadId, accountId);
            return this.Redirect($"/BaseThreads/ById/?id={baseThreadId}");
        }
    }
}
