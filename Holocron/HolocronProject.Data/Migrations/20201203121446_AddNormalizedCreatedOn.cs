using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddNormalizedCreatedOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "3d48b132-a9ce-4cb5-8690-8c71d51d4678");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "709bfbe2-a8b4-4004-8a55-443204848944");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "b937553f-5575-46b1-a718-bfcad61289ca");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d11996a0-8230-4509-b9c6-798a15f70a4c");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "da41270c-5a48-4ff2-8545-73f2e321bd7c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "171d30bd-ca63-4e83-8fd0-242c8ca5857a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1ea6aa77-88f1-42e1-8ac5-d228cb17eaea");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "315aa835-ec1b-4130-9c5b-0bdd2941f3d4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "31f68e13-c73b-4c1e-abd4-db30cd433925");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4a07c79c-c24d-4745-90d1-f2d0cb46b3b4");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4c8c13a2-aa73-4c00-a93e-79d36dd6c34d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5edb8341-ac60-4c1f-8a07-e1956c27ab40");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "72025818-3233-44dc-a8a5-44cabdecbbf7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "857b808f-aff0-4146-8c28-f9b36955b9d8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a9e88fce-3feb-4380-bab2-becb361f335d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b47120ae-b9e9-4a08-a7ae-dd033bd70fab");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b7a99d7e-7ad0-4a95-aafe-9093741cf96f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c2942cdf-16f9-4c9c-a820-b889231dd7b6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c684e0d3-09ce-43c4-8dcd-0affd400462c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c7dfd479-e309-4749-bc68-cb06c16ee28b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "d15d2cf5-7ca2-4793-b649-262093c89679");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0cf7be29-e48b-4b19-a5ce-6486740b003c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "23840dcc-934c-4847-8df1-a9d4d2851ac2");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2b4ed71d-74fa-4185-8ecd-d299207161ec");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4620dfc8-ac71-44c2-bece-ce9227d1b1b6");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "48e2e3eb-2204-4933-a128-a378dc189a2b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "66c98544-edcc-4fa5-b30e-cd6e0672bce8");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "88c96ac8-2348-4cbd-a396-b29614019088");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8dd08d3c-0237-450d-8b24-660dc52323ea");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b8115a22-fcf9-4983-8fa7-4d7e5c90a18e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d04c111c-2e58-4872-af17-73b3861eab80");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ebef3e58-124c-4116-976a-3bc5d86821b7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f1c93328-e3dc-437f-b2fa-50ee82d6b49d");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "2d91bd85-f901-4ef6-849a-180e07e3ebae");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "5163c626-c7dc-4d74-9045-48c2b9f7a2b8");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b6a9d8b5-dcd3-4b2e-ae0e-491f82f58d1f");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "ed43e646-23dc-4878-9fed-e1af2bc8537c");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "f25243a1-1612-49ee-9460-d4827778fda4");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedCreatedOn",
                table: "Threads",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedCreatedOn",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedCreatedOn",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedCreatedOn",
                table: "BaseThreads",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "Title" },
                values: new object[,]
                {
                    { "043d820d-70eb-4211-8a39-c05d48896c0c", "12/03/2020 12:14 PM", null, "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/03/2020 2:14 PM", "PVP" },
                    { "9cb4ecfc-29b2-4a84-8842-2d52d4366535", "12/03/2020 12:14 PM", null, "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/03/2020 2:14 PM", "PVE" },
                    { "ef194357-eee2-4b3b-b21b-f8ac1b665bc0", "12/03/2020 12:14 PM", null, "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/03/2020 2:14 PM", "RP" },
                    { "f41fdb57-1cc2-4510-b440-6b410e80d4bf", "12/03/2020 12:14 PM", null, "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/03/2020 2:14 PM", "Other" },
                    { "11503b5f-b841-40e7-8196-62b603b19b16", "12/03/2020 12:14 PM", null, "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/03/2020 2:14 PM", "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "cf277212-b3fd-43d9-9d52-1a43d584d196", 1, "Guardian" },
                    { "9d636c04-3160-44fd-90a2-7de25d10d3e5", 1, "Sentinel" },
                    { "bff4e6bf-67bb-4464-91ee-7168d251c9ee", 1, "Sage" },
                    { "ae0cea77-57db-4ba9-9dff-f4abbf29d5ed", 1, "Commando" },
                    { "61c2f600-0c8e-4a4b-b944-f3aaf815d0cd", 1, "Vanguard" },
                    { "468d3d66-7fe2-4cae-bdbf-ecdd75ec7afc", 1, "Scoundrel" },
                    { "4608d620-8bca-4c93-af12-e435795fa4e9", 1, "Gunslinger" },
                    { "7672a104-31ae-4f75-94ec-9cb68b72fd13", 1, "Shadow" },
                    { "a64e1acc-fa03-4c2d-96f4-7de39502878f", 2, "Powertech" },
                    { "8645dc5e-968a-4ee1-b676-bdf9fe57eb38", 2, "Operative" },
                    { "1ae10e83-1122-4d6e-adbe-18182ca05e43", 2, "Sniper" },
                    { "ef43c813-8dfd-4983-b5da-351153af213b", 2, "Assassin" },
                    { "229e4180-9731-4929-b84a-610c6d34c655", 2, "Sorcerer" },
                    { "ba9ce2db-fae8-44a1-a175-219e41d0a10f", 2, "Marauder" },
                    { "5d6eed3f-8097-4712-a828-c819a44820e1", 2, "Juggernaut" },
                    { "f33f1c83-e48e-4588-a783-b18588455bdd", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "ef932454-9c5f-4ad0-8a69-d61528e091e5", "Nautolan" },
                    { "69ac5397-ec9a-462e-8c04-046ec31b9fed", "Togruta" },
                    { "fa8934e2-6bb0-4fd0-b0a5-3b64a0fb8622", "Cathar" },
                    { "8cb5e9b5-877a-4fcd-a606-0dbc5afe6dda", "Zabrak" },
                    { "adf4dc27-5a67-4369-92b4-cf1b3940bcfb", "Twi'lek" },
                    { "f2c64fd5-4290-45e7-958f-fb5a041330c7", "Sith Pureblood" },
                    { "c859359f-fdd0-4fe8-bbc0-5de6081635cb", "Mirialan" },
                    { "b54bb197-9ffe-4b2e-8301-36073b9db484", "Miraluka" },
                    { "dd8ef0c3-859f-4aa4-a619-43fae7067aed", "Human" },
                    { "86995e1b-5dda-4890-93ad-7a501166698a", "Cyborg" },
                    { "edfe40dc-9106-43ff-a39e-5331f6269f93", "Chiss" },
                    { "a11b80fb-a017-4cb7-9496-547e61c9bffc", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "b20713ac-3404-46da-8b74-c3f664dd7edb", "Tulak Hord" },
                    { "28ac50fd-a0a9-4502-a8ae-c1b8f5617967", "Darth Malgus" },
                    { "762ee83e-8a13-4a6f-bdd4-b073482e83ca", "Star Forge" },
                    { "e5191968-c5dd-4faf-9cfd-db36b79a4c2d", "Satele Shan" },
                    { "821e0a5c-5248-4b37-af6c-4cc5f68cf1e1", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "043d820d-70eb-4211-8a39-c05d48896c0c");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "11503b5f-b841-40e7-8196-62b603b19b16");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "9cb4ecfc-29b2-4a84-8842-2d52d4366535");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "ef194357-eee2-4b3b-b21b-f8ac1b665bc0");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "f41fdb57-1cc2-4510-b440-6b410e80d4bf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "1ae10e83-1122-4d6e-adbe-18182ca05e43");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "229e4180-9731-4929-b84a-610c6d34c655");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "4608d620-8bca-4c93-af12-e435795fa4e9");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "468d3d66-7fe2-4cae-bdbf-ecdd75ec7afc");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "5d6eed3f-8097-4712-a828-c819a44820e1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "61c2f600-0c8e-4a4b-b944-f3aaf815d0cd");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7672a104-31ae-4f75-94ec-9cb68b72fd13");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8645dc5e-968a-4ee1-b676-bdf9fe57eb38");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9d636c04-3160-44fd-90a2-7de25d10d3e5");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "a64e1acc-fa03-4c2d-96f4-7de39502878f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ae0cea77-57db-4ba9-9dff-f4abbf29d5ed");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ba9ce2db-fae8-44a1-a175-219e41d0a10f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "bff4e6bf-67bb-4464-91ee-7168d251c9ee");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "cf277212-b3fd-43d9-9d52-1a43d584d196");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ef43c813-8dfd-4983-b5da-351153af213b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "f33f1c83-e48e-4588-a783-b18588455bdd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "69ac5397-ec9a-462e-8c04-046ec31b9fed");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "86995e1b-5dda-4890-93ad-7a501166698a");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8cb5e9b5-877a-4fcd-a606-0dbc5afe6dda");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "a11b80fb-a017-4cb7-9496-547e61c9bffc");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "adf4dc27-5a67-4369-92b4-cf1b3940bcfb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "b54bb197-9ffe-4b2e-8301-36073b9db484");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "c859359f-fdd0-4fe8-bbc0-5de6081635cb");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "dd8ef0c3-859f-4aa4-a619-43fae7067aed");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "edfe40dc-9106-43ff-a39e-5331f6269f93");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ef932454-9c5f-4ad0-8a69-d61528e091e5");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f2c64fd5-4290-45e7-958f-fb5a041330c7");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "fa8934e2-6bb0-4fd0-b0a5-3b64a0fb8622");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "28ac50fd-a0a9-4502-a8ae-c1b8f5617967");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "762ee83e-8a13-4a6f-bdd4-b073482e83ca");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "821e0a5c-5248-4b37-af6c-4cc5f68cf1e1");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b20713ac-3404-46da-8b74-c3f664dd7edb");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "e5191968-c5dd-4faf-9cfd-db36b79a4c2d");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "Threads");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "NormalizedCreatedOn",
                table: "BaseThreads");

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { "3d48b132-a9ce-4cb5-8690-8c71d51d4678", "11/29/2020 1:22 PM", null, "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "PVP" },
                    { "d11996a0-8230-4509-b9c6-798a15f70a4c", "11/29/2020 1:22 PM", null, "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "PVE" },
                    { "da41270c-5a48-4ff2-8545-73f2e321bd7c", "11/29/2020 1:22 PM", null, "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "RP" },
                    { "b937553f-5575-46b1-a718-bfcad61289ca", "11/29/2020 1:22 PM", null, "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "Other" },
                    { "709bfbe2-a8b4-4004-8a55-443204848944", "11/29/2020 1:22 PM", null, "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "d15d2cf5-7ca2-4793-b649-262093c89679", 1, "Guardian" },
                    { "4c8c13a2-aa73-4c00-a93e-79d36dd6c34d", 1, "Sentinel" },
                    { "b7a99d7e-7ad0-4a95-aafe-9093741cf96f", 1, "Sage" },
                    { "857b808f-aff0-4146-8c28-f9b36955b9d8", 1, "Commando" },
                    { "171d30bd-ca63-4e83-8fd0-242c8ca5857a", 1, "Vanguard" },
                    { "c2942cdf-16f9-4c9c-a820-b889231dd7b6", 1, "Scoundrel" },
                    { "c7dfd479-e309-4749-bc68-cb06c16ee28b", 1, "Gunslinger" },
                    { "4a07c79c-c24d-4745-90d1-f2d0cb46b3b4", 1, "Shadow" },
                    { "5edb8341-ac60-4c1f-8a07-e1956c27ab40", 2, "Powertech" },
                    { "315aa835-ec1b-4130-9c5b-0bdd2941f3d4", 2, "Operative" },
                    { "c684e0d3-09ce-43c4-8dcd-0affd400462c", 2, "Sniper" },
                    { "1ea6aa77-88f1-42e1-8ac5-d228cb17eaea", 2, "Assassin" },
                    { "31f68e13-c73b-4c1e-abd4-db30cd433925", 2, "Sorcerer" },
                    { "b47120ae-b9e9-4a08-a7ae-dd033bd70fab", 2, "Marauder" },
                    { "a9e88fce-3feb-4380-bab2-becb361f335d", 2, "Juggernaut" },
                    { "72025818-3233-44dc-a8a5-44cabdecbbf7", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0cf7be29-e48b-4b19-a5ce-6486740b003c", "Nautolan" },
                    { "66c98544-edcc-4fa5-b30e-cd6e0672bce8", "Togruta" },
                    { "f1c93328-e3dc-437f-b2fa-50ee82d6b49d", "Cathar" },
                    { "b8115a22-fcf9-4983-8fa7-4d7e5c90a18e", "Zabrak" },
                    { "2b4ed71d-74fa-4185-8ecd-d299207161ec", "Twi'lek" },
                    { "ebef3e58-124c-4116-976a-3bc5d86821b7", "Sith Pureblood" },
                    { "88c96ac8-2348-4cbd-a396-b29614019088", "Mirialan" },
                    { "d04c111c-2e58-4872-af17-73b3861eab80", "Miraluka" },
                    { "4620dfc8-ac71-44c2-bece-ce9227d1b1b6", "Human" },
                    { "8dd08d3c-0237-450d-8b24-660dc52323ea", "Cyborg" },
                    { "48e2e3eb-2204-4933-a128-a378dc189a2b", "Chiss" },
                    { "23840dcc-934c-4847-8df1-a9d4d2851ac2", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2d91bd85-f901-4ef6-849a-180e07e3ebae", "Tulak Hord" },
                    { "f25243a1-1612-49ee-9460-d4827778fda4", "Darth Malgus" },
                    { "ed43e646-23dc-4878-9fed-e1af2bc8537c", "Star Forge" },
                    { "5163c626-c7dc-4d74-9045-48c2b9f7a2b8", "Satele Shan" },
                    { "b6a9d8b5-dcd3-4b2e-ae0e-491f82f58d1f", "The Leviathan" }
                });
        }
    }
}
