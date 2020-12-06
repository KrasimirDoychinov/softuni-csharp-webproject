using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddAccountToCompetitionVoting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "04464f10-f9f0-4aea-a12f-52237971d915");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "18f852fb-8a65-4ea7-86fe-9a54b2931a7a");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "29b22e94-8a67-43fb-b894-847fef5020cb");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "c0b7852a-feeb-4050-8a5f-c9c529112021");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ebd9a77c-788a-4669-8a4d-7a8e84652f16");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0d2e9b52-19a3-4f79-957d-3472da0d00dd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1d3715ac-4042-4797-9c34-1e8d50df9232");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "23143c68-a968-424d-9a41-89a05bd4d294");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "26f1a562-1c77-4237-9156-d8ac65cb255d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "45221695-4f2a-4715-9473-177ad9ebc663");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5c7a49f6-da75-42e6-87b0-55ec7d0bdef0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "63c0b033-8391-446a-8a94-09d5e9353c46");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "64c5a2d9-7dd5-4bf7-aa49-e9fb65a416dc");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "77241116-ee1b-438e-8957-93b138e5c79d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "80e7411f-4cb7-479e-8d94-5805d8e9f256");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8687af5b-043d-4c94-9e67-03d848533c85");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "bab1ea19-6bf2-4811-8e84-64ae90146e7e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c2a2e1cc-6f07-4350-b606-a31b81d195ea");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c2d1194d-7e3d-49d7-8230-b749b1ba9986");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "da88fbe9-bc23-4d2e-93ba-c28d0f5c5df1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "dfdde4b6-b3eb-4d50-be2c-e3fdf77deeae");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "08e0062a-e892-47d0-bfdc-94586e60a5bf");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0b2177cd-e409-49c0-af77-0c3bb03ebe43");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1a994f32-07fc-4b7d-8d62-6c95d53f78f2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3a32d49f-c16f-4917-8afe-7e5d189ec731");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "80c5a72f-e4a2-4371-8ad8-444f546d6f47");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8d384568-7e29-4f64-b361-dbe8fd27f1d2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ab63dd6f-6991-465e-818d-a582e8ee0f35");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c1057ca8-c24e-44d5-90a4-aa4d24c8f35b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "cc726947-9035-4e20-af27-1b2c6cecca1a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d6d0bf84-5e68-4832-9358-6c76446a7d40");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e7d60b18-027c-4b3e-bd0f-72f245370dd9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "eab99232-3969-468a-a7b4-b8fe845fb765");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "8e86ab49-8b4b-42fb-8124-11a807aabd18");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "8f4a5164-2e9a-4f06-a90c-f429ca300f7f");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b0e0f262-a3b0-4ddd-86ec-34546841742e");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b133f650-1388-4165-8036-80056e2ebe78");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c492de2e-70f9-49b4-92aa-a10a96b7ba8a");

            migrationBuilder.DropColumn(
                name: "Votes",
                table: "CompetitionsCharacters");

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "CompetitionsCharacters",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Votes",
                table: "CompetitionsCharacters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "c0b7852a-feeb-4050-8a5f-c9c529112021", new DateTime(2020, 12, 6, 15, 28, 29, 827, DateTimeKind.Utc).AddTicks(26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/06/2020 05:28 PM", null, "PVP" },
                    { "ebd9a77c-788a-4669-8a4d-7a8e84652f16", new DateTime(2020, 12, 6, 15, 28, 29, 829, DateTimeKind.Utc).AddTicks(7936), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/06/2020 05:28 PM", null, "PVE" },
                    { "29b22e94-8a67-43fb-b894-847fef5020cb", new DateTime(2020, 12, 6, 15, 28, 29, 829, DateTimeKind.Utc).AddTicks(8029), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/06/2020 05:28 PM", null, "RP" },
                    { "18f852fb-8a65-4ea7-86fe-9a54b2931a7a", new DateTime(2020, 12, 6, 15, 28, 29, 829, DateTimeKind.Utc).AddTicks(8042), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/06/2020 05:28 PM", null, "Other" },
                    { "04464f10-f9f0-4aea-a12f-52237971d915", new DateTime(2020, 12, 6, 15, 28, 29, 829, DateTimeKind.Utc).AddTicks(8052), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/06/2020 05:28 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "8687af5b-043d-4c94-9e67-03d848533c85", 1, "Guardian" },
                    { "5c7a49f6-da75-42e6-87b0-55ec7d0bdef0", 1, "Sentinel" },
                    { "dfdde4b6-b3eb-4d50-be2c-e3fdf77deeae", 1, "Sage" },
                    { "c2a2e1cc-6f07-4350-b606-a31b81d195ea", 1, "Commando" },
                    { "80e7411f-4cb7-479e-8d94-5805d8e9f256", 1, "Vanguard" },
                    { "45221695-4f2a-4715-9473-177ad9ebc663", 1, "Scoundrel" },
                    { "63c0b033-8391-446a-8a94-09d5e9353c46", 1, "Gunslinger" },
                    { "26f1a562-1c77-4237-9156-d8ac65cb255d", 1, "Shadow" },
                    { "0d2e9b52-19a3-4f79-957d-3472da0d00dd", 2, "Powertech" },
                    { "64c5a2d9-7dd5-4bf7-aa49-e9fb65a416dc", 2, "Operative" },
                    { "1d3715ac-4042-4797-9c34-1e8d50df9232", 2, "Sniper" },
                    { "23143c68-a968-424d-9a41-89a05bd4d294", 2, "Assassin" },
                    { "da88fbe9-bc23-4d2e-93ba-c28d0f5c5df1", 2, "Sorcerer" },
                    { "c2d1194d-7e3d-49d7-8230-b749b1ba9986", 2, "Marauder" },
                    { "77241116-ee1b-438e-8957-93b138e5c79d", 2, "Juggernaut" },
                    { "bab1ea19-6bf2-4811-8e84-64ae90146e7e", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "8d384568-7e29-4f64-b361-dbe8fd27f1d2", "Nautolan" },
                    { "eab99232-3969-468a-a7b4-b8fe845fb765", "Togruta" },
                    { "cc726947-9035-4e20-af27-1b2c6cecca1a", "Cathar" },
                    { "0b2177cd-e409-49c0-af77-0c3bb03ebe43", "Zabrak" },
                    { "3a32d49f-c16f-4917-8afe-7e5d189ec731", "Twi'lek" },
                    { "80c5a72f-e4a2-4371-8ad8-444f546d6f47", "Sith Pureblood" },
                    { "e7d60b18-027c-4b3e-bd0f-72f245370dd9", "Mirialan" },
                    { "08e0062a-e892-47d0-bfdc-94586e60a5bf", "Miraluka" },
                    { "ab63dd6f-6991-465e-818d-a582e8ee0f35", "Human" },
                    { "d6d0bf84-5e68-4832-9358-6c76446a7d40", "Cyborg" },
                    { "1a994f32-07fc-4b7d-8d62-6c95d53f78f2", "Chiss" },
                    { "c1057ca8-c24e-44d5-90a4-aa4d24c8f35b", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c492de2e-70f9-49b4-92aa-a10a96b7ba8a", "Tulak Hord" },
                    { "8e86ab49-8b4b-42fb-8124-11a807aabd18", "Darth Malgus" },
                    { "b133f650-1388-4165-8036-80056e2ebe78", "Star Forge" },
                    { "8f4a5164-2e9a-4f06-a90c-f429ca300f7f", "Satele Shan" },
                    { "b0e0f262-a3b0-4ddd-86ec-34546841742e", "The Leviathan" }
                });
        }
    }
}
