using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace HolocronProject.Web.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewData["random"] = new Random().NextDouble();
            base.OnActionExecuted(context);
        }
    }
}
