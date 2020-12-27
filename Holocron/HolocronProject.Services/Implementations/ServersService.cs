using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using HolocronProject.Data;
using HolocronProject.Services.Mapper;

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
