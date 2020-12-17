using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class FixedCreatedOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "3a710b76-97e6-4922-aff0-3df63d92d0b2");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8b4ce15e-cc91-4c5a-8432-d0bc6aaa4247");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ac21bd77-7e1c-40c1-9d2e-df78268f642f");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "bbb0fc1e-db8a-499b-b23a-e243c9d46a58");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "e4073799-ff13-4243-b476-8ba5b9e57080");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1fdb1040-0468-4d53-9aaf-5f81d9c93155");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "325bf826-1f94-4ac0-a3f6-1cfd0715358c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3bf08fc3-13e4-44ae-9152-89640dab342a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3df21721-bb54-43f3-b7cf-b37207b804b7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4cb55826-f2fd-4b5e-8cfb-5a10e9c609f6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "56c0cf45-7574-4c54-84ea-bec618129445");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "68f798cf-99d6-4bab-a351-11a58948cdbc");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6e0e2c31-3733-465d-994d-8bce35b3f373");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7c04e6c0-d6d5-4d6a-b508-afcb531abd1f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7f3441f4-58d6-4f83-b7f2-f64ae6ad93e2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8479cabc-5c4c-4d6e-b022-dc0638493534");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8652536d-f76c-4098-8306-f28b8aaf0542");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8915e647-d04b-4a9a-bb3e-b48c367b13bd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b760665d-d721-4f5b-90fa-847b1d0a8d88");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e56dd53d-e49c-4171-8c1b-50cde4b4dc2e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ff3086d5-6bbd-4379-be45-90c5f8cae8b4");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "27482297-1592-4daa-8816-02c1a03b6cd7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2acf60a5-5358-4c46-9095-0d024e86db6e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5776155c-19d9-4e00-982b-265fca792cae");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "82348cee-6f76-4a08-af63-e7662f148833");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8ef8c5b3-f8f5-4f5b-8b21-60cb53743be8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9b3ac3ca-cf48-4460-8494-0b8fa2f0ce28");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a0de8003-8d12-4f1f-8e3b-eb3471f88897");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a2963bc8-23eb-4685-bd20-d975bd64c1d6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "be6eedf6-61e7-499f-9ae7-45cfc2317e6e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bf7363eb-49d8-4036-bb09-73e8c92f681f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ceb40fec-c925-442b-b98b-c503097f4016");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f17d2a68-7de6-482a-97ef-17a18c4bfc60");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1ac9cae9-ccdf-444c-b836-cd2f3ac55509");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "721c35fd-3ef9-4357-8261-47b78300150a");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "9a63040e-d42d-4edf-863d-a5257ca2fef9");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "bfc32301-bc59-454e-a888-fbec9ab8b381");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "d1c4ee97-402c-4cf5-b96d-78496ddab209");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "Threads");

            migrationBuilder.DropColumn(
                name: "NormalizedDeletedOn",
                table: "Threads");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "NormalizedDeletedOn",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "PostReports");

            migrationBuilder.DropColumn(
                name: "NormalizedResolvedOn",
                table: "PostReports");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "NormalizedDeletedOn",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "BugReports");

            migrationBuilder.DropColumn(
                name: "NormalizedResolvedOn",
                table: "BugReports");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "BaseThreads");

            migrationBuilder.DropColumn(
                name: "NormalizedDeletedOn",
                table: "BaseThreads");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "NormalizedCreatedOn",
                table: "Threads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedDeletedOn",
                table: "Threads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedCreatedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedDeletedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedCreatedOn",
                table: "PostReports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedResolvedOn",
                table: "PostReports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedCreatedOn",
                table: "Characters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedDeletedOn",
                table: "Characters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedCreatedOn",
                table: "BugReports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedResolvedOn",
                table: "BugReports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedCreatedOn",
                table: "BaseThreads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NormalizedDeletedOn",
                table: "BaseThreads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "3a710b76-97e6-4922-aff0-3df63d92d0b2", new DateTime(2020, 12, 14, 17, 38, 47, 700, DateTimeKind.Utc).AddTicks(7506), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PVP" },
                    { "bbb0fc1e-db8a-499b-b23a-e243c9d46a58", new DateTime(2020, 12, 14, 17, 38, 47, 700, DateTimeKind.Utc).AddTicks(8442), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PVE" },
                    { "8b4ce15e-cc91-4c5a-8432-d0bc6aaa4247", new DateTime(2020, 12, 14, 17, 38, 47, 700, DateTimeKind.Utc).AddTicks(8487), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RP" },
                    { "ac21bd77-7e1c-40c1-9d2e-df78268f642f", new DateTime(2020, 12, 14, 17, 38, 47, 700, DateTimeKind.Utc).AddTicks(8491), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Other" },
                    { "e4073799-ff13-4243-b476-8ba5b9e57080", new DateTime(2020, 12, 14, 17, 38, 47, 700, DateTimeKind.Utc).AddTicks(8494), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "e56dd53d-e49c-4171-8c1b-50cde4b4dc2e", 1, "Guardian" },
                    { "3bf08fc3-13e4-44ae-9152-89640dab342a", 1, "Sentinel" },
                    { "3df21721-bb54-43f3-b7cf-b37207b804b7", 1, "Sage" },
                    { "ff3086d5-6bbd-4379-be45-90c5f8cae8b4", 1, "Commando" },
                    { "1fdb1040-0468-4d53-9aaf-5f81d9c93155", 1, "Vanguard" },
                    { "325bf826-1f94-4ac0-a3f6-1cfd0715358c", 1, "Scoundrel" },
                    { "7f3441f4-58d6-4f83-b7f2-f64ae6ad93e2", 1, "Gunslinger" },
                    { "7c04e6c0-d6d5-4d6a-b508-afcb531abd1f", 1, "Shadow" },
                    { "8652536d-f76c-4098-8306-f28b8aaf0542", 2, "Powertech" },
                    { "56c0cf45-7574-4c54-84ea-bec618129445", 2, "Operative" },
                    { "4cb55826-f2fd-4b5e-8cfb-5a10e9c609f6", 2, "Sniper" },
                    { "68f798cf-99d6-4bab-a351-11a58948cdbc", 2, "Assassin" },
                    { "8479cabc-5c4c-4d6e-b022-dc0638493534", 2, "Sorcerer" },
                    { "b760665d-d721-4f5b-90fa-847b1d0a8d88", 2, "Marauder" },
                    { "8915e647-d04b-4a9a-bb3e-b48c367b13bd", 2, "Juggernaut" },
                    { "6e0e2c31-3733-465d-994d-8bce35b3f373", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "a0de8003-8d12-4f1f-8e3b-eb3471f88897", "Nautolan" },
                    { "f17d2a68-7de6-482a-97ef-17a18c4bfc60", "Togruta" },
                    { "9b3ac3ca-cf48-4460-8494-0b8fa2f0ce28", "Cathar" },
                    { "bf7363eb-49d8-4036-bb09-73e8c92f681f", "Zabrak" },
                    { "27482297-1592-4daa-8816-02c1a03b6cd7", "Twi'lek" },
                    { "a2963bc8-23eb-4685-bd20-d975bd64c1d6", "Sith Pureblood" },
                    { "be6eedf6-61e7-499f-9ae7-45cfc2317e6e", "Mirialan" },
                    { "82348cee-6f76-4a08-af63-e7662f148833", "Miraluka" },
                    { "2acf60a5-5358-4c46-9095-0d024e86db6e", "Human" },
                    { "5776155c-19d9-4e00-982b-265fca792cae", "Cyborg" },
                    { "ceb40fec-c925-442b-b98b-c503097f4016", "Chiss" },
                    { "8ef8c5b3-f8f5-4f5b-8b21-60cb53743be8", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "9a63040e-d42d-4edf-863d-a5257ca2fef9", "Tulak Hord" },
                    { "1ac9cae9-ccdf-444c-b836-cd2f3ac55509", "Darth Malgus" },
                    { "bfc32301-bc59-454e-a888-fbec9ab8b381", "Star Forge" },
                    { "721c35fd-3ef9-4357-8261-47b78300150a", "Satele Shan" },
                    { "d1c4ee97-402c-4cf5-b96d-78496ddab209", "The Leviathan" }
                });
        }
    }
}
