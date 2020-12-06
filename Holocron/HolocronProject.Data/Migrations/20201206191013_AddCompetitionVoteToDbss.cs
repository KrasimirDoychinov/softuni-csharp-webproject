using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddCompetitionVoteToDbss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CompetitionsCharacters_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "0827ef2a-0252-4ac6-b85f-389d9c786e90");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "1a22eb32-7b4c-4c08-8b12-8e5d59452945");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "78ffed01-a353-4310-a921-c46377482ec1");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "9f2a708a-0a36-4d3a-9eb0-482d395223c0");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d9dcc31b-7885-48ea-a671-a0a878badfb9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "09fc8517-ccf5-46ba-a94d-c3e154361bae");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1ea20eab-5715-4ea5-94ed-e670e1c8ab2c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3ab9ca2b-9c47-42bc-85a7-48e43fb142b8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4f573b77-ff48-4195-a0ea-21cb63eda796");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "57b51d27-7579-45c4-ae7e-331d4adc6358");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8808479e-a0f9-4e08-a47e-c571a4b89b59");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "95fcd167-f098-4713-b013-e2d0770c2017");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9f8b590e-026c-4943-a27e-f3b1b4ad4252");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c5917780-5bd7-4242-afb3-492c86c3f51f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "dd049a7c-2d3c-41b4-a320-b168b4c93b1d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e10c26c5-7994-4016-956e-84315bbe204c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e2c98dfd-c3e8-4f92-953b-9465e96f21c9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e7b03af2-4a59-4179-9f64-b70781560d2c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "eba94a41-4e12-46f8-9eef-fce9075a1c03");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ee7f88c1-80e1-4811-bb59-8873a529070b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f421b229-dda4-40a9-af28-1b752e648fc2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2b5b4399-ba65-4e99-a8b5-9a913f3fa79b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3e6083e5-5d26-4554-b206-80f0352ac451");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4d0ece24-e892-4c1e-bac3-1a8689faf27b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "53f35ed6-2b39-470c-b591-e8e46383f1dc");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6b651622-75a3-4737-aaa2-69570c79735b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8156ad0b-c7ad-4791-a869-c7120e462583");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a3f22d76-6531-411c-a0ea-e022819c6ce1");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b522edcb-558f-4c39-b0e1-362870f476f7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b5642c62-90f5-48a4-8fa4-eaa0d299a17b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "db966f5e-5c34-46a0-9979-1137626990b4");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f1d83b58-ed97-430c-b205-bea9a3bf6e40");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "fe0e3f93-567c-44e6-bc80-22137dd35250");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1939528c-4fd3-48a7-ac71-da6a8eb081f1");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "7302bf99-a01c-44f4-8d5d-33f66c98133d");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "74d07eaa-be18-4a49-8b6e-78ebd83d6f92");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "7ee1a1f2-cc03-40eb-bb82-fa003faa0757");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "af650522-d25b-471c-8cbf-b73b1e3d82b7");

            migrationBuilder.DropColumn(
                name: "CompetitionCharacterCharacterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompetitionCharacterCompetitionId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "CompetitionVotes",
                columns: table => new
                {
                    AccountId = table.Column<string>(nullable: false),
                    CompetitionCharacterId = table.Column<string>(nullable: false),
                    CompetitionCharacterCharacterId = table.Column<string>(nullable: true),
                    CompetitionCharacterCompetitionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionVotes", x => new { x.AccountId, x.CompetitionCharacterId });
                    table.ForeignKey(
                        name: "FK_CompetitionVotes_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionVotes_CompetitionsCharacters_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
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
                    { "85d10e9f-cc8c-47e1-bf0e-1f606bb940d1", new DateTime(2020, 12, 6, 19, 10, 12, 730, DateTimeKind.Utc).AddTicks(6475), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/06/2020 09:10 PM", null, "PVP" },
                    { "0bdcfda4-b630-4cb4-8bfd-b4ed7e6c695f", new DateTime(2020, 12, 6, 19, 10, 12, 733, DateTimeKind.Utc).AddTicks(3625), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/06/2020 09:10 PM", null, "PVE" },
                    { "a5caf828-145b-4736-b058-83fa4c599fea", new DateTime(2020, 12, 6, 19, 10, 12, 733, DateTimeKind.Utc).AddTicks(3712), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/06/2020 09:10 PM", null, "RP" },
                    { "81356fdd-c445-49b0-9183-a689fe54352f", new DateTime(2020, 12, 6, 19, 10, 12, 733, DateTimeKind.Utc).AddTicks(3725), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/06/2020 09:10 PM", null, "Other" },
                    { "8dd711c8-8e8b-4f73-8942-89eb4b89c220", new DateTime(2020, 12, 6, 19, 10, 12, 733, DateTimeKind.Utc).AddTicks(3735), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/06/2020 09:10 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "79b73460-8aa9-4451-ae84-4c18d8b3b72f", 1, "Guardian" },
                    { "7c21957b-920f-4a49-a8ab-bca3c501fb73", 1, "Sentinel" },
                    { "4e09805c-8387-4ae9-bf6c-4012636e7ff3", 1, "Sage" },
                    { "f4d89f6a-ac41-4533-9fbb-ca674eef5796", 1, "Commando" },
                    { "dd2f6e0f-b9a4-4151-99fd-7039a55cd757", 1, "Vanguard" },
                    { "37555677-e95c-4d9a-bd92-839313aa7b5a", 1, "Scoundrel" },
                    { "8979938c-954e-4ded-8ef2-eed119bda024", 1, "Gunslinger" },
                    { "f2478b3e-728c-4f84-97ce-cf4020904cf2", 1, "Shadow" },
                    { "f339fec7-e0e7-46da-9d20-500be2b931ad", 2, "Powertech" },
                    { "41cd24f4-8f22-4dc0-881e-c829a82af552", 2, "Operative" },
                    { "546d9938-10f2-4a02-914e-8f7a693193c9", 2, "Sniper" },
                    { "fa510434-d886-4e25-9bc2-7d316d120479", 2, "Assassin" },
                    { "968e8fa8-0dd5-44a3-bded-c4cd62e231fe", 2, "Sorcerer" },
                    { "68189fdf-6b88-4694-bd5e-10e32f6d7df1", 2, "Marauder" },
                    { "10ada69b-e099-447e-8d78-2de2944dc8da", 2, "Juggernaut" },
                    { "305bebaa-2d0c-459b-b46a-2d91746594c3", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "e00fc125-06ee-409a-9f70-3a499dcf3c20", "Nautolan" },
                    { "9c37ad5f-54f2-437a-9bef-bbb97370f574", "Togruta" },
                    { "cebcfa84-1009-46fe-a39c-0c2acc487385", "Cathar" },
                    { "5acee00c-4edd-46dd-9228-06da6521cd92", "Zabrak" },
                    { "19e6eedd-5fc7-43c8-adb7-16e9bffbe283", "Twi'lek" },
                    { "c4aca63b-cade-4a86-86ee-ac1a8c65927a", "Sith Pureblood" },
                    { "bc36a285-97da-43f4-81d1-1302ec53d0de", "Mirialan" },
                    { "d323e372-9770-4ae4-bfcd-13a1f1bdaef6", "Miraluka" },
                    { "e1971f82-6b0c-48a0-a03c-49e1fec2ba39", "Human" },
                    { "ad573aa0-ebd6-4339-bc0c-2d3ef8020a4d", "Cyborg" },
                    { "089218de-04cd-4af6-b1ac-6573f5af9a9b", "Chiss" },
                    { "3ea2e0c9-8cd3-4b75-869f-30afc11ebbbe", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "de3ccbe8-3624-4cc3-b206-dd9ad12ad2d0", "Tulak Hord" },
                    { "65cef325-e952-48c0-abe5-5be57d7c7297", "Darth Malgus" },
                    { "a2029da9-7367-4ccf-9f7b-2b8e74928a06", "Star Forge" },
                    { "e10db9dd-0795-4fdd-ad98-7e2097fd9e3c", "Satele Shan" },
                    { "af7cd04e-6d1a-4552-9c03-adf766f4d2ca", "The Leviathan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionVotes_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
                table: "CompetitionVotes",
                columns: new[] { "CompetitionCharacterCharacterId", "CompetitionCharacterCompetitionId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetitionVotes");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "0bdcfda4-b630-4cb4-8bfd-b4ed7e6c695f");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "81356fdd-c445-49b0-9183-a689fe54352f");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "85d10e9f-cc8c-47e1-bf0e-1f606bb940d1");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8dd711c8-8e8b-4f73-8942-89eb4b89c220");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a5caf828-145b-4736-b058-83fa4c599fea");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "10ada69b-e099-447e-8d78-2de2944dc8da");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "305bebaa-2d0c-459b-b46a-2d91746594c3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "37555677-e95c-4d9a-bd92-839313aa7b5a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "41cd24f4-8f22-4dc0-881e-c829a82af552");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4e09805c-8387-4ae9-bf6c-4012636e7ff3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "546d9938-10f2-4a02-914e-8f7a693193c9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "68189fdf-6b88-4694-bd5e-10e32f6d7df1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "79b73460-8aa9-4451-ae84-4c18d8b3b72f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7c21957b-920f-4a49-a8ab-bca3c501fb73");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8979938c-954e-4ded-8ef2-eed119bda024");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "968e8fa8-0dd5-44a3-bded-c4cd62e231fe");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "dd2f6e0f-b9a4-4151-99fd-7039a55cd757");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f2478b3e-728c-4f84-97ce-cf4020904cf2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f339fec7-e0e7-46da-9d20-500be2b931ad");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f4d89f6a-ac41-4533-9fbb-ca674eef5796");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "fa510434-d886-4e25-9bc2-7d316d120479");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "089218de-04cd-4af6-b1ac-6573f5af9a9b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "19e6eedd-5fc7-43c8-adb7-16e9bffbe283");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3ea2e0c9-8cd3-4b75-869f-30afc11ebbbe");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5acee00c-4edd-46dd-9228-06da6521cd92");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9c37ad5f-54f2-437a-9bef-bbb97370f574");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ad573aa0-ebd6-4339-bc0c-2d3ef8020a4d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bc36a285-97da-43f4-81d1-1302ec53d0de");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c4aca63b-cade-4a86-86ee-ac1a8c65927a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "cebcfa84-1009-46fe-a39c-0c2acc487385");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d323e372-9770-4ae4-bfcd-13a1f1bdaef6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e00fc125-06ee-409a-9f70-3a499dcf3c20");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e1971f82-6b0c-48a0-a03c-49e1fec2ba39");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "65cef325-e952-48c0-abe5-5be57d7c7297");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "a2029da9-7367-4ccf-9f7b-2b8e74928a06");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "af7cd04e-6d1a-4552-9c03-adf766f4d2ca");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "de3ccbe8-3624-4cc3-b206-dd9ad12ad2d0");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "e10db9dd-0795-4fdd-ad98-7e2097fd9e3c");

            migrationBuilder.AddColumn<string>(
                name: "CompetitionCharacterCharacterId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompetitionCharacterCompetitionId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "78ffed01-a353-4310-a921-c46377482ec1", new DateTime(2020, 12, 6, 19, 4, 56, 74, DateTimeKind.Utc).AddTicks(2825), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/06/2020 09:04 PM", null, "PVP" },
                    { "0827ef2a-0252-4ac6-b85f-389d9c786e90", new DateTime(2020, 12, 6, 19, 4, 56, 77, DateTimeKind.Utc).AddTicks(6108), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/06/2020 09:04 PM", null, "PVE" },
                    { "1a22eb32-7b4c-4c08-8b12-8e5d59452945", new DateTime(2020, 12, 6, 19, 4, 56, 77, DateTimeKind.Utc).AddTicks(6207), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/06/2020 09:04 PM", null, "RP" },
                    { "9f2a708a-0a36-4d3a-9eb0-482d395223c0", new DateTime(2020, 12, 6, 19, 4, 56, 77, DateTimeKind.Utc).AddTicks(6220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/06/2020 09:04 PM", null, "Other" },
                    { "d9dcc31b-7885-48ea-a671-a0a878badfb9", new DateTime(2020, 12, 6, 19, 4, 56, 77, DateTimeKind.Utc).AddTicks(6230), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/06/2020 09:04 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "c5917780-5bd7-4242-afb3-492c86c3f51f", 1, "Guardian" },
                    { "95fcd167-f098-4713-b013-e2d0770c2017", 1, "Sentinel" },
                    { "9f8b590e-026c-4943-a27e-f3b1b4ad4252", 1, "Sage" },
                    { "57b51d27-7579-45c4-ae7e-331d4adc6358", 1, "Commando" },
                    { "8808479e-a0f9-4e08-a47e-c571a4b89b59", 1, "Vanguard" },
                    { "e2c98dfd-c3e8-4f92-953b-9465e96f21c9", 1, "Scoundrel" },
                    { "e7b03af2-4a59-4179-9f64-b70781560d2c", 1, "Gunslinger" },
                    { "f421b229-dda4-40a9-af28-1b752e648fc2", 1, "Shadow" },
                    { "e10c26c5-7994-4016-956e-84315bbe204c", 2, "Powertech" },
                    { "4f573b77-ff48-4195-a0ea-21cb63eda796", 2, "Operative" },
                    { "3ab9ca2b-9c47-42bc-85a7-48e43fb142b8", 2, "Sniper" },
                    { "eba94a41-4e12-46f8-9eef-fce9075a1c03", 2, "Assassin" },
                    { "dd049a7c-2d3c-41b4-a320-b168b4c93b1d", 2, "Sorcerer" },
                    { "09fc8517-ccf5-46ba-a94d-c3e154361bae", 2, "Marauder" },
                    { "1ea20eab-5715-4ea5-94ed-e670e1c8ab2c", 2, "Juggernaut" },
                    { "ee7f88c1-80e1-4811-bb59-8873a529070b", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "f1d83b58-ed97-430c-b205-bea9a3bf6e40", "Nautolan" },
                    { "6b651622-75a3-4737-aaa2-69570c79735b", "Togruta" },
                    { "3e6083e5-5d26-4554-b206-80f0352ac451", "Cathar" },
                    { "b522edcb-558f-4c39-b0e1-362870f476f7", "Zabrak" },
                    { "db966f5e-5c34-46a0-9979-1137626990b4", "Twi'lek" },
                    { "a3f22d76-6531-411c-a0ea-e022819c6ce1", "Sith Pureblood" },
                    { "fe0e3f93-567c-44e6-bc80-22137dd35250", "Mirialan" },
                    { "2b5b4399-ba65-4e99-a8b5-9a913f3fa79b", "Miraluka" },
                    { "53f35ed6-2b39-470c-b591-e8e46383f1dc", "Human" },
                    { "b5642c62-90f5-48a4-8fa4-eaa0d299a17b", "Cyborg" },
                    { "8156ad0b-c7ad-4791-a869-c7120e462583", "Chiss" },
                    { "4d0ece24-e892-4c1e-bac3-1a8689faf27b", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "74d07eaa-be18-4a49-8b6e-78ebd83d6f92", "Tulak Hord" },
                    { "7ee1a1f2-cc03-40eb-bb82-fa003faa0757", "Darth Malgus" },
                    { "7302bf99-a01c-44f4-8d5d-33f66c98133d", "Star Forge" },
                    { "1939528c-4fd3-48a7-ac71-da6a8eb081f1", "Satele Shan" },
                    { "af650522-d25b-471c-8cbf-b73b1e3d82b7", "The Leviathan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
                table: "AspNetUsers",
                columns: new[] { "CompetitionCharacterCharacterId", "CompetitionCharacterCompetitionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CompetitionsCharacters_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
                table: "AspNetUsers",
                columns: new[] { "CompetitionCharacterCharacterId", "CompetitionCharacterCompetitionId" },
                principalTable: "CompetitionsCharacters",
                principalColumns: new[] { "CharacterId", "CompetitionId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
