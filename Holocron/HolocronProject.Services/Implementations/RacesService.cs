using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Security.Cryptography.X509Certificates;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services
{
    public class RacesService : IRacesService
    {
        private HolocronDbContext context;

        public RacesService(HolocronDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>()
            => this.context.Races
            .OrderBy(x => x.Name)
            .To<T>()
            .ToList();

    }
}
