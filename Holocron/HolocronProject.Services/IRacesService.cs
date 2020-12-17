using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IRacesService
    {
        IEnumerable<T> GetAll<T>();
    }
}
