using System.Linq;
using System.Collections.Generic;

using AutoMapper;

using HolocronProject.Data;
using HolocronProject.Services.Mapper;

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
