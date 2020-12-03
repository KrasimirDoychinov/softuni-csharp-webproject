using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddedNotificationsAndCharacterApproval1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IsNotified",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "NotificationStatus",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "e2be8a23-f3d8-406c-93be-ecfe3b150c66", new DateTime(2020, 12, 3, 14, 45, 13, 76, DateTimeKind.Utc).AddTicks(8047), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/03/2020 04:45 PM", null, "PVP" },
                    { "d9ff8c35-98e6-4e3f-bf7c-f62bca14d404", new DateTime(2020, 12, 3, 14, 45, 13, 79, DateTimeKind.Utc).AddTicks(4170), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/03/2020 04:45 PM", null, "PVE" },
                    { "1efd7b2b-a3e6-43b2-ba7f-8916afbeb38b", new DateTime(2020, 12, 3, 14, 45, 13, 79, DateTimeKind.Utc).AddTicks(4258), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/03/2020 04:45 PM", null, "RP" },
                    { "a63b76d7-4865-4c18-8318-7695c047a313", new DateTime(2020, 12, 3, 14, 45, 13, 79, DateTimeKind.Utc).AddTicks(4302), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/03/2020 04:45 PM", null, "Other" },
                    { "679c7a6c-83c3-486a-a022-45d8c85df36f", new DateTime(2020, 12, 3, 14, 45, 13, 79, DateTimeKind.Utc).AddTicks(4312), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/03/2020 04:45 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "c2fa2190-828c-42a8-910c-dad922d0f320", 1, "Guardian" },
                    { "6fc65d0f-f000-4166-8807-be60ff5b14d3", 1, "Sentinel" },
                    { "e584e1fe-cedb-48b0-a033-2a00d23493de", 1, "Sage" },
                    { "7a0d9d7f-22d9-4e4e-9d43-a3ed3b55b3c1", 1, "Commando" },
                    { "24616d48-8536-419c-8747-bc8766e3b7c7", 1, "Vanguard" },
                    { "44f91080-b271-4533-9915-96ab659d1908", 1, "Scoundrel" },
                    { "91e28d65-8cef-4e63-b7c3-0f68f95ecc58", 1, "Gunslinger" },
                    { "aa112212-b364-40b2-8383-06b5dd0fc6ec", 1, "Shadow" },
                    { "304d6589-0c34-44ec-9667-09c4cae61ee8", 2, "Powertech" },
                    { "e9a132bd-4c31-45df-adec-49623b6af32c", 2, "Operative" },
                    { "c8e808f1-f75a-41ba-83e6-76b1d776622f", 2, "Sniper" },
                    { "055744d0-6d4a-43b2-b6bd-e1fb3030d77d", 2, "Assassin" },
                    { "b1b94002-4910-4365-88cc-6129884780b3", 2, "Sorcerer" },
                    { "614996b4-ffd1-47b7-bddf-6e3abf4aaf45", 2, "Marauder" },
                    { "c1b9832b-df79-4c92-8ada-6213209e5671", 2, "Juggernaut" },
                    { "894813ab-42da-4ba8-870e-1fd86dd7f721", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4096f3f0-1a88-462d-95e0-540147fb9875", "Nautolan" },
                    { "9552dbed-8fe3-43c2-ba46-146905116a8f", "Togruta" },
                    { "8e5c63ab-887a-44cd-9d94-f6bb6df46bba", "Cathar" },
                    { "d8630b57-974e-431d-937c-b08f9dabb308", "Zabrak" },
                    { "1d6b18ac-9a23-4841-a633-7943e367228e", "Twi'lek" },
                    { "ba61df24-37e4-4be9-94ba-12fb3d44429f", "Sith Pureblood" },
                    { "09ace8a1-72b7-4220-945a-844f980245bf", "Mirialan" },
                    { "efe7056e-a463-4967-a5ad-0113617d94c6", "Miraluka" },
                    { "861871be-249e-4f74-9942-5f7086ae8446", "Human" },
                    { "df06472a-34f6-45a5-bb60-2df5c30332d9", "Cyborg" },
                    { "2e9bf790-68ac-4cd4-918b-4bbda58ffe13", "Chiss" },
                    { "dad4d9aa-2f3e-4d97-b423-772873960edf", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "385e1a8b-a9d4-495c-8782-650393cbdb76", "Tulak Hord" },
                    { "5ec5b33f-0980-49c3-a6be-8a8e108be7fb", "Darth Malgus" },
                    { "b0734d00-3054-4df5-be03-339cdde99736", "Star Forge" },
                    { "6ca0c5e6-ee60-4d51-8051-62d59fa1fd53", "Satele Shan" },
                    { "1fa2a70e-69a4-4b03-aebd-def1bab14095", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "1efd7b2b-a3e6-43b2-ba7f-8916afbeb38b");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "679c7a6c-83c3-486a-a022-45d8c85df36f");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a63b76d7-4865-4c18-8318-7695c047a313");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d9ff8c35-98e6-4e3f-bf7c-f62bca14d404");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "e2be8a23-f3d8-406c-93be-ecfe3b150c66");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "055744d0-6d4a-43b2-b6bd-e1fb3030d77d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "24616d48-8536-419c-8747-bc8766e3b7c7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "304d6589-0c34-44ec-9667-09c4cae61ee8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "44f91080-b271-4533-9915-96ab659d1908");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "614996b4-ffd1-47b7-bddf-6e3abf4aaf45");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6fc65d0f-f000-4166-8807-be60ff5b14d3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7a0d9d7f-22d9-4e4e-9d43-a3ed3b55b3c1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "894813ab-42da-4ba8-870e-1fd86dd7f721");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "91e28d65-8cef-4e63-b7c3-0f68f95ecc58");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "aa112212-b364-40b2-8383-06b5dd0fc6ec");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b1b94002-4910-4365-88cc-6129884780b3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c1b9832b-df79-4c92-8ada-6213209e5671");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c2fa2190-828c-42a8-910c-dad922d0f320");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c8e808f1-f75a-41ba-83e6-76b1d776622f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e584e1fe-cedb-48b0-a033-2a00d23493de");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e9a132bd-4c31-45df-adec-49623b6af32c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "09ace8a1-72b7-4220-945a-844f980245bf");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1d6b18ac-9a23-4841-a633-7943e367228e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2e9bf790-68ac-4cd4-918b-4bbda58ffe13");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4096f3f0-1a88-462d-95e0-540147fb9875");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "861871be-249e-4f74-9942-5f7086ae8446");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8e5c63ab-887a-44cd-9d94-f6bb6df46bba");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9552dbed-8fe3-43c2-ba46-146905116a8f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ba61df24-37e4-4be9-94ba-12fb3d44429f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d8630b57-974e-431d-937c-b08f9dabb308");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "dad4d9aa-2f3e-4d97-b423-772873960edf");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "df06472a-34f6-45a5-bb60-2df5c30332d9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "efe7056e-a463-4967-a5ad-0113617d94c6");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1fa2a70e-69a4-4b03-aebd-def1bab14095");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "385e1a8b-a9d4-495c-8782-650393cbdb76");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "5ec5b33f-0980-49c3-a6be-8a8e108be7fb");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "6ca0c5e6-ee60-4d51-8051-62d59fa1fd53");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b0734d00-3054-4df5-be03-339cdde99736");

            migrationBuilder.DropColumn(
                name: "NotificationStatus",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsNotified",
                table: "AspNetUsers",
                type: "bit",
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
    }
}
