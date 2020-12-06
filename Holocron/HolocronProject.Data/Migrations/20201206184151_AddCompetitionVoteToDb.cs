using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddCompetitionVoteToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsCharacters_AspNetUsers_AccountId",
                table: "CompetitionsCharacters");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionsCharacters_AccountId",
                table: "CompetitionsCharacters");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "03d81445-30e8-49c8-888a-9056b4597067");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "54746ca1-3db6-44e9-912d-a07c0cbf7a54");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8a8f9b8b-5052-4367-849d-9e51d3ae2490");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "bd43f047-46c9-4df2-a968-83f62f1f1d50");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d7f93746-c61a-4f9f-9497-4145819021c7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "11d63ac7-6773-4238-ba8a-744ba79000bb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "144cd095-aefc-4679-be79-b7ebe6150cac");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "169ea5b4-ea08-4665-ae75-30237f14ce8f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1a6d8341-8d36-4b70-86ad-5389ec727cbd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "49ec0157-dfb2-4b27-8c36-b9d7894e918a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "57083941-988c-4fa7-984b-3f9446993854");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5a9061a4-7fa5-4ba5-9e9c-212bbe606d94");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7ed17eec-8bfe-4a9e-98fb-ed4fc6b947b2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "89c50e60-57d3-4d27-9cdc-a769a9d59a21");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9a153947-f7a4-47cb-a6bb-c32544884239");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b0f6d6a0-030f-4423-830c-6272d0090b40");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "be889d5a-1576-46a7-9a43-0fa518dbd621");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "de8e9495-e250-4756-8143-e5dc3f07349f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e166e94d-96d4-480e-b351-dcb30a15cdf8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e1daeaa5-3c52-429d-a147-7410e2fb7ec5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e3c39566-70fb-4151-948a-6c190715e2c8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "19cef016-ce5d-410e-8c5f-96edf148a33c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "300d66a0-1f96-4efd-95c3-f4bce4a2ddb9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "34e5a5bf-78ff-415a-8caa-ef6d6c8478ce");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "75b41f8f-e0ea-4c67-b1e6-0906c630ab16");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "952caa73-2094-43f0-9464-272e27fd8092");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9f69253c-e4b3-4c2f-b8c0-2bef4d10344c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a1b9a3cc-372d-4be4-948e-8e5a55d3ee2e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bc0efacb-5e25-4ff4-9c50-05b1dcf1411f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c09c2d3b-dcfc-4651-bea4-c4bfda0e164f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ef349733-13ca-44f0-97db-e95d61218602");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "faf8ce45-fb26-4478-b431-eb98f976c547");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "fe249fed-accc-4c1c-8f52-a286c740b045");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "9ce0e808-ec04-4c09-bf8c-3cc5af00d2b4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "a7f25ebd-063f-484c-8c7d-18e5e94726be");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "a887ff5d-655b-40cf-9843-20664ae2d62f");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b8b7f4c5-aace-4fd7-a968-e43d16d3645b");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "ebeda1e5-38db-4e1f-9afc-c1e4c251bd12");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "CompetitionsCharacters");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "CompetitionsCharacters",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompetitionVotes",
                columns: table => new
                {
                    CompetitionCharacterId = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CompetitionsCharacters");

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "CompetitionsCharacters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "54746ca1-3db6-44e9-912d-a07c0cbf7a54", new DateTime(2020, 12, 6, 18, 31, 58, 688, DateTimeKind.Utc).AddTicks(6220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/06/2020 08:31 PM", null, "PVP" },
                    { "03d81445-30e8-49c8-888a-9056b4597067", new DateTime(2020, 12, 6, 18, 31, 58, 691, DateTimeKind.Utc).AddTicks(6148), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/06/2020 08:31 PM", null, "PVE" },
                    { "bd43f047-46c9-4df2-a968-83f62f1f1d50", new DateTime(2020, 12, 6, 18, 31, 58, 691, DateTimeKind.Utc).AddTicks(6244), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/06/2020 08:31 PM", null, "RP" },
                    { "8a8f9b8b-5052-4367-849d-9e51d3ae2490", new DateTime(2020, 12, 6, 18, 31, 58, 691, DateTimeKind.Utc).AddTicks(6257), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/06/2020 08:31 PM", null, "Other" },
                    { "d7f93746-c61a-4f9f-9497-4145819021c7", new DateTime(2020, 12, 6, 18, 31, 58, 691, DateTimeKind.Utc).AddTicks(6267), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/06/2020 08:31 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "e166e94d-96d4-480e-b351-dcb30a15cdf8", 1, "Guardian" },
                    { "5a9061a4-7fa5-4ba5-9e9c-212bbe606d94", 1, "Sentinel" },
                    { "de8e9495-e250-4756-8143-e5dc3f07349f", 1, "Sage" },
                    { "89c50e60-57d3-4d27-9cdc-a769a9d59a21", 1, "Commando" },
                    { "1a6d8341-8d36-4b70-86ad-5389ec727cbd", 1, "Vanguard" },
                    { "b0f6d6a0-030f-4423-830c-6272d0090b40", 1, "Scoundrel" },
                    { "be889d5a-1576-46a7-9a43-0fa518dbd621", 1, "Gunslinger" },
                    { "7ed17eec-8bfe-4a9e-98fb-ed4fc6b947b2", 1, "Shadow" },
                    { "169ea5b4-ea08-4665-ae75-30237f14ce8f", 2, "Powertech" },
                    { "144cd095-aefc-4679-be79-b7ebe6150cac", 2, "Operative" },
                    { "11d63ac7-6773-4238-ba8a-744ba79000bb", 2, "Sniper" },
                    { "57083941-988c-4fa7-984b-3f9446993854", 2, "Assassin" },
                    { "9a153947-f7a4-47cb-a6bb-c32544884239", 2, "Sorcerer" },
                    { "e1daeaa5-3c52-429d-a147-7410e2fb7ec5", 2, "Marauder" },
                    { "49ec0157-dfb2-4b27-8c36-b9d7894e918a", 2, "Juggernaut" },
                    { "e3c39566-70fb-4151-948a-6c190715e2c8", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "9f69253c-e4b3-4c2f-b8c0-2bef4d10344c", "Nautolan" },
                    { "952caa73-2094-43f0-9464-272e27fd8092", "Togruta" },
                    { "ef349733-13ca-44f0-97db-e95d61218602", "Cathar" },
                    { "fe249fed-accc-4c1c-8f52-a286c740b045", "Zabrak" },
                    { "300d66a0-1f96-4efd-95c3-f4bce4a2ddb9", "Twi'lek" },
                    { "c09c2d3b-dcfc-4651-bea4-c4bfda0e164f", "Sith Pureblood" },
                    { "19cef016-ce5d-410e-8c5f-96edf148a33c", "Mirialan" },
                    { "34e5a5bf-78ff-415a-8caa-ef6d6c8478ce", "Miraluka" },
                    { "faf8ce45-fb26-4478-b431-eb98f976c547", "Human" },
                    { "75b41f8f-e0ea-4c67-b1e6-0906c630ab16", "Cyborg" },
                    { "a1b9a3cc-372d-4be4-948e-8e5a55d3ee2e", "Chiss" },
                    { "bc0efacb-5e25-4ff4-9c50-05b1dcf1411f", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "9ce0e808-ec04-4c09-bf8c-3cc5af00d2b4", "Tulak Hord" },
                    { "a7f25ebd-063f-484c-8c7d-18e5e94726be", "Darth Malgus" },
                    { "a887ff5d-655b-40cf-9843-20664ae2d62f", "Star Forge" },
                    { "ebeda1e5-38db-4e1f-9afc-c1e4c251bd12", "Satele Shan" },
                    { "b8b7f4c5-aace-4fd7-a968-e43d16d3645b", "The Leviathan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsCharacters_AccountId",
                table: "CompetitionsCharacters",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsCharacters_AspNetUsers_AccountId",
                table: "CompetitionsCharacters",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
