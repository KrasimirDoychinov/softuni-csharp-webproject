﻿using System.Collections.Generic;

using AutoMapper;

namespace HolocronProject.Services
{
    public interface IClassesService
    {
        IEnumerable<T> GetAll<T>(IMapper mapper);
    }
}
