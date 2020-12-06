using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class FixedTheAchievementModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Characters_CharacterId",
                table: "Achievements");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "09167c68-7cdf-4141-837d-9f6bd097c51e");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "64f05672-d5f1-4b6d-95a5-f51972a93f04");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "678bc661-d2a9-4e46-9331-de851f6bf30d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "9bd461cd-5d6e-47b6-b028-7a6d2992ba3d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a0731313-94a0-40a5-989a-0b96fb74f5f6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "00b4e8ee-b621-4846-9319-66855256f6b8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "02e9e065-8ce7-40a0-a355-3b21197a6134");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0d83d8e6-f3bd-4e71-a735-9bd72b4edfc2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0f7ddb30-bb86-484c-ae04-c73abbebd0cf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "39c02d16-25d3-41a0-b6bb-317c36d11cff");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "522d733a-26c2-4dca-9b78-84b800e26045");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6a6aa58a-64b9-4af6-97e5-ea44a7130982");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8ad7f202-218a-4092-8ad6-8206ef5ca1e2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9c6e43a0-d5c9-440a-b94a-ebc71c907408");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ad6cde2e-fdbc-4ca7-b7fc-8c38f006f2b3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b54f7651-3ba3-4a89-a3ce-ce0c54779a8a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "bf1de329-070a-4fdd-a5b4-5099a5377eba");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c432e063-1acb-4939-ae23-11f1e5b7db4b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "db3d2bab-2cf0-4352-ad77-a343a08431e1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "db550ff8-c726-4742-8ef4-edda3c318228");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e6b33b2e-051c-4d4d-9b77-fa8156669efd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0d069e1f-4a33-4679-8e1d-42afbd8437ae");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1b1ddab1-68fa-4eb4-a13e-c3020007cb38");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1e178939-8e38-416a-a59f-179884bb6d70");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2b7c873a-a993-45ac-a8b7-d04984b3d97c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2d32f234-c9f7-4d3c-ae27-54f39a0d584b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4401a516-8de7-4ab5-9d93-665debc7e6d3");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "455387b1-e3d4-4606-8a33-6fc3b1425a10");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "655cf164-f535-4418-89ab-eccfd3ffd5fe");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "747cc447-4ee1-490a-b607-91a1e571349d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d6b721e3-ae8d-416b-a980-31a3ddc62291");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f68de4a0-f3dd-4c5c-a331-205322ab7767");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f7e00413-9ad5-47bb-ba51-690255feacf0");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "561947dd-d167-44b9-9278-f5932f1fa1a5");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "9954555c-2cf2-4cfb-a7be-1cc1833c21c8");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b35e54c6-1682-4e7d-b442-00cb428355a4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "e9602f3b-5246-4543-8234-6e6243781ce8");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "fd908eb9-de71-478c-b9d6-d3e37fe47b04");

            migrationBuilder.AlterColumn<string>(
                name: "CharacterId",
                table: "Achievements",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Characters_CharacterId",
                table: "Achievements",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Characters_CharacterId",
                table: "Achievements");

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
                name: "CharacterId",
                table: "Achievements",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "09167c68-7cdf-4141-837d-9f6bd097c51e", new DateTime(2020, 12, 4, 18, 30, 25, 114, DateTimeKind.Utc).AddTicks(3053), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/04/2020 08:30 PM", null, "PVP" },
                    { "678bc661-d2a9-4e46-9331-de851f6bf30d", new DateTime(2020, 12, 4, 18, 30, 25, 117, DateTimeKind.Utc).AddTicks(86), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/04/2020 08:30 PM", null, "PVE" },
                    { "64f05672-d5f1-4b6d-95a5-f51972a93f04", new DateTime(2020, 12, 4, 18, 30, 25, 117, DateTimeKind.Utc).AddTicks(168), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/04/2020 08:30 PM", null, "RP" },
                    { "a0731313-94a0-40a5-989a-0b96fb74f5f6", new DateTime(2020, 12, 4, 18, 30, 25, 117, DateTimeKind.Utc).AddTicks(182), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/04/2020 08:30 PM", null, "Other" },
                    { "9bd461cd-5d6e-47b6-b028-7a6d2992ba3d", new DateTime(2020, 12, 4, 18, 30, 25, 117, DateTimeKind.Utc).AddTicks(192), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/04/2020 08:30 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "6a6aa58a-64b9-4af6-97e5-ea44a7130982", 1, "Guardian" },
                    { "0f7ddb30-bb86-484c-ae04-c73abbebd0cf", 1, "Sentinel" },
                    { "522d733a-26c2-4dca-9b78-84b800e26045", 1, "Sage" },
                    { "9c6e43a0-d5c9-440a-b94a-ebc71c907408", 1, "Commando" },
                    { "db3d2bab-2cf0-4352-ad77-a343a08431e1", 1, "Vanguard" },
                    { "02e9e065-8ce7-40a0-a355-3b21197a6134", 1, "Scoundrel" },
                    { "db550ff8-c726-4742-8ef4-edda3c318228", 1, "Gunslinger" },
                    { "8ad7f202-218a-4092-8ad6-8206ef5ca1e2", 1, "Shadow" },
                    { "ad6cde2e-fdbc-4ca7-b7fc-8c38f006f2b3", 2, "Powertech" },
                    { "0d83d8e6-f3bd-4e71-a735-9bd72b4edfc2", 2, "Operative" },
                    { "b54f7651-3ba3-4a89-a3ce-ce0c54779a8a", 2, "Sniper" },
                    { "bf1de329-070a-4fdd-a5b4-5099a5377eba", 2, "Assassin" },
                    { "c432e063-1acb-4939-ae23-11f1e5b7db4b", 2, "Sorcerer" },
                    { "39c02d16-25d3-41a0-b6bb-317c36d11cff", 2, "Marauder" },
                    { "e6b33b2e-051c-4d4d-9b77-fa8156669efd", 2, "Juggernaut" },
                    { "00b4e8ee-b621-4846-9319-66855256f6b8", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4401a516-8de7-4ab5-9d93-665debc7e6d3", "Nautolan" },
                    { "2b7c873a-a993-45ac-a8b7-d04984b3d97c", "Togruta" },
                    { "455387b1-e3d4-4606-8a33-6fc3b1425a10", "Cathar" },
                    { "1b1ddab1-68fa-4eb4-a13e-c3020007cb38", "Zabrak" },
                    { "1e178939-8e38-416a-a59f-179884bb6d70", "Twi'lek" },
                    { "655cf164-f535-4418-89ab-eccfd3ffd5fe", "Sith Pureblood" },
                    { "0d069e1f-4a33-4679-8e1d-42afbd8437ae", "Mirialan" },
                    { "747cc447-4ee1-490a-b607-91a1e571349d", "Miraluka" },
                    { "f68de4a0-f3dd-4c5c-a331-205322ab7767", "Human" },
                    { "d6b721e3-ae8d-416b-a980-31a3ddc62291", "Cyborg" },
                    { "f7e00413-9ad5-47bb-ba51-690255feacf0", "Chiss" },
                    { "2d32f234-c9f7-4d3c-ae27-54f39a0d584b", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "561947dd-d167-44b9-9278-f5932f1fa1a5", "Tulak Hord" },
                    { "e9602f3b-5246-4543-8234-6e6243781ce8", "Darth Malgus" },
                    { "b35e54c6-1682-4e7d-b442-00cb428355a4", "Star Forge" },
                    { "9954555c-2cf2-4cfb-a7be-1cc1833c21c8", "Satele Shan" },
                    { "fd908eb9-de71-478c-b9d6-d3e37fe47b04", "The Leviathan" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Characters_CharacterId",
                table: "Achievements",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
