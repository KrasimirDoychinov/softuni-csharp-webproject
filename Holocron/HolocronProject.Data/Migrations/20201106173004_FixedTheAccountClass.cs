using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class FixedTheAccountClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df3275e8-1a65-44a6-ab61-8679e6d07091");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "20ec6ced-0830-40f7-bf8b-b80bd717d440");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "5a8f87bd-05a3-4441-99c9-1007d4fc5bfd");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "6a76a417-32eb-44b4-8b34-b913db762280");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "6faf6ca4-29e0-4a9c-82c2-10e42938ad6c");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "add72c65-5c20-4436-bffa-41df8c8ac6c2");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: "3ac440db-1fcf-4570-b17b-3a49ade43d9f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "03f70048-a7f9-4cb8-83a8-e6bfc556a942");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "13d76c0c-47f3-4547-bd83-20f0587e2ac9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1c22267c-cca5-42d1-9954-9490e2f36922");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "32052642-cae3-4c8f-a958-2a6adcf098a8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4c90e0ca-9c69-447f-954e-ee747bd4e9eb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "53934fa1-3084-4c94-b629-bae0cb386ded");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "542efb50-3d68-481f-a200-64d7c2e99ffe");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "820cbf3a-c8d6-4f28-8d67-8bc15e82e6ba");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "86a77d83-5713-42a0-893c-1cfa6102f414");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "94dd0d0a-7537-4e79-8858-63ba4c3d79c6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9ce3bd4c-4158-4c0b-afc0-85ba8c0fdb14");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a1c6610a-dfd9-4c44-9272-9363ce98ebd5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a4a90797-99dd-49e8-852d-84d31f01674b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d79d7fd2-2d75-4dd9-8823-a38465f853d5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "df384b84-2b4b-4a2c-ab3d-cfc2e4186d9b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e6cf74a7-5857-4de4-a6f4-735511c491d2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2dd5a732-e096-48d6-a0fd-eae4cef81009");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "480055d6-050f-417c-8ae6-99e9852238a6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "647125b1-3fc3-44e1-8443-2734c3e1de78");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7fc60783-3382-4f05-8a0f-a2459126bbcb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "978b648d-c78f-4c6a-a564-305711837a9c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "acdf9bd9-83a4-4dcd-aee8-d3932b788a68");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c20acf70-0f3a-4a8e-9097-56ffc5430b19");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c253aed8-415c-4b70-9904-1ba935ba7a5f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d109185f-dd33-4619-8d42-d279bae2290e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d76d62eb-2150-4004-b5d0-c9f216332c4c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "dd3c6066-086f-4729-b2e8-e3a813ea4671");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e4c7ea12-d35e-4c74-963e-7b883a20dff4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "2d424aee-9a7f-4da7-bd80-fd21e9ce2484");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "47f263c9-957f-44ff-b031-04836c73f110");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "75b089df-d5f8-49c1-b79b-35fe99c441e9");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b0504dcb-cee1-4579-bee6-b762fbc1b566");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b4406d87-6193-4466-9bc0-309a53d27a66");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "1b4456a1-eae0-4fe2-bc11-659e529ab4d7");

            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountName", "AvatarImage", "ConcurrencyStamp", "CreatedOn", "DisplayName", "Email", "EmailConfirmed", "ForumSignature", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "df3275e8-1a65-44a6-ab61-8679e6d07091", 0, "Test username", "Placeholder Image", "e215e056-0f94-4c82-957d-3ceeb06fb8b1", "11/05/2020 6:35 PM", "Test display name", null, false, "Placeholder forum signature", false, null, null, null, "Test password", null, null, false, "716af112-cbe6-4d7d-a4b7-ea79f4036538", false, null });

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "add72c65-5c20-4436-bffa-41df8c8ac6c2", false, "PVP" },
                    { "6a76a417-32eb-44b4-8b34-b913db762280", false, "PVE" },
                    { "20ec6ced-0830-40f7-bf8b-b80bd717d440", false, "RP" },
                    { "6faf6ca4-29e0-4a9c-82c2-10e42938ad6c", false, "Guides" },
                    { "5a8f87bd-05a3-4441-99c9-1007d4fc5bfd", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AccountId", "Backstory", "CharacterType", "ClassId", "ForceAffiliation", "Gender", "Image", "IsDeleted", "Name", "RaceId", "ServerId", "Title" },
                values: new object[] { "3ac440db-1fcf-4570-b17b-3a49ade43d9f", null, "Test backstory", 1, null, 2, 1, "Placeholder image", false, "Test char", null, null, "None" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "13d76c0c-47f3-4547-bd83-20f0587e2ac9", 1, "Guardian" },
                    { "94dd0d0a-7537-4e79-8858-63ba4c3d79c6", 1, "Sentinel" },
                    { "e6cf74a7-5857-4de4-a6f4-735511c491d2", 1, "Sage" },
                    { "03f70048-a7f9-4cb8-83a8-e6bfc556a942", 1, "Commando" },
                    { "a1c6610a-dfd9-4c44-9272-9363ce98ebd5", 1, "Vanguard" },
                    { "86a77d83-5713-42a0-893c-1cfa6102f414", 1, "Scoundrel" },
                    { "d79d7fd2-2d75-4dd9-8823-a38465f853d5", 1, "Gunslinger" },
                    { "df384b84-2b4b-4a2c-ab3d-cfc2e4186d9b", 1, "Shadow" },
                    { "820cbf3a-c8d6-4f28-8d67-8bc15e82e6ba", 2, "Powertech" },
                    { "542efb50-3d68-481f-a200-64d7c2e99ffe", 2, "Operative" },
                    { "1c22267c-cca5-42d1-9954-9490e2f36922", 2, "Sniper" },
                    { "9ce3bd4c-4158-4c0b-afc0-85ba8c0fdb14", 2, "Assassin" },
                    { "4c90e0ca-9c69-447f-954e-ee747bd4e9eb", 2, "Sorcerer" },
                    { "53934fa1-3084-4c94-b629-bae0cb386ded", 2, "Marauder" },
                    { "32052642-cae3-4c8f-a958-2a6adcf098a8", 2, "Juggernaut" },
                    { "a4a90797-99dd-49e8-852d-84d31f01674b", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "978b648d-c78f-4c6a-a564-305711837a9c", "Nautolan" },
                    { "acdf9bd9-83a4-4dcd-aee8-d3932b788a68", "Togruta" },
                    { "e4c7ea12-d35e-4c74-963e-7b883a20dff4", "Cathar" },
                    { "dd3c6066-086f-4729-b2e8-e3a813ea4671", "Zabrak" },
                    { "d109185f-dd33-4619-8d42-d279bae2290e", "Twi'lek" },
                    { "2dd5a732-e096-48d6-a0fd-eae4cef81009", "Sith Pureblood" },
                    { "480055d6-050f-417c-8ae6-99e9852238a6", "Mirialan" },
                    { "c253aed8-415c-4b70-9904-1ba935ba7a5f", "Miraluka" },
                    { "647125b1-3fc3-44e1-8443-2734c3e1de78", "Human" },
                    { "c20acf70-0f3a-4a8e-9097-56ffc5430b19", "Cyborg" },
                    { "7fc60783-3382-4f05-8a0f-a2459126bbcb", "Chiss" },
                    { "d76d62eb-2150-4004-b5d0-c9f216332c4c", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { "47f263c9-957f-44ff-b031-04836c73f110", false, "The Leviathan" },
                    { "2d424aee-9a7f-4da7-bd80-fd21e9ce2484", false, "Darth Malgus" },
                    { "b0504dcb-cee1-4579-bee6-b762fbc1b566", false, "Star Forge" },
                    { "75b089df-d5f8-49c1-b79b-35fe99c441e9", false, "Satele Shan" },
                    { "b4406d87-6193-4466-9bc0-309a53d27a66", false, "Tulak Hord" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AccountId", "BaseThreadId", "CreatedOn", "IsDeleted", "Title" },
                values: new object[] { "1b4456a1-eae0-4fe2-bc11-659e529ab4d7", null, null, "11/05/2020 6:35 PM", false, "Test thread" });
        }
    }
}
