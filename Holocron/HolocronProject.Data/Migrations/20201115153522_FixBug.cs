using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class FixBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Characters_CharacterId",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Competitions_CompetitionId",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AspNetUsers_AccountId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Classes_ClassId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Servers_ServerId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReports_AspNetUsers_AccountId",
                table: "PostReports");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReports_Posts_PostId",
                table: "PostReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Threads_BaseThreads_BaseThreadId",
                table: "Threads");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "5188b91d-aa0c-4285-a452-ff172a624a53");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "586ca4ac-e834-4ac1-b735-c206c76b2bad");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "afc5c545-3f1d-49aa-8487-baf8552745d9");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "e1d0b8ce-8771-491f-9b6a-8820f34e29af");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f4f80c9a-3b26-41f9-86af-15b383126c6f");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: "da7772f4-f518-4183-8e1c-f1c40f3c8c41");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "058d6800-c97e-4295-aa81-81ea3cf07aad");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "198401d1-1d7d-4c68-8a08-77956462b59d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2a0fc67b-76b2-4459-a3fb-b9b2f11cd72c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "39258433-554c-49d0-81e5-b001047f9b9f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "498b8bfb-1d77-4834-bfbf-2ac37416d84b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "53693b2f-d390-4d55-a4d5-e9940dba4b50");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5fc6c37a-5d1b-4c8e-9bda-111b138b8f8a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "69ca1ee5-6513-4524-963f-1c8e02921817");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7267e1cb-96f9-4608-a2b8-6191bcdccbf2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a52245ac-ebea-4f93-97e6-ff5b916cb6fb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a5d133fe-2a0a-4896-9a14-c7a0f3575f04");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c6ae098d-b9f7-43b8-8088-089688d52bd4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "cbab07ba-98cb-4e7c-8538-63d7fa555dcf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d196d5ef-85bc-4308-bdf8-d45793c259cd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d9ee7c95-6be9-4944-9d8a-0479e4be5720");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "faecbe4b-458b-4410-a2c3-c014e880e039");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "053bc93f-a183-4151-8104-79c8637f5b20");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "27faa23e-3593-4bc5-9406-708ef49eecc3");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "45446412-6158-44bf-81b6-73563315758f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4ff7e39e-6cdc-4f95-838a-6e5ff6000d3c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6a1c4f3e-1dd6-4a85-92a5-6b0abadcde35");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "adaf0825-0bd7-4b55-82a7-38e1440876eb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b098fe2d-05de-4c71-9692-56384f037aaf");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d41b34d8-6f12-4b0e-a8cd-7f1e903a0687");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d793feb2-20a5-45e8-b5ae-db213b92f002");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e25fcac5-a0b7-4885-b2d2-613c63de96f9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e2cb909a-b47e-44bb-87e4-4407797014df");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f01eb3f2-fd14-4e8d-9cae-16b0512e0cf4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "32d8b8ca-06ee-46ab-8a65-c594a138b539");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "6e3795de-33e2-4706-b86e-454901622e24");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "854323a7-a896-4388-a4de-2522326eb32e");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "c8bf7e2d-7a64-42c4-9a03-f2f7114194ba");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "fef10acc-4dad-451d-b04e-f66af0210dbb");

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: "f7d2bef1-f0c8-4761-8fa3-7e38a0da503c");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "BaseThreadId",
                table: "Threads",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Threads",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostId",
                table: "PostReports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "PostReports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServerId",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RaceId",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "BugReports",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompetitionId",
                table: "Achievements",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CharacterId",
                table: "Achievements",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "f91650ea-8731-4128-88a1-55fe1e1ab6ed", null, false, "PVP" },
                    { "cbe696e2-8f80-4042-8291-11d75bd55f63", null, false, "PVE" },
                    { "123b6160-275c-433b-935a-680cc80a1d47", null, false, "RP" },
                    { "027ca17c-b249-4044-8300-4c33a9ef0043", null, false, "Guides" },
                    { "b2b7d44c-1ae4-46c2-82d5-552469fe4830", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "e973e9f8-3379-44a4-922e-14164829a45d", 1, "Guardian" },
                    { "0701935d-079a-4b29-b4d3-95b3a8bc889d", 1, "Sentinel" },
                    { "e85b475f-4486-4a5e-a543-87f158acadfc", 1, "Sage" },
                    { "8e9d2d00-b3df-43b5-aad8-79ae1044005e", 1, "Commando" },
                    { "66bd04d2-4ea2-49ca-8021-78b4ca4e5999", 1, "Vanguard" },
                    { "2ff3d5ab-494d-44cb-bdd7-58c519c1c9be", 1, "Scoundrel" },
                    { "c1c30c2b-eaf3-4b05-9271-3b3591751f31", 1, "Gunslinger" },
                    { "e34ad784-f0d5-46ba-8574-5df090c1ce56", 1, "Shadow" },
                    { "aa6e1197-c5c8-4d44-abfc-0a12523bebcb", 2, "Powertech" },
                    { "d73ec337-a233-4715-9150-2e045bae2539", 2, "Operative" },
                    { "2a789a91-3921-4b84-b26e-c924b634010a", 2, "Sniper" },
                    { "79b9b833-d80a-4893-8d1f-51143d76e920", 2, "Assassin" },
                    { "9bacf4ad-5175-498c-a163-3eb98adb1347", 2, "Sorcerer" },
                    { "17de8df7-ac2c-48a4-a03a-306c4c335676", 2, "Marauder" },
                    { "c6672ae4-9dae-4151-9e03-47300cd860ca", 2, "Juggernaut" },
                    { "322fa2a5-c24e-4aed-8223-619a9fe87ef8", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "549912d7-a83c-468a-8e82-891712431ca5", "Nautolan" },
                    { "0f852b66-acf5-4255-993f-3cb029221bd8", "Togruta" },
                    { "f03aeff2-ed13-43ed-8d55-183697ea12f4", "Cathar" },
                    { "e15ffa99-8524-4e8b-b758-b2fb72bc8815", "Zabrak" },
                    { "9bbe42b3-07ae-4cf2-aacc-5a0b85854087", "Twi'lek" },
                    { "19f812f6-562d-4545-8f7d-45cb46e5945e", "Sith Pureblood" },
                    { "ac4f2c85-5a92-47e2-80b0-279d3d06983a", "Mirialan" },
                    { "620ec530-6802-4bfc-b855-1d905f861725", "Miraluka" },
                    { "e518290e-7dec-47d7-90ea-f821bb739cb5", "Human" },
                    { "76ad1e08-c7d1-411b-be12-5ca3601cd53e", "Cyborg" },
                    { "eab5823a-29b4-45a4-8a6e-6439c4f92a8a", "Chiss" },
                    { "10b06c9d-d7d0-4a9c-abd8-3368d5360378", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "23052c2f-8d1f-418b-99a9-ab50ee392785", "Tulak Hord" },
                    { "1b53c5e5-3652-4002-bd89-c5d8811eac91", "Darth Malgus" },
                    { "1b690890-9bf3-4bd4-96f3-4381ab833344", "Star Forge" },
                    { "1e9f8b58-a2f3-4ce4-84ea-279e1932b684", "Satele Shan" },
                    { "e8bbc5f6-91d0-4132-a7a5-184135f1f7f7", "The Leviathan" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Characters_CharacterId",
                table: "Achievements",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Competitions_CompetitionId",
                table: "Achievements",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AspNetUsers_AccountId",
                table: "Characters",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Classes_ClassId",
                table: "Characters",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Servers_ServerId",
                table: "Characters",
                column: "ServerId",
                principalTable: "Servers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReports_AspNetUsers_AccountId",
                table: "PostReports",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReports_Posts_PostId",
                table: "PostReports",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Threads_BaseThreads_BaseThreadId",
                table: "Threads",
                column: "BaseThreadId",
                principalTable: "BaseThreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Characters_CharacterId",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Competitions_CompetitionId",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AspNetUsers_AccountId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Classes_ClassId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Servers_ServerId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReports_AspNetUsers_AccountId",
                table: "PostReports");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReports_Posts_PostId",
                table: "PostReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Threads_BaseThreads_BaseThreadId",
                table: "Threads");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "027ca17c-b249-4044-8300-4c33a9ef0043");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "123b6160-275c-433b-935a-680cc80a1d47");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b2b7d44c-1ae4-46c2-82d5-552469fe4830");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "cbe696e2-8f80-4042-8291-11d75bd55f63");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f91650ea-8731-4128-88a1-55fe1e1ab6ed");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0701935d-079a-4b29-b4d3-95b3a8bc889d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "17de8df7-ac2c-48a4-a03a-306c4c335676");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2a789a91-3921-4b84-b26e-c924b634010a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2ff3d5ab-494d-44cb-bdd7-58c519c1c9be");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "322fa2a5-c24e-4aed-8223-619a9fe87ef8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "66bd04d2-4ea2-49ca-8021-78b4ca4e5999");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "79b9b833-d80a-4893-8d1f-51143d76e920");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8e9d2d00-b3df-43b5-aad8-79ae1044005e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9bacf4ad-5175-498c-a163-3eb98adb1347");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "aa6e1197-c5c8-4d44-abfc-0a12523bebcb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c1c30c2b-eaf3-4b05-9271-3b3591751f31");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c6672ae4-9dae-4151-9e03-47300cd860ca");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d73ec337-a233-4715-9150-2e045bae2539");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e34ad784-f0d5-46ba-8574-5df090c1ce56");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e85b475f-4486-4a5e-a543-87f158acadfc");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e973e9f8-3379-44a4-922e-14164829a45d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0f852b66-acf5-4255-993f-3cb029221bd8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "10b06c9d-d7d0-4a9c-abd8-3368d5360378");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "19f812f6-562d-4545-8f7d-45cb46e5945e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "549912d7-a83c-468a-8e82-891712431ca5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "620ec530-6802-4bfc-b855-1d905f861725");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "76ad1e08-c7d1-411b-be12-5ca3601cd53e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9bbe42b3-07ae-4cf2-aacc-5a0b85854087");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ac4f2c85-5a92-47e2-80b0-279d3d06983a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e15ffa99-8524-4e8b-b758-b2fb72bc8815");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e518290e-7dec-47d7-90ea-f821bb739cb5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "eab5823a-29b4-45a4-8a6e-6439c4f92a8a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f03aeff2-ed13-43ed-8d55-183697ea12f4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1b53c5e5-3652-4002-bd89-c5d8811eac91");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1b690890-9bf3-4bd4-96f3-4381ab833344");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1e9f8b58-a2f3-4ce4-84ea-279e1932b684");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "23052c2f-8d1f-418b-99a9-ab50ee392785");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "e8bbc5f6-91d0-4132-a7a5-184135f1f7f7");

            migrationBuilder.AlterColumn<string>(
                name: "BaseThreadId",
                table: "Threads",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Threads",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PostId",
                table: "PostReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "PostReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ServerId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RaceId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "BugReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompetitionId",
                table: "Achievements",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CharacterId",
                table: "Achievements",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "5188b91d-aa0c-4285-a452-ff172a624a53", null, false, "PVP" },
                    { "f4f80c9a-3b26-41f9-86af-15b383126c6f", null, false, "PVE" },
                    { "afc5c545-3f1d-49aa-8487-baf8552745d9", null, false, "RP" },
                    { "e1d0b8ce-8771-491f-9b6a-8820f34e29af", null, false, "Guides" },
                    { "586ca4ac-e834-4ac1-b735-c206c76b2bad", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AccountId", "Backstory", "CharacterType", "ClassId", "DeletedOn", "ForceAffiliation", "Gender", "ImagePath", "IsDeleted", "Name", "RaceId", "ServerId", "Title" },
                values: new object[] { "da7772f4-f518-4183-8e1c-f1c40f3c8c41", null, "Test backstory", 1, null, null, 3, 1, null, false, "Test char", null, null, null });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "058d6800-c97e-4295-aa81-81ea3cf07aad", 1, "Guardian" },
                    { "7267e1cb-96f9-4608-a2b8-6191bcdccbf2", 1, "Sentinel" },
                    { "cbab07ba-98cb-4e7c-8538-63d7fa555dcf", 1, "Sage" },
                    { "69ca1ee5-6513-4524-963f-1c8e02921817", 1, "Commando" },
                    { "39258433-554c-49d0-81e5-b001047f9b9f", 1, "Vanguard" },
                    { "d196d5ef-85bc-4308-bdf8-d45793c259cd", 1, "Scoundrel" },
                    { "2a0fc67b-76b2-4459-a3fb-b9b2f11cd72c", 1, "Gunslinger" },
                    { "a5d133fe-2a0a-4896-9a14-c7a0f3575f04", 1, "Shadow" },
                    { "a52245ac-ebea-4f93-97e6-ff5b916cb6fb", 2, "Powertech" },
                    { "d9ee7c95-6be9-4944-9d8a-0479e4be5720", 2, "Operative" },
                    { "198401d1-1d7d-4c68-8a08-77956462b59d", 2, "Sniper" },
                    { "5fc6c37a-5d1b-4c8e-9bda-111b138b8f8a", 2, "Assassin" },
                    { "498b8bfb-1d77-4834-bfbf-2ac37416d84b", 2, "Sorcerer" },
                    { "faecbe4b-458b-4410-a2c3-c014e880e039", 2, "Marauder" },
                    { "53693b2f-d390-4d55-a4d5-e9940dba4b50", 2, "Juggernaut" },
                    { "c6ae098d-b9f7-43b8-8088-089688d52bd4", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "27faa23e-3593-4bc5-9406-708ef49eecc3", "Nautolan" },
                    { "053bc93f-a183-4151-8104-79c8637f5b20", "Togruta" },
                    { "d793feb2-20a5-45e8-b5ae-db213b92f002", "Cathar" },
                    { "4ff7e39e-6cdc-4f95-838a-6e5ff6000d3c", "Zabrak" },
                    { "adaf0825-0bd7-4b55-82a7-38e1440876eb", "Twi'lek" },
                    { "6a1c4f3e-1dd6-4a85-92a5-6b0abadcde35", "Sith Pureblood" },
                    { "45446412-6158-44bf-81b6-73563315758f", "Mirialan" },
                    { "f01eb3f2-fd14-4e8d-9cae-16b0512e0cf4", "Miraluka" },
                    { "d41b34d8-6f12-4b0e-a8cd-7f1e903a0687", "Human" },
                    { "b098fe2d-05de-4c71-9692-56384f037aaf", "Cyborg" },
                    { "e25fcac5-a0b7-4885-b2d2-613c63de96f9", "Chiss" },
                    { "e2cb909a-b47e-44bb-87e4-4407797014df", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "c8bf7e2d-7a64-42c4-9a03-f2f7114194ba", "The Leviathan" },
                    { "854323a7-a896-4388-a4de-2522326eb32e", "Darth Malgus" },
                    { "32d8b8ca-06ee-46ab-8a65-c594a138b539", "Star Forge" },
                    { "6e3795de-33e2-4706-b86e-454901622e24", "Satele Shan" },
                    { "fef10acc-4dad-451d-b04e-f66af0210dbb", "Tulak Hord" }
                });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "Id", "AccountId", "BaseThreadId", "CreatedOn", "DeletedOn", "IsDeleted", "Title" },
                values: new object[] { "f7d2bef1-f0c8-4761-8fa3-7e38a0da503c", null, null, "11/14/2020 11:27 AM", null, false, "Test thread" });

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Characters_CharacterId",
                table: "Achievements",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Competitions_CompetitionId",
                table: "Achievements",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AspNetUsers_AccountId",
                table: "Characters",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Classes_ClassId",
                table: "Characters",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Servers_ServerId",
                table: "Characters",
                column: "ServerId",
                principalTable: "Servers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReports_AspNetUsers_AccountId",
                table: "PostReports",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReports_Posts_PostId",
                table: "PostReports",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Threads_BaseThreads_BaseThreadId",
                table: "Threads",
                column: "BaseThreadId",
                principalTable: "BaseThreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
