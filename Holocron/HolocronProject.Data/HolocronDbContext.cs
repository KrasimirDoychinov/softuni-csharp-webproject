﻿using HolocronProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data
{
    public class HolocronDbContext : DbContext
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

        public DbSet<Class> Classes { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostTag> PostsTags { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Server> Servers { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Holocron;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PostTag>()
                .HasKey(x => new { x.PostId, x.TagId });
        }
    }
}
