﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        private IConfigurationProvider config;
        private HolocronDbContext context;

        public AccountService(IConfigurationProvider config)
        {
            this.context = new HolocronDbContext();
            this.config = config;
        }

        public async Task Create(string accountName, string password, string displayName,
            string avatarImage = "Placeholder")
        {
            var account = context.Accounts.FirstOrDefault(x => x.AccountName == accountName);
            if (account != null)
            {
                Console.WriteLine("The account already exist!");
                return;
            }

            if (accountName.Length < 5)
            {
                Console.WriteLine("The account name is too short!");
                return;
            }

            if (password.Length < 5 
                || !password.Any(char.IsDigit) 
                || !password.Any(char.IsUpper)
                || !password.Any(char.IsLower))
            {
                Console.WriteLine("The password doesn't meet the requirements!");
                return;
            }

            var displayNameTaken = context.Accounts.Any(x => x.DisplayName == displayName);
            if (displayNameTaken)
            {
                Console.WriteLine("The display name is taken!");
                return;
            }

            account = new Account
            {
                AccountName = accountName,
                Password = password,
                DisplayName = displayName,
                AvatarImage = avatarImage
            };

            await context.Accounts.AddAsync(account);
            await context.SaveChangesAsync();
        }

        public async Task CreateCharacter(string accountName, string characterName, 
            int gender, int characterType, int faction,
            string className, string raceName, string serverName, int forceAffiliation, string backstory = "none")
        {
            var account = context.Accounts.FirstOrDefault(x => x.AccountName == accountName);
            var character = context.Characters.FirstOrDefault(x => x.Name == characterName);

            if (account == null)
            {
                Console.WriteLine("The account doesn't exist!");
                return;
            }

            if (character != null)
            {
                Console.WriteLine("The character name is already taken!");
                return;
            }
            var race = context.Races.FirstOrDefault(x => x.Name == raceName);
            var server = context.Servers.FirstOrDefault(x => x.Name == serverName);

            character = new Character
            {
                Account = account,
                Name = characterName,
                Gender = (Gender)gender,
                CharacterType = (CharacterType)characterType,
                Faction = (Faction)faction,
                ForceAffiliation = (ForceAffiliation)forceAffiliation,
                Class = className,
                Race = race,
                Server = server,
                Backstory = backstory
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
    }
}
