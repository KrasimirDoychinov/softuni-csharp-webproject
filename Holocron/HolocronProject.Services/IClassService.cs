﻿using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IClassService
    {
        Class GetClassByName(string className);

        IEnumerable<Class> GetMostPlayedCasses();
    }
}
