using HolocronProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IServerService
    {
        // Admin services
        Task CreateAllCurrentServers();

        Task CreateNewServer(string serverName);

        // Search services
        IEnumerable<ServerDto> MostPopularServers();
    }
}
