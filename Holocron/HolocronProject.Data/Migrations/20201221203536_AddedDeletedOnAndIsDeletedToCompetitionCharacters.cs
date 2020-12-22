using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddedDeletedOnAndIsDeletedToCompetitionCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "2cbb8212-dd51-4075-a3ea-5d176385ee74");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "3dcc678b-5ccb-4022-97fd-29fdaa0acd3c");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "74963ce9-adb1-45df-94c8-242e1103b861");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "82503854-0663-40a0-9db6-bfa5b69fdf76");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f5bc9c07-565a-4632-9a2a-2efbcbf48a33");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "034d7010-fb25-4db8-a021-7c3e7d423130");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "248b5b81-f4d1-4b46-8409-e652393c4900");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "25afa204-83e6-4e51-b6af-2c7a4ee0c0c9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2707a95d-e661-4a9c-bcde-c8a0c00d9c51");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2bf01faf-3a77-4879-a534-a53917324612");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3ad63a64-0ef2-439c-9de9-37abe3eff7e8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6435963f-8080-4394-bba8-103654564c29");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "73405003-fabb-4d12-b92d-6b777aad449d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8a3f0512-1613-4524-8071-303a251c910a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a7ab6449-9960-47a1-8c12-0655551d573f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "bef47115-605c-4e5f-ba50-2529fe094371");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c488442d-749d-4fcf-9aa6-2a0c47105df4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "dcab30db-80f0-400d-858f-610ded1ce96c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e310d70b-c0dd-4e99-8c49-5ea51265f32e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "eacbf460-d948-47c4-a191-60a04bdcff41");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ef02f334-7477-4292-a72f-6804ca227e38");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0d8df660-5bf7-483c-bc44-950b795b595f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3086d2ba-59a7-431c-ac84-f7bc4edc5509");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "45a2b836-f01a-4175-8d6c-be15f8f4e878");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5af61b4a-c009-4821-b3b9-61a87fde9c30");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5f0e3b99-0849-40ca-9f16-d9eed3e4fc07");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6a923973-88b9-4264-8c7b-875d2d5cae31");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9257a6d6-9ec4-4d62-b398-e7d9270a8025");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9d1d5cc7-f219-457f-971a-f7592d1de3b7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9e49e02c-1f4a-46de-81b2-6f6f7b8d03bc");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "cfbf5a5a-de23-4ae3-8d90-3838d347ab36");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "dfaf3442-bac6-4ad4-a400-b93671651937");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f6ff4adc-3c90-4c13-a3e2-afc255954079");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "246fd9ad-efa2-4a97-9048-b84c9ff44fc1");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "2537ae3d-1fcb-43e2-b59d-62507c980fb0");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "398ba4e7-561b-470b-aff2-83354b5ba368");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "7a747106-a0df-4dc8-98bb-804e802e43f8");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "979874d2-b414-46bb-ad9f-176223dab8f9");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "CompetitionsCharacters",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "CompetitionsCharacters",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CompetitionsCharacters",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "CompetitionAccounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "CompetitionAccounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CompetitionAccounts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "8d87f83a-10a3-460c-adf6-d6ecb206a74a", new DateTime(2020, 12, 21, 20, 35, 36, 10, DateTimeKind.Utc).AddTicks(5441), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "4aa5b8e4-0cef-467e-8b77-68d96bce8867", new DateTime(2020, 12, 21, 20, 35, 36, 10, DateTimeKind.Utc).AddTicks(6398), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "edbb24f8-1960-4cff-9b46-d20fec7767f0", new DateTime(2020, 12, 21, 20, 35, 36, 10, DateTimeKind.Utc).AddTicks(6431), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "2cc0aa94-d1f0-40c8-b10a-ee3b2d96112a", new DateTime(2020, 12, 21, 20, 35, 36, 10, DateTimeKind.Utc).AddTicks(6435), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "2732201b-f04c-44e4-828f-906dec5bd489", new DateTime(2020, 12, 21, 20, 35, 36, 10, DateTimeKind.Utc).AddTicks(6438), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "773e99b1-2342-49d0-8ef7-9bc83eb1fdb0", 1, "Guardian" },
                    { "70c79b25-dd43-4ed6-92da-978c5c1e6a83", 1, "Sentinel" },
                    { "cab1d360-5d85-4a0b-81b9-9382b4c563a5", 1, "Sage" },
                    { "1a06f3ac-0ed5-4f0f-b901-551443f0b32a", 1, "Commando" },
                    { "e7554da4-945b-4dc1-b1a8-881ac4cc3369", 1, "Vanguard" },
                    { "8b5650ab-cfd2-46c2-9d3b-6870bb92995e", 1, "Scoundrel" },
                    { "7b010d6e-5c5b-4e41-9cc6-402158d6b0ca", 1, "Gunslinger" },
                    { "9209fe13-4576-4f92-9051-cf49fa9ff456", 1, "Shadow" },
                    { "3864d4d8-a3c8-423b-b17c-c8683d8e7d3d", 2, "Powertech" },
                    { "81d23bb6-8a57-4f53-8b27-18c4fcc6e5ff", 2, "Operative" },
                    { "c231513b-bcc7-42e0-bcd9-e55e302e33da", 2, "Sniper" },
                    { "7cf2831a-f0a5-4e29-9789-59bc0e675394", 2, "Assassin" },
                    { "1e9f561c-9443-4ddf-833c-82c066f21143", 2, "Sorcerer" },
                    { "f1781ad4-427a-4519-99ef-a1a46428fcaa", 2, "Marauder" },
                    { "8a927bef-c032-473d-9ae2-3a0f4f60b26a", 2, "Juggernaut" },
                    { "3abdd356-5305-4856-a51b-3769e062f581", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2062f3dc-7113-429e-9651-3a8c9428e2e3", "Nautolan" },
                    { "0ee02430-c323-4e21-a848-6175eebf50d3", "Togruta" },
                    { "b6f0c00e-bd00-4330-8089-730c744cb43e", "Cathar" },
                    { "b0eeedf7-909c-47ef-b325-06cb2abb120b", "Zabrak" },
                    { "fd1b2902-9a80-4ea2-a14c-b717574b35aa", "Twi'lek" },
                    { "5c3d2e7b-c71d-49fa-8291-2ffe811d373b", "Sith Pureblood" },
                    { "ff174841-14f5-4aa0-b374-591fb987473e", "Mirialan" },
                    { "616cd03a-d774-4703-a7a9-bce49854bbd2", "Miraluka" },
                    { "e051d939-e104-403c-b394-a9d849437b13", "Human" },
                    { "cfc59985-61b5-47d2-9d51-787b905daf42", "Cyborg" },
                    { "bef40ca3-fdb4-4628-9748-9ca86c2f6eb6", "Chiss" },
                    { "a2c31b55-47a4-4309-83ea-01d1d28f5464", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "420f8380-cbc2-448f-b110-8476a7eeadea", "Tulak Hord" },
                    { "e0966aba-376a-4f5e-9c2f-1c72cd399771", "Darth Malgus" },
                    { "40b48d8d-8e3b-41a8-b59c-62890cfa7e13", "Star Forge" },
                    { "2c3c2433-12de-44e7-b130-fdcf72bf827e", "Satele Shan" },
                    { "5f5141b6-ee32-44e3-b80c-595df99e08d7", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "2732201b-f04c-44e4-828f-906dec5bd489");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "2cc0aa94-d1f0-40c8-b10a-ee3b2d96112a");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "4aa5b8e4-0cef-467e-8b77-68d96bce8867");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8d87f83a-10a3-460c-adf6-d6ecb206a74a");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "edbb24f8-1960-4cff-9b46-d20fec7767f0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1a06f3ac-0ed5-4f0f-b901-551443f0b32a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1e9f561c-9443-4ddf-833c-82c066f21143");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3864d4d8-a3c8-423b-b17c-c8683d8e7d3d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3abdd356-5305-4856-a51b-3769e062f581");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "70c79b25-dd43-4ed6-92da-978c5c1e6a83");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "773e99b1-2342-49d0-8ef7-9bc83eb1fdb0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7b010d6e-5c5b-4e41-9cc6-402158d6b0ca");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7cf2831a-f0a5-4e29-9789-59bc0e675394");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "81d23bb6-8a57-4f53-8b27-18c4fcc6e5ff");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8a927bef-c032-473d-9ae2-3a0f4f60b26a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8b5650ab-cfd2-46c2-9d3b-6870bb92995e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9209fe13-4576-4f92-9051-cf49fa9ff456");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c231513b-bcc7-42e0-bcd9-e55e302e33da");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "cab1d360-5d85-4a0b-81b9-9382b4c563a5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e7554da4-945b-4dc1-b1a8-881ac4cc3369");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f1781ad4-427a-4519-99ef-a1a46428fcaa");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0ee02430-c323-4e21-a848-6175eebf50d3");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2062f3dc-7113-429e-9651-3a8c9428e2e3");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5c3d2e7b-c71d-49fa-8291-2ffe811d373b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "616cd03a-d774-4703-a7a9-bce49854bbd2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a2c31b55-47a4-4309-83ea-01d1d28f5464");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b0eeedf7-909c-47ef-b325-06cb2abb120b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b6f0c00e-bd00-4330-8089-730c744cb43e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bef40ca3-fdb4-4628-9748-9ca86c2f6eb6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "cfc59985-61b5-47d2-9d51-787b905daf42");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e051d939-e104-403c-b394-a9d849437b13");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "fd1b2902-9a80-4ea2-a14c-b717574b35aa");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ff174841-14f5-4aa0-b374-591fb987473e");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "2c3c2433-12de-44e7-b130-fdcf72bf827e");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "40b48d8d-8e3b-41a8-b59c-62890cfa7e13");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "420f8380-cbc2-448f-b110-8476a7eeadea");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "5f5141b6-ee32-44e3-b80c-595df99e08d7");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "e0966aba-376a-4f5e-9c2f-1c72cd399771");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CompetitionsCharacters");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CompetitionsCharacters");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CompetitionsCharacters");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CompetitionAccounts");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CompetitionAccounts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CompetitionAccounts");

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "2cbb8212-dd51-4075-a3ea-5d176385ee74", new DateTime(2020, 12, 21, 19, 50, 45, 743, DateTimeKind.Utc).AddTicks(2029), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "3dcc678b-5ccb-4022-97fd-29fdaa0acd3c", new DateTime(2020, 12, 21, 19, 50, 45, 743, DateTimeKind.Utc).AddTicks(2984), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "f5bc9c07-565a-4632-9a2a-2efbcbf48a33", new DateTime(2020, 12, 21, 19, 50, 45, 743, DateTimeKind.Utc).AddTicks(3022), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "74963ce9-adb1-45df-94c8-242e1103b861", new DateTime(2020, 12, 21, 19, 50, 45, 743, DateTimeKind.Utc).AddTicks(3025), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "82503854-0663-40a0-9db6-bfa5b69fdf76", new DateTime(2020, 12, 21, 19, 50, 45, 743, DateTimeKind.Utc).AddTicks(3029), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "e310d70b-c0dd-4e99-8c49-5ea51265f32e", 1, "Guardian" },
                    { "ef02f334-7477-4292-a72f-6804ca227e38", 1, "Sentinel" },
                    { "73405003-fabb-4d12-b92d-6b777aad449d", 1, "Sage" },
                    { "3ad63a64-0ef2-439c-9de9-37abe3eff7e8", 1, "Commando" },
                    { "2bf01faf-3a77-4879-a534-a53917324612", 1, "Vanguard" },
                    { "c488442d-749d-4fcf-9aa6-2a0c47105df4", 1, "Scoundrel" },
                    { "bef47115-605c-4e5f-ba50-2529fe094371", 1, "Gunslinger" },
                    { "a7ab6449-9960-47a1-8c12-0655551d573f", 1, "Shadow" },
                    { "8a3f0512-1613-4524-8071-303a251c910a", 2, "Powertech" },
                    { "6435963f-8080-4394-bba8-103654564c29", 2, "Operative" },
                    { "dcab30db-80f0-400d-858f-610ded1ce96c", 2, "Sniper" },
                    { "2707a95d-e661-4a9c-bcde-c8a0c00d9c51", 2, "Assassin" },
                    { "034d7010-fb25-4db8-a021-7c3e7d423130", 2, "Sorcerer" },
                    { "248b5b81-f4d1-4b46-8409-e652393c4900", 2, "Marauder" },
                    { "25afa204-83e6-4e51-b6af-2c7a4ee0c0c9", 2, "Juggernaut" },
                    { "eacbf460-d948-47c4-a191-60a04bdcff41", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "3086d2ba-59a7-431c-ac84-f7bc4edc5509", "Nautolan" },
                    { "6a923973-88b9-4264-8c7b-875d2d5cae31", "Togruta" },
                    { "dfaf3442-bac6-4ad4-a400-b93671651937", "Cathar" },
                    { "cfbf5a5a-de23-4ae3-8d90-3838d347ab36", "Zabrak" },
                    { "9d1d5cc7-f219-457f-971a-f7592d1de3b7", "Twi'lek" },
                    { "0d8df660-5bf7-483c-bc44-950b795b595f", "Sith Pureblood" },
                    { "5af61b4a-c009-4821-b3b9-61a87fde9c30", "Mirialan" },
                    { "9e49e02c-1f4a-46de-81b2-6f6f7b8d03bc", "Miraluka" },
                    { "f6ff4adc-3c90-4c13-a3e2-afc255954079", "Human" },
                    { "5f0e3b99-0849-40ca-9f16-d9eed3e4fc07", "Cyborg" },
                    { "9257a6d6-9ec4-4d62-b398-e7d9270a8025", "Chiss" },
                    { "45a2b836-f01a-4175-8d6c-be15f8f4e878", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2537ae3d-1fcb-43e2-b59d-62507c980fb0", "Tulak Hord" },
                    { "398ba4e7-561b-470b-aff2-83354b5ba368", "Darth Malgus" },
                    { "979874d2-b414-46bb-ad9f-176223dab8f9", "Star Forge" },
                    { "7a747106-a0df-4dc8-98bb-804e802e43f8", "Satele Shan" },
                    { "246fd9ad-efa2-4a97-9048-b84c9ff44fc1", "The Leviathan" }
                });
        }
    }
}
