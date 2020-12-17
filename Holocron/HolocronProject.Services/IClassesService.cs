using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IClassesService
    {
        IEnumerable<T> GetAll<T>();
    }
}
