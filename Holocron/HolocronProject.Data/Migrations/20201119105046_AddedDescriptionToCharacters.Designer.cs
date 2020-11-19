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
    [Migration("20201119105046_AddedDescriptionToCharacters")]
    partial class AddedDescriptionToCharacters
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
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
                            Id = "962ac89a-2ecf-458b-adca-82baa390d035",
                            CreatedOn = "11/19/2020 10:50 AM",
                            IsDeleted = false,
                            Title = "PVP"
                        },
                        new
                        {
                            Id = "08b03b33-f4e6-4abf-82e9-dc6dc7e1713d",
                            CreatedOn = "11/19/2020 10:50 AM",
                            IsDeleted = false,
                            Title = "PVE"
                        },
                        new
                        {
                            Id = "53eac92b-3ad5-4ef4-8cd0-13cff7d7fc60",
                            CreatedOn = "11/19/2020 10:50 AM",
                            IsDeleted = false,
                            Title = "RP"
                        },
                        new
                        {
                            Id = "90862a10-3d17-41e6-b145-1cee1f34e6a6",
                            CreatedOn = "11/19/2020 10:50 AM",
                            IsDeleted = false,
                            Title = "Guides"
                        },
                        new
                        {
                            Id = "275895a5-39f8-4f2b-ba69-58b2264e7b37",
                            CreatedOn = "11/19/2020 10:50 AM",
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

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(25000);

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
                            Id = "ab798037-520b-4e32-ad67-af1834c5b588",
                            Faction = 2,
                            Name = "Juggernaut"
                        },
                        new
                        {
                            Id = "d6764955-973f-4942-b37f-9f22ce310f06",
                            Faction = 2,
                            Name = "Marauder"
                        },
                        new
                        {
                            Id = "84645b8d-c7b1-422c-883b-7e6142ad27ba",
                            Faction = 2,
                            Name = "Sorcerer"
                        },
                        new
                        {
                            Id = "9e19aa9a-9bba-43d6-b325-2d26f3cb6091",
                            Faction = 2,
                            Name = "Assassin"
                        },
                        new
                        {
                            Id = "6c8be7f6-36f4-4bfa-99f3-ddf576c7d467",
                            Faction = 2,
                            Name = "Sniper"
                        },
                        new
                        {
                            Id = "b8d1a94d-4a77-478f-9de7-f42d0c16e4e2",
                            Faction = 2,
                            Name = "Operative"
                        },
                        new
                        {
                            Id = "0d72c88e-02bc-413b-aee2-01c4478ddf5b",
                            Faction = 2,
                            Name = "Powertech"
                        },
                        new
                        {
                            Id = "fe334538-9bb7-4416-ba92-17061eafa892",
                            Faction = 2,
                            Name = "Mercenary"
                        },
                        new
                        {
                            Id = "5a7611fe-01bb-4558-951f-c895420606f6",
                            Faction = 1,
                            Name = "Gunslinger"
                        },
                        new
                        {
                            Id = "0b5c4d27-b933-4549-8990-915a013f7df6",
                            Faction = 1,
                            Name = "Scoundrel"
                        },
                        new
                        {
                            Id = "40b06e98-9c26-477d-b3b8-a90a537305bf",
                            Faction = 1,
                            Name = "Vanguard"
                        },
                        new
                        {
                            Id = "ae4921e1-6899-4b94-b906-94216055c978",
                            Faction = 1,
                            Name = "Commando"
                        },
                        new
                        {
                            Id = "41f17dba-bbaf-4312-91f9-787f0af346b5",
                            Faction = 1,
                            Name = "Sage"
                        },
                        new
                        {
                            Id = "ec560abc-030d-496d-adc0-1049a9523c1a",
                            Faction = 1,
                            Name = "Shadow"
                        },
                        new
                        {
                            Id = "44b7141c-4908-4ac2-aefe-664098f5c2aa",
                            Faction = 1,
                            Name = "Sentinel"
                        },
                        new
                        {
                            Id = "02ec223f-51f8-4336-bf24-e88c00dbb7ab",
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
                            Id = "cbc3307b-98ed-4188-9185-d21b918d9a37",
                            Name = "Chiss"
                        },
                        new
                        {
                            Id = "63057747-2772-4a33-bf84-706eb21fc209",
                            Name = "Cyborg"
                        },
                        new
                        {
                            Id = "904aad6a-e507-4421-ac79-c6a349a986c1",
                            Name = "Human"
                        },
                        new
                        {
                            Id = "b60b2e85-5c8f-4213-8cad-7e41c0a8819e",
                            Name = "Miraluka"
                        },
                        new
                        {
                            Id = "409ff2e9-ae6b-43ef-8eea-c8c32acc586b",
                            Name = "Mirialan"
                        },
                        new
                        {
                            Id = "446ca2bb-c7e7-42a2-aaa9-de74ecc76760",
                            Name = "Rattaki"
                        },
                        new
                        {
                            Id = "e1537e82-bdad-4b5f-ae31-f0be4ca4bf0f",
                            Name = "Sith Pureblood"
                        },
                        new
                        {
                            Id = "b8b3be4f-f302-4467-b6aa-5f1f2f5df3c9",
                            Name = "Twi'lek"
                        },
                        new
                        {
                            Id = "28ced486-e7a3-46d0-be4b-b135c7bdfa22",
                            Name = "Zabrak"
                        },
                        new
                        {
                            Id = "add6477d-9248-4fc9-8b50-45a998dd653d",
                            Name = "Cathar"
                        },
                        new
                        {
                            Id = "af5ddea7-8d03-43b8-abcc-311c0ba56cb9",
                            Name = "Togruta"
                        },
                        new
                        {
                            Id = "6332a0e7-97d7-43c9-9e1e-2f683b063f7d",
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
                            Id = "b8d8e990-9959-4d9c-b682-766a4fa963bf",
                            Name = "Darth Malgus"
                        },
                        new
                        {
                            Id = "87eb2150-52fe-43b8-b50f-e0eb9e8a0507",
                            Name = "Star Forge"
                        },
                        new
                        {
                            Id = "da991a16-8d44-44e1-a93a-566b53f6df02",
                            Name = "Satele Shan"
                        },
                        new
                        {
                            Id = "a489e5a5-cc2c-4504-95a3-ee1ea6eb7f46",
                            Name = "Tulak Hord"
                        },
                        new
                        {
                            Id = "a110d75a-3927-44d1-8844-02121074621a",
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
