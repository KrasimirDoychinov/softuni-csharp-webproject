using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IClassService
    {
        Class GetClassIdByName(string className);

        Class GetClassById(string classId);

        IEnumerable<Class> GetAll();
    }
}
