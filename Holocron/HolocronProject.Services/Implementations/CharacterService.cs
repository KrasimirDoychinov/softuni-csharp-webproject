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

        public void IsCharacterDetailsValid(string characterName, int gender, int characterType, int faction,
            string className, string raceName, string serverName, 
            int forceAffiliation, string backstory) 
        {

            if (gender != 1 || gender != 2)
            {
                throw new ArgumentException("The gender is invalid!");
            }

            if (characterType != 1 || characterType != 2 || characterType != 3)
            {
                throw new ArgumentException("The character type is invalid!");
            }

            if (faction != 1 || faction != 2)
            {
                throw new ArgumentException("The faction is invalid!");
            }

            if (forceAffiliation != 1 || forceAffiliation != 2)
            {
                throw new ArgumentException("The force affiliation is invalid!");
            }

            var validClass = this.context.Classes
                .Any(x => x.Name == className);

            if (!validClass)
            {
                throw new ArgumentException("The class is invalid!");
            }

            var validRace = this.context.Races
                .Any(x => x.Name == raceName);

            if (!validRace)
            {
                throw new ArgumentException("The race is invalid!");
            }

            var validServer = this.context.Servers
                .Any(x => x.Name == serverName);

            if (!validClass)
            {
                throw new ArgumentException("The server is invalid!");
            }
        }

        public void IsCharacterNameTaken(string characterName)
        {
            var character = this.context.Characters
                .Any(x => x.Name == characterName);

            if (character)
            {
                throw new ArgumentException("The character name is taken!");
            }
        }

    }
}
