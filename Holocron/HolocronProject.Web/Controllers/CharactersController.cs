using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult AddCharacter()
        {
            return this.View();
        }
    }
}
