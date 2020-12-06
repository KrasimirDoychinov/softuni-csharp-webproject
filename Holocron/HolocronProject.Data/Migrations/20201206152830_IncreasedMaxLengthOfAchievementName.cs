using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class IncreasedMaxLengthOfAchievementName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "12549902-ff74-4501-bf1d-897c66257ef4");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8dd26e79-2886-4d52-9863-6c09bf1a0d54");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "96dd8b89-79e6-40c9-abd5-e5fa41c5414e");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ab1880e6-c953-40cd-91cd-4c66c4b8629e");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d22d5520-126e-4443-b079-47ed5e82baae");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0062e8af-f9df-4c86-9dd3-92ee6e8f41aa");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0368b3c5-70d1-4d76-b6c2-10a8f2a0b072");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2535b1b3-9791-4b87-9889-7b0fd1ef94c5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "264e8615-8532-406d-9a9c-3efcc715d808");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3bbbf5ad-964a-482b-a402-c4ce0b358865");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6c079ed3-1a40-41c3-855f-0a9d4c5c2806");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "72a9483d-d677-48ae-ad14-22f67aa7beb2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8746b60b-fbbc-4886-94a5-0f00b454ab60");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ad7ee563-4225-4008-abaa-6d8d1c7c4cbd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "adb1407a-d7dd-48f9-888e-ecf6df788d90");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b11f98c9-a2e4-4d83-989c-b5eeae01e787");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c7478d2e-6142-4ce6-802b-188f25874ae1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "cefbfe4e-88f3-490a-8cca-f15f08c095f0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "de16ded5-ec08-4a6d-a2f9-ab01804f7f1d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "deb8ad8d-81df-4cc0-98d4-538a23127b71");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f3549715-ff71-4a7f-b01c-07cfc19138fb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "059192e6-bb36-4388-ab1d-0800d2760a5e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0632d59b-fd50-4a6f-9ab1-a6297d4aaf08");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "266c8799-bdba-4aa5-80e2-afe7af620329");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4b4c0f73-bf82-4aea-9a5a-2eb75040fd0b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5805da8c-171c-454d-845c-96199359c1c0");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6dcf22db-d849-4d64-ba9b-e3f339b09aa1");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "abee6449-8523-4705-8f95-47cd8f4dd057");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b78e3e52-0367-45b5-934b-bdeea4a05bd0");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "baf178aa-31f2-4542-92c1-dfab44b76ab1");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c3e13d8a-8dca-4bca-9117-1121b594ff73");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "dcc4d691-abd1-4c61-9484-b165f99a0f14");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f68287d2-8df4-446a-8795-0973d6047966");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "12b3f7d9-52c8-44f1-a6ee-4db3028ea417");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1b14db4b-e999-4603-8746-bb5103ef952b");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "60a28176-eae0-42fd-bdf2-a1ecf41f4e79");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "78603d2d-72fe-435b-8c3d-0f2cb1584138");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "f68e58f4-a0b0-4af1-94a9-6909f27b07d5");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Achievements",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Achievements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "ab1880e6-c953-40cd-91cd-4c66c4b8629e", new DateTime(2020, 12, 6, 14, 28, 33, 371, DateTimeKind.Utc).AddTicks(2077), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/06/2020 04:28 PM", null, "PVP" },
                    { "d22d5520-126e-4443-b079-47ed5e82baae", new DateTime(2020, 12, 6, 14, 28, 33, 374, DateTimeKind.Utc).AddTicks(1122), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/06/2020 04:28 PM", null, "PVE" },
                    { "8dd26e79-2886-4d52-9863-6c09bf1a0d54", new DateTime(2020, 12, 6, 14, 28, 33, 374, DateTimeKind.Utc).AddTicks(1214), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/06/2020 04:28 PM", null, "RP" },
                    { "96dd8b89-79e6-40c9-abd5-e5fa41c5414e", new DateTime(2020, 12, 6, 14, 28, 33, 374, DateTimeKind.Utc).AddTicks(1227), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/06/2020 04:28 PM", null, "Other" },
                    { "12549902-ff74-4501-bf1d-897c66257ef4", new DateTime(2020, 12, 6, 14, 28, 33, 374, DateTimeKind.Utc).AddTicks(1237), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/06/2020 04:28 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "6c079ed3-1a40-41c3-855f-0a9d4c5c2806", 1, "Guardian" },
                    { "cefbfe4e-88f3-490a-8cca-f15f08c095f0", 1, "Sentinel" },
                    { "b11f98c9-a2e4-4d83-989c-b5eeae01e787", 1, "Sage" },
                    { "deb8ad8d-81df-4cc0-98d4-538a23127b71", 1, "Commando" },
                    { "0368b3c5-70d1-4d76-b6c2-10a8f2a0b072", 1, "Vanguard" },
                    { "72a9483d-d677-48ae-ad14-22f67aa7beb2", 1, "Scoundrel" },
                    { "ad7ee563-4225-4008-abaa-6d8d1c7c4cbd", 1, "Gunslinger" },
                    { "c7478d2e-6142-4ce6-802b-188f25874ae1", 1, "Shadow" },
                    { "3bbbf5ad-964a-482b-a402-c4ce0b358865", 2, "Powertech" },
                    { "f3549715-ff71-4a7f-b01c-07cfc19138fb", 2, "Operative" },
                    { "de16ded5-ec08-4a6d-a2f9-ab01804f7f1d", 2, "Sniper" },
                    { "8746b60b-fbbc-4886-94a5-0f00b454ab60", 2, "Assassin" },
                    { "264e8615-8532-406d-9a9c-3efcc715d808", 2, "Sorcerer" },
                    { "adb1407a-d7dd-48f9-888e-ecf6df788d90", 2, "Marauder" },
                    { "0062e8af-f9df-4c86-9dd3-92ee6e8f41aa", 2, "Juggernaut" },
                    { "2535b1b3-9791-4b87-9889-7b0fd1ef94c5", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0632d59b-fd50-4a6f-9ab1-a6297d4aaf08", "Nautolan" },
                    { "f68287d2-8df4-446a-8795-0973d6047966", "Togruta" },
                    { "b78e3e52-0367-45b5-934b-bdeea4a05bd0", "Cathar" },
                    { "baf178aa-31f2-4542-92c1-dfab44b76ab1", "Zabrak" },
                    { "266c8799-bdba-4aa5-80e2-afe7af620329", "Twi'lek" },
                    { "c3e13d8a-8dca-4bca-9117-1121b594ff73", "Sith Pureblood" },
                    { "dcc4d691-abd1-4c61-9484-b165f99a0f14", "Mirialan" },
                    { "4b4c0f73-bf82-4aea-9a5a-2eb75040fd0b", "Miraluka" },
                    { "059192e6-bb36-4388-ab1d-0800d2760a5e", "Human" },
                    { "5805da8c-171c-454d-845c-96199359c1c0", "Cyborg" },
                    { "6dcf22db-d849-4d64-ba9b-e3f339b09aa1", "Chiss" },
                    { "abee6449-8523-4705-8f95-47cd8f4dd057", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1b14db4b-e999-4603-8746-bb5103ef952b", "Tulak Hord" },
                    { "78603d2d-72fe-435b-8c3d-0f2cb1584138", "Darth Malgus" },
                    { "12b3f7d9-52c8-44f1-a6ee-4db3028ea417", "Star Forge" },
                    { "f68e58f4-a0b0-4af1-94a9-6909f27b07d5", "Satele Shan" },
                    { "60a28176-eae0-42fd-bdf2-a1ecf41f4e79", "The Leviathan" }
                });
        }
    }
}
