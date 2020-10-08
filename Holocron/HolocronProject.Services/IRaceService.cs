using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IRaceService
    {
        Task CreateAllCurrentRaces();

        Task CreateNewRace(string raceName);
    }
}
