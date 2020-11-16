using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class RenamedImagePathToCharacterImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ImagePath",
                table: "Characters");

            migrationBuilder.AddColumn<string>(
                name: "CharacterImagePath",
                table: "Characters",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "26b016de-1b3e-49bb-822e-ea6524597dc5", "11/16/2020 7:06 PM", null, false, "PVP" },
                    { "9f3df090-0670-4299-9af0-0fc6a0ed1b87", "11/16/2020 7:06 PM", null, false, "PVE" },
                    { "6d7d2cde-639d-4964-b462-e111f538d428", "11/16/2020 7:06 PM", null, false, "RP" },
                    { "19fead36-11a0-48e3-9156-63c7c0f2ef88", "11/16/2020 7:06 PM", null, false, "Guides" },
                    { "0a132f3f-a27c-43c1-a680-1cc03a67dc59", "11/16/2020 7:06 PM", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "ff6c40eb-8982-47de-8f44-cb218ea30f66", 1, "Guardian" },
                    { "edf09d25-9bca-4488-a589-46ecbcc12a5d", 1, "Sentinel" },
                    { "9db3d3e7-1d8f-4394-bf91-e0ec04c4d675", 1, "Sage" },
                    { "5fbc440c-fca4-498c-8ab0-c4b30e6abfcb", 1, "Commando" },
                    { "2ec51978-b07f-4a16-8111-e5bca48ac1d0", 1, "Vanguard" },
                    { "aafd9581-b583-4caa-a990-b1157b2f0c47", 1, "Scoundrel" },
                    { "beb4adb5-dbaf-4484-82eb-7ae8e1c0f05c", 1, "Gunslinger" },
                    { "a2dee534-dd24-4dd4-8f10-a9211c508f63", 1, "Shadow" },
                    { "42ecfdbe-1b97-410d-81bf-94724225d499", 2, "Powertech" },
                    { "af1fd266-0731-4d8f-b0f4-5be4793ef84d", 2, "Operative" },
                    { "3e6727d3-4bd6-48b4-969c-a96306e8e6e2", 2, "Sniper" },
                    { "28beeac1-d7b1-4ec8-9355-35c16693ed70", 2, "Assassin" },
                    { "4b15c1a1-4d65-471f-a8f6-12eef2cacb29", 2, "Sorcerer" },
                    { "44047691-2e62-4d0b-afd3-bb3fac7e0309", 2, "Marauder" },
                    { "121de4cf-9bb6-4ece-b482-54a69301e626", 2, "Juggernaut" },
                    { "eb8c271c-0dc3-46c0-a0b0-7abd82aec40d", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "a92c5023-143a-46c7-8a84-4ffc06fc60cd", "Nautolan" },
                    { "8128fe87-ff6d-4968-9618-142708f4c583", "Togruta" },
                    { "36bad8de-e808-45b9-9369-6f8ebf759174", "Cathar" },
                    { "89cec3df-e3d8-40b0-bba1-1356add22725", "Zabrak" },
                    { "c7c5ccde-b7dc-490f-a497-64557f86e460", "Twi'lek" },
                    { "9eb9e73e-6327-427b-86df-b59f56fefc7a", "Sith Pureblood" },
                    { "ea970296-504e-4a68-b10e-c2f94a3cb62a", "Mirialan" },
                    { "47e1a68f-0bb5-4470-ac29-da479078e5e1", "Miraluka" },
                    { "e5ed84df-7181-4051-b37e-9cb98a9f491b", "Human" },
                    { "9d37af21-4c3f-49ab-b2e2-0cd731e2b1f8", "Cyborg" },
                    { "44d76c13-9f62-4888-863f-8eff8018a4a2", "Chiss" },
                    { "58cc4727-b75d-4b7b-8fd3-b59fe8528fee", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "ca344da7-68bf-4b89-83e1-2dc52477390b", "Tulak Hord" },
                    { "50d1e0d5-bde2-44c0-99a0-af337865b033", "Darth Malgus" },
                    { "1c06407e-f4fd-49c0-9f31-1921650a1a78", "Star Forge" },
                    { "53d12e31-2e63-463c-bf1d-f77751742b17", "Satele Shan" },
                    { "50cb22c8-cf18-440e-abc8-96a9037a487c", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "0a132f3f-a27c-43c1-a680-1cc03a67dc59");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "19fead36-11a0-48e3-9156-63c7c0f2ef88");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "26b016de-1b3e-49bb-822e-ea6524597dc5");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "6d7d2cde-639d-4964-b462-e111f538d428");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "9f3df090-0670-4299-9af0-0fc6a0ed1b87");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "121de4cf-9bb6-4ece-b482-54a69301e626");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "28beeac1-d7b1-4ec8-9355-35c16693ed70");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2ec51978-b07f-4a16-8111-e5bca48ac1d0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3e6727d3-4bd6-48b4-969c-a96306e8e6e2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "42ecfdbe-1b97-410d-81bf-94724225d499");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "44047691-2e62-4d0b-afd3-bb3fac7e0309");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4b15c1a1-4d65-471f-a8f6-12eef2cacb29");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5fbc440c-fca4-498c-8ab0-c4b30e6abfcb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9db3d3e7-1d8f-4394-bf91-e0ec04c4d675");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a2dee534-dd24-4dd4-8f10-a9211c508f63");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "aafd9581-b583-4caa-a990-b1157b2f0c47");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "af1fd266-0731-4d8f-b0f4-5be4793ef84d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "beb4adb5-dbaf-4484-82eb-7ae8e1c0f05c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "eb8c271c-0dc3-46c0-a0b0-7abd82aec40d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "edf09d25-9bca-4488-a589-46ecbcc12a5d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ff6c40eb-8982-47de-8f44-cb218ea30f66");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "36bad8de-e808-45b9-9369-6f8ebf759174");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "44d76c13-9f62-4888-863f-8eff8018a4a2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "47e1a68f-0bb5-4470-ac29-da479078e5e1");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "58cc4727-b75d-4b7b-8fd3-b59fe8528fee");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8128fe87-ff6d-4968-9618-142708f4c583");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "89cec3df-e3d8-40b0-bba1-1356add22725");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9d37af21-4c3f-49ab-b2e2-0cd731e2b1f8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9eb9e73e-6327-427b-86df-b59f56fefc7a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a92c5023-143a-46c7-8a84-4ffc06fc60cd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c7c5ccde-b7dc-490f-a497-64557f86e460");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e5ed84df-7181-4051-b37e-9cb98a9f491b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ea970296-504e-4a68-b10e-c2f94a3cb62a");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1c06407e-f4fd-49c0-9f31-1921650a1a78");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "50cb22c8-cf18-440e-abc8-96a9037a487c");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "50d1e0d5-bde2-44c0-99a0-af337865b033");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "53d12e31-2e63-463c-bf1d-f77751742b17");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "ca344da7-68bf-4b89-83e1-2dc52477390b");

            migrationBuilder.DropColumn(
                name: "CharacterImagePath",
                table: "Characters");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Characters",
                type: "nvarchar(max)",
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
    }
}
