using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IClassesService
    {
        Class GetClassById(string classId);

        IEnumerable<T> GetAll<T>();
    }
}
