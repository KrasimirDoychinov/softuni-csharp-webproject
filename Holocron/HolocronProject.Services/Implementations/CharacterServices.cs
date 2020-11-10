﻿using System;
using System.Linq;
using System.Collections.Generic;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using System.Threading.Tasks;
using HolocronProject.Services.Models;
using System.Security.Cryptography.X509Certificates;
using HolocronProject.Services.Models.Character;

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
            var list = this.context.Characters.ToList();

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


        public IEnumerable<CharacterUserDto> GetCurrentUsersCharacter(string accountId)
        {
            var charList = this.context.Characters
                .Where(x => x.AccountId == accountId)
                .Select(x => new CharacterUserDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    ClassName = x.Class.Name,
                    ServerName = x.Server.Name,
                    RaceName = x.Race.Name
                })
                .ToList();

            return charList;
        }
        

        public CharacterUserDto GetCharacterInfo(string characterId)
        {
            return this.context.Characters
                .Select(x => new CharacterUserDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    ServerName = x.Server.Name,
                    ClassName = x.Class.Name,
                    RaceName = x.Race.Name
                })
                .FirstOrDefault(x => x.Id == characterId);
        }

        public Character GetCharacterById(string characterId)
            => this.context.Characters.FirstOrDefault(x => x.Id == characterId);

        public bool IsCharacterNameOnServerTaken(string characterName, string serverId)
            => this.context.Characters
            .Any(x => x.ServerId == serverId && x.Name.ToLower() == characterName.ToLower());
    }
}
