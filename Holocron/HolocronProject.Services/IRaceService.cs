using HolocronProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IRaceService
    {
        Task CreateNewRace(string raceName);

        IEnumerable<RaceDto> MostPlayedRaces(int topAmmount);

    }
}
