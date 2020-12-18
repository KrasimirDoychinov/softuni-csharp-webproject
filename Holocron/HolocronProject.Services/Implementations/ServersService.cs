using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Security.Cryptography.X509Certificates;
using HolocronProject.Services.Mapper;
using AutoMapper;

namespace HolocronProject.Services.Implementations
{
    public class ServersService : IServersService
    {
        private ApplicationDbContext context;

        public ServersService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>(IMapper mapper = null)
            => this.context.Servers
            .OrderBy(x => x.Name)
            .To<T>(mapper)
            .ToList();

    }
}
