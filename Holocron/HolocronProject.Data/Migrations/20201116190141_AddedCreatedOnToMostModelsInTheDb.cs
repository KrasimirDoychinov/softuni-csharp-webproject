using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddedCreatedOnToMostModelsInTheDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "347b8559-a436-4e3a-89a5-b3c45fc6f769");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "3797630a-d25f-4289-bbc7-c7b95092d8c8");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8b23e445-8faa-4dcd-a088-724ef0a45b6e");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b2e8b763-7f47-42a1-bc62-32e7f4d85b19");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "c0f908e8-dadb-48f6-84f9-f977a5cd3c54");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "07b786fd-0458-4e21-9889-35842f0e297d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1d5f7ad3-bbd4-4f99-9f71-c9e493282293");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1e18e4ed-6d55-4336-9632-1eb1a666508c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1f0681c4-f67d-470d-a850-beab5bdffc3f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "270c1bf7-96a2-4bb9-8cb5-66da2e08a69c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "33a0a141-9a0c-482f-9aee-3bbd363646f7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3e025ede-ba9e-43a5-b737-f0a3d894c8e3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3f568fe7-8d8d-475d-bebe-ad82e8d53d45");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5b2d5a0a-dfcc-4d33-bc2c-dfd5b9267c87");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "954baebd-c596-4acf-9c54-de59292e6c99");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a9d9e3bd-5c2b-4b23-9ff1-5786967fccc2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c00f7daf-1a38-4bdc-95d0-2423bd404a63");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "da78ebf3-277a-4dec-ba4c-c25292f222ee");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ef66e0d3-fbe2-44b0-8990-5dbb03f2dc2e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f8482505-d5ab-418e-997e-037139b1cb1f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f9cb5eb3-95c1-4b01-ad7e-b4c8e0fb6e7d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0c77e61d-f810-4fca-85b6-2f8877793cb7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "12cb169b-5ef3-4d2e-a6e7-05614801e0b4");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "216b41eb-4304-4b7a-9efc-e8eff2309f3c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2f3526cc-89cc-408a-99d7-0f370f006caf");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "31494aed-bedf-485c-891f-0133491f46fb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3e9d43b6-b0b8-4b8a-9afc-c057edf26f36");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "68c443aa-1ebe-4443-b698-f3589fe4e3f7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "73cf6eb0-77da-4b9c-b558-c9add6ddeb64");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "885269e3-652d-4bb0-a28e-55ba972e2cbd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "893e28ed-c4d9-4e3b-88a6-467a1a4ce54b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b355e492-bf1a-4dec-9249-e4368d0e0536");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bf25b72a-1dd2-49d7-a817-f5795be8bf06");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "30bd955b-9712-46b8-b016-f2cafec798f5");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "ace8d337-2e34-499b-b420-201f620a29ce");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b5638585-ef09-4c57-a462-06ef1d188945");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "ec3ca8fb-683c-4df3-9bb6-3f90def6e978");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "f0713740-4c07-44e4-96d5-d90f6bf5d347");

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "PostReports",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsResolved",
                table: "PostReports",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResolvedDate",
                table: "PostReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "BugReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "BaseThreads",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "1249c45e-e4b3-4ee7-9eef-abda724185c2", "11/16/2020 7:01 PM", null, false, "PVP" },
                    { "28102665-c0e4-4ab4-8d9e-fd36b178cf81", "11/16/2020 7:01 PM", null, false, "PVE" },
                    { "b32d82ba-a545-403a-83da-6e053f171c04", "11/16/2020 7:01 PM", null, false, "RP" },
                    { "059c6089-fdde-40e8-97be-971e5e91ca82", "11/16/2020 7:01 PM", null, false, "Guides" },
                    { "ab913dce-223f-496d-90b6-f7e0925ae05d", "11/16/2020 7:01 PM", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "994f6bb8-ed04-489f-8e0f-559b259fd935", 1, "Guardian" },
                    { "3cdf181c-ca17-40d6-94a5-9e941968e494", 1, "Sentinel" },
                    { "8213234b-c484-465b-aa6c-ebc4adbf4ef4", 1, "Sage" },
                    { "1a1a5568-5534-4095-9536-470ccf636523", 1, "Commando" },
                    { "7da85f85-28f2-4ddb-9a89-24124232cf81", 1, "Vanguard" },
                    { "55fd624b-dda3-41ac-a63d-a87bfc978a10", 1, "Scoundrel" },
                    { "14277830-f4d6-4bf1-be56-a1f26337310a", 1, "Gunslinger" },
                    { "dcbc0181-e194-48f6-ad2b-1b1c807f0992", 1, "Shadow" },
                    { "c1abadb2-5928-415c-b591-61d0b2e5a43e", 2, "Powertech" },
                    { "5f78f098-b365-4d37-bbcc-d2dc138c787f", 2, "Operative" },
                    { "322d210a-8ec3-44b5-9c59-326bd06b32fa", 2, "Sniper" },
                    { "876e2f15-296a-482a-b4e8-7e835cd59fb0", 2, "Assassin" },
                    { "e7aff7d4-e01a-4b65-b1a2-5eabbc967a6d", 2, "Sorcerer" },
                    { "9d6cb7af-64e3-4b3e-9261-fef4e5a269f2", 2, "Marauder" },
                    { "4311ce1f-60a7-4cb6-83b6-4f401f5e9b51", 2, "Juggernaut" },
                    { "1501a27e-bd71-4d48-9cce-84c02248fd5e", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "8e3fc2fc-2523-4b41-9505-85613c5d7ddc", "Nautolan" },
                    { "271f6e82-bbaf-4c70-89d0-1b4fce08d577", "Togruta" },
                    { "57f42fb3-7c01-4902-af2e-ba5d0e3e2114", "Cathar" },
                    { "77855aca-dbaf-4371-b326-6c8a4b975eea", "Zabrak" },
                    { "0bf47e66-0b15-43ae-9b49-6a913c039a11", "Twi'lek" },
                    { "bf678d33-8bc4-4cd9-9649-2a6c9d59bab2", "Sith Pureblood" },
                    { "3167c820-9633-421e-989a-9094430c3e1f", "Mirialan" },
                    { "5a700d77-2a09-47d9-9640-077370eae0fd", "Miraluka" },
                    { "8405f31c-3139-40c7-8597-e2fb98320b8c", "Human" },
                    { "5a1d419e-e5b2-4bc1-bb9c-96d38415891b", "Cyborg" },
                    { "09fd5999-7f06-4e0e-bd7e-f2237f9a32ab", "Chiss" },
                    { "f28a9fb7-d9f9-4409-8291-c7cd32fdfbbf", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "893171f3-9647-42d2-bb8d-d95c8c7ef5e7", "Tulak Hord" },
                    { "df877060-cfc4-4306-9f6c-60deab2c40d7", "Darth Malgus" },
                    { "53838484-e4ff-4403-9692-7d86c94a5977", "Star Forge" },
                    { "8c5f165d-89e6-4aa9-9aaf-58a18854c9d4", "Satele Shan" },
                    { "2dc5fff5-3ce6-4c99-abc8-e033a2953df1", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "059c6089-fdde-40e8-97be-971e5e91ca82");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "1249c45e-e4b3-4ee7-9eef-abda724185c2");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "28102665-c0e4-4ab4-8d9e-fd36b178cf81");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ab913dce-223f-496d-90b6-f7e0925ae05d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b32d82ba-a545-403a-83da-6e053f171c04");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "14277830-f4d6-4bf1-be56-a1f26337310a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1501a27e-bd71-4d48-9cce-84c02248fd5e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1a1a5568-5534-4095-9536-470ccf636523");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "322d210a-8ec3-44b5-9c59-326bd06b32fa");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3cdf181c-ca17-40d6-94a5-9e941968e494");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4311ce1f-60a7-4cb6-83b6-4f401f5e9b51");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "55fd624b-dda3-41ac-a63d-a87bfc978a10");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5f78f098-b365-4d37-bbcc-d2dc138c787f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7da85f85-28f2-4ddb-9a89-24124232cf81");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8213234b-c484-465b-aa6c-ebc4adbf4ef4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "876e2f15-296a-482a-b4e8-7e835cd59fb0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "994f6bb8-ed04-489f-8e0f-559b259fd935");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9d6cb7af-64e3-4b3e-9261-fef4e5a269f2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c1abadb2-5928-415c-b591-61d0b2e5a43e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "dcbc0181-e194-48f6-ad2b-1b1c807f0992");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e7aff7d4-e01a-4b65-b1a2-5eabbc967a6d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "09fd5999-7f06-4e0e-bd7e-f2237f9a32ab");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0bf47e66-0b15-43ae-9b49-6a913c039a11");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "271f6e82-bbaf-4c70-89d0-1b4fce08d577");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3167c820-9633-421e-989a-9094430c3e1f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "57f42fb3-7c01-4902-af2e-ba5d0e3e2114");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5a1d419e-e5b2-4bc1-bb9c-96d38415891b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5a700d77-2a09-47d9-9640-077370eae0fd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "77855aca-dbaf-4371-b326-6c8a4b975eea");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8405f31c-3139-40c7-8597-e2fb98320b8c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8e3fc2fc-2523-4b41-9505-85613c5d7ddc");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "bf678d33-8bc4-4cd9-9649-2a6c9d59bab2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f28a9fb7-d9f9-4409-8291-c7cd32fdfbbf");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "2dc5fff5-3ce6-4c99-abc8-e033a2953df1");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "53838484-e4ff-4403-9692-7d86c94a5977");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "893171f3-9647-42d2-bb8d-d95c8c7ef5e7");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "8c5f165d-89e6-4aa9-9aaf-58a18854c9d4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "df877060-cfc4-4306-9f6c-60deab2c40d7");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "PostReports");

            migrationBuilder.DropColumn(
                name: "IsResolved",
                table: "PostReports");

            migrationBuilder.DropColumn(
                name: "ResolvedDate",
                table: "PostReports");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "BugReports");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "BaseThreads");

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "c0f908e8-dadb-48f6-84f9-f977a5cd3c54", null, false, "PVP" },
                    { "3797630a-d25f-4289-bbc7-c7b95092d8c8", null, false, "PVE" },
                    { "b2e8b763-7f47-42a1-bc62-32e7f4d85b19", null, false, "RP" },
                    { "8b23e445-8faa-4dcd-a088-724ef0a45b6e", null, false, "Guides" },
                    { "347b8559-a436-4e3a-89a5-b3c45fc6f769", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "c00f7daf-1a38-4bdc-95d0-2423bd404a63", 1, "Guardian" },
                    { "f8482505-d5ab-418e-997e-037139b1cb1f", 1, "Sentinel" },
                    { "da78ebf3-277a-4dec-ba4c-c25292f222ee", 1, "Sage" },
                    { "5b2d5a0a-dfcc-4d33-bc2c-dfd5b9267c87", 1, "Commando" },
                    { "954baebd-c596-4acf-9c54-de59292e6c99", 1, "Vanguard" },
                    { "3e025ede-ba9e-43a5-b737-f0a3d894c8e3", 1, "Scoundrel" },
                    { "1e18e4ed-6d55-4336-9632-1eb1a666508c", 1, "Gunslinger" },
                    { "f9cb5eb3-95c1-4b01-ad7e-b4c8e0fb6e7d", 1, "Shadow" },
                    { "a9d9e3bd-5c2b-4b23-9ff1-5786967fccc2", 2, "Powertech" },
                    { "3f568fe7-8d8d-475d-bebe-ad82e8d53d45", 2, "Operative" },
                    { "07b786fd-0458-4e21-9889-35842f0e297d", 2, "Sniper" },
                    { "ef66e0d3-fbe2-44b0-8990-5dbb03f2dc2e", 2, "Assassin" },
                    { "33a0a141-9a0c-482f-9aee-3bbd363646f7", 2, "Sorcerer" },
                    { "1f0681c4-f67d-470d-a850-beab5bdffc3f", 2, "Marauder" },
                    { "270c1bf7-96a2-4bb9-8cb5-66da2e08a69c", 2, "Juggernaut" },
                    { "1d5f7ad3-bbd4-4f99-9f71-c9e493282293", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "73cf6eb0-77da-4b9c-b558-c9add6ddeb64", "Nautolan" },
                    { "885269e3-652d-4bb0-a28e-55ba972e2cbd", "Togruta" },
                    { "bf25b72a-1dd2-49d7-a817-f5795be8bf06", "Cathar" },
                    { "b355e492-bf1a-4dec-9249-e4368d0e0536", "Zabrak" },
                    { "0c77e61d-f810-4fca-85b6-2f8877793cb7", "Twi'lek" },
                    { "31494aed-bedf-485c-891f-0133491f46fb", "Sith Pureblood" },
                    { "216b41eb-4304-4b7a-9efc-e8eff2309f3c", "Mirialan" },
                    { "2f3526cc-89cc-408a-99d7-0f370f006caf", "Miraluka" },
                    { "68c443aa-1ebe-4443-b698-f3589fe4e3f7", "Human" },
                    { "3e9d43b6-b0b8-4b8a-9afc-c057edf26f36", "Cyborg" },
                    { "12cb169b-5ef3-4d2e-a6e7-05614801e0b4", "Chiss" },
                    { "893e28ed-c4d9-4e3b-88a6-467a1a4ce54b", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "30bd955b-9712-46b8-b016-f2cafec798f5", "Tulak Hord" },
                    { "ec3ca8fb-683c-4df3-9bb6-3f90def6e978", "Darth Malgus" },
                    { "ace8d337-2e34-499b-b420-201f620a29ce", "Star Forge" },
                    { "f0713740-4c07-44e4-96d5-d90f6bf5d347", "Satele Shan" },
                    { "b5638585-ef09-4c57-a462-06ef1d188945", "The Leviathan" }
                });
        }
    }
}
