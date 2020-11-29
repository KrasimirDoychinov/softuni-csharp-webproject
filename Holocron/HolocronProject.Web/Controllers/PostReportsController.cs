using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class PostReportsController : Controller
    {
        
        [Authorize]
        public IActionResult Create(string postId)
        {
            return this.View();
        }
    }
}
