    using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HolocronProject.Data
{
    public class HolocronDbContext : IdentityDbContext<Account>
    {

        public HolocronDbContext()
        {
        }

        public HolocronDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Thread> Threads { get; set; }

        public DbSet<BaseThread> BaseThreads { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostTag> PostsTags { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Server> Servers { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<BugReport> BugReports { get; set; }

        public DbSet<PostReport> PostReports { get; set; }

        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Competition> Competitions { get; set; }

        public DbSet<CompetitionCharacter> CompetitionsCharacters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Holocron;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Character>()
            //    .HasData(
            //    new Character 
            //    { 
            //        Name = "Test char", 
            //        Backstory = "Test backstory", 
            //        Gender = Gender.Male,
            //        CharacterType = CharacterType.PVE,
            //        ForceAffiliation = ForceAffiliation.DarkSide
            //    }
            //    );

            //builder.Entity<Thread>()
            //    .HasData(
            //    new Thread { Title = "Test thread" }
            //    );


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
                new Server { Name = "The Leviathan" }
                );

            builder.Entity<BaseThread>()
                .HasData(
                new BaseThread { Title = "PVP" },
                new BaseThread { Title = "PVE" },
                new BaseThread { Title = "RP" },
                new BaseThread { Title = "Guides" },
                new BaseThread { Title = "Fashion" }
                );

            builder.Entity<PostTag>()
                .HasKey(x => new { x.PostId, x.TagId });

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
        }
    }
}
