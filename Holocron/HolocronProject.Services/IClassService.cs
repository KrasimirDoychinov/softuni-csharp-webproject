using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IClassService
    {
        Class GetClassById(string classId);

        IEnumerable<T> GetAll<T>();
    }
}
