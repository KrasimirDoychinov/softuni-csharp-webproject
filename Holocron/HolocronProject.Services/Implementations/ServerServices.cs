using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.ViewModelsTemp;

namespace HolocronProject.Services
{
    public class ServerServices : IServerService
    {
        private HolocronDbContext context;

        public ServerServices(HolocronDbContext context)
        {
            this.context = context;
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

        public Server GetServerByName(string serverName)
            => this.context.Servers.FirstOrDefault(x => x.Name == serverName);

        //public IEnumerable<ServerDto> MostPopularServers()
        //{
        //    var servers = this.context.Servers
        //        .Select(x => new ServerDto
        //        {
        //            Name = x.Name,
        //            CountOfCharacters = x.Characters.Count
        //        })
        //        .OrderByDescending(x => x.CountOfCharacters)
        //        .ToList();

        //    return servers;
        //}
    }
}
