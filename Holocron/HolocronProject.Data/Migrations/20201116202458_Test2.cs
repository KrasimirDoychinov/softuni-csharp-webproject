using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "4326e375-7d20-4dd7-a561-09100f5ca19b", "11/16/2020 8:24 PM", null, false, "PVP" },
                    { "94ab2771-7710-4d17-b4f6-a81444189f1a", "11/16/2020 8:24 PM", null, false, "PVE" },
                    { "0b55b082-5075-4d8b-9532-151f86020273", "11/16/2020 8:24 PM", null, false, "RP" },
                    { "ebf4971d-88f9-4b6a-9a04-505ae797ea8c", "11/16/2020 8:24 PM", null, false, "Guides" },
                    { "84603646-254e-4064-9285-5f16fdd1ace7", "11/16/2020 8:24 PM", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "82376362-02dd-4a80-aa24-30d0a0740dff", 1, "Guardian" },
                    { "c30191a1-7581-4ac7-9314-e293c3cf51eb", 1, "Sentinel" },
                    { "4c0355b3-c360-4d94-a21c-e84e9e0d97f1", 1, "Sage" },
                    { "7bfa7d08-443b-48ac-9f1f-e72a6e5d6eea", 1, "Commando" },
                    { "5f62630b-cb4b-4cfa-b0a9-f95987a241f0", 1, "Vanguard" },
                    { "90c5db7b-36a4-4c42-90b9-61e9cbd1e324", 1, "Scoundrel" },
                    { "4c6b3f26-1f13-49cd-a076-513cec8a0dae", 1, "Gunslinger" },
                    { "be6e2ba3-1e63-4505-9335-c34c633eed7d", 1, "Shadow" },
                    { "cd141500-8d0c-469b-81d9-6505efbac710", 2, "Powertech" },
                    { "36be12fd-6fae-4517-baa9-04c0b77bf227", 2, "Operative" },
                    { "e0e0bf4f-8949-4515-94fe-4362a9de5b56", 2, "Sniper" },
                    { "6aa60ab8-83e9-4b1f-b3dc-9155e72d72c2", 2, "Assassin" },
                    { "1b68d5bf-6bdd-438f-a25b-299cf593346d", 2, "Sorcerer" },
                    { "0bb90dbe-8b94-4f14-990b-3c778f40c1ab", 2, "Marauder" },
                    { "6c63fcb3-b704-4007-9ad5-145ba221a11f", 2, "Juggernaut" },
                    { "885d26c8-cc32-4b35-bb30-8937e962c435", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "b72f6737-e451-469c-ad0e-c89d49ab697e", "Nautolan" },
                    { "20e0b5b8-2363-4d7d-a9d9-07b5d464f968", "Togruta" },
                    { "4244427f-6f52-4f63-97f6-9fabf3ba8318", "Cathar" },
                    { "55375926-fb44-4723-aca8-3434c4f0dbe8", "Zabrak" },
                    { "d8af4819-883e-4b69-a04e-0a57046992d5", "Twi'lek" },
                    { "a2b97f93-fc84-491b-b206-bdfe2d419d80", "Sith Pureblood" },
                    { "db9aaa64-ac69-4667-bcff-82b2b4e6dbcc", "Mirialan" },
                    { "5837cdae-9967-4cb2-93a7-f31872bb1564", "Miraluka" },
                    { "b8bd8251-86da-4980-bb64-3006d497d326", "Human" },
                    { "ab8fd8e6-2035-4ef7-90c1-6d52e39c4603", "Cyborg" },
                    { "dbabc78c-abcc-4bc0-a336-33d9d5943b17", "Chiss" },
                    { "53884ac2-e0e3-4ee0-b8e8-fb7257ebf754", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "54d3b50a-06e5-4819-800c-30927379f6d5", "Tulak Hord" },
                    { "d48dcb02-5864-4e5d-aa3b-87697cde56db", "Darth Malgus" },
                    { "639fd3da-5cbd-43d4-943c-86f9031e335c", "Star Forge" },
                    { "1c16d3c4-d5ec-4b2c-9db2-429755ca462b", "Satele Shan" },
                    { "b2d0315d-5511-41e7-bdcb-251f52a3db84", "The Leviathan" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugReports_AspNetUsers_AccountId",
                table: "BugReports");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "0b55b082-5075-4d8b-9532-151f86020273");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "4326e375-7d20-4dd7-a561-09100f5ca19b");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "84603646-254e-4064-9285-5f16fdd1ace7");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "94ab2771-7710-4d17-b4f6-a81444189f1a");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ebf4971d-88f9-4b6a-9a04-505ae797ea8c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0bb90dbe-8b94-4f14-990b-3c778f40c1ab");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1b68d5bf-6bdd-438f-a25b-299cf593346d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "36be12fd-6fae-4517-baa9-04c0b77bf227");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4c0355b3-c360-4d94-a21c-e84e9e0d97f1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4c6b3f26-1f13-49cd-a076-513cec8a0dae");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5f62630b-cb4b-4cfa-b0a9-f95987a241f0");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6aa60ab8-83e9-4b1f-b3dc-9155e72d72c2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6c63fcb3-b704-4007-9ad5-145ba221a11f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7bfa7d08-443b-48ac-9f1f-e72a6e5d6eea");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "82376362-02dd-4a80-aa24-30d0a0740dff");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "885d26c8-cc32-4b35-bb30-8937e962c435");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "90c5db7b-36a4-4c42-90b9-61e9cbd1e324");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "be6e2ba3-1e63-4505-9335-c34c633eed7d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c30191a1-7581-4ac7-9314-e293c3cf51eb");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "cd141500-8d0c-469b-81d9-6505efbac710");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e0e0bf4f-8949-4515-94fe-4362a9de5b56");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "20e0b5b8-2363-4d7d-a9d9-07b5d464f968");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4244427f-6f52-4f63-97f6-9fabf3ba8318");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "53884ac2-e0e3-4ee0-b8e8-fb7257ebf754");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "55375926-fb44-4723-aca8-3434c4f0dbe8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "5837cdae-9967-4cb2-93a7-f31872bb1564");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a2b97f93-fc84-491b-b206-bdfe2d419d80");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ab8fd8e6-2035-4ef7-90c1-6d52e39c4603");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b72f6737-e451-469c-ad0e-c89d49ab697e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b8bd8251-86da-4980-bb64-3006d497d326");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d8af4819-883e-4b69-a04e-0a57046992d5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "db9aaa64-ac69-4667-bcff-82b2b4e6dbcc");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "dbabc78c-abcc-4bc0-a336-33d9d5943b17");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1c16d3c4-d5ec-4b2c-9db2-429755ca462b");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "54d3b50a-06e5-4819-800c-30927379f6d5");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "639fd3da-5cbd-43d4-943c-86f9031e335c");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b2d0315d-5511-41e7-bdcb-251f52a3db84");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "d48dcb02-5864-4e5d-aa3b-87697cde56db");

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "BugReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

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
    }
}
