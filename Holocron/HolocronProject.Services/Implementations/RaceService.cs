﻿using System;
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

        public RaceService(HolocronDbContext context)
        {
            this.context = context;
        }

        // TODO: Fix this method
        // Admin class
        public async Task CreateNewRace(string raceName)
        {
            var newRace = new Race();

            await context.Races.AddAsync(newRace);
            await context.SaveChangesAsync();
        }

        public Race GetRaceByName(string raceName)
        {

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
