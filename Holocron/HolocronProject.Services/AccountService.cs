using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;

namespace HolocronProject.Services
{

    public class AccountService : IAccountService
    {
        private List<string> correctClasses = new List<string>
        {
            "Sith Juggernaut",
            "Sith Marauder",
            "Sith Assassin",
            "Sith Sorcerer",
            "Operative",
            "Sniper",
            "Powertech",
            "Mercenary",
            "Jedi Guardian",
            "Jedi Sentinel",
            "Jedi Shadow",
            "Jedi Sage",
            "Scoundrel",
            "Gunslinger",
            "Vanguard",
            "Commando"
        };

        private HolocronDbContext context;
        public AccountService()
        {
            context = new HolocronDbContext();
        }

        // TODO: Fix the fucking method 
        public async Task Create(string accountName, string password, string displayName)
        {
            var list = context.Accounts.ToList();
            var newAccount = context.Accounts.FirstOrDefault(x => x.AccountName == accountName);
            if (newAccount != null)
            {
                Console.WriteLine("Account exists!");
                Console.WriteLine("Exiting...");
                return;
            }

            newAccount = new Account
            {
                AccountName = accountName,
                Password = password
            };


            var displayNameEixts = context.Accounts.Select(x => x.DisplayName)
                .FirstOrDefault(x => x == displayName);
            while (displayNameEixts != null)
            {
                Console.WriteLine("The display name exist!");
                Console.WriteLine("Choose another one...");

                displayName = Console.ReadLine();

                displayNameEixts = context.Accounts.Select(x => x.DisplayName)
                .FirstOrDefault(x => x == displayName);
            }
            
            
            newAccount.DisplayName = displayName;

            context.Accounts.Add(newAccount);

            await context.SaveChangesAsync();
        }

        // TODO: Fix the fucking method
        // TODO: Fix backstory
        public async Task CreateCharacter(string accountName, string characterName, 
            int gender, int characterType, int faction,
            string className, string raceName, string serverName, int forceAffiliation, string backstory = "none")
        {
            var newCharacter = context.Characters.FirstOrDefault(x => x.Name == characterName);
            var account = context.Accounts.FirstOrDefault(x => x.AccountName == accountName);

            if (account == null)
            {
                Console.WriteLine("An account with that name doesn't exist");
                Console.WriteLine("Exiting...");
                return;
            }


            if (newCharacter != null)
            {
                Console.WriteLine("A character with that name already exists!");
                Console.WriteLine("Exiting...");
                return;
            }

            newCharacter = new Character
            {
                Account = account,
                Name = characterName,
                Gender = (Gender)gender,
                CharacterType = (CharacterType)characterType,
                Faction = (Faction)faction,
                ForceAffiliation = (ForceAffiliation)forceAffiliation
            };

            if (!correctClasses.Contains(className))
            {
                Console.WriteLine("The class name is incorrect");
                Console.WriteLine("Exiting...");
                return;
            }
            newCharacter.Class = className;

            var race = context.Races.FirstOrDefault(x => x.Name == raceName);
            if (race == null)
            {
                Console.WriteLine("The race doesn't exist!");
                return;
            }
            newCharacter.Race = race;

            var server = context.Servers.FirstOrDefault(x => x.Name == serverName && x.IsDeleted == false);
            if (server == null)
            {
                Console.WriteLine("The server doesn't exist!");
                return;
            }
            newCharacter.Server = server;


            await context.Characters.AddAsync(newCharacter);
            await context.SaveChangesAsync();
        }

        // TODO: Fix the fucking method
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

        // TODO: Fix the fucking method
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

        // TODO: Fix the fucking method
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

        public ForeignAccountDto ForeignAccount(string displayName)
        {
            var foreignAccount = context.Accounts
                .Select(x => new ForeignAccountDto
                {
                    DisplayName = x.DisplayName,
                    AvatarImage = x.AvatarImage,
                    Characters = x.Characters,
                    Posts = x.Posts,
                    Threads = x.Threads,
                    CreatedOn = x.CreatedOn
                })
                .FirstOrDefault(x => x.DisplayName == displayName);

            return foreignAccount;
        }

        public IEnumerable<AccountDto> SearchByMostPosts(int ammountOfAccounts)
        {
            var listAccounts = context.Accounts.Select(x => new AccountDto
            {
                DisplayName = x.DisplayName,
                CreatedOn = x.CreatedOn,
                AvatarImage = x.AvatarImage,
                CharactersCount = x.Characters.Count,
                PostsCount = x.Posts.Count,
                ThreadsCount = x.Threads.Count
            })
            .OrderByDescending(x => x.PostsCount)
            .Take(ammountOfAccounts)
            .ToList();

            return listAccounts;
        }

        public IEnumerable<AccountDto> SearchOldestAccounts(int ammountOfAccounts)
        {
            var listAccounts = context.Accounts.Select(x => new AccountDto
            {
                DisplayName = x.DisplayName,
                CreatedOn = x.CreatedOn,
                AvatarImage = x.AvatarImage,
                CharactersCount = x.Characters.Count,
                PostsCount = x.Posts.Count,
                ThreadsCount = x.Threads.Count

            })
            .OrderBy(x => x.CreatedOn)
            .Take(ammountOfAccounts)
            .ToList();

            return listAccounts;
        }
    }
}
