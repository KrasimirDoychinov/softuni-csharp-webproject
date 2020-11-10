using AutoMapper;
using HolocronProject.Data.Models;
using HolocronProject.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Profiles
{
    public class TestClassProfile : Profile
    {
        public TestClassProfile()
        {
            CreateMap<Class, TestClass>();
        }
    }
}
