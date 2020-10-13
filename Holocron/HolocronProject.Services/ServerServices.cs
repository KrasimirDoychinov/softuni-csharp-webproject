using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public class ServerServices : IServerService
    {
        private HolocronDbContext context;

        public ServerServices()
        {
            this.context = new HolocronDbContext();
        }

        // Admin class
        public async Task CreateNewServer(string serverName)
        {
            var newServer = context.Servers.FirstOrDefault(x => x.Name == serverName);

            if (newServer != null)
            {
                Console.WriteLine("There is a server with that name already!");
                return;
            }

            //newServer = new Server
            //{
            //    Name = serverName
            //};

            await context.Servers.AddAsync(newServer);
            await context.SaveChangesAsync();
        }

        public IEnumerable<ServerDto> MostPopularServers()
        {
            var servers = this.context.Servers
                .Select(x => new ServerDto
                {
                    Name = x.Name,
                    CountOfCharacters = x.Characters.Count
                })
                .OrderByDescending(x => x.CountOfCharacters)
                .ToList();

            return servers;
        }
    }
}
