using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddCompetitionVoteToDbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetitionVotes");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "7c0fdd86-d49d-4349-abff-daf4a14f2736");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "7fe30a26-e868-40b9-bc95-38d285521fdb");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b0feb307-2332-4079-8002-143d4007cdbc");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b78c80c5-a58c-462e-a795-df71435527fb");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ca5eb44d-5cbd-4e20-9d3e-ec8784996f2a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0fecd4c9-ed98-40dc-a5a2-9f231f5e039a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2ea86281-a3cf-4670-a072-3f55e93a2409");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4025cdfd-b894-44c2-974a-7281f0266661");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4785a565-b30e-4f26-beec-59a032387c6a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "49da1379-4f14-46f4-b094-ed8f42c4d6fe");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "92781e4e-e22d-4d0d-929e-5bf082494950");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "928494c8-9c47-4aec-86b5-5f731a530551");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "97c920a1-fdea-4a92-9dc6-331b2cce1bd4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9afb2be7-89b0-4988-8001-b40e0494508c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b395ec62-a286-4536-8316-6f34fc5499de");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b4c821cf-1d58-43c4-a54c-faf91fa0cf42");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b6cd7e48-1bae-45dd-9e90-8adfb69a8906");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e10712f7-1def-4250-a930-3cbae83f916c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e7ba18ef-b598-4840-ac7d-14a41d1b7c2e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "edc4f781-b46f-42a1-9a51-b37e8ef420a0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "efada50b-f0c6-4655-a6ce-fa232a947df8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "026c52aa-76e4-49ee-bb80-59dd1bd157ce");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1d595fc6-b186-4028-a37a-3129d3a941a4");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2b0eb861-8a58-4c7f-b633-e6a9f594b17a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6056c26a-78f9-4366-b4ac-453a025c8fb0");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6c832f9f-35c2-437c-876e-f78f580e9dfa");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "71978176-40be-4843-a635-187f7719ff2d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "79037340-2691-4a28-ac41-fc5ffbd04d4e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7ad7f69e-8fd6-41bc-988c-82f3cb07fe48");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b31a540d-985c-4e2a-a34c-3acce8639e4c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ccff3c97-75df-45a9-a5f8-ad1a59a01d9d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d19f7c0b-675a-473a-879d-c06016bdaae5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f9de0995-3b16-47bb-9017-52487a1ace61");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "0f744160-21a4-4d20-ae53-e296f17f89bc");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "7a6338e7-60c8-4bf9-abdd-be2659c88502");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "8b6c409e-88e2-4da4-a704-e2114b8734f9");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b20db136-060a-483e-bdc5-d610efac2c96");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "ed62839a-0b71-4723-8b75-0041a02bd108");

            migrationBuilder.AddColumn<string>(
                name: "CompetitionCharacterCharacterId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompetitionCharacterCompetitionId",
                table: "AspNetUsers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompetitionCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompetitionCharacterCharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompetitionCharacterCompetitionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    { "7fe30a26-e868-40b9-bc95-38d285521fdb", new DateTime(2020, 12, 6, 18, 41, 50, 621, DateTimeKind.Utc).AddTicks(1108), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/06/2020 08:41 PM", null, "PVP" },
                    { "b78c80c5-a58c-462e-a795-df71435527fb", new DateTime(2020, 12, 6, 18, 41, 50, 623, DateTimeKind.Utc).AddTicks(6664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/06/2020 08:41 PM", null, "PVE" },
                    { "7c0fdd86-d49d-4349-abff-daf4a14f2736", new DateTime(2020, 12, 6, 18, 41, 50, 623, DateTimeKind.Utc).AddTicks(6747), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/06/2020 08:41 PM", null, "RP" },
                    { "b0feb307-2332-4079-8002-143d4007cdbc", new DateTime(2020, 12, 6, 18, 41, 50, 623, DateTimeKind.Utc).AddTicks(6760), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/06/2020 08:41 PM", null, "Other" },
                    { "ca5eb44d-5cbd-4e20-9d3e-ec8784996f2a", new DateTime(2020, 12, 6, 18, 41, 50, 623, DateTimeKind.Utc).AddTicks(6770), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/06/2020 08:41 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "e7ba18ef-b598-4840-ac7d-14a41d1b7c2e", 1, "Guardian" },
                    { "b4c821cf-1d58-43c4-a54c-faf91fa0cf42", 1, "Sentinel" },
                    { "92781e4e-e22d-4d0d-929e-5bf082494950", 1, "Sage" },
                    { "0fecd4c9-ed98-40dc-a5a2-9f231f5e039a", 1, "Commando" },
                    { "b395ec62-a286-4536-8316-6f34fc5499de", 1, "Vanguard" },
                    { "49da1379-4f14-46f4-b094-ed8f42c4d6fe", 1, "Scoundrel" },
                    { "97c920a1-fdea-4a92-9dc6-331b2cce1bd4", 1, "Gunslinger" },
                    { "9afb2be7-89b0-4988-8001-b40e0494508c", 1, "Shadow" },
                    { "edc4f781-b46f-42a1-9a51-b37e8ef420a0", 2, "Powertech" },
                    { "e10712f7-1def-4250-a930-3cbae83f916c", 2, "Operative" },
                    { "2ea86281-a3cf-4670-a072-3f55e93a2409", 2, "Sniper" },
                    { "b6cd7e48-1bae-45dd-9e90-8adfb69a8906", 2, "Assassin" },
                    { "928494c8-9c47-4aec-86b5-5f731a530551", 2, "Sorcerer" },
                    { "4785a565-b30e-4f26-beec-59a032387c6a", 2, "Marauder" },
                    { "efada50b-f0c6-4655-a6ce-fa232a947df8", 2, "Juggernaut" },
                    { "4025cdfd-b894-44c2-974a-7281f0266661", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "ccff3c97-75df-45a9-a5f8-ad1a59a01d9d", "Nautolan" },
                    { "71978176-40be-4843-a635-187f7719ff2d", "Togruta" },
                    { "d19f7c0b-675a-473a-879d-c06016bdaae5", "Cathar" },
                    { "f9de0995-3b16-47bb-9017-52487a1ace61", "Zabrak" },
                    { "6c832f9f-35c2-437c-876e-f78f580e9dfa", "Twi'lek" },
                    { "b31a540d-985c-4e2a-a34c-3acce8639e4c", "Sith Pureblood" },
                    { "7ad7f69e-8fd6-41bc-988c-82f3cb07fe48", "Mirialan" },
                    { "1d595fc6-b186-4028-a37a-3129d3a941a4", "Miraluka" },
                    { "79037340-2691-4a28-ac41-fc5ffbd04d4e", "Human" },
                    { "2b0eb861-8a58-4c7f-b633-e6a9f594b17a", "Cyborg" },
                    { "026c52aa-76e4-49ee-bb80-59dd1bd157ce", "Chiss" },
                    { "6056c26a-78f9-4366-b4ac-453a025c8fb0", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "8b6c409e-88e2-4da4-a704-e2114b8734f9", "Tulak Hord" },
                    { "7a6338e7-60c8-4bf9-abdd-be2659c88502", "Darth Malgus" },
                    { "0f744160-21a4-4d20-ae53-e296f17f89bc", "Star Forge" },
                    { "ed62839a-0b71-4723-8b75-0041a02bd108", "Satele Shan" },
                    { "b20db136-060a-483e-bdc5-d610efac2c96", "The Leviathan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionVotes_CompetitionCharacterCharacterId_CompetitionCharacterCompetitionId",
                table: "CompetitionVotes",
                columns: new[] { "CompetitionCharacterCharacterId", "CompetitionCharacterCompetitionId" });
        }
    }
}
