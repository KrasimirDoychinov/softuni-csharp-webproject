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

        public BaseThreadsController(IBaseThreadsService baseThreadService)
        {
            this.baseThreadService = baseThreadService;
        }

        public IActionResult ById(string threadId, int? page)
        {
            var baseThread = this.baseThreadService.GetById<BaseThreadViewModel>(threadId);

            var pager = new Pager(baseThread.ThreadsCount, page);
            baseThread.Threads = baseThread.Threads.OrderByDescending(x => x.CreatedOn);
            baseThread.Threads = baseThread.Threads.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize);
            baseThread.Pager = pager;

            return this.View(baseThread);
        }
    }
}
