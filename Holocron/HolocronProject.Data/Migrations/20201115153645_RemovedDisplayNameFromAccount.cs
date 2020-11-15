using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class RemovedDisplayNameFromAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Threads_ThreadId",
                table: "Posts");

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
                name: "ThreadId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Threads_ThreadId",
                table: "Posts",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Threads_ThreadId",
                table: "Posts");

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

            migrationBuilder.AlterColumn<string>(
                name: "ThreadId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

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
                name: "FK_Posts_Threads_ThreadId",
                table: "Posts",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
