﻿using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography;

using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;

using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace HolocronProject.Services
{

    public class AccountService : IAccountService
    {
        private IClassService classService;
        private IRaceService raceService;
        private IServerService serverService;
        private IConfigurationProvider config;
        private ICharacterService characterService;
        private HolocronDbContext context;

        public AccountService(IConfigurationProvider config,
            IClassService classService,
            IRaceService raceService,
            IServerService serverService,
            ICharacterService characterService,
            HolocronDbContext context)
        {
            this.context = context;
            this.config = config;

            this.classService = classService;
            this.raceService = raceService;
            this.serverService = serverService;
            this.characterService = characterService;
        }

        

        public async Task CreateAccount(string accountName, string password, string displayName,
            string avatarImage = "Placeholder")
        {
            IsAccountNameTaken(accountName);
            IsDisplayNameTaken(displayName);
            IsAccountDetailsValidForRegistration(accountName, password, displayName);

            var account = new Account
            {
                AccountName = accountName,
                Password = CommuteHash(password),
                DisplayName = displayName,
                AvatarImage = avatarImage
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();
        }

        public async Task CreateCharacter(string accountName, string characterName, 
            int gender, int characterType, int faction,
            string className, string raceName, string serverName, int forceAffiliation, string backstory, 
            string title, string image)
        {
            characterService.IsCharacterDetailsValid(characterName, gender, 
                characterType, faction, className,
                raceName, serverName, forceAffiliation, backstory);
            characterService.IsCharacterNameTaken(characterName);
            IsAccountExist(accountName);

            var race = this.raceService.GetRaceByName(raceName);
            var server = this.serverService.GetServerByName(serverName);
            var @class = this.classService.GetClassByName(className);
            var account = GetAccountByName(accountName);

            var character = new Character
            {
                Account = account,
                Name = characterName,
                Gender = (Gender)gender,
                CharacterType = (CharacterType)characterType,
                Faction = (Faction)faction,
                ForceAffiliation = (ForceAffiliation)forceAffiliation,
                Class = @class,
                Race = race,
                Server = server,
                Backstory = backstory,
                Title = title,
                Image = image
            };

            await context.Characters.AddAsync(character);
            await context.SaveChangesAsync();
        }

        public async Task CreatePost(string accountName, string description, string threadName)
        {
            var account = context.Accounts.FirstOrDefault(x => x.AccountName == accountName);
            if (account == null)
            {
                Console.WriteLine("This account doesn't exist!");
                return;
            }

            var thread = context.Threads.FirstOrDefault(x => x.Title == threadName);
            if (thread == null)
            {
                Console.WriteLine("The thread doesn't exist!");
                return;
            }

            var post = new Post
            {
                Account = account,
                Description = description,
                Thread = thread
            };

            account.Posts.Add(post);
            await context.SaveChangesAsync();
        }

        public async Task CreateThread(string accountName, string title, string baseThreadTitle)
        {
            var account = context.Accounts.FirstOrDefault(x => x.AccountName == accountName);
            if (account == null)
            {
                Console.WriteLine("The account doesn't exist");
                return;
            }

            var baseThread = context.BaseThreads.FirstOrDefault(x => x.Title == baseThreadTitle);
            if (baseThread == null)
            {
                Console.WriteLine("There is no such base thread!");
                return;
            }

            var thread = new Thread
            {
                Title = title,
                BaseThread = baseThread
            };


            account.Threads.Add(thread);
            await context.SaveChangesAsync();
        }

        public async Task DeleteCharacter(string characterName)
        {
            var characterToDelete = context.Characters.FirstOrDefault(x => x.Name == characterName && x.IsDeleted == false);

            if (characterToDelete == null)
            {
                Console.WriteLine("Character not found");
                return;
            }

            characterToDelete.IsDeleted = true;

            context.Characters.Update(characterToDelete);

            await context.SaveChangesAsync();
        }

        public IEnumerable<AccountDto> SearchByMostPosts(int amountOfAccounts)
        {
            var listAccounts = context.Accounts
            .ProjectTo<AccountDto>(this.config)
            .OrderByDescending(x => x.PostsCount)
            .Take(amountOfAccounts)
            .ToList();

            return listAccounts;
        }

        public IEnumerable<AccountDto> SearchOldestAccounts(int amountOfAccounts)
        {
            var listAccounts = context.Accounts.ProjectTo<AccountDto>(this.config)
            .OrderBy(x => x.CreatedOn)
            .Take(amountOfAccounts)
            .ToList();

            return listAccounts;
        }

        public IEnumerable<AccountDto> SearchAccountsWithMostCharacters(int amountOfAccounts)
        {
            var accounts = this.context.Accounts
                .ProjectTo<AccountDto>(this.config)
                .OrderByDescending(x => x.CharactersCount)
                .Take(amountOfAccounts)
                .ToList();

            return accounts;
        }

        public ForeignAccountDto SearchForeignAccount(string displayName)
        {
            var foreignAccount = context.Accounts
                .ProjectTo<ForeignAccountDto>(this.config)
                .FirstOrDefault(x => x.DisplayName == displayName);

            return foreignAccount;
        }

        public Account GetAccountByName(string accountName)
            => this.context.Accounts.FirstOrDefault(x => x.AccountName == accountName);

        private void IsAccountDetailsValidForRegistration(string accountName, string password, string displayName)
        {

            if (accountName.Length < 5
                || accountName.Length > 30)
            {
                throw new ArgumentException("Account is too short or too long.");
            }

            if (password.Length < 5
                || !password.Any(char.IsDigit)
                || !password.Any(char.IsUpper)
                || !password.Any(char.IsLower))
            {
                throw new ArgumentException("The password is too short or invalid!");
            }

            if (displayName.Length < 5
                || displayName.Length > 25)
            {
                throw new ArgumentException("The display name is too short or too long!");
            }

        }

        private void IsAccountNameTaken(string accountName)
        {
            var account = this.context.Accounts
                .FirstOrDefault(x => x.AccountName == accountName);

            if (account != null)
            {
                throw new ArgumentException("The account name is already taken!");
            }

        }

        private void IsAccountExist(string accountName)
        {
            var account = this.context.Accounts
                .FirstOrDefault(x => x.AccountName == accountName);

            if (account == null)
            {
                throw new ArgumentException("The account doesn't exist!");
            }
        }

        private void IsDisplayNameTaken(string displayName)
        {
            var account = this.context.Accounts
                .FirstOrDefault(x => x.DisplayName == displayName);

            if (account != null)
            {
                throw new ArgumentException("The display name is already taken!");
            }

        }

        private bool IsAccountDetailsValidForLogin(string accountName, string password)
        {
            return this.context.Accounts
                .Any(x => x.AccountName == accountName && x.Password == password);
        }

        private string CommuteHash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            using var hash = SHA512.Create();
            var hashedInputBytes = hash.ComputeHash(bytes);

            // Convert to text
            // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
            var hashedInputStringBuilder = new System.Text.StringBuilder(128);
            foreach (var b in hashedInputBytes)
                hashedInputStringBuilder.Append(b.ToString("X2"));
            return hashedInputStringBuilder.ToString();
        }

    }
}
