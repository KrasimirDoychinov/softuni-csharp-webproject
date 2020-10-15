using AutoMapper;
using AutoMapper.QueryableExtensions;
using HolocronProject.Data;
using HolocronProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolocronProject.Services
{
    // TODO: Add more character services
    public class CharacterService : ICharacterService
    {
        private IConfigurationProvider config;
        private HolocronDbContext context;

        public CharacterService(IConfigurationProvider config, HolocronDbContext context)
        {
            this.context = context;
            this.config = config;
        }

        public IEnumerable<CharacterDto> MostPopularClasses()
        {
            var characters = context.Characters
                .ProjectTo<CharacterDto>(this.config)
                .OrderByDescending(x => x.Faction)
                .ToList();

            return characters;
        }
    }
}
