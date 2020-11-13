using HolocronProject.Services;
using HolocronProject.Web.ViewModels.BaseThreads;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class BaseThreadsController : Controller
    {
        private readonly IBaseThreadService baseThreadService;

        public BaseThreadsController(IBaseThreadService baseThreadService)
        {
            this.baseThreadService = baseThreadService;
        }

        public IActionResult ById(string id)
        {
            var baseThread = this.baseThreadService.GetById<BaseThreadViewModel>(id);

            return this.View(baseThread);
        }
    }
}
