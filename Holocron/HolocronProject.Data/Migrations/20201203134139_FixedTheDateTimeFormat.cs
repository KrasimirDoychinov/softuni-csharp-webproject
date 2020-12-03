using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class FixedTheDateTimeFormat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "043d820d-70eb-4211-8a39-c05d48896c0c");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "11503b5f-b841-40e7-8196-62b603b19b16");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "9cb4ecfc-29b2-4a84-8842-2d52d4366535");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ef194357-eee2-4b3b-b21b-f8ac1b665bc0");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f41fdb57-1cc2-4510-b440-6b410e80d4bf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1ae10e83-1122-4d6e-adbe-18182ca05e43");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "229e4180-9731-4929-b84a-610c6d34c655");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4608d620-8bca-4c93-af12-e435795fa4e9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "468d3d66-7fe2-4cae-bdbf-ecdd75ec7afc");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5d6eed3f-8097-4712-a828-c819a44820e1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "61c2f600-0c8e-4a4b-b944-f3aaf815d0cd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7672a104-31ae-4f75-94ec-9cb68b72fd13");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8645dc5e-968a-4ee1-b676-bdf9fe57eb38");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9d636c04-3160-44fd-90a2-7de25d10d3e5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a64e1acc-fa03-4c2d-96f4-7de39502878f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ae0cea77-57db-4ba9-9dff-f4abbf29d5ed");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ba9ce2db-fae8-44a1-a175-219e41d0a10f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "bff4e6bf-67bb-4464-91ee-7168d251c9ee");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "cf277212-b3fd-43d9-9d52-1a43d584d196");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ef43c813-8dfd-4983-b5da-351153af213b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f33f1c83-e48e-4588-a783-b18588455bdd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "69ac5397-ec9a-462e-8c04-046ec31b9fed");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "86995e1b-5dda-4890-93ad-7a501166698a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8cb5e9b5-877a-4fcd-a606-0dbc5afe6dda");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a11b80fb-a017-4cb7-9496-547e61c9bffc");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "adf4dc27-5a67-4369-92b4-cf1b3940bcfb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b54bb197-9ffe-4b2e-8301-36073b9db484");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c859359f-fdd0-4fe8-bbc0-5de6081635cb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "dd8ef0c3-859f-4aa4-a619-43fae7067aed");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "edfe40dc-9106-43ff-a39e-5331f6269f93");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ef932454-9c5f-4ad0-8a69-d61528e091e5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f2c64fd5-4290-45e7-958f-fb5a041330c7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "fa8934e2-6bb0-4fd0-b0a5-3b64a0fb8622");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "28ac50fd-a0a9-4502-a8ae-c1b8f5617967");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "762ee83e-8a13-4a6f-bdd4-b073482e83ca");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "821e0a5c-5248-4b37-af6c-4cc5f68cf1e1");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b20713ac-3404-46da-8b74-c3f664dd7edb");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "e5191968-c5dd-4faf-9cfd-db36b79a4c2d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Threads",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Threads",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedDeletedOn",
                table: "Threads",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedDeletedOn",
                table: "Posts",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResolvedOn",
                table: "PostReports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PostReports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedDeletedOn",
                table: "Characters",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResolvedOn",
                table: "BugReports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BugReports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "BaseThreads",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BaseThreads",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedDeletedOn",
                table: "BaseThreads",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "677c5260-84ae-4055-8160-5bc92ffeec52", new DateTime(2020, 12, 3, 13, 41, 38, 771, DateTimeKind.Utc).AddTicks(8048), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/03/2020 03:41 PM", null, "PVP" },
                    { "b7078b44-7ead-4609-9f9d-adb583548fd9", new DateTime(2020, 12, 3, 13, 41, 38, 774, DateTimeKind.Utc).AddTicks(4132), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/03/2020 03:41 PM", null, "PVE" },
                    { "51918837-e494-4f9f-b58e-526627a01137", new DateTime(2020, 12, 3, 13, 41, 38, 774, DateTimeKind.Utc).AddTicks(4216), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/03/2020 03:41 PM", null, "RP" },
                    { "695f72bc-789e-455d-b5eb-5434fedf9968", new DateTime(2020, 12, 3, 13, 41, 38, 774, DateTimeKind.Utc).AddTicks(4229), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/03/2020 03:41 PM", null, "Other" },
                    { "ff9facf7-ef75-43b4-a9c2-f961de422eed", new DateTime(2020, 12, 3, 13, 41, 38, 774, DateTimeKind.Utc).AddTicks(4239), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/03/2020 03:41 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "b7a05dbf-0fbe-4d59-84fd-9df5d50099ac", 1, "Guardian" },
                    { "32d9396d-e56e-4a55-8cfd-5824a7b5d074", 1, "Sentinel" },
                    { "16a59d3c-fb14-41b2-b20c-727cf069ee09", 1, "Sage" },
                    { "429d19bc-3d70-4906-9f1b-17da13c6fd01", 1, "Commando" },
                    { "a89fe145-5521-48ad-a0ef-3a25f7af49d5", 1, "Vanguard" },
                    { "9f533e3b-ede1-420b-b3ca-ec0857b7cbbe", 1, "Scoundrel" },
                    { "fac78554-21d6-41b5-8b3f-f66fb10a7353", 1, "Gunslinger" },
                    { "354b13be-1c21-44eb-98c1-046a5d2ea031", 1, "Shadow" },
                    { "1589cdcb-ddb6-4f2a-913a-024ba0582eaf", 2, "Powertech" },
                    { "200b1cf1-0de5-4b82-8557-e5a6e2742334", 2, "Operative" },
                    { "9b768a36-95c5-4451-9b4e-11c73a8a0f0b", 2, "Sniper" },
                    { "bf543b06-fdd8-449a-8821-acaae1160d4e", 2, "Assassin" },
                    { "8231537a-f137-403d-919f-57320fbf5013", 2, "Sorcerer" },
                    { "275fb7fd-84c6-477f-834b-1bcef0da5ba2", 2, "Marauder" },
                    { "dbc4f60d-9d13-41b7-855d-44ac3dc74f75", 2, "Juggernaut" },
                    { "c5b607a2-7e08-4e36-8b64-760d7b210d6f", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "96294237-1ab9-4ebc-aeff-e1e9afe41dc0", "Nautolan" },
                    { "acb6becc-a231-42f9-93a8-936b877c9006", "Togruta" },
                    { "06822844-fe61-439d-b50c-844f51821075", "Cathar" },
                    { "8f6e24b5-a550-4d33-930c-1d4bab5f5334", "Zabrak" },
                    { "13a01779-dda1-4f84-a4de-044037b0f40d", "Twi'lek" },
                    { "4b26f7c1-8ccc-4c29-b20e-10cfc74001af", "Sith Pureblood" },
                    { "df67912d-18cc-402c-8953-6c953b9d213c", "Mirialan" },
                    { "a6294a2a-a6c2-466e-a700-a652e4d96c68", "Miraluka" },
                    { "d9c3e134-bab8-4cd6-bf46-c4bd662440f5", "Human" },
                    { "7b1af34d-d61a-4e0b-889f-d392032e5208", "Cyborg" },
                    { "8597c87d-fb19-49d1-a339-9dc2fe78c276", "Chiss" },
                    { "375bfa21-717c-46a8-8a79-7b641bcf7825", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "91dc068c-fa17-4c79-bb04-05e07c63e933", "Tulak Hord" },
                    { "bb83888a-4a53-414d-8d02-736c76793ae8", "Darth Malgus" },
                    { "de94544a-c9d5-44dc-8016-8606a535958a", "Star Forge" },
                    { "bf4f9bdb-6491-40c0-849c-d8674d4796bd", "Satele Shan" },
                    { "33a86123-fa8e-4ace-80d8-3e60736f72eb", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "51918837-e494-4f9f-b58e-526627a01137");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "677c5260-84ae-4055-8160-5bc92ffeec52");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "695f72bc-789e-455d-b5eb-5434fedf9968");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b7078b44-7ead-4609-9f9d-adb583548fd9");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ff9facf7-ef75-43b4-a9c2-f961de422eed");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1589cdcb-ddb6-4f2a-913a-024ba0582eaf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "16a59d3c-fb14-41b2-b20c-727cf069ee09");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "200b1cf1-0de5-4b82-8557-e5a6e2742334");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "275fb7fd-84c6-477f-834b-1bcef0da5ba2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "32d9396d-e56e-4a55-8cfd-5824a7b5d074");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "354b13be-1c21-44eb-98c1-046a5d2ea031");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "429d19bc-3d70-4906-9f1b-17da13c6fd01");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8231537a-f137-403d-919f-57320fbf5013");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9b768a36-95c5-4451-9b4e-11c73a8a0f0b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9f533e3b-ede1-420b-b3ca-ec0857b7cbbe");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a89fe145-5521-48ad-a0ef-3a25f7af49d5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b7a05dbf-0fbe-4d59-84fd-9df5d50099ac");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "bf543b06-fdd8-449a-8821-acaae1160d4e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c5b607a2-7e08-4e36-8b64-760d7b210d6f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "dbc4f60d-9d13-41b7-855d-44ac3dc74f75");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "fac78554-21d6-41b5-8b3f-f66fb10a7353");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "06822844-fe61-439d-b50c-844f51821075");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "13a01779-dda1-4f84-a4de-044037b0f40d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "375bfa21-717c-46a8-8a79-7b641bcf7825");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4b26f7c1-8ccc-4c29-b20e-10cfc74001af");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7b1af34d-d61a-4e0b-889f-d392032e5208");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8597c87d-fb19-49d1-a339-9dc2fe78c276");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8f6e24b5-a550-4d33-930c-1d4bab5f5334");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "96294237-1ab9-4ebc-aeff-e1e9afe41dc0");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a6294a2a-a6c2-466e-a700-a652e4d96c68");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "acb6becc-a231-42f9-93a8-936b877c9006");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d9c3e134-bab8-4cd6-bf46-c4bd662440f5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "df67912d-18cc-402c-8953-6c953b9d213c");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "33a86123-fa8e-4ace-80d8-3e60736f72eb");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "91dc068c-fa17-4c79-bb04-05e07c63e933");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "bb83888a-4a53-414d-8d02-736c76793ae8");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "bf4f9bdb-6491-40c0-849c-d8674d4796bd");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "de94544a-c9d5-44dc-8016-8606a535958a");

            migrationBuilder.DropColumn(
                name: "NormalizedDeletedOn",
                table: "Threads");

            migrationBuilder.DropColumn(
                name: "NormalizedDeletedOn",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "NormalizedDeletedOn",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "NormalizedDeletedOn",
                table: "BaseThreads");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedOn",
                table: "Threads",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                table: "Threads",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DeletedOn",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ResolvedOn",
                table: "PostReports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                table: "PostReports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DeletedOn",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "ResolvedOn",
                table: "BugReports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                table: "BugReports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DeletedOn",
                table: "BaseThreads",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                table: "BaseThreads",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "Title" },
                values: new object[,]
                {
                    { "043d820d-70eb-4211-8a39-c05d48896c0c", "12/03/2020 12:14 PM", null, "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/03/2020 2:14 PM", "PVP" },
                    { "9cb4ecfc-29b2-4a84-8842-2d52d4366535", "12/03/2020 12:14 PM", null, "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/03/2020 2:14 PM", "PVE" },
                    { "ef194357-eee2-4b3b-b21b-f8ac1b665bc0", "12/03/2020 12:14 PM", null, "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/03/2020 2:14 PM", "RP" },
                    { "f41fdb57-1cc2-4510-b440-6b410e80d4bf", "12/03/2020 12:14 PM", null, "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/03/2020 2:14 PM", "Other" },
                    { "11503b5f-b841-40e7-8196-62b603b19b16", "12/03/2020 12:14 PM", null, "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/03/2020 2:14 PM", "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "cf277212-b3fd-43d9-9d52-1a43d584d196", 1, "Guardian" },
                    { "9d636c04-3160-44fd-90a2-7de25d10d3e5", 1, "Sentinel" },
                    { "bff4e6bf-67bb-4464-91ee-7168d251c9ee", 1, "Sage" },
                    { "ae0cea77-57db-4ba9-9dff-f4abbf29d5ed", 1, "Commando" },
                    { "61c2f600-0c8e-4a4b-b944-f3aaf815d0cd", 1, "Vanguard" },
                    { "468d3d66-7fe2-4cae-bdbf-ecdd75ec7afc", 1, "Scoundrel" },
                    { "4608d620-8bca-4c93-af12-e435795fa4e9", 1, "Gunslinger" },
                    { "7672a104-31ae-4f75-94ec-9cb68b72fd13", 1, "Shadow" },
                    { "a64e1acc-fa03-4c2d-96f4-7de39502878f", 2, "Powertech" },
                    { "8645dc5e-968a-4ee1-b676-bdf9fe57eb38", 2, "Operative" },
                    { "1ae10e83-1122-4d6e-adbe-18182ca05e43", 2, "Sniper" },
                    { "ef43c813-8dfd-4983-b5da-351153af213b", 2, "Assassin" },
                    { "229e4180-9731-4929-b84a-610c6d34c655", 2, "Sorcerer" },
                    { "ba9ce2db-fae8-44a1-a175-219e41d0a10f", 2, "Marauder" },
                    { "5d6eed3f-8097-4712-a828-c819a44820e1", 2, "Juggernaut" },
                    { "f33f1c83-e48e-4588-a783-b18588455bdd", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "ef932454-9c5f-4ad0-8a69-d61528e091e5", "Nautolan" },
                    { "69ac5397-ec9a-462e-8c04-046ec31b9fed", "Togruta" },
                    { "fa8934e2-6bb0-4fd0-b0a5-3b64a0fb8622", "Cathar" },
                    { "8cb5e9b5-877a-4fcd-a606-0dbc5afe6dda", "Zabrak" },
                    { "adf4dc27-5a67-4369-92b4-cf1b3940bcfb", "Twi'lek" },
                    { "f2c64fd5-4290-45e7-958f-fb5a041330c7", "Sith Pureblood" },
                    { "c859359f-fdd0-4fe8-bbc0-5de6081635cb", "Mirialan" },
                    { "b54bb197-9ffe-4b2e-8301-36073b9db484", "Miraluka" },
                    { "dd8ef0c3-859f-4aa4-a619-43fae7067aed", "Human" },
                    { "86995e1b-5dda-4890-93ad-7a501166698a", "Cyborg" },
                    { "edfe40dc-9106-43ff-a39e-5331f6269f93", "Chiss" },
                    { "a11b80fb-a017-4cb7-9496-547e61c9bffc", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "b20713ac-3404-46da-8b74-c3f664dd7edb", "Tulak Hord" },
                    { "28ac50fd-a0a9-4502-a8ae-c1b8f5617967", "Darth Malgus" },
                    { "762ee83e-8a13-4a6f-bdd4-b073482e83ca", "Star Forge" },
                    { "e5191968-c5dd-4faf-9cfd-db36b79a4c2d", "Satele Shan" },
                    { "821e0a5c-5248-4b37-af6c-4cc5f68cf1e1", "The Leviathan" }
                });
        }
    }
}
