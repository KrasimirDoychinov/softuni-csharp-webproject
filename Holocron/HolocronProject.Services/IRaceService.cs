using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IRaceService
    {
        Task CreateRaceAsync(string name);

        Race GetRaceIdByName(string name);
        
    }
}
