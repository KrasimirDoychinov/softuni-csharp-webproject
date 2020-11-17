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
    [Migration("20201116190612_RenamedImagePathToCharacterImagePath")]
    partial class RenamedImagePathToCharacterImagePath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HolocronProject.Data.Models.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AvatarImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ForumSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Achievement", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CharacterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompetitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.BaseThread", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BaseThreads");

                    b.HasData(
                        new
                        {
                            Id = "26b016de-1b3e-49bb-822e-ea6524597dc5",
                            CreatedOn = "11/16/2020 7:06 PM",
                            IsDeleted = false,
                            Title = "PVP"
                        },
                        new
                        {
                            Id = "9f3df090-0670-4299-9af0-0fc6a0ed1b87",
                            CreatedOn = "11/16/2020 7:06 PM",
                            IsDeleted = false,
                            Title = "PVE"
                        },
                        new
                        {
                            Id = "6d7d2cde-639d-4964-b462-e111f538d428",
                            CreatedOn = "11/16/2020 7:06 PM",
                            IsDeleted = false,
                            Title = "RP"
                        },
                        new
                        {
                            Id = "19fead36-11a0-48e3-9156-63c7c0f2ef88",
                            CreatedOn = "11/16/2020 7:06 PM",
                            IsDeleted = false,
                            Title = "Guides"
                        },
                        new
                        {
                            Id = "0a132f3f-a27c-43c1-a680-1cc03a67dc59",
                            CreatedOn = "11/16/2020 7:06 PM",
                            IsDeleted = false,
                            Title = "Fashion"
                        });
                });

            modelBuilder.Entity("HolocronProject.Data.Models.BugReport", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(10000);

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ResolvedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("BugReports");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Character", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Backstory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(25000);

                    b.Property<string>("CharacterImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CharacterType")
                        .HasColumnType("int");

                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("ForceAffiliation")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("RaceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ServerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

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

                    b.HasData(
                        new
                        {
                            Id = "121de4cf-9bb6-4ece-b482-54a69301e626",
                            Faction = 2,
                            Name = "Juggernaut"
                        },
                        new
                        {
                            Id = "44047691-2e62-4d0b-afd3-bb3fac7e0309",
                            Faction = 2,
                            Name = "Marauder"
                        },
                        new
                        {
                            Id = "4b15c1a1-4d65-471f-a8f6-12eef2cacb29",
                            Faction = 2,
                            Name = "Sorcerer"
                        },
                        new
                        {
                            Id = "28beeac1-d7b1-4ec8-9355-35c16693ed70",
                            Faction = 2,
                            Name = "Assassin"
                        },
                        new
                        {
                            Id = "3e6727d3-4bd6-48b4-969c-a96306e8e6e2",
                            Faction = 2,
                            Name = "Sniper"
                        },
                        new
                        {
                            Id = "af1fd266-0731-4d8f-b0f4-5be4793ef84d",
                            Faction = 2,
                            Name = "Operative"
                        },
                        new
                        {
                            Id = "42ecfdbe-1b97-410d-81bf-94724225d499",
                            Faction = 2,
                            Name = "Powertech"
                        },
                        new
                        {
                            Id = "eb8c271c-0dc3-46c0-a0b0-7abd82aec40d",
                            Faction = 2,
                            Name = "Mercenary"
                        },
                        new
                        {
                            Id = "beb4adb5-dbaf-4484-82eb-7ae8e1c0f05c",
                            Faction = 1,
                            Name = "Gunslinger"
                        },
                        new
                        {
                            Id = "aafd9581-b583-4caa-a990-b1157b2f0c47",
                            Faction = 1,
                            Name = "Scoundrel"
                        },
                        new
                        {
                            Id = "2ec51978-b07f-4a16-8111-e5bca48ac1d0",
                            Faction = 1,
                            Name = "Vanguard"
                        },
                        new
                        {
                            Id = "5fbc440c-fca4-498c-8ab0-c4b30e6abfcb",
                            Faction = 1,
                            Name = "Commando"
                        },
                        new
                        {
                            Id = "9db3d3e7-1d8f-4394-bf91-e0ec04c4d675",
                            Faction = 1,
                            Name = "Sage"
                        },
                        new
                        {
                            Id = "a2dee534-dd24-4dd4-8f10-a9211c508f63",
                            Faction = 1,
                            Name = "Shadow"
                        },
                        new
                        {
                            Id = "edf09d25-9bca-4488-a589-46ecbcc12a5d",
                            Faction = 1,
                            Name = "Sentinel"
                        },
                        new
                        {
                            Id = "ff6c40eb-8982-47de-8f44-cb218ea30f66",
                            Faction = 1,
                            Name = "Guardian"
                        });
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Competition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(10000);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinishedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

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
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(10000);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ThreadId")
                        .IsRequired()
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
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(10000);

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ResolvedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

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

                    b.HasData(
                        new
                        {
                            Id = "44d76c13-9f62-4888-863f-8eff8018a4a2",
                            Name = "Chiss"
                        },
                        new
                        {
                            Id = "9d37af21-4c3f-49ab-b2e2-0cd731e2b1f8",
                            Name = "Cyborg"
                        },
                        new
                        {
                            Id = "e5ed84df-7181-4051-b37e-9cb98a9f491b",
                            Name = "Human"
                        },
                        new
                        {
                            Id = "47e1a68f-0bb5-4470-ac29-da479078e5e1",
                            Name = "Miraluka"
                        },
                        new
                        {
                            Id = "ea970296-504e-4a68-b10e-c2f94a3cb62a",
                            Name = "Mirialan"
                        },
                        new
                        {
                            Id = "58cc4727-b75d-4b7b-8fd3-b59fe8528fee",
                            Name = "Rattaki"
                        },
                        new
                        {
                            Id = "9eb9e73e-6327-427b-86df-b59f56fefc7a",
                            Name = "Sith Pureblood"
                        },
                        new
                        {
                            Id = "c7c5ccde-b7dc-490f-a497-64557f86e460",
                            Name = "Twi'lek"
                        },
                        new
                        {
                            Id = "89cec3df-e3d8-40b0-bba1-1356add22725",
                            Name = "Zabrak"
                        },
                        new
                        {
                            Id = "36bad8de-e808-45b9-9369-6f8ebf759174",
                            Name = "Cathar"
                        },
                        new
                        {
                            Id = "8128fe87-ff6d-4968-9618-142708f4c583",
                            Name = "Togruta"
                        },
                        new
                        {
                            Id = "a92c5023-143a-46c7-8a84-4ffc06fc60cd",
                            Name = "Nautolan"
                        });
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Server", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servers");

                    b.HasData(
                        new
                        {
                            Id = "50d1e0d5-bde2-44c0-99a0-af337865b033",
                            Name = "Darth Malgus"
                        },
                        new
                        {
                            Id = "1c06407e-f4fd-49c0-9f31-1921650a1a78",
                            Name = "Star Forge"
                        },
                        new
                        {
                            Id = "53d12e31-2e63-463c-bf1d-f77751742b17",
                            Name = "Satele Shan"
                        },
                        new
                        {
                            Id = "ca344da7-68bf-4b89-83e1-2dc52477390b",
                            Name = "Tulak Hord"
                        },
                        new
                        {
                            Id = "50cb22c8-cf18-440e-abc8-96a9037a487c",
                            Name = "The Leviathan"
                        });
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Tag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Thread", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BaseThreadId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BaseThreadId");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Achievement", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Character", "Character")
                        .WithMany("Achievements")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Competition", "Competition")
                        .WithMany("Achievements")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HolocronProject.Data.Models.BugReport", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("BugReports")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Character", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("Characters")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Class", "Class")
                        .WithMany("Characters")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Race", "Race")
                        .WithMany("Characters")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Server", "Server")
                        .WithMany("Characters")
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Post", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("Posts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Thread", "Thread")
                        .WithMany("Posts")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HolocronProject.Data.Models.PostReport", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("PostReports")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                });

            modelBuilder.Entity("HolocronProject.Data.Models.Thread", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", "Account")
                        .WithMany("Threads")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.BaseThread", "BaseThread")
                        .WithMany("Threads")
                        .HasForeignKey("BaseThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolocronProject.Data.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HolocronProject.Data.Models.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}