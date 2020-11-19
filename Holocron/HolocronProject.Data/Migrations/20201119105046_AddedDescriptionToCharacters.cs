using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddedDescriptionToCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Backstory",
                table: "Characters",
                maxLength: 25000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 25000);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Characters",
                maxLength: 25000,
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "962ac89a-2ecf-458b-adca-82baa390d035", "11/19/2020 10:50 AM", null, false, "PVP" },
                    { "08b03b33-f4e6-4abf-82e9-dc6dc7e1713d", "11/19/2020 10:50 AM", null, false, "PVE" },
                    { "53eac92b-3ad5-4ef4-8cd0-13cff7d7fc60", "11/19/2020 10:50 AM", null, false, "RP" },
                    { "90862a10-3d17-41e6-b145-1cee1f34e6a6", "11/19/2020 10:50 AM", null, false, "Guides" },
                    { "275895a5-39f8-4f2b-ba69-58b2264e7b37", "11/19/2020 10:50 AM", null, false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "02ec223f-51f8-4336-bf24-e88c00dbb7ab", 1, "Guardian" },
                    { "44b7141c-4908-4ac2-aefe-664098f5c2aa", 1, "Sentinel" },
                    { "41f17dba-bbaf-4312-91f9-787f0af346b5", 1, "Sage" },
                    { "ae4921e1-6899-4b94-b906-94216055c978", 1, "Commando" },
                    { "40b06e98-9c26-477d-b3b8-a90a537305bf", 1, "Vanguard" },
                    { "0b5c4d27-b933-4549-8990-915a013f7df6", 1, "Scoundrel" },
                    { "5a7611fe-01bb-4558-951f-c895420606f6", 1, "Gunslinger" },
                    { "ec560abc-030d-496d-adc0-1049a9523c1a", 1, "Shadow" },
                    { "0d72c88e-02bc-413b-aee2-01c4478ddf5b", 2, "Powertech" },
                    { "b8d1a94d-4a77-478f-9de7-f42d0c16e4e2", 2, "Operative" },
                    { "6c8be7f6-36f4-4bfa-99f3-ddf576c7d467", 2, "Sniper" },
                    { "9e19aa9a-9bba-43d6-b325-2d26f3cb6091", 2, "Assassin" },
                    { "84645b8d-c7b1-422c-883b-7e6142ad27ba", 2, "Sorcerer" },
                    { "d6764955-973f-4942-b37f-9f22ce310f06", 2, "Marauder" },
                    { "ab798037-520b-4e32-ad67-af1834c5b588", 2, "Juggernaut" },
                    { "fe334538-9bb7-4416-ba92-17061eafa892", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "6332a0e7-97d7-43c9-9e1e-2f683b063f7d", "Nautolan" },
                    { "af5ddea7-8d03-43b8-abcc-311c0ba56cb9", "Togruta" },
                    { "add6477d-9248-4fc9-8b50-45a998dd653d", "Cathar" },
                    { "28ced486-e7a3-46d0-be4b-b135c7bdfa22", "Zabrak" },
                    { "b8b3be4f-f302-4467-b6aa-5f1f2f5df3c9", "Twi'lek" },
                    { "e1537e82-bdad-4b5f-ae31-f0be4ca4bf0f", "Sith Pureblood" },
                    { "409ff2e9-ae6b-43ef-8eea-c8c32acc586b", "Mirialan" },
                    { "b60b2e85-5c8f-4213-8cad-7e41c0a8819e", "Miraluka" },
                    { "904aad6a-e507-4421-ac79-c6a349a986c1", "Human" },
                    { "63057747-2772-4a33-bf84-706eb21fc209", "Cyborg" },
                    { "cbc3307b-98ed-4188-9185-d21b918d9a37", "Chiss" },
                    { "446ca2bb-c7e7-42a2-aaa9-de74ecc76760", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "a489e5a5-cc2c-4504-95a3-ee1ea6eb7f46", "Tulak Hord" },
                    { "b8d8e990-9959-4d9c-b682-766a4fa963bf", "Darth Malgus" },
                    { "87eb2150-52fe-43b8-b50f-e0eb9e8a0507", "Star Forge" },
                    { "da991a16-8d44-44e1-a93a-566b53f6df02", "Satele Shan" },
                    { "a110d75a-3927-44d1-8844-02121074621a", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "08b03b33-f4e6-4abf-82e9-dc6dc7e1713d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "275895a5-39f8-4f2b-ba69-58b2264e7b37");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "53eac92b-3ad5-4ef4-8cd0-13cff7d7fc60");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "90862a10-3d17-41e6-b145-1cee1f34e6a6");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "962ac89a-2ecf-458b-adca-82baa390d035");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "02ec223f-51f8-4336-bf24-e88c00dbb7ab");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0b5c4d27-b933-4549-8990-915a013f7df6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0d72c88e-02bc-413b-aee2-01c4478ddf5b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "40b06e98-9c26-477d-b3b8-a90a537305bf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "41f17dba-bbaf-4312-91f9-787f0af346b5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "44b7141c-4908-4ac2-aefe-664098f5c2aa");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5a7611fe-01bb-4558-951f-c895420606f6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6c8be7f6-36f4-4bfa-99f3-ddf576c7d467");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "84645b8d-c7b1-422c-883b-7e6142ad27ba");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9e19aa9a-9bba-43d6-b325-2d26f3cb6091");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ab798037-520b-4e32-ad67-af1834c5b588");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ae4921e1-6899-4b94-b906-94216055c978");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b8d1a94d-4a77-478f-9de7-f42d0c16e4e2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d6764955-973f-4942-b37f-9f22ce310f06");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ec560abc-030d-496d-adc0-1049a9523c1a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "fe334538-9bb7-4416-ba92-17061eafa892");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "28ced486-e7a3-46d0-be4b-b135c7bdfa22");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "409ff2e9-ae6b-43ef-8eea-c8c32acc586b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "446ca2bb-c7e7-42a2-aaa9-de74ecc76760");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "63057747-2772-4a33-bf84-706eb21fc209");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "6332a0e7-97d7-43c9-9e1e-2f683b063f7d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "904aad6a-e507-4421-ac79-c6a349a986c1");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "add6477d-9248-4fc9-8b50-45a998dd653d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "af5ddea7-8d03-43b8-abcc-311c0ba56cb9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b60b2e85-5c8f-4213-8cad-7e41c0a8819e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b8b3be4f-f302-4467-b6aa-5f1f2f5df3c9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "cbc3307b-98ed-4188-9185-d21b918d9a37");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "e1537e82-bdad-4b5f-ae31-f0be4ca4bf0f");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "87eb2150-52fe-43b8-b50f-e0eb9e8a0507");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "a110d75a-3927-44d1-8844-02121074621a");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "a489e5a5-cc2c-4504-95a3-ee1ea6eb7f46");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b8d8e990-9959-4d9c-b682-766a4fa963bf");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "da991a16-8d44-44e1-a93a-566b53f6df02");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Characters");

            migrationBuilder.AlterColumn<string>(
                name: "Backstory",
                table: "Characters",
                type: "nvarchar(max)",
                maxLength: 25000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25000,
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
        }
    }
}
