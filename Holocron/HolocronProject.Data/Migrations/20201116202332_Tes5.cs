using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class Tes5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports");

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

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "BugReports",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "7e0b6a0e-ab89-437f-9b28-e843d422e72e", "11/16/2020 8:23 PM", null, false, "PVP" },
                    { "a0f4458f-52bb-47a7-8cdc-657cbf1deed8", "11/16/2020 8:23 PM", null, false, "PVE" },
                    { "e5c013ec-7974-4063-889b-4e0659161a12", "11/16/2020 8:23 PM", null, false, "RP" },
                    { "f6866d9b-b014-42e9-8036-dd9f8dd175d5", "11/16/2020 8:23 PM", null, false, "Guides" },
                    { "098f932a-1569-4b21-8df2-bd47d7e17ee2", "11/16/2020 8:23 PM", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "1f2ef869-1028-4f87-b459-03607e088a0b", 1, "Guardian" },
                    { "5c03b0d2-6e59-49fd-8773-71fcbada4697", 1, "Sentinel" },
                    { "6cc0f92f-211d-4ca3-b4c0-e5c77f3f9916", 1, "Sage" },
                    { "2603271d-2310-45a0-bcef-513cec42ace5", 1, "Commando" },
                    { "73742e0f-a27a-4bbb-9c95-fe06b90041ba", 1, "Vanguard" },
                    { "db8e2d8b-b330-4bad-95fd-ada87816039a", 1, "Scoundrel" },
                    { "f620d0a0-f345-4463-8681-307a1f19040a", 1, "Gunslinger" },
                    { "0f3603ca-d442-4374-adda-eb5d41655cad", 1, "Shadow" },
                    { "b8cbeb3e-b0ef-4043-94da-28b7dcd98cc3", 2, "Powertech" },
                    { "510ed473-63e2-4776-a00d-6c9d75459d3c", 2, "Operative" },
                    { "90da8deb-4dc2-48cc-8ab8-a0f72a66a404", 2, "Sniper" },
                    { "2b215e75-4448-43bb-8ce6-872852031bf8", 2, "Assassin" },
                    { "0d65c8e9-842c-4f8f-af92-5c25c4362ce6", 2, "Sorcerer" },
                    { "3b4decd1-ced8-4ca9-8747-43b81e5f78a8", 2, "Marauder" },
                    { "b693dd69-1492-4e65-887c-9008d9a64d95", 2, "Juggernaut" },
                    { "b74ed853-6136-4ea3-93fe-e95719509a2d", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1e384ed1-c3fa-4efe-99e7-51790e67e25d", "Nautolan" },
                    { "fd2075e0-1297-45f9-9c8b-f17465812137", "Togruta" },
                    { "b38b25d5-d01b-4762-8887-c93ba9384343", "Cathar" },
                    { "e53b04e2-6d38-4a92-ab94-309080d70565", "Zabrak" },
                    { "4fa7e136-b0de-4e82-be36-cef3f2cf40b0", "Twi'lek" },
                    { "59b4ffaf-2c21-43f7-bbff-aa4eb002523e", "Sith Pureblood" },
                    { "9e2ba48c-0272-4836-8c9b-c3251d59d007", "Mirialan" },
                    { "f3d95e07-61bc-4d65-9945-252e12871401", "Miraluka" },
                    { "50d597b9-57c8-4d36-a421-817a0a680363", "Human" },
                    { "641ee699-0591-4842-8d0e-8963dee84476", "Cyborg" },
                    { "cf4f374c-a811-4e12-be2c-fe39e9354c1c", "Chiss" },
                    { "71255541-9d44-44ca-8db9-9d0f8a53654b", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "f03116cc-41c2-4364-8081-f8f2abf9df2c", "Tulak Hord" },
                    { "56167fbe-189b-4bb8-927c-16cc9ca39db6", "Darth Malgus" },
                    { "39a9e9b2-6a24-4039-a7e6-189e839842b4", "Star Forge" },
                    { "1882e9b9-2dc9-4f8f-9a41-2dde2724b89a", "Satele Shan" },
                    { "9a0751da-470d-4d0d-a769-0884079d3032", "The Leviathan" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "098f932a-1569-4b21-8df2-bd47d7e17ee2");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "7e0b6a0e-ab89-437f-9b28-e843d422e72e");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a0f4458f-52bb-47a7-8cdc-657cbf1deed8");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "e5c013ec-7974-4063-889b-4e0659161a12");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f6866d9b-b014-42e9-8036-dd9f8dd175d5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0d65c8e9-842c-4f8f-af92-5c25c4362ce6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0f3603ca-d442-4374-adda-eb5d41655cad");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1f2ef869-1028-4f87-b459-03607e088a0b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2603271d-2310-45a0-bcef-513cec42ace5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2b215e75-4448-43bb-8ce6-872852031bf8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "3b4decd1-ced8-4ca9-8747-43b81e5f78a8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "510ed473-63e2-4776-a00d-6c9d75459d3c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5c03b0d2-6e59-49fd-8773-71fcbada4697");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6cc0f92f-211d-4ca3-b4c0-e5c77f3f9916");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "73742e0f-a27a-4bbb-9c95-fe06b90041ba");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "90da8deb-4dc2-48cc-8ab8-a0f72a66a404");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b693dd69-1492-4e65-887c-9008d9a64d95");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b74ed853-6136-4ea3-93fe-e95719509a2d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b8cbeb3e-b0ef-4043-94da-28b7dcd98cc3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "db8e2d8b-b330-4bad-95fd-ada87816039a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f620d0a0-f345-4463-8681-307a1f19040a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1e384ed1-c3fa-4efe-99e7-51790e67e25d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4fa7e136-b0de-4e82-be36-cef3f2cf40b0");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "50d597b9-57c8-4d36-a421-817a0a680363");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "59b4ffaf-2c21-43f7-bbff-aa4eb002523e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "641ee699-0591-4842-8d0e-8963dee84476");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "71255541-9d44-44ca-8db9-9d0f8a53654b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9e2ba48c-0272-4836-8c9b-c3251d59d007");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b38b25d5-d01b-4762-8887-c93ba9384343");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "cf4f374c-a811-4e12-be2c-fe39e9354c1c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e53b04e2-6d38-4a92-ab94-309080d70565");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f3d95e07-61bc-4d65-9945-252e12871401");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "fd2075e0-1297-45f9-9c8b-f17465812137");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1882e9b9-2dc9-4f8f-9a41-2dde2724b89a");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "39a9e9b2-6a24-4039-a7e6-189e839842b4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "56167fbe-189b-4bb8-927c-16cc9ca39db6");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "9a0751da-470d-4d0d-a769-0884079d3032");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "f03116cc-41c2-4364-8081-f8f2abf9df2c");

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "BugReports",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
