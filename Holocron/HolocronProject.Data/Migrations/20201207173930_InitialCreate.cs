using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<string>(nullable: true),
                    AvatarImagePath = table.Column<string>(nullable: true),
                    ForumSignature = table.Column<string>(nullable: true),
                    NotificationStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseThreads",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    NormalizedCreatedOn = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: false),
                    NormalizedDeletedOn = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseThreads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Faction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 20000, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsFinished = table.Column<bool>(nullable: false),
                    FinishedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BugReports",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    NormalizedCreatedOn = table.Column<string>(nullable: true),
                    IsResolved = table.Column<bool>(nullable: false),
                    ResolvedOn = table.Column<DateTime>(nullable: false),
                    NormalizedResolvedOn = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 20000, nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    AccountId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BugReports_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Threads",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    NormalizedCreatedOn = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: false),
                    NormalizedDeletedOn = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    BaseThreadId = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Threads_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Threads_BaseThreads_BaseThreadId",
                        column: x => x.BaseThreadId,
                        principalTable: "BaseThreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    NormalizedCreatedOn = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: false),
                    NormalizedDeletedOn = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 25, nullable: false),
                    Backstory = table.Column<string>(maxLength: 25000, nullable: true),
                    Description = table.Column<string>(maxLength: 25000, nullable: true),
                    Title = table.Column<string>(maxLength: 25, nullable: true),
                    CharacterImagePath = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    CharacterType = table.Column<int>(nullable: false),
                    ForceAffiliation = table.Column<int>(nullable: false),
                    ClassId = table.Column<string>(nullable: false),
                    RaceId = table.Column<string>(nullable: false),
                    ServerId = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    CharacterStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    NormalizedCreatedOn = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: false),
                    NormalizedDeletedOn = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 20000, nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    ThreadId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    ThreadId = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => new { x.ThreadId, x.AccountId });
                    table.ForeignKey(
                        name: "FK_Votes_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CharacterId = table.Column<string>(nullable: true),
                    CompetitionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Achievements_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionsCharacters",
                columns: table => new
                {
                    CompetitionId = table.Column<string>(nullable: false),
                    CharacterId = table.Column<string>(nullable: false),
                    Id = table.Column<string>(nullable: true),
                    Votes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionsCharacters", x => new { x.CharacterId, x.CompetitionId });
                    table.ForeignKey(
                        name: "FK_CompetitionsCharacters_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionsCharacters_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostReports",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    NormalizedCreatedOn = table.Column<string>(nullable: true),
                    IsResolved = table.Column<bool>(nullable: false),
                    ResolvedOn = table.Column<DateTime>(nullable: false),
                    NormalizedResolvedOn = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 20000, nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    PostId = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostReports_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostReports_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionAccounts",
                columns: table => new
                {
                    AccountId = table.Column<string>(nullable: false),
                    CompetitionId = table.Column<string>(nullable: false),
                    HasVoted = table.Column<bool>(nullable: false),
                    CompetitionCharacterId = table.Column<string>(nullable: true),
                    CompetitionCharacterCharacterId = table.Column<string>(nullable: true),
                    CompetitionCharacterCompetitionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionAccounts", x => new { x.AccountId, x.CompetitionId });
                    table.ForeignKey(
                        name: "FK_CompetitionAccounts_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionAccounts_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionAccounts_CompetitionsCharacters_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
                        columns: x => new { x.CompetitionCharacterCharacterId, x.CompetitionCharacterCompetitionId },
                        principalTable: "CompetitionsCharacters",
                        principalColumns: new[] { "CharacterId", "CompetitionId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "b268a2f7-25e1-470a-ad73-c73b8f57158d", new DateTime(2020, 12, 7, 17, 39, 29, 685, DateTimeKind.Utc).AddTicks(5976), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/07/2020 07:39 PM", null, "PVP" },
                    { "a88e2498-d7c9-421b-a49c-34b8a3070f29", new DateTime(2020, 12, 7, 17, 39, 29, 688, DateTimeKind.Utc).AddTicks(4568), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/07/2020 07:39 PM", null, "PVE" },
                    { "81a4e972-4b89-4072-9395-361f0602e119", new DateTime(2020, 12, 7, 17, 39, 29, 688, DateTimeKind.Utc).AddTicks(4670), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/07/2020 07:39 PM", null, "RP" },
                    { "c79f5b98-8a24-4f85-bf85-5280f86530f1", new DateTime(2020, 12, 7, 17, 39, 29, 688, DateTimeKind.Utc).AddTicks(4684), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/07/2020 07:39 PM", null, "Other" },
                    { "3f4f4851-dfb5-4524-bf32-c4b7f957dca0", new DateTime(2020, 12, 7, 17, 39, 29, 688, DateTimeKind.Utc).AddTicks(4693), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/07/2020 07:39 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "62287eef-2a3a-4510-91fd-2a6a5cce81f4", 1, "Guardian" },
                    { "abcf5b88-b85b-4f2f-a857-1474b0f0f99d", 1, "Sentinel" },
                    { "e246c05c-6906-47d7-a1bc-973a6f66836c", 1, "Sage" },
                    { "92ddc5c4-558b-4082-937d-3b1b0f14220d", 1, "Commando" },
                    { "8386213f-89c6-4d38-a5ef-3fe6631881f7", 1, "Vanguard" },
                    { "69d577b8-1d70-48b1-8d87-05904297f21d", 1, "Scoundrel" },
                    { "cf5b9c91-0e5b-420f-85f1-d2143d29c55b", 1, "Gunslinger" },
                    { "d8a5f67f-aaee-4fd7-8208-e84accb28e59", 1, "Shadow" },
                    { "313fda59-0f85-46a4-a18e-c2258dd8cbdc", 2, "Powertech" },
                    { "cd86e460-f6a8-4a1b-99ce-f12c37be6a0e", 2, "Operative" },
                    { "603239b9-05c7-46a1-8d6b-69c781cf797c", 2, "Sniper" },
                    { "9eec1d7b-fbe4-4137-b631-798a62136cc3", 2, "Assassin" },
                    { "16ae45b2-61e1-4ecf-a6d6-0cfea2b53e5a", 2, "Sorcerer" },
                    { "3d5c19a5-61b3-4eab-bf1c-53e3b3e27487", 2, "Marauder" },
                    { "413604a7-f2fd-4348-b1b6-5b7b33cdd95a", 2, "Juggernaut" },
                    { "31d3ee35-2dca-4d2a-9566-79980528e9df", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "55be3df9-dcc7-4c08-94cc-09aaaaebb840", "Nautolan" },
                    { "a43209ab-fa49-402a-9ee7-e0a5bfa106f2", "Togruta" },
                    { "14686975-acd7-4a5b-b502-50fa3d72726e", "Cathar" },
                    { "b2896fe3-ff0a-4375-8172-ed57c54f3534", "Zabrak" },
                    { "6d060ba2-d185-4ae3-a842-c56d3cd018ce", "Twi'lek" },
                    { "2ba9b9db-52f3-40d9-92c8-cf8ffe649445", "Sith Pureblood" },
                    { "cdce640b-2898-48c1-8904-dad3e4326bc2", "Mirialan" },
                    { "9375f632-ad85-4044-a115-da4d1f4091dd", "Miraluka" },
                    { "2facd810-ae05-4d16-a87a-9d012b4b5f8c", "Human" },
                    { "b3e265d5-148b-446c-8130-c1f34ee8dce4", "Cyborg" },
                    { "878a4a8a-3706-41e1-b595-e1694a583988", "Chiss" },
                    { "aaf1084c-dbec-4dc3-81b7-77d9afba88e2", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "f670fa98-e967-406d-a9d6-afa56dc30263", "Tulak Hord" },
                    { "c0870b48-8ecd-4537-9ac6-2af49cfce712", "Darth Malgus" },
                    { "32b50f1f-92a1-4a31-b2d7-dfe90ba2f026", "Star Forge" },
                    { "60bd5c4b-1ca4-464a-8090-ffe5f66d5c34", "Satele Shan" },
                    { "aa2ccc20-5145-4fa0-b05c-dd48fb53b9eb", "The Leviathan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_CharacterId",
                table: "Achievements",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_CompetitionId",
                table: "Achievements",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BugReports_AccountId",
                table: "BugReports",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AccountId",
                table: "Characters",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ServerId",
                table: "Characters",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionAccounts_CompetitionId",
                table: "CompetitionAccounts",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionAccounts_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
                table: "CompetitionAccounts",
                columns: new[] { "CompetitionCharacterCharacterId", "CompetitionCharacterCompetitionId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsCharacters_CompetitionId",
                table: "CompetitionsCharacters",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReports_AccountId",
                table: "PostReports",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReports_PostId",
                table: "PostReports",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AccountId",
                table: "Posts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ThreadId",
                table: "Posts",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_AccountId",
                table: "Threads",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_BaseThreadId",
                table: "Threads",
                column: "BaseThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_AccountId",
                table: "Votes",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BugReports");

            migrationBuilder.DropTable(
                name: "CompetitionAccounts");

            migrationBuilder.DropTable(
                name: "PostReports");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CompetitionsCharacters");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Threads");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BaseThreads");
        }
    }
}
