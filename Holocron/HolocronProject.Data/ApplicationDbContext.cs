    using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HolocronProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<Account>
    {

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Thread> Threads { get; set; }

        public DbSet<BaseThread> BaseThreads { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Server> Servers { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<BugReport> BugReports { get; set; }

        public DbSet<PostReport> PostReports { get; set; }

        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Competition> Competitions { get; set; }

        public DbSet<CompetitionCharacter> CompetitionsCharacters { get; set; }

        public DbSet<CompetitionAccount> CompetitionAccounts { get; set; }

        public DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Holocron;Integrated Security=true;");
            }

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Class>()
                .HasData(
                new Class { Name = "Juggernaut", Faction = Enums.Faction.Empire },
                new Class { Name = "Marauder", Faction = Enums.Faction.Empire },
                new Class { Name = "Sorcerer", Faction = Enums.Faction.Empire },
                new Class { Name = "Assassin", Faction = Enums.Faction.Empire },
                new Class { Name = "Sniper", Faction = Enums.Faction.Empire },
                new Class { Name = "Operative", Faction = Enums.Faction.Empire },
                new Class { Name = "Powertech", Faction = Enums.Faction.Empire },
                new Class { Name = "Mercenary", Faction = Enums.Faction.Empire },
                new Class { Name = "Gunslinger", Faction = Enums.Faction.Republic },
                new Class { Name = "Scoundrel", Faction = Enums.Faction.Republic },
                new Class { Name = "Vanguard", Faction = Enums.Faction.Republic },
                new Class { Name = "Commando", Faction = Enums.Faction.Republic },
                new Class { Name = "Sage", Faction = Enums.Faction.Republic },
                new Class { Name = "Shadow", Faction = Enums.Faction.Republic },
                new Class { Name = "Sentinel", Faction = Enums.Faction.Republic },
                new Class { Name = "Guardian", Faction = Enums.Faction.Republic }
                );

            builder.Entity<Race>()
                .HasData(
                new Race { Name = "Chiss" },
                new Race { Name = "Cyborg" },
                new Race { Name = "Human" },
                new Race { Name = "Miraluka" },
                new Race { Name = "Mirialan" },
                new Race { Name = "Rattaki" },
                new Race { Name = "Sith Pureblood" },
                new Race { Name = "Twi'lek" },
                new Race { Name = "Zabrak" },
                new Race { Name = "Cathar" },
                new Race { Name = "Togruta" },
                new Race { Name = "Nautolan" }
                );

            builder.Entity<Server>()
                .HasData(
                new Server { Name = "Darth Malgus" },
                new Server { Name = "Star Forge" },
                new Server { Name = "Satele Shan" },
                new Server { Name = "Tulak Hord" },
                new Server { Name = "The Leviathan"}
                );

            builder.Entity<BaseThread>()
                .HasData(
                new BaseThread { Title = "PVP", 
                    ImageUrl = "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", 
                    Description = "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more." },
                new BaseThread { Title = "PVE", 
                    ImageUrl = "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png",
                    Description = "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here." },
                new BaseThread { Title = "RP", 
                    ImageUrl = "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png",
                    Description = "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on." },
                new BaseThread { Title = "Other", 
                    ImageUrl = "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png",
                    Description = "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads." },
                new BaseThread { Title = "Fashion", 
                    ImageUrl = "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png",
                    Description = "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game." }
                );

            builder.Entity<CompetitionCharacter>()
                .HasKey(x => new { x.CharacterId, x.CompetitionId });

            builder.Entity<Thread>()
                .HasOne(x => x.Account)
                .WithMany(y => y.Threads)
                .HasForeignKey(x => x.AccountId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Post>()
                .HasOne(x => x.Account)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.AccountId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Vote>()
                .HasKey(x => new { x.ThreadId, x.AccountId });

            builder.Entity<CompetitionAccount>()
                .HasKey(x => new { x.AccountId, x.CompetitionId});
        }
    }
}
