using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddedDescriptionToThreads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "1a32c4c5-40f4-4d6c-b784-a9d45f1a0f20");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "24d7d960-58b2-43d2-bc20-7fad6c35ced8");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "3565b29d-cf1a-43ad-a3b5-132ab8b5fbb5");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "719d09cb-4859-454b-9099-cab85d66651d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "7bf9c37f-b85d-4db2-9329-b75011a43b64");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "032f1541-a2cf-4a02-9ce5-2670ecd11d51");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3a17297b-21e2-4d12-becf-d91b959cdf1c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "61a77c2f-c7f8-4d87-9e15-4d9d26a1e8cf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6bb06be8-dbc0-401f-9813-337cce552eed");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6eabb4f4-960e-4c59-bfb7-677d6cd08287");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6f1dc2c8-f6b7-4d62-8e83-396724f43cf6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "71b3d863-e5fe-4dfb-82f5-2079ef5e51bc");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7506dc33-e27f-41c7-b161-d50d2346239f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7da05a93-5458-4ac9-a14b-925e604f2a48");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8c32c965-6ea1-41a7-ac66-b8d7c0a440ac");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b8d2c672-d4c9-403b-8986-d14d2fb9ae91");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ded8d615-21ba-4fe4-a0be-e2cd59500f39");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ee93bba9-3fcd-48f8-8bef-33cf32967f12");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ee9c8830-eaf4-406f-a56b-5ea78a7f7791");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ef4fc7b8-f20e-4346-a18d-1750ae6dc79a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f3f04f7c-e827-4be7-9bf8-25a1523ebf84");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "11b0fe63-177a-48db-874a-c7df8cde58ed");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "37756e15-962a-416a-b99c-b1840c11799f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "42b7027b-4d61-4021-86ed-ce13d0f46aa6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5490c65c-8588-4d08-88ed-707594eed42a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "55aef3e6-2b33-4138-ae83-c0ce9503036b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "56ee7c0b-a496-4372-b969-2aa358520ee9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "66d623fe-15ac-4c93-92c7-6c7048a01c07");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "71dbff3a-e69e-4de6-8f6c-2cc2692df436");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7e7da782-c017-4dea-9220-5233dc8c5967");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bb6bb564-1025-4125-b201-86b7da7bd625");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f25428d0-6c29-4d35-8551-375e1a192303");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f9028041-8c6e-4137-8df5-f8b11ff68de6");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "04b3975c-0900-4331-9f07-cf6ef93591a3");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "4a0c4bc0-04d5-4579-a7ff-ca2b09e64b41");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "707c6577-2889-4776-b3ea-5ea8d3ffb06f");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "9eb2aa39-b112-42a7-9975-3d025fc06db2");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c2cf7640-ce86-4e80-b5c4-5e76e753948e");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Threads",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "b660416c-0720-4ed5-b8bd-374f44e9e02b", "11/19/2020 3:29 PM", null, "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "60dba601-f16c-4b58-bad4-128eaec2f13f", "11/19/2020 3:29 PM", null, "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "f848cbbe-8bdd-474a-b660-af8df5d0f049", "11/19/2020 3:29 PM", null, "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "813a08dc-a4dc-4bd9-a3e1-435d559c6b0e", "11/19/2020 3:29 PM", null, "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "b5551ff8-33db-45a4-a793-13a63e1c6abd", "11/19/2020 3:29 PM", null, "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "87587886-bef8-46ed-9861-bc20ec82a48d", 1, "Guardian" },
                    { "15149276-574e-4493-98fc-25b91ceb87ec", 1, "Sentinel" },
                    { "0e722a3b-e4f4-426e-ae6c-bf724e70607e", 1, "Sage" },
                    { "039ab63f-a81f-4422-a279-ef2a40ee03b1", 1, "Commando" },
                    { "3a38d2d2-29a7-493e-ad9e-9bc0387e92ef", 1, "Vanguard" },
                    { "19a87a48-06f9-4736-bec4-d5be18b99b1f", 1, "Scoundrel" },
                    { "21e0dbc3-c629-4299-8c74-a202ae769ad5", 1, "Gunslinger" },
                    { "2719e485-5349-4b73-8a96-c4826d499f76", 1, "Shadow" },
                    { "d6dded09-881f-4244-9a6c-22c53d8dc5d2", 2, "Powertech" },
                    { "1629a36d-1a90-4c5b-afaa-f5d195bf5273", 2, "Operative" },
                    { "66c81c20-5d89-47a9-bc66-9223057abef8", 2, "Sniper" },
                    { "d8223d24-7b16-40f2-869f-c792c5b162d2", 2, "Assassin" },
                    { "fa55fe8d-7160-427a-8312-0b2536061dc8", 2, "Sorcerer" },
                    { "d653bec2-78e7-4d6d-b734-765d73dbe53c", 2, "Marauder" },
                    { "f3e81e6b-7ecb-4653-8bfc-2e956e0ba4aa", 2, "Juggernaut" },
                    { "86d77d4e-9c9a-4bdd-8555-22b73a075da9", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c929c185-813c-4915-91e5-ed54028025f8", "Nautolan" },
                    { "ad1c376f-bad3-4596-b84d-27b347fc588c", "Togruta" },
                    { "f2b90c7f-2456-4ea8-b595-895b08055e60", "Cathar" },
                    { "c7a775bc-f044-48f6-9c92-80f687b0d3fb", "Zabrak" },
                    { "b03d2dfe-3fd3-40b9-b280-e3e9251f91d8", "Twi'lek" },
                    { "0cdce0b6-873b-4ca6-b803-6c36ec25e7be", "Sith Pureblood" },
                    { "c248ed8b-9eaf-42f0-a921-215c6a58045e", "Mirialan" },
                    { "19a8bd24-90df-4c60-afb9-9f828e022077", "Miraluka" },
                    { "38742828-ab8d-491d-9141-3a94d9e742e1", "Human" },
                    { "57fc4dda-5ec1-415e-b5af-c19e31e3070a", "Cyborg" },
                    { "40a00763-e6de-4691-a5cf-e9eb0d68a695", "Chiss" },
                    { "40f5aca6-f7b1-41d7-8fdd-1f60157ca9b0", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "7c734bc1-4b8d-4bca-8138-5a08b1f4c859", "Tulak Hord" },
                    { "2b5a0158-cebd-48bc-a025-4040ee5bc643", "Darth Malgus" },
                    { "436aacd6-04d0-48be-8250-9bf80d3f3224", "Star Forge" },
                    { "f88eb029-1cef-4003-8920-da43046cbae1", "Satele Shan" },
                    { "e36cabfc-3b96-4a25-befd-a6621e71d9b3", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "60dba601-f16c-4b58-bad4-128eaec2f13f");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "813a08dc-a4dc-4bd9-a3e1-435d559c6b0e");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b5551ff8-33db-45a4-a793-13a63e1c6abd");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b660416c-0720-4ed5-b8bd-374f44e9e02b");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f848cbbe-8bdd-474a-b660-af8df5d0f049");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "039ab63f-a81f-4422-a279-ef2a40ee03b1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0e722a3b-e4f4-426e-ae6c-bf724e70607e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "15149276-574e-4493-98fc-25b91ceb87ec");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1629a36d-1a90-4c5b-afaa-f5d195bf5273");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "19a87a48-06f9-4736-bec4-d5be18b99b1f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "21e0dbc3-c629-4299-8c74-a202ae769ad5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2719e485-5349-4b73-8a96-c4826d499f76");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3a38d2d2-29a7-493e-ad9e-9bc0387e92ef");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "66c81c20-5d89-47a9-bc66-9223057abef8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "86d77d4e-9c9a-4bdd-8555-22b73a075da9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "87587886-bef8-46ed-9861-bc20ec82a48d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d653bec2-78e7-4d6d-b734-765d73dbe53c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d6dded09-881f-4244-9a6c-22c53d8dc5d2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d8223d24-7b16-40f2-869f-c792c5b162d2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f3e81e6b-7ecb-4653-8bfc-2e956e0ba4aa");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "fa55fe8d-7160-427a-8312-0b2536061dc8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0cdce0b6-873b-4ca6-b803-6c36ec25e7be");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "19a8bd24-90df-4c60-afb9-9f828e022077");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "38742828-ab8d-491d-9141-3a94d9e742e1");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "40a00763-e6de-4691-a5cf-e9eb0d68a695");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "40f5aca6-f7b1-41d7-8fdd-1f60157ca9b0");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "57fc4dda-5ec1-415e-b5af-c19e31e3070a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ad1c376f-bad3-4596-b84d-27b347fc588c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b03d2dfe-3fd3-40b9-b280-e3e9251f91d8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c248ed8b-9eaf-42f0-a921-215c6a58045e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c7a775bc-f044-48f6-9c92-80f687b0d3fb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c929c185-813c-4915-91e5-ed54028025f8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f2b90c7f-2456-4ea8-b595-895b08055e60");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "2b5a0158-cebd-48bc-a025-4040ee5bc643");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "436aacd6-04d0-48be-8250-9bf80d3f3224");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "7c734bc1-4b8d-4bca-8138-5a08b1f4c859");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "e36cabfc-3b96-4a25-befd-a6621e71d9b3");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "f88eb029-1cef-4003-8920-da43046cbae1");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Threads");

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "24d7d960-58b2-43d2-bc20-7fad6c35ced8", "11/19/2020 2:57 PM", null, "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "7bf9c37f-b85d-4db2-9329-b75011a43b64", "11/19/2020 2:57 PM", null, "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "1a32c4c5-40f4-4d6c-b784-a9d45f1a0f20", "11/19/2020 2:57 PM", null, "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "719d09cb-4859-454b-9099-cab85d66651d", "11/19/2020 2:57 PM", null, "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "3565b29d-cf1a-43ad-a3b5-132ab8b5fbb5", "11/19/2020 2:57 PM", null, "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "8c32c965-6ea1-41a7-ac66-b8d7c0a440ac", 1, "Guardian" },
                    { "ee9c8830-eaf4-406f-a56b-5ea78a7f7791", 1, "Sentinel" },
                    { "7506dc33-e27f-41c7-b161-d50d2346239f", 1, "Sage" },
                    { "6bb06be8-dbc0-401f-9813-337cce552eed", 1, "Commando" },
                    { "61a77c2f-c7f8-4d87-9e15-4d9d26a1e8cf", 1, "Vanguard" },
                    { "ded8d615-21ba-4fe4-a0be-e2cd59500f39", 1, "Scoundrel" },
                    { "f3f04f7c-e827-4be7-9bf8-25a1523ebf84", 1, "Gunslinger" },
                    { "71b3d863-e5fe-4dfb-82f5-2079ef5e51bc", 1, "Shadow" },
                    { "6eabb4f4-960e-4c59-bfb7-677d6cd08287", 2, "Powertech" },
                    { "032f1541-a2cf-4a02-9ce5-2670ecd11d51", 2, "Operative" },
                    { "7da05a93-5458-4ac9-a14b-925e604f2a48", 2, "Sniper" },
                    { "3a17297b-21e2-4d12-becf-d91b959cdf1c", 2, "Assassin" },
                    { "ef4fc7b8-f20e-4346-a18d-1750ae6dc79a", 2, "Sorcerer" },
                    { "b8d2c672-d4c9-403b-8986-d14d2fb9ae91", 2, "Marauder" },
                    { "ee93bba9-3fcd-48f8-8bef-33cf32967f12", 2, "Juggernaut" },
                    { "6f1dc2c8-f6b7-4d62-8e83-396724f43cf6", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "7e7da782-c017-4dea-9220-5233dc8c5967", "Nautolan" },
                    { "11b0fe63-177a-48db-874a-c7df8cde58ed", "Togruta" },
                    { "66d623fe-15ac-4c93-92c7-6c7048a01c07", "Cathar" },
                    { "5490c65c-8588-4d08-88ed-707594eed42a", "Zabrak" },
                    { "56ee7c0b-a496-4372-b969-2aa358520ee9", "Twi'lek" },
                    { "f9028041-8c6e-4137-8df5-f8b11ff68de6", "Sith Pureblood" },
                    { "bb6bb564-1025-4125-b201-86b7da7bd625", "Mirialan" },
                    { "55aef3e6-2b33-4138-ae83-c0ce9503036b", "Miraluka" },
                    { "37756e15-962a-416a-b99c-b1840c11799f", "Human" },
                    { "71dbff3a-e69e-4de6-8f6c-2cc2692df436", "Cyborg" },
                    { "f25428d0-6c29-4d35-8551-375e1a192303", "Chiss" },
                    { "42b7027b-4d61-4021-86ed-ce13d0f46aa6", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "9eb2aa39-b112-42a7-9975-3d025fc06db2", "Tulak Hord" },
                    { "04b3975c-0900-4331-9f07-cf6ef93591a3", "Darth Malgus" },
                    { "c2cf7640-ce86-4e80-b5c4-5e76e753948e", "Star Forge" },
                    { "4a0c4bc0-04d5-4579-a7ff-ca2b09e64b41", "Satele Shan" },
                    { "707c6577-2889-4776-b3ea-5ea8d3ffb06f", "The Leviathan" }
                });
        }
    }
}
