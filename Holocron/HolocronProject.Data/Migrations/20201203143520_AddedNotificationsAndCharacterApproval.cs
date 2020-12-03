using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddedNotificationsAndCharacterApproval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Characters",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNotified",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "76287523-008f-4461-8d04-ff9ca0dca943", new DateTime(2020, 12, 3, 14, 35, 20, 280, DateTimeKind.Utc).AddTicks(1971), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/03/2020 04:35 PM", null, "PVP" },
                    { "f9a7903f-a3cd-401f-93f7-79783bdd9943", new DateTime(2020, 12, 3, 14, 35, 20, 282, DateTimeKind.Utc).AddTicks(7982), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/03/2020 04:35 PM", null, "PVE" },
                    { "99b4d988-fcca-4ca1-871e-73b3471602d2", new DateTime(2020, 12, 3, 14, 35, 20, 282, DateTimeKind.Utc).AddTicks(8067), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/03/2020 04:35 PM", null, "RP" },
                    { "8886675f-35c0-4c3b-8681-58d1ed6e8c27", new DateTime(2020, 12, 3, 14, 35, 20, 282, DateTimeKind.Utc).AddTicks(8080), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/03/2020 04:35 PM", null, "Other" },
                    { "b4e9d0a6-4166-4557-b83b-c3483ec5b816", new DateTime(2020, 12, 3, 14, 35, 20, 282, DateTimeKind.Utc).AddTicks(8090), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/03/2020 04:35 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "7b04d8f5-7ef5-47e0-a052-d81c23abbc12", 1, "Guardian" },
                    { "50575a87-d580-4c77-8199-93f4f7cd6bda", 1, "Sentinel" },
                    { "761c8cba-d9b6-4530-8ab5-53dfc9707eae", 1, "Sage" },
                    { "8cd5dbfc-d34b-4044-ba77-aae977ac3e79", 1, "Commando" },
                    { "ea75ed3b-e938-4809-873c-2bad5ed2d83c", 1, "Vanguard" },
                    { "56e76dc4-74bf-40b8-8b77-cfb1f09a1a4d", 1, "Scoundrel" },
                    { "a1a913af-7bda-4683-a872-1f486dfe5301", 1, "Gunslinger" },
                    { "f84825df-f35b-4e86-b79c-5c52d8307793", 1, "Shadow" },
                    { "24f86fac-97a2-40a4-8678-8fca7ff29882", 2, "Powertech" },
                    { "dcb9de3e-9029-4bcd-b3f3-8446b8e6b413", 2, "Operative" },
                    { "b332d3c8-9cdb-4307-9ae8-67e9934e0071", 2, "Sniper" },
                    { "1bea44ed-310a-43f0-a0b7-587d5fcd2cc9", 2, "Assassin" },
                    { "2829689b-50aa-4024-922d-565c585cdb4b", 2, "Sorcerer" },
                    { "ee4a025d-7ab2-4f62-a87f-f4b44b15430e", 2, "Marauder" },
                    { "41b2bde8-6039-4645-8505-5691eaa45186", 2, "Juggernaut" },
                    { "89876f20-37a6-4f7e-b93b-18fd022a7739", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "471f1786-473b-43a7-8170-e22feee41ab0", "Nautolan" },
                    { "bd09beea-dd3e-40a9-bbf3-f302a811d9fc", "Togruta" },
                    { "d94a356d-952b-46fd-aaf5-7d9a92fe65bb", "Cathar" },
                    { "93dd89bb-c0bf-407d-8d92-6241040d64ab", "Zabrak" },
                    { "7ee124cf-42be-49ec-a000-43c7ee55179e", "Twi'lek" },
                    { "03362391-1c36-4ede-b9a3-1c0b2280b671", "Sith Pureblood" },
                    { "0aa494fa-a8d2-4ad9-ab4c-58556ed20693", "Mirialan" },
                    { "27a04412-eb14-4148-87ec-8685a77f2868", "Miraluka" },
                    { "f64badbc-b148-4ea0-9e97-47fbfdee94f0", "Human" },
                    { "8453f192-f1e5-434d-b384-747186e912c2", "Cyborg" },
                    { "033c8bac-2206-4077-ab43-7ffd019d3f08", "Chiss" },
                    { "056a05a5-41b8-4ad8-a9e7-638b794aa2d6", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "7f5d5382-fd7d-4fd2-98ce-c6bf5c50b914", "Tulak Hord" },
                    { "b857bf3f-3d7c-40e1-b11a-349b0c74ef4e", "Darth Malgus" },
                    { "190e70da-0656-4d6d-83ed-8e5d1bf02403", "Star Forge" },
                    { "bd528bbc-0eaa-4fcb-92dc-ce24dd71baec", "Satele Shan" },
                    { "c7077c65-0615-4e75-85b9-87d96bf9d17e", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "76287523-008f-4461-8d04-ff9ca0dca943");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8886675f-35c0-4c3b-8681-58d1ed6e8c27");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "99b4d988-fcca-4ca1-871e-73b3471602d2");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b4e9d0a6-4166-4557-b83b-c3483ec5b816");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f9a7903f-a3cd-401f-93f7-79783bdd9943");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1bea44ed-310a-43f0-a0b7-587d5fcd2cc9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "24f86fac-97a2-40a4-8678-8fca7ff29882");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2829689b-50aa-4024-922d-565c585cdb4b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "41b2bde8-6039-4645-8505-5691eaa45186");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "50575a87-d580-4c77-8199-93f4f7cd6bda");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "56e76dc4-74bf-40b8-8b77-cfb1f09a1a4d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "761c8cba-d9b6-4530-8ab5-53dfc9707eae");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7b04d8f5-7ef5-47e0-a052-d81c23abbc12");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "89876f20-37a6-4f7e-b93b-18fd022a7739");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8cd5dbfc-d34b-4044-ba77-aae977ac3e79");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a1a913af-7bda-4683-a872-1f486dfe5301");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b332d3c8-9cdb-4307-9ae8-67e9934e0071");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "dcb9de3e-9029-4bcd-b3f3-8446b8e6b413");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ea75ed3b-e938-4809-873c-2bad5ed2d83c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ee4a025d-7ab2-4f62-a87f-f4b44b15430e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f84825df-f35b-4e86-b79c-5c52d8307793");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "03362391-1c36-4ede-b9a3-1c0b2280b671");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "033c8bac-2206-4077-ab43-7ffd019d3f08");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "056a05a5-41b8-4ad8-a9e7-638b794aa2d6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0aa494fa-a8d2-4ad9-ab4c-58556ed20693");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "27a04412-eb14-4148-87ec-8685a77f2868");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "471f1786-473b-43a7-8170-e22feee41ab0");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7ee124cf-42be-49ec-a000-43c7ee55179e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8453f192-f1e5-434d-b384-747186e912c2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "93dd89bb-c0bf-407d-8d92-6241040d64ab");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bd09beea-dd3e-40a9-bbf3-f302a811d9fc");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d94a356d-952b-46fd-aaf5-7d9a92fe65bb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f64badbc-b148-4ea0-9e97-47fbfdee94f0");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "190e70da-0656-4d6d-83ed-8e5d1bf02403");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "7f5d5382-fd7d-4fd2-98ce-c6bf5c50b914");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b857bf3f-3d7c-40e1-b11a-349b0c74ef4e");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "bd528bbc-0eaa-4fcb-92dc-ce24dd71baec");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c7077c65-0615-4e75-85b9-87d96bf9d17e");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsNotified",
                table: "AspNetUsers");

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
    }
}
