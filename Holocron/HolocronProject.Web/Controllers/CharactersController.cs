using AutoMapper;
using HolocronProject.Services;
using HolocronProject.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class CharactersController : Controller
    {
        private readonly IClassService classService;
        private readonly IMapper mapper;

        public CharactersController(IClassService classService, IMapper mapper)
        {
            this.classService = classService;
            this.mapper = mapper;
        }

        public IActionResult All()
        {
            var classes = this.classService.GetAll();

            var n = classes.FirstOrDefault();

            var testClass = mapper.Map<TestClass>(n);

            return this.View(testClass);
        }

    }
}
