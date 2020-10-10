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

        // The two classes below are admin classes
        public async Task CreateAllCurrentServers()
        {
            var currentServers = new List<Server>();

            var darthMalgus = new Server
            {
                Name = "Darth Malgus"
            };

            var starForge = new Server
            {
                Name = "Star Forge"
            };

            var sateleShan = new Server
            {
                Name = "Satele Shan"
            };

            var tulakHord = new Server
            {
                Name = "Tulak Hord"
            };

            var theLeviathan = new Server
            {
                Name = "The Leviathan"
            };

            currentServers.Add(darthMalgus);
            currentServers.Add(starForge);
            currentServers.Add(sateleShan);
            currentServers.Add(tulakHord);
            currentServers.Add(theLeviathan);

            await context.Servers.AddRangeAsync(currentServers);
            await context.SaveChangesAsync();
        }

        public async Task CreateNewServer(string serverName)
        {
            var newServer = context.Servers.FirstOrDefault(x => x.Name == serverName);

            if (newServer != null)
            {
                Console.WriteLine("There is a server with that name already!");
                return;
            }

            newServer = new Server
            {
                Name = serverName
            };

            await context.Servers.AddAsync(newServer);
            await context.SaveChangesAsync();
        }

        public IEnumerable<ServerDto> MostPopularServers()
        {
            throw new NotImplementedException();
        }
    }
}
