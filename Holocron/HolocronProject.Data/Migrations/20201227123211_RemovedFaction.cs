using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class RemovedFaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "73ecce08-c9c0-4591-913c-c9865684f56c");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "985361b6-9ba8-4e43-8e01-c02c1cf29804");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "c3f413d6-ee63-4ccc-abc9-62d068787f21");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "e0c3540e-de27-429b-9acf-f49de8e74a38");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "e31edf4d-a2a5-4646-8127-fb8a6724bdc6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "06b3950c-a424-4f09-a983-821671f078f7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "09c22cd8-525c-4778-b82e-fed3276fdfd7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0daefe56-b0b6-4cce-a2c2-933f57e88965");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1255172a-6102-41a4-9166-81d9b6a64ae5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "145c8c42-fa16-447f-8d01-6e86cae5fe5a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "26d564c7-6743-4afb-835d-620c64d1f29d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "433b275f-9db6-4575-9ddc-c896cb99b245");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "800a79c5-7267-49c2-831f-b93fab9e07f8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "84641c3c-bf53-48a1-b16a-7cdfc137078d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "85c42745-4bd0-42f6-bca5-161aa13ad430");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b6073a8a-b0e1-437c-b667-ba51c25f2729");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c1a255b1-358d-4546-b742-577daef86f17");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c9276ddf-45df-473e-b501-fe12bbd902f5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d0298e5d-36f3-40a5-bd15-1f0dfd9cfd58");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e30660bc-87fb-4c3c-b02c-fc2a792c4deb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e55b759d-d197-49e2-ac93-b2e51ed17653");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "07339d8a-8692-470f-a04d-8a62593489b3");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "095218ce-b288-459e-9e96-96dfab03cb31");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1144458a-f57b-4afc-b112-c0a0b12cecd2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "789e642d-91e4-4958-afbc-4c235af57c9c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7b792843-c033-4eec-8c28-381d0f6e0943");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "add7ab0f-b035-47a5-a19a-cb363dcb8676");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b6db4fcd-72da-4539-9f90-f860168436d7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bc48c3ae-0e6c-42b4-ab92-402446b81250");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bd200213-9a4c-4701-b794-b013f32d4a99");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c1e273ac-d8c9-440e-a50e-157b748a6706");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c913a16f-4c11-4c49-9a82-e23b4eb4b891");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d1fb902b-4c2e-4cae-a29d-4fd195ad2059");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "37b1d766-b64c-4310-b86f-06fdea5dacb0");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "43df1b5d-fda1-4dcc-8d0f-0aa8a21e0807");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "797ea3e9-2f80-4d76-a667-cc5f979736da");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "975411c6-ccda-41ff-8c9c-09690703a317");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c2e8363f-01ac-43e2-8cb0-d174538f26dd");

            migrationBuilder.DropColumn(
                name: "Faction",
                table: "Classes");

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "b1f5cd8a-b728-495e-9b67-2cb2f6ea0b19", new DateTime(2020, 12, 27, 12, 32, 11, 398, DateTimeKind.Utc).AddTicks(1531), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "d19139f4-4123-46a5-aee6-3f7ce341220d", new DateTime(2020, 12, 27, 12, 32, 11, 398, DateTimeKind.Utc).AddTicks(2492), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "a99536fd-a173-43f4-b369-cc9ceee0d22a", new DateTime(2020, 12, 27, 12, 32, 11, 398, DateTimeKind.Utc).AddTicks(2524), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "a065c6b9-651d-43e0-a84b-49b5ce3439e0", new DateTime(2020, 12, 27, 12, 32, 11, 398, DateTimeKind.Utc).AddTicks(2528), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "e6dcde41-6046-4e46-8c7f-b77300ed769e", new DateTime(2020, 12, 27, 12, 32, 11, 398, DateTimeKind.Utc).AddTicks(2530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "859b4a0a-4d82-4f3e-b984-7e90b3a939a2", "Guardian" },
                    { "14fe1bd0-740f-4def-97ea-99e4c2d0f3d2", "Sentinel" },
                    { "30e477f6-f94f-41e7-b92c-233dbb7c9856", "Sage" },
                    { "b750bbf9-6dce-4d8a-8578-1be5cba08063", "Commando" },
                    { "a01b804a-5e71-4ecb-8286-9754661ebc00", "Vanguard" },
                    { "ebe030d6-fd80-4b0d-bda4-ba74937334de", "Scoundrel" },
                    { "cce7c9e0-e2ec-4289-bb9a-622551033934", "Gunslinger" },
                    { "f3f62772-dbfb-492e-9666-69d7ab6b3e8b", "Shadow" },
                    { "14077f4c-82b1-4aa2-8489-0c723228e333", "Powertech" },
                    { "95b31332-15af-466a-9b4e-43a6cf03c39c", "Operative" },
                    { "e5c8673f-94c2-471a-944f-e7e95fd35666", "Sniper" },
                    { "327bcfa2-8639-4da8-97c2-67dc5f66d980", "Assassin" },
                    { "49bf0baf-e716-45ca-8e50-55eaf9459fb1", "Sorcerer" },
                    { "aa67ecbf-7574-45df-bee0-4a04c4bdb55f", "Marauder" },
                    { "66bf6d38-be11-4ed4-9ff6-de1b3fdf3129", "Juggernaut" },
                    { "67c2001f-ece1-41f1-a907-f9d4090a5174", "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "e8dc9f1a-c386-4146-826e-be9ba6d603e7", "Nautolan" },
                    { "e1ef05db-649d-48d7-8655-f7bf12ce1580", "Togruta" },
                    { "4466ea93-ee6e-46f4-9774-20194a35809c", "Cathar" },
                    { "9a55f216-ff80-4934-8de7-ea28ba2937db", "Zabrak" },
                    { "a1483bc7-3187-42d3-9fce-8261b4f067c4", "Twi'lek" },
                    { "188594d8-e819-4b2c-a28c-0b23e6917917", "Sith Pureblood" },
                    { "b2d758d7-9983-489e-bbcf-1c837956af89", "Mirialan" },
                    { "6407dc45-3247-41da-a390-172dd1455849", "Miraluka" },
                    { "e1b7bc8c-6aac-4218-b66f-da3120264539", "Human" },
                    { "6915eeab-4990-4926-b96b-4f72f3b29c3b", "Cyborg" },
                    { "8c92af34-1cd9-4f1a-960d-a58a04c7fb62", "Chiss" },
                    { "524fbed2-dc3b-40c7-ad2e-e7d3c9a1bb76", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "a0db0cd4-35b8-4e6d-a234-a9724e522b92", "Tulak Hord" },
                    { "b2ca777c-6097-4bc1-a5d2-367565906abd", "Darth Malgus" },
                    { "a0e6ec9e-cdd0-4afe-b668-e37d2aebffa2", "Star Forge" },
                    { "8ec96954-dbe4-40fb-ab0d-e8ee8f03b6c4", "Satele Shan" },
                    { "60d47e40-9b91-47ee-8a2a-fcf5a2aa988c", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a065c6b9-651d-43e0-a84b-49b5ce3439e0");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a99536fd-a173-43f4-b369-cc9ceee0d22a");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b1f5cd8a-b728-495e-9b67-2cb2f6ea0b19");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d19139f4-4123-46a5-aee6-3f7ce341220d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "e6dcde41-6046-4e46-8c7f-b77300ed769e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "14077f4c-82b1-4aa2-8489-0c723228e333");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "14fe1bd0-740f-4def-97ea-99e4c2d0f3d2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "30e477f6-f94f-41e7-b92c-233dbb7c9856");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "327bcfa2-8639-4da8-97c2-67dc5f66d980");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "49bf0baf-e716-45ca-8e50-55eaf9459fb1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "66bf6d38-be11-4ed4-9ff6-de1b3fdf3129");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "67c2001f-ece1-41f1-a907-f9d4090a5174");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "859b4a0a-4d82-4f3e-b984-7e90b3a939a2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "95b31332-15af-466a-9b4e-43a6cf03c39c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a01b804a-5e71-4ecb-8286-9754661ebc00");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "aa67ecbf-7574-45df-bee0-4a04c4bdb55f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b750bbf9-6dce-4d8a-8578-1be5cba08063");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "cce7c9e0-e2ec-4289-bb9a-622551033934");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e5c8673f-94c2-471a-944f-e7e95fd35666");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ebe030d6-fd80-4b0d-bda4-ba74937334de");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f3f62772-dbfb-492e-9666-69d7ab6b3e8b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "188594d8-e819-4b2c-a28c-0b23e6917917");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4466ea93-ee6e-46f4-9774-20194a35809c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "524fbed2-dc3b-40c7-ad2e-e7d3c9a1bb76");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6407dc45-3247-41da-a390-172dd1455849");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6915eeab-4990-4926-b96b-4f72f3b29c3b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8c92af34-1cd9-4f1a-960d-a58a04c7fb62");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9a55f216-ff80-4934-8de7-ea28ba2937db");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a1483bc7-3187-42d3-9fce-8261b4f067c4");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b2d758d7-9983-489e-bbcf-1c837956af89");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e1b7bc8c-6aac-4218-b66f-da3120264539");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e1ef05db-649d-48d7-8655-f7bf12ce1580");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e8dc9f1a-c386-4146-826e-be9ba6d603e7");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "60d47e40-9b91-47ee-8a2a-fcf5a2aa988c");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "8ec96954-dbe4-40fb-ab0d-e8ee8f03b6c4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "a0db0cd4-35b8-4e6d-a234-a9724e522b92");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "a0e6ec9e-cdd0-4afe-b668-e37d2aebffa2");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b2ca777c-6097-4bc1-a5d2-367565906abd");

            migrationBuilder.AddColumn<int>(
                name: "Faction",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "e31edf4d-a2a5-4646-8127-fb8a6724bdc6", new DateTime(2020, 12, 25, 14, 29, 9, 714, DateTimeKind.Utc).AddTicks(7700), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "e0c3540e-de27-429b-9acf-f49de8e74a38", new DateTime(2020, 12, 25, 14, 29, 9, 714, DateTimeKind.Utc).AddTicks(8660), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "985361b6-9ba8-4e43-8e01-c02c1cf29804", new DateTime(2020, 12, 25, 14, 29, 9, 714, DateTimeKind.Utc).AddTicks(8692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "c3f413d6-ee63-4ccc-abc9-62d068787f21", new DateTime(2020, 12, 25, 14, 29, 9, 714, DateTimeKind.Utc).AddTicks(8695), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "73ecce08-c9c0-4591-913c-c9865684f56c", new DateTime(2020, 12, 25, 14, 29, 9, 714, DateTimeKind.Utc).AddTicks(8703), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "84641c3c-bf53-48a1-b16a-7cdfc137078d", 1, "Guardian" },
                    { "0daefe56-b0b6-4cce-a2c2-933f57e88965", 1, "Sentinel" },
                    { "09c22cd8-525c-4778-b82e-fed3276fdfd7", 1, "Sage" },
                    { "e30660bc-87fb-4c3c-b02c-fc2a792c4deb", 1, "Commando" },
                    { "85c42745-4bd0-42f6-bca5-161aa13ad430", 1, "Vanguard" },
                    { "800a79c5-7267-49c2-831f-b93fab9e07f8", 1, "Scoundrel" },
                    { "26d564c7-6743-4afb-835d-620c64d1f29d", 1, "Gunslinger" },
                    { "433b275f-9db6-4575-9ddc-c896cb99b245", 1, "Shadow" },
                    { "c9276ddf-45df-473e-b501-fe12bbd902f5", 2, "Powertech" },
                    { "b6073a8a-b0e1-437c-b667-ba51c25f2729", 2, "Operative" },
                    { "e55b759d-d197-49e2-ac93-b2e51ed17653", 2, "Sniper" },
                    { "145c8c42-fa16-447f-8d01-6e86cae5fe5a", 2, "Assassin" },
                    { "c1a255b1-358d-4546-b742-577daef86f17", 2, "Sorcerer" },
                    { "1255172a-6102-41a4-9166-81d9b6a64ae5", 2, "Marauder" },
                    { "06b3950c-a424-4f09-a983-821671f078f7", 2, "Juggernaut" },
                    { "d0298e5d-36f3-40a5-bd15-1f0dfd9cfd58", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c1e273ac-d8c9-440e-a50e-157b748a6706", "Nautolan" },
                    { "c913a16f-4c11-4c49-9a82-e23b4eb4b891", "Togruta" },
                    { "bd200213-9a4c-4701-b794-b013f32d4a99", "Cathar" },
                    { "7b792843-c033-4eec-8c28-381d0f6e0943", "Zabrak" },
                    { "d1fb902b-4c2e-4cae-a29d-4fd195ad2059", "Twi'lek" },
                    { "bc48c3ae-0e6c-42b4-ab92-402446b81250", "Sith Pureblood" },
                    { "095218ce-b288-459e-9e96-96dfab03cb31", "Mirialan" },
                    { "1144458a-f57b-4afc-b112-c0a0b12cecd2", "Miraluka" },
                    { "b6db4fcd-72da-4539-9f90-f860168436d7", "Human" },
                    { "07339d8a-8692-470f-a04d-8a62593489b3", "Cyborg" },
                    { "789e642d-91e4-4958-afbc-4c235af57c9c", "Chiss" },
                    { "add7ab0f-b035-47a5-a19a-cb363dcb8676", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "975411c6-ccda-41ff-8c9c-09690703a317", "Tulak Hord" },
                    { "37b1d766-b64c-4310-b86f-06fdea5dacb0", "Darth Malgus" },
                    { "c2e8363f-01ac-43e2-8cb0-d174538f26dd", "Star Forge" },
                    { "43df1b5d-fda1-4dcc-8d0f-0aa8a21e0807", "Satele Shan" },
                    { "797ea3e9-2f80-4d76-a667-cc5f979736da", "The Leviathan" }
                });
        }
    }
}
