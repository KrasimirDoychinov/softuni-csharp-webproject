using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolocronProject.Web.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using HolocronProject.Services;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels.BaseThreads;

namespace HolocronProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBaseThreadsService baseThreadService;

        public HomeController(ILogger<HomeController> logger,
            IBaseThreadsService baseThreadService)
        {
            _logger = logger;
            this.baseThreadService = baseThreadService;
        }

        public IActionResult Index()
        {
            var baseThreads = this.baseThreadService.GetAll<BaseThreadViewModel>();

            return View(baseThreads);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
