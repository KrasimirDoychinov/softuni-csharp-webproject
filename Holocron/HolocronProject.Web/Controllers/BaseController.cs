using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var random = new Random().NextDouble().ToString();
            ViewData["random"] = random;

            base.OnActionExecuted(filterContext);
        }
    }
}
