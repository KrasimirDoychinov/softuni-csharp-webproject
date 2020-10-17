using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using HolocronProject.Services.Models;

namespace HolocronProject.Services
{
    public interface IServerService
    {
        Task CreateNewServer(string serverName);

        Server GetServerByName(string serverName);

        IEnumerable<ServerDto> MostPopularServers();
    }
}
