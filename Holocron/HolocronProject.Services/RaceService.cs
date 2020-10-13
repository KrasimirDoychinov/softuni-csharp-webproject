using System;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolocronProject.Services.Models;

namespace HolocronProject.Services
{
    public class RaceService : IRaceService
    {
        private HolocronDbContext context;

        public RaceService()
        {
            this.context = new HolocronDbContext();
        }

        // The class below is an admin class
        public async Task CreateNewRace(string raceName)
        {
            var newRace = new Race(raceName);

            await context.Races.AddAsync(newRace);
            await context.SaveChangesAsync();
        }

        public IEnumerable<RaceDto> MostPlayedRaces()
        {
            var mostPlayedRaces = this.context.Races
                .Select(x => new RaceDto
                {
                    Name = x.Name,
                    CharacterCount = x.Characters.Count
                })
                .OrderByDescending(x => x.CharacterCount)
                .ToList();

            return mostPlayedRaces;
        }
    }
}
