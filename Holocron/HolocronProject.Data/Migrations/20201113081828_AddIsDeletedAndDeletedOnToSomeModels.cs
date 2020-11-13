using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddIsDeletedAndDeletedOnToSomeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "7644c607-9d7d-486a-a5c3-17935d2aad3c");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "8b183282-3720-45e4-983f-3791bd889bea");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "94d5ed74-d3bc-485f-8dca-01415e7cb09f");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "98eb0533-2960-41a5-8a7b-bddd7ffaf0c5");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ec3f2145-96d9-4178-9f17-a1994bff50ff");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: "21592cb0-4140-4906-a8df-8e3077692c70");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0113c571-522a-4658-b38e-b0fe10d05364");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3364a14b-62ac-415a-aa83-edf384c706c8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3c793aad-8e6d-4e5c-9ff4-c6a0db899c84");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3f3b593a-bb96-4225-9d69-5abe2c5a3ab7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4baff3c3-11c1-4a3b-a779-0db070aa891e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5486f95b-f608-4a8f-85f6-bf7a225da28c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "54d7f6c2-0e4f-483a-b013-834a7ab968dd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "74bf7d6b-ef61-4b79-bd18-91ce39db21d5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "944a86f7-944b-46ce-9de7-ad64e2e40996");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9a80f48e-18ca-4a95-8952-a5cc13a5910a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b47d21fc-8812-412a-bc2b-231acc491489");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b6930677-3b07-4287-9478-195a9641bf03");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c68cae16-26f9-4491-bf23-f2a0b49d5759");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "cc990ab8-ef90-4886-a6da-0eb7682d53b4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d4064306-a29c-41a2-8c97-10ff25ba8736");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e2c4ef30-ba75-45b0-8bf8-119a79712e8e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "109ff278-2858-44e4-b0a3-b8a4c146042a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1907bcb2-eac3-4f06-8f02-fe1c65f5ff7f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2701e97f-1086-4df1-9b78-ccc5acb85f14");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4518a15c-90c6-43d3-ad20-611402667168");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "57d595a5-34ad-48df-9711-f09470ad7fc7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "582cd3bf-4893-44ae-b176-b91ad9e485a0");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "70fec936-a187-4d7b-9ee1-d600a68f323a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9b19cece-b8d9-41d2-80f5-bc32c16dec92");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c52fe2d3-097d-4177-b61d-98862fc6e8d2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "cfd0b501-1103-4fa0-ac10-0568e4c5cf12");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e936e971-27c7-45f7-a64a-37f8ec572da4");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "edd04bde-8bb6-4957-8cf4-a3922b8b114f");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "0c260665-9eb4-4802-bf24-67c8be50203d");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "46ddfe59-b5c5-40bc-b183-77d439bd63e7");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "513896a7-94c7-4acb-81ad-84f0773240be");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "afc24c07-3e5f-4103-961c-425e1d59a59b");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "d4ffc7bb-2978-4909-b99e-57bdeb957f96");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "3bc31e8c-dda3-4836-8df1-8569e81350e6");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PostsTags");

            migrationBuilder.DropColumn(
                name: "IsResolved",
                table: "PostReports");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Threads",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishedOn",
                table: "Competitions",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Characters",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Characters",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Backstory",
                table: "Characters",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 25000);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResolvedDate",
                table: "BugReports",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "BaseThreads",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "7e92f21a-257a-4034-9c30-b9779204afc1", null, false, "PVP" },
                    { "34eef49d-7cc5-4330-90dc-e49ae80ce184", null, false, "PVE" },
                    { "fd81915e-3f9a-4021-a12b-80ac6a835c4a", null, false, "RP" },
                    { "a75ef261-4c40-4c09-b58d-af5950310e33", null, false, "Guides" },
                    { "32070235-b2cd-4596-a397-4c60be0dedfb", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AccountId", "Backstory", "CharacterType", "ClassId", "DeletedOn", "ForceAffiliation", "Gender", "Image", "IsDeleted", "Name", "RaceId", "ServerId", "Title" },
                values: new object[] { "7b4174f7-27a3-411a-8988-40b3f927772d", null, "Test backstory", 1, null, null, 2, 1, null, false, "Test char", null, null, null });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "d6503a45-c4d3-4566-816c-030870c5826e", 1, "Guardian" },
                    { "28484abb-f752-4483-83da-8301cb8ec278", 1, "Sentinel" },
                    { "d7d8f1f6-22fa-4f40-baf7-3d5071ed2957", 1, "Sage" },
                    { "3c6892ab-a597-4192-8ca1-a659b4378c3d", 1, "Commando" },
                    { "9cb7a143-e0d2-498c-976b-9860bbe0bcb8", 1, "Vanguard" },
                    { "3fb933d6-2669-4818-bf03-371c39288be3", 1, "Scoundrel" },
                    { "2e9c53ca-449e-4eff-aa82-59d9b7286caf", 1, "Gunslinger" },
                    { "8220d70b-e725-4727-9211-5c5255cd949f", 1, "Shadow" },
                    { "b703d50a-30f6-4d71-b5ba-dee53365ee98", 2, "Powertech" },
                    { "3cf0959b-ffd3-4f6f-b6fc-a59a2aa81b07", 2, "Operative" },
                    { "89f5de59-10b5-4e66-be4b-a16659b32032", 2, "Sniper" },
                    { "1603b945-c583-4831-9041-5e17fb53c7b2", 2, "Assassin" },
                    { "f67988b4-da6d-46df-a80e-a2d1281e97b9", 2, "Sorcerer" },
                    { "f9dc5856-0f88-411b-b808-ca81de96ef21", 2, "Marauder" },
                    { "de1a81fc-42a8-4c19-88de-2e0e7d7f2187", 2, "Juggernaut" },
                    { "071dddcb-b338-4387-9287-cc7cba0556b3", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "80b3b98c-c879-45e0-89a3-82317a9f0f1c", "Nautolan" },
                    { "8dba31e6-521d-4a10-bd41-1e1de50e91bd", "Togruta" },
                    { "937c1aa1-4f61-4d9e-ad02-7111661a37c3", "Cathar" },
                    { "51119608-ba2a-49cd-a5d7-516f668f2183", "Zabrak" },
                    { "5de83227-b750-4be7-b2df-be13625c845f", "Twi'lek" },
                    { "3377d51e-ae36-42fa-b9c7-c61d39ede920", "Sith Pureblood" },
                    { "72912686-7eb8-4ea6-8e94-09fa0de16873", "Mirialan" },
                    { "4d615683-d5cf-44ad-b264-dcd028997410", "Miraluka" },
                    { "8d1c1998-47f2-45ba-b717-619b9107fc20", "Human" },
                    { "d2f71210-fe18-4c15-9a2b-9409fc799c5a", "Cyborg" },
                    { "d10ac1ee-b0d5-482c-a2c0-d4a0ca72a24a", "Chiss" },
                    { "2aa56f92-5ffc-4f43-9235-ada12bc554af", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "816ec9ad-bbfe-4fdb-9701-62416fdc2ad4", "The Leviathan" },
                    { "14e53f5f-2896-4d52-9395-023d64890b6e", "Darth Malgus" },
                    { "d3e013d9-0c8c-4b61-832a-b98f93b2d68a", "Star Forge" },
                    { "c31ed292-4fb2-4ac5-b70c-1fb1c20269fe", "Satele Shan" },
                    { "98043cb9-d83b-4beb-ae22-154092f5e473", "Tulak Hord" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AccountId", "BaseThreadId", "CreatedOn", "DeletedOn", "IsDeleted", "Title" },
                values: new object[] { "e437852d-157d-4bea-832b-da3916ac5784", null, null, "11/13/2020 10:18 AM", null, false, "Test thread" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "32070235-b2cd-4596-a397-4c60be0dedfb");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "34eef49d-7cc5-4330-90dc-e49ae80ce184");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "7e92f21a-257a-4034-9c30-b9779204afc1");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a75ef261-4c40-4c09-b58d-af5950310e33");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "fd81915e-3f9a-4021-a12b-80ac6a835c4a");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: "7b4174f7-27a3-411a-8988-40b3f927772d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "071dddcb-b338-4387-9287-cc7cba0556b3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1603b945-c583-4831-9041-5e17fb53c7b2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "28484abb-f752-4483-83da-8301cb8ec278");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2e9c53ca-449e-4eff-aa82-59d9b7286caf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3c6892ab-a597-4192-8ca1-a659b4378c3d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3cf0959b-ffd3-4f6f-b6fc-a59a2aa81b07");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3fb933d6-2669-4818-bf03-371c39288be3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8220d70b-e725-4727-9211-5c5255cd949f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "89f5de59-10b5-4e66-be4b-a16659b32032");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9cb7a143-e0d2-498c-976b-9860bbe0bcb8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b703d50a-30f6-4d71-b5ba-dee53365ee98");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d6503a45-c4d3-4566-816c-030870c5826e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d7d8f1f6-22fa-4f40-baf7-3d5071ed2957");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "de1a81fc-42a8-4c19-88de-2e0e7d7f2187");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f67988b4-da6d-46df-a80e-a2d1281e97b9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f9dc5856-0f88-411b-b808-ca81de96ef21");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2aa56f92-5ffc-4f43-9235-ada12bc554af");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "3377d51e-ae36-42fa-b9c7-c61d39ede920");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4d615683-d5cf-44ad-b264-dcd028997410");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "51119608-ba2a-49cd-a5d7-516f668f2183");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5de83227-b750-4be7-b2df-be13625c845f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "72912686-7eb8-4ea6-8e94-09fa0de16873");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "80b3b98c-c879-45e0-89a3-82317a9f0f1c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8d1c1998-47f2-45ba-b717-619b9107fc20");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8dba31e6-521d-4a10-bd41-1e1de50e91bd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "937c1aa1-4f61-4d9e-ad02-7111661a37c3");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d10ac1ee-b0d5-482c-a2c0-d4a0ca72a24a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d2f71210-fe18-4c15-9a2b-9409fc799c5a");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "14e53f5f-2896-4d52-9395-023d64890b6e");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "816ec9ad-bbfe-4fdb-9701-62416fdc2ad4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "98043cb9-d83b-4beb-ae22-154092f5e473");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c31ed292-4fb2-4ac5-b70c-1fb1c20269fe");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "d3e013d9-0c8c-4b61-832a-b98f93b2d68a");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "e437852d-157d-4bea-832b-da3916ac5784");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Threads");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "FinishedOn",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ResolvedDate",
                table: "BugReports");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "BaseThreads");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Servers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PostsTags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsResolved",
                table: "PostReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Characters",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Characters",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Backstory",
                table: "Characters",
                type: "nvarchar(max)",
                maxLength: 25000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "8b183282-3720-45e4-983f-3791bd889bea", false, "PVP" },
                    { "94d5ed74-d3bc-485f-8dca-01415e7cb09f", false, "PVE" },
                    { "7644c607-9d7d-486a-a5c3-17935d2aad3c", false, "RP" },
                    { "ec3f2145-96d9-4178-9f17-a1994bff50ff", false, "Guides" },
                    { "98eb0533-2960-41a5-8a7b-bddd7ffaf0c5", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AccountId", "Backstory", "CharacterType", "ClassId", "ForceAffiliation", "Gender", "Image", "IsDeleted", "Name", "RaceId", "ServerId", "Title" },
                values: new object[] { "21592cb0-4140-4906-a8df-8e3077692c70", null, "Test backstory", 1, null, 2, 1, "Placeholder image", false, "Test char", null, null, "None" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "0113c571-522a-4658-b38e-b0fe10d05364", 1, "Guardian" },
                    { "e2c4ef30-ba75-45b0-8bf8-119a79712e8e", 1, "Sentinel" },
                    { "c68cae16-26f9-4491-bf23-f2a0b49d5759", 1, "Sage" },
                    { "3f3b593a-bb96-4225-9d69-5abe2c5a3ab7", 1, "Commando" },
                    { "4baff3c3-11c1-4a3b-a779-0db070aa891e", 1, "Vanguard" },
                    { "cc990ab8-ef90-4886-a6da-0eb7682d53b4", 1, "Scoundrel" },
                    { "54d7f6c2-0e4f-483a-b013-834a7ab968dd", 1, "Gunslinger" },
                    { "d4064306-a29c-41a2-8c97-10ff25ba8736", 1, "Shadow" },
                    { "3c793aad-8e6d-4e5c-9ff4-c6a0db899c84", 2, "Powertech" },
                    { "b6930677-3b07-4287-9478-195a9641bf03", 2, "Operative" },
                    { "74bf7d6b-ef61-4b79-bd18-91ce39db21d5", 2, "Sniper" },
                    { "5486f95b-f608-4a8f-85f6-bf7a225da28c", 2, "Assassin" },
                    { "3364a14b-62ac-415a-aa83-edf384c706c8", 2, "Sorcerer" },
                    { "b47d21fc-8812-412a-bc2b-231acc491489", 2, "Marauder" },
                    { "944a86f7-944b-46ce-9de7-ad64e2e40996", 2, "Juggernaut" },
                    { "9a80f48e-18ca-4a95-8952-a5cc13a5910a", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1907bcb2-eac3-4f06-8f02-fe1c65f5ff7f", "Nautolan" },
                    { "4518a15c-90c6-43d3-ad20-611402667168", "Togruta" },
                    { "109ff278-2858-44e4-b0a3-b8a4c146042a", "Cathar" },
                    { "582cd3bf-4893-44ae-b176-b91ad9e485a0", "Zabrak" },
                    { "edd04bde-8bb6-4957-8cf4-a3922b8b114f", "Twi'lek" },
                    { "c52fe2d3-097d-4177-b61d-98862fc6e8d2", "Sith Pureblood" },
                    { "70fec936-a187-4d7b-9ee1-d600a68f323a", "Mirialan" },
                    { "cfd0b501-1103-4fa0-ac10-0568e4c5cf12", "Miraluka" },
                    { "e936e971-27c7-45f7-a64a-37f8ec572da4", "Human" },
                    { "9b19cece-b8d9-41d2-80f5-bc32c16dec92", "Cyborg" },
                    { "2701e97f-1086-4df1-9b78-ccc5acb85f14", "Chiss" },
                    { "57d595a5-34ad-48df-9711-f09470ad7fc7", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { "513896a7-94c7-4acb-81ad-84f0773240be", false, "The Leviathan" },
                    { "0c260665-9eb4-4802-bf24-67c8be50203d", false, "Darth Malgus" },
                    { "d4ffc7bb-2978-4909-b99e-57bdeb957f96", false, "Star Forge" },
                    { "46ddfe59-b5c5-40bc-b183-77d439bd63e7", false, "Satele Shan" },
                    { "afc24c07-3e5f-4103-961c-425e1d59a59b", false, "Tulak Hord" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AccountId", "BaseThreadId", "CreatedOn", "IsDeleted", "Title" },
                values: new object[] { "3bc31e8c-dda3-4836-8df1-8569e81350e6", null, null, "11/06/2020 7:30 PM", false, "Test thread" });
        }
    }
}
