using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class RenamedDeletedOnAndIsDeletedToBannedOnAndIsBanned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "15b00b1c-6a9e-4ed4-8b57-36dc7789cfd5");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "366d7978-7508-4b7c-8ebb-c4089e98f2c0");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "6c1fa392-584a-483d-b556-98f53686ce42");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "7dab54eb-3127-454a-a061-7738e6e6a794");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8e17737d-b2cb-41aa-9546-e64eb0a3396e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "06b95437-40b1-4023-a278-57d26bf5d845");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "25a3d451-87a9-4fca-8e1f-42afd932ac71");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "35b03190-03b5-44cd-afac-6bc13f0092a3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "407e4253-4b0a-4bec-be4b-b5a9d196dcd9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "65f6b6ee-e0fb-4233-8ca9-0981ad77f0ba");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "724a3253-6ccc-48e0-94e2-133aa41ffcd8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7b0678f9-d7a6-483e-a17b-30194e74e2af");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "995aa575-b0e1-46f0-811e-52b0aa6b0aef");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a574e76d-f0d1-4bec-a00a-759f6abdbbb5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b7c998d8-8239-42a2-b953-64ea79521a0d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "bed4dc7d-c2a4-4f75-ab05-31975cc8a9ed");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c48b331e-448b-466f-8718-50aa3ae3225c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d8886125-f9af-4adc-adbe-edc5a05396eb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e08f68ce-f2a5-431f-a803-bc3e15b8bb90");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e6fc2e6e-0408-4c19-b77d-e5b689fe7a1d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e7f2761c-f42c-4025-a602-86c103d6800c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "03f26e12-31bc-4cd1-89a8-df83f2496bed");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "089c0b84-d0ea-4efa-87bc-c34f6794d415");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "13229c5e-bb30-455d-8fba-5f5ab854773d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1eb19ff9-3f57-4288-9bcc-30fe36ec6c1e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1ed718b1-274e-4d9f-937f-a9571dfcfacf");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3172db37-01e5-4fda-b2aa-32c2dcf3a6e9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "43b3263c-b634-46e9-a720-62fdf5cb2a3d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "75ac9fe3-11bc-4e78-85f3-011184a337fb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7c86d9c7-7f37-41ef-848a-4ccd3c68c1a6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "823882f1-a4b0-45ea-9048-0218e2a375e7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "da0f3a23-7b6a-42f2-98e1-82e6d4ec126a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f1683fc0-8647-4441-8892-3a17cdce31ea");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "49d3f0c3-b2b8-4747-989d-17d4e76d3078");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b3285389-38fc-4219-b0ff-6b92ad02bc20");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c576c8d7-34ea-4050-a592-975b72fcc4e5");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "ccc5328a-8a00-4fb2-ac86-50592ca4e129");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "cd78a688-b4e0-428c-94f1-596da6d369c7");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "BannedOn",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BannedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "366d7978-7508-4b7c-8ebb-c4089e98f2c0", new DateTime(2020, 12, 21, 19, 6, 11, 93, DateTimeKind.Utc).AddTicks(6148), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "15b00b1c-6a9e-4ed4-8b57-36dc7789cfd5", new DateTime(2020, 12, 21, 19, 6, 11, 93, DateTimeKind.Utc).AddTicks(7100), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "6c1fa392-584a-483d-b556-98f53686ce42", new DateTime(2020, 12, 21, 19, 6, 11, 93, DateTimeKind.Utc).AddTicks(7135), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "8e17737d-b2cb-41aa-9546-e64eb0a3396e", new DateTime(2020, 12, 21, 19, 6, 11, 93, DateTimeKind.Utc).AddTicks(7138), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "7dab54eb-3127-454a-a061-7738e6e6a794", new DateTime(2020, 12, 21, 19, 6, 11, 93, DateTimeKind.Utc).AddTicks(7141), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "995aa575-b0e1-46f0-811e-52b0aa6b0aef", 1, "Guardian" },
                    { "7b0678f9-d7a6-483e-a17b-30194e74e2af", 1, "Sentinel" },
                    { "bed4dc7d-c2a4-4f75-ab05-31975cc8a9ed", 1, "Sage" },
                    { "d8886125-f9af-4adc-adbe-edc5a05396eb", 1, "Commando" },
                    { "724a3253-6ccc-48e0-94e2-133aa41ffcd8", 1, "Vanguard" },
                    { "06b95437-40b1-4023-a278-57d26bf5d845", 1, "Scoundrel" },
                    { "e7f2761c-f42c-4025-a602-86c103d6800c", 1, "Gunslinger" },
                    { "25a3d451-87a9-4fca-8e1f-42afd932ac71", 1, "Shadow" },
                    { "35b03190-03b5-44cd-afac-6bc13f0092a3", 2, "Powertech" },
                    { "c48b331e-448b-466f-8718-50aa3ae3225c", 2, "Operative" },
                    { "a574e76d-f0d1-4bec-a00a-759f6abdbbb5", 2, "Sniper" },
                    { "e08f68ce-f2a5-431f-a803-bc3e15b8bb90", 2, "Assassin" },
                    { "e6fc2e6e-0408-4c19-b77d-e5b689fe7a1d", 2, "Sorcerer" },
                    { "407e4253-4b0a-4bec-be4b-b5a9d196dcd9", 2, "Marauder" },
                    { "65f6b6ee-e0fb-4233-8ca9-0981ad77f0ba", 2, "Juggernaut" },
                    { "b7c998d8-8239-42a2-b953-64ea79521a0d", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "03f26e12-31bc-4cd1-89a8-df83f2496bed", "Nautolan" },
                    { "7c86d9c7-7f37-41ef-848a-4ccd3c68c1a6", "Togruta" },
                    { "75ac9fe3-11bc-4e78-85f3-011184a337fb", "Cathar" },
                    { "f1683fc0-8647-4441-8892-3a17cdce31ea", "Zabrak" },
                    { "823882f1-a4b0-45ea-9048-0218e2a375e7", "Twi'lek" },
                    { "1eb19ff9-3f57-4288-9bcc-30fe36ec6c1e", "Sith Pureblood" },
                    { "089c0b84-d0ea-4efa-87bc-c34f6794d415", "Mirialan" },
                    { "3172db37-01e5-4fda-b2aa-32c2dcf3a6e9", "Miraluka" },
                    { "1ed718b1-274e-4d9f-937f-a9571dfcfacf", "Human" },
                    { "43b3263c-b634-46e9-a720-62fdf5cb2a3d", "Cyborg" },
                    { "da0f3a23-7b6a-42f2-98e1-82e6d4ec126a", "Chiss" },
                    { "13229c5e-bb30-455d-8fba-5f5ab854773d", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c576c8d7-34ea-4050-a592-975b72fcc4e5", "Tulak Hord" },
                    { "49d3f0c3-b2b8-4747-989d-17d4e76d3078", "Darth Malgus" },
                    { "b3285389-38fc-4219-b0ff-6b92ad02bc20", "Star Forge" },
                    { "cd78a688-b4e0-428c-94f1-596da6d369c7", "Satele Shan" },
                    { "ccc5328a-8a00-4fb2-ac86-50592ca4e129", "The Leviathan" }
                });
        }
    }
}
