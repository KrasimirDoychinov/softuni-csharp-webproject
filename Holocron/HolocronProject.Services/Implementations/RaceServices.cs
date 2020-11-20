using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Security.Cryptography.X509Certificates;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services
{
    public class RaceServices : IRaceService
    {
        private HolocronDbContext context;

        public RaceServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateRaceAsync(string name)
        {
            var race = new Race
            {
                Name = name
            };

            await this.context.Races.AddAsync(race);
            await this.context.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>()
            => this.context.Races
            .OrderBy(x => x.Name)
            .To<T>()
            .ToList();

    }
}
