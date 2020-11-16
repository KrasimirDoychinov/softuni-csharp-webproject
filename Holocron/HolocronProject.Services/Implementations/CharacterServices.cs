using System;
using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;
using HolocronProject.Services.Models;
using System.Security.Cryptography.X509Certificates;
using HolocronProject.Services.Models.Character;
using HolocronProject.Services.Mapper;
using Microsoft.AspNetCore.Http;
using System.IO;

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

        public async Task CreateCharacterAsync(CharacterInputDto input)
        {
            var character = new Character
            {
                AccountId = input.AccountId,
                Name = input.Name,
                Backstory = input.Backstory,
                Title = input.Title,
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


        public IEnumerable<T> GetCurrentUsersCharacter<T>(string accountId)
        {
            var charList = this.context.Characters
                .Where(x => x.AccountId == accountId)
                .To<T>()
                .ToList();

            return charList;
        }
        
        public T GetCharacterInfo<T>(string characterId)
        {
            return this.context.Characters
                .Where(x => x.Id == characterId)
                .To<T>().FirstOrDefault();
        }

        public async Task CreateCharacterImage(string characterName, IFormFile image)
        {
            var character = this.context.Characters
                .OrderByDescending(x => x.CreatedOn)
                .FirstOrDefault();

            using (var fs = new FileStream(
               $"wwwroot/Images/CharacterImages/{character.Id}(Character).png", FileMode.Create))
            {
                await image.CopyToAsync(fs);
            }

            character.CharacterImagePath = $"{character.Id}(Character).png";
            await this.context.SaveChangesAsync();
        }

        public Character GetCharacterById(string characterId)
            => this.context.Characters.FirstOrDefault(x => x.Id == characterId);

        
    }
}
