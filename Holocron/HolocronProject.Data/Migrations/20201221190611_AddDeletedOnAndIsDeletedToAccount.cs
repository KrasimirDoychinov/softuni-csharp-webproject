using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddDeletedOnAndIsDeletedToAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "03f986fd-1b84-47d9-a4fa-8c6e2dada5ae");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "2a27c9c4-ba09-44c2-9152-2a57f7b717b5");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "7306ac71-c43b-4be9-ad97-98ed38da598b");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "9944f961-b95e-45dd-a0e7-d404b278a430");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a393fb61-920a-4de2-9a7a-2f2ee7799f9b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0490900b-c3b4-46fe-9ce5-451b0eb59d5f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "324fe5d1-b9c8-4bbb-b141-794149087bb2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3b5fd488-9b41-48b0-90f7-d3c5488ebf03");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3c2adada-5831-4763-a11b-3313a0b63ce1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3ffcf212-dfe3-49cf-a335-61a4a563ed56");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "554b3490-0608-439e-a2a5-ed3dfa01a19e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "65699983-3d84-4993-9d76-35646c299ac0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "72d6074e-f895-465f-8dac-771d7639158b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "77ef1260-e6b8-4cd2-9b64-88673d612e4d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a12c5061-3701-45c5-904e-57ae127b9efa");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a43e4c0e-72a8-42e1-8aea-aa93f682a387");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a6f526e7-a1db-42f2-9eec-0c2e2ef2abf5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b1a3060f-9c6f-47fc-b22d-faafd93223e4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c4e986c5-c081-4f2b-9780-96ba96685e74");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c9df688f-0a28-4eab-9dd3-02d5de8e9abe");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f24e29d5-0758-4f2e-9b41-ffc5c7efa893");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3f2eebe9-24f4-431e-bdca-600fc62048eb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4ac761bc-2181-4c3c-9c5d-e75f78599611");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6d72ca20-1812-4697-8f2e-75299f2c2b18");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7d1ab4cf-efe7-43e6-b198-e670ff5164b6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a237e9a7-9bcd-4304-900c-9f56e8dd7c37");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ad6c17fb-35ce-47f1-b600-fe1d306e7eb8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c5e70f04-875e-4cd0-9b93-4f82c0b5cefd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d2019b2f-2781-44ae-a8fe-34bb9e22f196");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e0464711-6c47-46ce-896c-751da864780c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e0ff874c-bb03-4343-a94c-b6fa22e4d093");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f3d2541a-b7dd-4d3a-b5f2-12e758b39483");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "febadc80-101b-4184-a2dc-7d11cad5d0c7");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "12f7a232-0d05-445c-9544-b839142fd040");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "4dcdab98-709c-4599-9cac-5d4227340781");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "9fd791c7-ccd8-4a15-8ba3-7a690b91dc22");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c4110fe5-5049-4ab8-921f-0c740dff8fae");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "d8739036-fe88-4482-a197-062fa446390e");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "a393fb61-920a-4de2-9a7a-2f2ee7799f9b", new DateTime(2020, 12, 17, 10, 20, 58, 83, DateTimeKind.Utc).AddTicks(5100), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "9944f961-b95e-45dd-a0e7-d404b278a430", new DateTime(2020, 12, 17, 10, 20, 58, 83, DateTimeKind.Utc).AddTicks(6016), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "03f986fd-1b84-47d9-a4fa-8c6e2dada5ae", new DateTime(2020, 12, 17, 10, 20, 58, 83, DateTimeKind.Utc).AddTicks(6050), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "7306ac71-c43b-4be9-ad97-98ed38da598b", new DateTime(2020, 12, 17, 10, 20, 58, 83, DateTimeKind.Utc).AddTicks(6054), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "2a27c9c4-ba09-44c2-9152-2a57f7b717b5", new DateTime(2020, 12, 17, 10, 20, 58, 83, DateTimeKind.Utc).AddTicks(6057), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "a6f526e7-a1db-42f2-9eec-0c2e2ef2abf5", 1, "Guardian" },
                    { "3b5fd488-9b41-48b0-90f7-d3c5488ebf03", 1, "Sentinel" },
                    { "c9df688f-0a28-4eab-9dd3-02d5de8e9abe", 1, "Sage" },
                    { "a12c5061-3701-45c5-904e-57ae127b9efa", 1, "Commando" },
                    { "a43e4c0e-72a8-42e1-8aea-aa93f682a387", 1, "Vanguard" },
                    { "72d6074e-f895-465f-8dac-771d7639158b", 1, "Scoundrel" },
                    { "324fe5d1-b9c8-4bbb-b141-794149087bb2", 1, "Gunslinger" },
                    { "f24e29d5-0758-4f2e-9b41-ffc5c7efa893", 1, "Shadow" },
                    { "3c2adada-5831-4763-a11b-3313a0b63ce1", 2, "Powertech" },
                    { "65699983-3d84-4993-9d76-35646c299ac0", 2, "Operative" },
                    { "b1a3060f-9c6f-47fc-b22d-faafd93223e4", 2, "Sniper" },
                    { "3ffcf212-dfe3-49cf-a335-61a4a563ed56", 2, "Assassin" },
                    { "554b3490-0608-439e-a2a5-ed3dfa01a19e", 2, "Sorcerer" },
                    { "c4e986c5-c081-4f2b-9780-96ba96685e74", 2, "Marauder" },
                    { "77ef1260-e6b8-4cd2-9b64-88673d612e4d", 2, "Juggernaut" },
                    { "0490900b-c3b4-46fe-9ce5-451b0eb59d5f", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "d2019b2f-2781-44ae-a8fe-34bb9e22f196", "Nautolan" },
                    { "7d1ab4cf-efe7-43e6-b198-e670ff5164b6", "Togruta" },
                    { "a237e9a7-9bcd-4304-900c-9f56e8dd7c37", "Cathar" },
                    { "4ac761bc-2181-4c3c-9c5d-e75f78599611", "Zabrak" },
                    { "e0ff874c-bb03-4343-a94c-b6fa22e4d093", "Twi'lek" },
                    { "e0464711-6c47-46ce-896c-751da864780c", "Sith Pureblood" },
                    { "3f2eebe9-24f4-431e-bdca-600fc62048eb", "Mirialan" },
                    { "f3d2541a-b7dd-4d3a-b5f2-12e758b39483", "Miraluka" },
                    { "6d72ca20-1812-4697-8f2e-75299f2c2b18", "Human" },
                    { "c5e70f04-875e-4cd0-9b93-4f82c0b5cefd", "Cyborg" },
                    { "febadc80-101b-4184-a2dc-7d11cad5d0c7", "Chiss" },
                    { "ad6c17fb-35ce-47f1-b600-fe1d306e7eb8", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4dcdab98-709c-4599-9cac-5d4227340781", "Tulak Hord" },
                    { "c4110fe5-5049-4ab8-921f-0c740dff8fae", "Darth Malgus" },
                    { "12f7a232-0d05-445c-9544-b839142fd040", "Star Forge" },
                    { "9fd791c7-ccd8-4a15-8ba3-7a690b91dc22", "Satele Shan" },
                    { "d8739036-fe88-4482-a197-062fa446390e", "The Leviathan" }
                });
        }
    }
}
