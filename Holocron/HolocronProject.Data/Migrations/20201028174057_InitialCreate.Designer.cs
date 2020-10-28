﻿// <auto-generated />
using System;
using HolocronProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HolocronProject.Data.Migrations
{
    [DbContext(typeof(HolocronDbContext))]
    [Migration("20201028174057_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("HolocronProject.Data.Models.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AvatarImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ForumSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Achievement", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CharacterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompetitionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.BaseThread", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BaseThreads");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.BugReport", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("BugReports");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Character", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Backstory")
                        .IsRequired()
                        .HasMaxLength(25000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CharacterType")
                        .HasColumnType("int");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Faction")
                        .HasColumnType("int");

                    b.Property<int>("ForceAffiliation")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("RaceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ServerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ClassId");

                    b.HasIndex("RaceId");

                    b.HasIndex("ServerId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Class", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Faction")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Competition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.CompetitionCharacter", b =>
                {
                    b.Property<string>("CharacterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompetitionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Votes")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "CompetitionId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("CompetitionsCharacters");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ThreadId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ThreadId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.PostReport", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PostId");

                    b.ToTable("PostReports");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.PostTag", b =>
                {
                    b.Property<string>("PostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostsTags");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Race", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Server", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Tag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Thread", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BaseThreadId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BaseThreadId");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Achievement", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Character", "Character")
                        .WithMany("Achievements")
                        .HasForeignKey("CharacterId");

                    b.HasOne("HolocronProject.Data.Models.Competition", "Competition")
                        .WithMany("Achievements")
                        .HasForeignKey("CompetitionId");

                    b.Navigation("Character");

                    b.Navigation("Competition");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.BugReport", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("BugReports")
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Character", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("Characters")
                        .HasForeignKey("AccountId");

                    b.HasOne("HolocronProject.Data.Models.Class", "Class")
                        .WithMany("Characters")
                        .HasForeignKey("ClassId");

                    b.HasOne("HolocronProject.Data.Models.Race", "Race")
                        .WithMany("Characters")
                        .HasForeignKey("RaceId");

                    b.HasOne("HolocronProject.Data.Models.Server", "Server")
                        .WithMany("Characters")
                        .HasForeignKey("ServerId");

                    b.Navigation("Account");

                    b.Navigation("Class");

                    b.Navigation("Race");

                    b.Navigation("Server");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.CompetitionCharacter", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Character", "Character")
                        .WithMany("Competitions")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Competition", "Competition")
                        .WithMany("Characters")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Competition");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Post", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("Posts")
                        .HasForeignKey("AccountId");

                    b.HasOne("HolocronProject.Data.Models.Thread", "Thread")
                        .WithMany("Posts")
                        .HasForeignKey("ThreadId");

                    b.Navigation("Account");

                    b.Navigation("Thread");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.PostReport", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("PostReports")
                        .HasForeignKey("AccountId");

                    b.HasOne("HolocronProject.Data.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId");

                    b.Navigation("Account");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.PostTag", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Post", "Post")
                        .WithMany("Tags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Tag", "Tag")
                        .WithMany("Posts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Thread", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("Threads")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HolocronProject.Data.Models.BaseThread", "BaseThread")
                        .WithMany("Threads")
                        .HasForeignKey("BaseThreadId");

                    b.Navigation("Account");

                    b.Navigation("BaseThread");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Account", b =>
                {
                    b.Navigation("BugReports");

                    b.Navigation("Characters");

                    b.Navigation("PostReports");

                    b.Navigation("Posts");

                    b.Navigation("Threads");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.BaseThread", b =>
                {
                    b.Navigation("Threads");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Character", b =>
                {
                    b.Navigation("Achievements");

                    b.Navigation("Competitions");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Class", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Competition", b =>
                {
                    b.Navigation("Achievements");

                    b.Navigation("Characters");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Post", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Race", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Server", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Tag", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Thread", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}