using HolocronProject.Services;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class VotesController : Controller
    {
        private readonly IServerService serverService;

        public VotesController(IServerService serverService)
        {
            this.serverService = serverService;
        }

        [HttpPost]
        public IActionResult Post()
        {
            var json = new JsonResult("GOSHO");
            return new JsonResult(json);
        }
    }
}
