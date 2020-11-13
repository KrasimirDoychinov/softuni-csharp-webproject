using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class ChangedImageToImagePathAndAvatarImageToAvatarImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Image",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AvatarImage",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Characters",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Characters",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Backstory",
                table: "Characters",
                maxLength: 25000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AvatarImagePath",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "f8c3997d-2638-45b2-ac21-bdb3081069cb", null, false, "PVP" },
                    { "cc1f883d-f316-4233-b2bf-ed874600cc5d", null, false, "PVE" },
                    { "d5b86efd-8149-457a-9fd4-8124317dd599", null, false, "RP" },
                    { "f361d53a-c404-4445-b966-874dddaa60ce", null, false, "Guides" },
                    { "b6473574-fac1-4709-bb15-d2740fd77777", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AccountId", "Backstory", "CharacterType", "ClassId", "DeletedOn", "ForceAffiliation", "Gender", "ImagePath", "IsDeleted", "Name", "RaceId", "ServerId", "Title" },
                values: new object[] { "bef22f28-683b-4146-843d-c18eac817d86", null, "Test backstory", 1, null, null, 3, 1, null, false, "Test char", null, null, null });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "590a3a01-0f20-4ea1-b7c1-87a476046220", 1, "Guardian" },
                    { "ac520662-4647-44ea-a699-fa1f1b75999a", 1, "Sentinel" },
                    { "a07d7336-3ebe-4416-a61c-66a03442a161", 1, "Sage" },
                    { "508a67d9-8b11-4fdf-8566-da7f634b01dd", 1, "Commando" },
                    { "a25253ab-ae9e-4daf-b089-c140c687f78e", 1, "Vanguard" },
                    { "e43c68bd-546f-4741-b276-a6e71e3a45aa", 1, "Scoundrel" },
                    { "d259f96f-38ef-4944-85e1-83a6e5d06429", 1, "Gunslinger" },
                    { "343a14e8-71d0-4a1f-92ce-c4aea07e8274", 1, "Shadow" },
                    { "9433540f-aec3-4251-aae2-fc829b247a96", 2, "Powertech" },
                    { "81967562-6a95-46c6-8e54-3e6e83dc66a2", 2, "Operative" },
                    { "659dd997-9d7e-4de2-ac14-00c4a5ecd5cb", 2, "Sniper" },
                    { "16e34f34-aab4-4b5b-a4b3-37562cce2ad0", 2, "Assassin" },
                    { "6f1c2e6a-671e-4cf1-95e9-cea91aa1f493", 2, "Sorcerer" },
                    { "215dfdf6-0856-461e-86ff-056bf93213c9", 2, "Marauder" },
                    { "f1983dfb-685e-406f-a76a-2bf181ba651f", 2, "Juggernaut" },
                    { "73dad6d1-2732-4313-838c-8158571a34d4", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "16417352-3053-499b-9807-29d07e3b639e", "Nautolan" },
                    { "87d873a7-4dcd-4866-8696-473804d06972", "Togruta" },
                    { "fe4faf50-a9ed-40fc-a381-d8d468f00fed", "Cathar" },
                    { "634b00b9-16ba-46f0-a39e-7d471417bb0e", "Zabrak" },
                    { "4ae07e79-9be9-4cb3-9ef2-bb71ad6f2c36", "Twi'lek" },
                    { "b098f098-e9c7-4296-a110-f29af2a9415f", "Sith Pureblood" },
                    { "39723c72-8d37-44dc-befd-690e31d9627d", "Mirialan" },
                    { "014b6705-6250-4f53-8181-99080126ded5", "Miraluka" },
                    { "df1f5a62-2c37-4f01-ae60-7ceead294010", "Human" },
                    { "0d18b17c-85b1-478d-8414-460927d48a05", "Cyborg" },
                    { "89db6f41-e761-47a6-9eba-70bb46915d03", "Chiss" },
                    { "9b6c0f76-854e-4c77-a52f-05a24095254a", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "3cdd86f8-2ad2-4c6f-adfc-073a70d766e4", "The Leviathan" },
                    { "c2da4c81-a188-4c26-bed0-76168444d9b4", "Darth Malgus" },
                    { "92be1c3c-5f06-4394-90c5-327e115736ba", "Star Forge" },
                    { "dd26c9ba-d56d-4ba0-a79d-cc6df3b8e670", "Satele Shan" },
                    { "293d38ca-256a-46b4-84dc-0dfe8748899f", "Tulak Hord" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AccountId", "BaseThreadId", "CreatedOn", "DeletedOn", "IsDeleted", "Title" },
                values: new object[] { "4acc7085-cfde-4419-8fe9-897b26863f74", null, null, "11/13/2020 11:24 AM", null, false, "Test thread" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b6473574-fac1-4709-bb15-d2740fd77777");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "cc1f883d-f316-4233-b2bf-ed874600cc5d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d5b86efd-8149-457a-9fd4-8124317dd599");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f361d53a-c404-4445-b966-874dddaa60ce");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f8c3997d-2638-45b2-ac21-bdb3081069cb");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: "bef22f28-683b-4146-843d-c18eac817d86");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "16e34f34-aab4-4b5b-a4b3-37562cce2ad0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "215dfdf6-0856-461e-86ff-056bf93213c9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "343a14e8-71d0-4a1f-92ce-c4aea07e8274");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "508a67d9-8b11-4fdf-8566-da7f634b01dd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "590a3a01-0f20-4ea1-b7c1-87a476046220");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "659dd997-9d7e-4de2-ac14-00c4a5ecd5cb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6f1c2e6a-671e-4cf1-95e9-cea91aa1f493");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "73dad6d1-2732-4313-838c-8158571a34d4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "81967562-6a95-46c6-8e54-3e6e83dc66a2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9433540f-aec3-4251-aae2-fc829b247a96");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a07d7336-3ebe-4416-a61c-66a03442a161");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a25253ab-ae9e-4daf-b089-c140c687f78e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ac520662-4647-44ea-a699-fa1f1b75999a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d259f96f-38ef-4944-85e1-83a6e5d06429");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e43c68bd-546f-4741-b276-a6e71e3a45aa");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f1983dfb-685e-406f-a76a-2bf181ba651f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "014b6705-6250-4f53-8181-99080126ded5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0d18b17c-85b1-478d-8414-460927d48a05");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "16417352-3053-499b-9807-29d07e3b639e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "39723c72-8d37-44dc-befd-690e31d9627d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4ae07e79-9be9-4cb3-9ef2-bb71ad6f2c36");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "634b00b9-16ba-46f0-a39e-7d471417bb0e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "87d873a7-4dcd-4866-8696-473804d06972");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "89db6f41-e761-47a6-9eba-70bb46915d03");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9b6c0f76-854e-4c77-a52f-05a24095254a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b098f098-e9c7-4296-a110-f29af2a9415f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "df1f5a62-2c37-4f01-ae60-7ceead294010");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "fe4faf50-a9ed-40fc-a381-d8d468f00fed");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "293d38ca-256a-46b4-84dc-0dfe8748899f");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "3cdd86f8-2ad2-4c6f-adfc-073a70d766e4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "92be1c3c-5f06-4394-90c5-327e115736ba");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c2da4c81-a188-4c26-bed0-76168444d9b4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "dd26c9ba-d56d-4ba0-a79d-cc6df3b8e670");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "4acc7085-cfde-4419-8fe9-897b26863f74");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AvatarImagePath",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Backstory",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25000);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AvatarImage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
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
    }
}
