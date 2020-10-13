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

        // The two classes below are admin classes
        public async Task CreateAllCurrentRaces()
        {
            //var currentRaces = new List<Race>();

            //var chiss = new Race("Chiss");
            //var cyborg = new Race("Cyborg");
            //var human = new Race("Human");
            //var miraluka = new Race("Miraluka");
            //var mirialan = new Race("Mirialan");
            //var rattataki = new Race("Rattaki");
            //var sithPureblood = new Race("Sith Pureblood");
            //var twilek = new Race("Twi'lek");
            //var zabrak = new Race("Zabrak");
            //var cathar = new Race("Cathar");
            //var togruta = new Race("Togruta");
            //var nautolan = new Race("Nautolan");

            //currentRaces.Add(chiss);
            //currentRaces.Add(cyborg);
            //currentRaces.Add(human);
            //currentRaces.Add(miraluka);
            //currentRaces.Add(mirialan);
            //currentRaces.Add(rattataki);
            //currentRaces.Add(sithPureblood);
            //currentRaces.Add(twilek);
            //currentRaces.Add(zabrak);
            //currentRaces.Add(cathar);
            //currentRaces.Add(togruta);
            //currentRaces.Add(nautolan);

            //await context.Races.AddRangeAsync(currentRaces);
            //await context.SaveChangesAsync();
        }

        public async Task CreateNewRace(string raceName)
        {
            //var newRace = new Race(raceName);
            
            //await context.Races.AddAsync(newRace);
            //await context.SaveChangesAsync();
        }

        public IEnumerable<RaceDto> MostPlayedRaces(int topAmmount)
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
