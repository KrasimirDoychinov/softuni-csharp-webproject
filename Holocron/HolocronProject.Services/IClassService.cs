using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services
{
    public interface IClassService
    {
        Class GetClassByName(string className);
    }
}
