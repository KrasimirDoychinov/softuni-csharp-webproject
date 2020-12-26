using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolocronProject.Web.Models;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels.BaseThreads;

namespace HolocronProject.Web.Controllers
{
    public class HomeController : BaseController
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

            foreach (var baseThread in baseThreads)
            {
                baseThread.Threads = baseThread.Threads.Where(x => !x.IsDeleted);
                foreach (var thread in baseThread.Threads)
                {
                    baseThread.ThreadsPostsCount += thread.Posts.Where(x => !x.IsDeleted).Count();
                }
            }
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
