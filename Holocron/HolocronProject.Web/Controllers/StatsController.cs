using HolocronProject.Data;
using HolocronProject.Web.ViewModels.Stats;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace HolocronProject.Web.Controllers
{
    public class StatsController : Controller
    {
        public StatsController()
        {

        }
        
        [Authorize]
        public IActionResult Stats()
        {
            return View();
        }
    }

}
