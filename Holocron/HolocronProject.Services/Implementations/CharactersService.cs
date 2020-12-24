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
using Hangfire;
using AutoMapper;

namespace HolocronProject.Services.Implementations
{
    // TODO: Add more character services
    public class CharactersService : ICharactersService
    {
        private readonly ApplicationDbContext context;
        private readonly IAccountsService accountsService;

        public CharactersService(ApplicationDbContext context,
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

        public async Task UpdateCharacterImageAsync(string webRootPath, string characterName, string serverId, IFormFile image)
        {
            if (image == null)
            {
                return;
            }
            else
            {
                var character = this.context.Characters
                .FirstOrDefault(x => x.Name == characterName && x.Server.Id == serverId);
                character.CharacterImagePath = $"{character.Id}(Character).png";

                using (var fs = new FileStream(
                   $"{webRootPath}/Images/CharacterImages/{character.CharacterImagePath}", FileMode.Create))
                {
                    await image.CopyToAsync(fs);
                }

                
                await this.context.SaveChangesAsync();
            }
        }

        public async Task ApproveCharacterAsync(string characterId, string accountId)
        {
            var character = this.GetCharacterById(characterId);
            
            character.CharacterStatus = CharacterStatus.Approved;

            await this.accountsService.NotifyAccountOfApprovedCharactersAsync(accountId);

            this.context.Characters.Update(character);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteCharacterAsync(string characterId, string accountId)
        {
            var character = this.GetCharacterById(characterId);

            character.CharacterStatus = CharacterStatus.Deleted;
            character.IsDeleted = true;
            character.DeletedOn = DateTime.UtcNow;

            await this.accountsService.NotifyAccountOfDeletedCharactersAsync(accountId);

            this.context.Characters.Update(character);
            await this.context.SaveChangesAsync();
        }

        public async Task EditCharacterAsync(CharacterEditDto input)
        {
            var character = this.GetCharacterById(input.Id);

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

        public Character GetCharacterById(string characterId)
            => this.context.Characters
            .FirstOrDefault(x => x.Id == characterId);

        public int TotalCharacters()
            => this.context.Characters
            .Count();

        public IEnumerable<T> GetAllCharacters<T>(IMapper mapper = null)
            => this.context.Characters
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetPendingCharacters<T>(string accountId, IMapper mapper = null)
            => this.context.Characters
            .Where(x => x.AccountId == accountId && x.CharacterStatus == CharacterStatus.Pending)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetAllPendingCharacters<T>(IMapper mapper = null)
            => this.context.Characters
            .Where(x => x.CharacterStatus == CharacterStatus.Pending)
            .To<T>(mapper)
            .ToList();

        public int TotalPendingCharacters()
            => this.context.Characters
            .Where(x => x.CharacterStatus == CharacterStatus.Pending)
            .Count();

        public IEnumerable<T> GetCurrentAccountCharacters<T>(string accountId, IMapper mapper = null)
            => this.context.Characters
                .Where(x => x.AccountId == accountId && x.CharacterStatus == CharacterStatus.Approved)
                .To<T>(mapper)
                .ToList();

        public IEnumerable<T> GetCurrentAccountCharacterForCompetition<T>(string accountId, string competitionId, IMapper mapper = null)
            => this.context.Characters
                .Where(x => x.AccountId == accountId
                && x.CharacterStatus == CharacterStatus.Approved
                && !x.Competitions.Any(x => x.CompetitionId == competitionId))
                .To<T>(mapper)
                .ToList();

        public T GetCharacterByIdGeneric<T>(string characterId, IMapper mapper = null)
            => this.context.Characters
                .Where(x => x.Id == characterId)
                .To<T>(mapper)
            .FirstOrDefault();

        public int DeletedCharactersByAccount(string accountId)
            => this.context.Characters
            .Where(x => x.AccountId == accountId && x.IsDeleted)
            .Count();

        public int NotDeletedCharactersByAccount(string accountId)
            => this.context.Characters
            .Where(x => x.AccountId == accountId && !x.IsDeleted)
            .Count();
    }
}
