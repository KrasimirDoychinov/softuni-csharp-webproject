using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using HolocronProject.Services.ViewModelsTemp;

namespace HolocronProject.Services
{
    public interface IRaceService
    {
        Task CreateRace(string name);
        
    }
}
