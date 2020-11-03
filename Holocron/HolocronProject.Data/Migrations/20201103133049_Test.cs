using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "5ba028d8-75dd-4284-817a-bc0ab0d22792", false, "PVP" },
                    { "2092ea46-e241-445d-b261-ddf9a60c316a", false, "PVE" },
                    { "d96ee4f4-cda0-4128-939f-4aa27718641f", false, "RP" },
                    { "3a107250-ad47-491b-af2d-ee73e55bfcbd", false, "Guides" },
                    { "a9aa7461-e983-4cc6-a943-df87d77e7a2d", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "7f7e9a34-a4c0-4b0c-a9ae-b6d9a4ab1372", 1, "Guardian" },
                    { "83764afa-c3fd-473d-af98-acac81e232c3", 1, "Sentinel" },
                    { "2d7918a6-11b4-4975-9b15-96f481642331", 1, "Sage" },
                    { "66728d65-3963-4d2c-a324-ba062d8cdd7e", 1, "Commando" },
                    { "94858512-595d-4963-9165-1511c8b2377c", 1, "Vanguard" },
                    { "46b30953-2afd-4c83-b182-c50d96929610", 1, "Scoundrel" },
                    { "6f697343-f4f3-4870-b338-0a669cb0b425", 1, "Gunslinger" },
                    { "4bc08106-f7ea-4ff4-9c0b-b763fd26ed0a", 1, "Shadow" },
                    { "03ef935a-d0a7-4cf9-aa80-848a059061dc", 2, "Powertech" },
                    { "c861a69e-a246-4b4d-b791-8c78863cfd83", 2, "Operative" },
                    { "09888700-e616-46c0-bce5-3a6f30731a36", 2, "Sniper" },
                    { "7bddebbf-1d52-43e0-981d-5bdb76252d3d", 2, "Assassin" },
                    { "8dc83559-7810-49a5-bb84-72770a9931e3", 2, "Sorcerer" },
                    { "88e08ecf-2349-4f48-8767-8ae548571059", 2, "Marauder" },
                    { "02f4a5a9-f669-4197-9c5e-149a1f833d00", 2, "Juggernaut" },
                    { "4a075f15-6145-43d2-b360-ac6debb0b872", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "8f368480-c998-4ebb-b4a8-fbac0452485b", "Nautolan" },
                    { "8589f4d4-daf4-4854-a24f-15d7c0a2c6da", "Togruta" },
                    { "32f627d7-831f-4029-a7c0-fc28536439e5", "Cathar" },
                    { "8d887ac2-03b1-4b3d-9f66-b29ffda99bc1", "Zabrak" },
                    { "40abe7b6-471e-4998-abb7-ffc7a87930b6", "Twi'lek" },
                    { "13836c70-523f-4bab-b765-332990de4b83", "Sith Pureblood" },
                    { "71f228cf-6e42-4b49-b01f-0a3be18ccafe", "Mirialan" },
                    { "62a4515f-87e4-46a6-9be4-5fd4f1119909", "Miraluka" },
                    { "47413c38-aabe-4104-8e96-28bfe26651a9", "Human" },
                    { "d51be1c4-3470-4bc6-93e6-5f99a509e877", "Cyborg" },
                    { "668d1eab-9dd9-4027-a12e-426492f6f847", "Chiss" },
                    { "7104306d-427c-4c69-a8ea-d0f1256f877f", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { "d402f01a-e67e-4349-9548-26da89042cc1", false, "Tulak Hord" },
                    { "5e326770-1898-454c-940b-91e185c20047", false, "Darth Malgus" },
                    { "d27c8d98-eb6f-46a2-80fd-014e26d24e77", false, "Star Forge" },
                    { "55b1e552-43f4-43bb-a420-7cbfe4694932", false, "Satele Shan" },
                    { "89572c9b-1197-4678-8b96-ea9d026a79d5", false, "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "2092ea46-e241-445d-b261-ddf9a60c316a");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "3a107250-ad47-491b-af2d-ee73e55bfcbd");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "5ba028d8-75dd-4284-817a-bc0ab0d22792");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a9aa7461-e983-4cc6-a943-df87d77e7a2d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d96ee4f4-cda0-4128-939f-4aa27718641f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "02f4a5a9-f669-4197-9c5e-149a1f833d00");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "03ef935a-d0a7-4cf9-aa80-848a059061dc");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "09888700-e616-46c0-bce5-3a6f30731a36");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "2d7918a6-11b4-4975-9b15-96f481642331");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "46b30953-2afd-4c83-b182-c50d96929610");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4a075f15-6145-43d2-b360-ac6debb0b872");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4bc08106-f7ea-4ff4-9c0b-b763fd26ed0a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "66728d65-3963-4d2c-a324-ba062d8cdd7e");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6f697343-f4f3-4870-b338-0a669cb0b425");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7bddebbf-1d52-43e0-981d-5bdb76252d3d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7f7e9a34-a4c0-4b0c-a9ae-b6d9a4ab1372");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "83764afa-c3fd-473d-af98-acac81e232c3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "88e08ecf-2349-4f48-8767-8ae548571059");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8dc83559-7810-49a5-bb84-72770a9931e3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "94858512-595d-4963-9165-1511c8b2377c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c861a69e-a246-4b4d-b791-8c78863cfd83");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "13836c70-523f-4bab-b765-332990de4b83");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "32f627d7-831f-4029-a7c0-fc28536439e5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "40abe7b6-471e-4998-abb7-ffc7a87930b6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "47413c38-aabe-4104-8e96-28bfe26651a9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "62a4515f-87e4-46a6-9be4-5fd4f1119909");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "668d1eab-9dd9-4027-a12e-426492f6f847");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "7104306d-427c-4c69-a8ea-d0f1256f877f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "71f228cf-6e42-4b49-b01f-0a3be18ccafe");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8589f4d4-daf4-4854-a24f-15d7c0a2c6da");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8d887ac2-03b1-4b3d-9f66-b29ffda99bc1");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8f368480-c998-4ebb-b4a8-fbac0452485b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d51be1c4-3470-4bc6-93e6-5f99a509e877");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "55b1e552-43f4-43bb-a420-7cbfe4694932");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "5e326770-1898-454c-940b-91e185c20047");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "89572c9b-1197-4678-8b96-ea9d026a79d5");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "d27c8d98-eb6f-46a2-80fd-014e26d24e77");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "d402f01a-e67e-4349-9548-26da89042cc1");
        }
    }
}
