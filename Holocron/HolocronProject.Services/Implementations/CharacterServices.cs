using System;
using System.Linq;
using System.Collections.Generic;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.ViewModelsTemp;
using System.Threading.Tasks;
using HolocronProject.Services.ViewModelsTemp;

namespace HolocronProject.Services.Implementations
{
    // TODO: Add more character services
    public class CharacterServices : ICharacterService
    {
        private readonly HolocronDbContext context;

        public CharacterServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateCharacterAsync(CharacterInputModel input)
        {
            var character = new Character
            {
                AccountId = input.AccountId,
                Name = input.Name,
                Backstory = input.Backstory,
                Title = input.Title,
                Image = input.Image,
                Gender = input.Gender,
                CharacterType = input.CharacterType,
                ForceAffiliation = input.ForceAffiliation,
                ClassId = input.ClassId,
                RaceId = input.RaceId,
                ServerId = input.ServerId
            };

            await this.context.Characters.AddAsync(character);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteCharacterAsync(string characterId)
        {
            var character = GetCharacterById(characterId);

            character.IsDeleted = true;

            this.context.Characters.Update(character);
            await this.context.SaveChangesAsync();
        }

        public Character GetCharacterById(string characterId)
            => this.context.Characters.FirstOrDefault(x => x.Id == characterId);

        // TODO: Move to controller
        public bool IsCharacterNameTaken(string characterName)
            => this.context.Characters.Any(x => x.Name == characterName);
    }
}
