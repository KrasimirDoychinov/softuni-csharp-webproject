using System;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public class RaceService : IRaceService
    {
        private HolocronDbContext context;

        public RaceService()
        {
            this.context = new HolocronDbContext();
        }

        public async Task CreateAllCurrentRaces()
        {
            var currentRaces = new List<Race>();

            var chiss = new Race
            {
                Name = "Chiss"
            };

            var cyborg = new Race
            {
                Name = "Cyborg"
            };

            var human = new Race
            {
                Name = "Human"
            };

            var miraluka = new Race
            {
                Name = "Miraluka"
            };

            var mirialan = new Race
            {
                Name = "Mirialan"
            };

            var rattataki = new Race
            {
                Name = "Rattataki"
            };

            var sithPureblood = new Race
            {
                Name = "Sith Pureblood"
            };

            var twilek = new Race
            {
                Name = "Twi'lek"
            };

            var zabrak = new Race
            {
                Name = "Zabrak"
            };

            var cathar = new Race
            {
                Name = "Cathar"
            };

            var togruta = new Race
            {
                Name = "Togruta"
            };

            var nautolan = new Race
            {
                Name = "Nautolan"

            };

            currentRaces.Add(chiss);
            currentRaces.Add(cyborg);
            currentRaces.Add(human);
            currentRaces.Add(miraluka);
            currentRaces.Add(mirialan);
            currentRaces.Add(rattataki);
            currentRaces.Add(sithPureblood);
            currentRaces.Add(twilek);
            currentRaces.Add(zabrak);
            currentRaces.Add(cathar);
            currentRaces.Add(togruta);
            currentRaces.Add(nautolan);

            await context.Races.AddRangeAsync(currentRaces);
            await context.SaveChangesAsync();
        }

        public async Task CreateNewRace(string raceName)
        {
            var newRace = context.Races.FirstOrDefault(x => x.Name == raceName);

            if (newRace != null)
            {
                Console.WriteLine("The race already exists!");
                return;
            }

            context.Races.Add(newRace);

            await context.SaveChangesAsync();
        }
    }
}
