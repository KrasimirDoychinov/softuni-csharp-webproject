using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IServerService
    {
        Task CreateAllServers();

        Task CreateNewServer(string serverName);
    }
}
