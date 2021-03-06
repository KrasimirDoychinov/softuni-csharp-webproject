﻿using System.Linq;

using HolocronProject.Services;
using HolocronProject.Web.ViewModels.Pager;
using HolocronProject.Web.ViewModels.BaseThreads;

using Microsoft.AspNetCore.Mvc;

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
            var baseThread = this.baseThreadService.GetById<BaseThreadViewModel>(threadId, null);
            Pager pager = BaseThreadPager(page, baseThread);

            foreach (var thread in baseThread.Threads)
            {
                thread.PostsCount = this.postsService.TotalNotDeletedPostInThread(thread.Id);
            }

            baseThread.Pager = pager;

            return this.View(baseThread);
        }

        private static Pager BaseThreadPager(int? page, BaseThreadViewModel baseThread)
        {
            var pager = new Pager(baseThread.ThreadsCount, page);
            baseThread.Threads = baseThread.Threads.Where(x => !x.IsDeleted);
            baseThread.Threads = baseThread.Threads.OrderByDescending(x => x.CreatedOn);
            baseThread.Threads = baseThread.Threads.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            return pager;
        }
    }
}
