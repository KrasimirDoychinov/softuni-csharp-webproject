using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.ViewModelsTemp;

namespace HolocronProject.Services
{
    public class RaceServices : IRaceService
    {
        private HolocronDbContext context;

        public RaceServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateRace(string name)
        {
            var race = new Race
            {
                Name = name
            };

            await this.context.Races.AddAsync(race);
            await this.context.SaveChangesAsync();
        }
    }
}
