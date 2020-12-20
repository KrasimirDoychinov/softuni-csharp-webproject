using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Security.Cryptography.X509Certificates;
using HolocronProject.Services.Mapper;
using AutoMapper;

namespace HolocronProject.Services
{
    public class RacesService : IRacesService
    {
        private ApplicationDbContext context;

        public RacesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>(IMapper mapper = null)
            => this.context.Races
            .OrderBy(x => x.Name)
            .To<T>(mapper)
            .ToList();
    }
}
