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
using HolocronProject.Services.Models.Characters;
using HolocronProject.Data.Enums;

namespace HolocronProject.Services.Implementations
{
    // TODO: Add more character services
    public class CharactersService : ICharactersService
    {
        private readonly HolocronDbContext context;
        private readonly IAccountsService accountsService;

        public CharactersService(HolocronDbContext context,
            IAccountsService accountsService)
        {
            this.context = context;
            this.accountsService = accountsService;
        }

        public async Task CreateCharacterAsync(CharacterInputDto input)
        {
            var character = new Character
            {
                AccountId = input.AccountId,
                Name = input.Name,
                Backstory = input.Backstory,
                Description = input.Description,
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

        public IEnumerable<T> GetCurrentAccountCharacter<T>(string accountId)
            => this.context.Characters
                .Where(x => x.AccountId == accountId && x.CharacterStatus == CharacterStatus.Approved)
                .To<T>()
                .ToList();
        
        public T GetCharacterByIdGeneric<T>(string characterId)
            => this.context.Characters
                .Where(x => x.Id == characterId)
                .To<T>().FirstOrDefault();

        public async Task UpdateCharacterImage(string characterName, IFormFile image)
        {
            if (image == null)
            {
                return;
            }
            else
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
        }

        public Character GetCharacterById(string characterId)
            => this.context.Characters
            .FirstOrDefault(x => x.Id == characterId);

        public int TotalApprovedCharacters()
            => this.context.Characters
            .Where(x => x.CharacterStatus == CharacterStatus.Approved)
            .Count();

        public IEnumerable<T> GetNewestCharacters<T>()
            => this.context.Characters
            .Where(x => x.CharacterStatus == CharacterStatus.Approved)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>()
            .ToList();

        public async Task ApproveCharacter(string characterId, string accountId)
        {
            var character = this.GetCharacterById(characterId);
            
            character.CharacterStatus = CharacterStatus.Approved;
            await this.accountsService.NotifyAccountOfApprovedCharacters(accountId);

            this.context.Characters.Update(character);
            await this.context.SaveChangesAsync();
        }

        public IEnumerable<T> GetPendingCharacters<T>(string accountId)
            => this.context.Characters
            .Where(x => x.AccountId == accountId && x.CharacterStatus  == CharacterStatus.Pending)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetAllPendingCharacters<T>()
            => this.context.Characters
            .Where(x => x.CharacterStatus == CharacterStatus.Pending)
            .To<T>()
            .ToList();

        public int TotalPendingCharacters()
            => this.context.Characters
            .Where(x => x.CharacterStatus == CharacterStatus.Pending)
            .Count();

        public async Task EditCharacterAsync(CharacterEditDto input)
        {
            var character = this.GetCharacterById(input.Id);

            character.AccountId = input.AccountId;
            character.Backstory = input.Backstory;
            character.Description = input.Description;
            character.CharacterType = input.CharacterType;
            character.ClassId = input.ClassId;
            character.ForceAffiliation = input.ForceAffiliation;
            character.Gender = input.Gender;
            character.Name = input.Name;
            character.RaceId = input.RaceId;
            character.ServerId = input.ServerId;
            character.Title = input.Title;
            
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteCharacter(string characterId, string accountId)
        {
            var character = this.GetCharacterById(characterId);

            character.CharacterStatus = CharacterStatus.Deleted;
            character.IsDeleted = true;
            character.DeletedOn = DateTime.UtcNow;
            character.NormalizedDeletedOn = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss");

            await this.accountsService.NotifyAccountOfDeletedCharacters(accountId);

            this.context.Characters.Update(character);
            await this.context.SaveChangesAsync();
        }
    }
}
