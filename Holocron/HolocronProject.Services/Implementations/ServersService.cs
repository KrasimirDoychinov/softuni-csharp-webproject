﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Security.Cryptography.X509Certificates;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services.Implementations
{
    public class ServersService : IServersService
    {
        private HolocronDbContext context;

        public ServersService(HolocronDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>()
            => this.context.Servers
            .OrderBy(x => x.Name)
            .To<T>()
            .ToList();

    }
}
