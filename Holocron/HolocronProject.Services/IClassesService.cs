using System.Collections.Generic;
using AutoMapper;
using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IClassesService
    {
        IEnumerable<T> GetAll<T>(IMapper mapper);
    }
}
