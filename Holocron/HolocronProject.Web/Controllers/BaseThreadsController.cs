using HolocronProject.Services;
using HolocronProject.Web.ViewModels.BaseThreads;
using HolocronProject.Web.ViewModels.Pager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class BaseThreadsController : BaseController
    {
        private readonly IBaseThreadsService baseThreadService;
        private readonly IPostsService postsService;

        public BaseThreadsController(IBaseThreadsService baseThreadService,
            IPostsService postsService)
        {
            this.baseThreadService = baseThreadService;
            this.postsService = postsService;
        }

        public IActionResult ById(string threadId, int? page)
        {
            var baseThread = this.baseThreadService.GetById<BaseThreadViewModel>(threadId);

            var pager = new Pager(baseThread.ThreadsCount, page);
            baseThread.Threads = baseThread.Threads.Where(x => !x.IsDeleted);
            baseThread.Threads = baseThread.Threads.OrderByDescending(x => x.CreatedOn);
            baseThread.Threads = baseThread.Threads.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);

            foreach (var thread in baseThread.Threads)
            {
                thread.PostsCount = this.postsService.TotalPostInThread(thread.Id);
            }


            baseThread.Pager = pager;

            return this.View(baseThread);
        }
    }
}
