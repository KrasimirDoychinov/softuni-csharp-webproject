using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IRacesService
    {
        Task CreateRaceAsync(string name);

        IEnumerable<T> GetAll<T>();
        
    }
}
