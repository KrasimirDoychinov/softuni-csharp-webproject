﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.ViewModelsTemp;

namespace HolocronProject.Services.Implementations
{
    public class ServerServices : IServerService
    {
        private HolocronDbContext context;

        public ServerServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateServerAsync(string name)
        {
            var server = new Server
            {
                Name = name
            };

            await this.context.Servers.AddAsync(server);
            await this.context.SaveChangesAsync();
        }
    }
}
