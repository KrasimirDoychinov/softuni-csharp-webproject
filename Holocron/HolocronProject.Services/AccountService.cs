using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using HolocronProject.Data;
using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;

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

        public async Task Create(string accountName, string password, string displayName)
        {
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

            // TODO: Add option to type the display name again
            var newDisplayName = context.Accounts.Select(x => x.DisplayName)
                .FirstOrDefault(x => x == displayName);
            if (newDisplayName != null)
            {
                Console.WriteLine("The display name exist!");
                Console.WriteLine("Choose another one...");
                return;
            }
            newAccount.DisplayName = newDisplayName;

            context.Accounts.Add(newAccount);

            await context.SaveChangesAsync();
        }

        public async Task CreateCharacter(string accountName, string characterName, 
            int gender, int characterType, int faction,
            string className, string raceName, string serverName, int forceAffiliation)
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
                race = new Race
                {
                    Name = raceName
                };
            }
            newCharacter.Race = race;

            var server = context.Servers.FirstOrDefault(x => x.Name == serverName);
            if (server == null)
            {
                server = new Server
                {
                    Name = serverName
                };
            }
            newCharacter.Server = server;

            context.Characters.Add(newCharacter);

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
    }
}
