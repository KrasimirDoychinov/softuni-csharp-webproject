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

namespace HolocronProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClassService classService;
        private readonly IAccountService accountService;

        public HomeController(ILogger<HomeController> logger,
            IClassService classService,
            IAccountService accountService)
        {
            _logger = logger;
            this.classService = classService;
            this.accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
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
