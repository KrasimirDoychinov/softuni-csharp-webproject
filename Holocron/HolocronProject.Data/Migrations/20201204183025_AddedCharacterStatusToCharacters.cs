using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddedCharacterStatusToCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "1efd7b2b-a3e6-43b2-ba7f-8916afbeb38b");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "679c7a6c-83c3-486a-a022-45d8c85df36f");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a63b76d7-4865-4c18-8318-7695c047a313");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "d9ff8c35-98e6-4e3f-bf7c-f62bca14d404");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "e2be8a23-f3d8-406c-93be-ecfe3b150c66");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "055744d0-6d4a-43b2-b6bd-e1fb3030d77d");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "24616d48-8536-419c-8747-bc8766e3b7c7");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "304d6589-0c34-44ec-9667-09c4cae61ee8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "44f91080-b271-4533-9915-96ab659d1908");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "614996b4-ffd1-47b7-bddf-6e3abf4aaf45");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6fc65d0f-f000-4166-8807-be60ff5b14d3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "7a0d9d7f-22d9-4e4e-9d43-a3ed3b55b3c1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "894813ab-42da-4ba8-870e-1fd86dd7f721");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "91e28d65-8cef-4e63-b7c3-0f68f95ecc58");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "aa112212-b364-40b2-8383-06b5dd0fc6ec");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b1b94002-4910-4365-88cc-6129884780b3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c1b9832b-df79-4c92-8ada-6213209e5671");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c2fa2190-828c-42a8-910c-dad922d0f320");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c8e808f1-f75a-41ba-83e6-76b1d776622f");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e584e1fe-cedb-48b0-a033-2a00d23493de");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e9a132bd-4c31-45df-adec-49623b6af32c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "09ace8a1-72b7-4220-945a-844f980245bf");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1d6b18ac-9a23-4841-a633-7943e367228e");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2e9bf790-68ac-4cd4-918b-4bbda58ffe13");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4096f3f0-1a88-462d-95e0-540147fb9875");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "861871be-249e-4f74-9942-5f7086ae8446");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "8e5c63ab-887a-44cd-9d94-f6bb6df46bba");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "9552dbed-8fe3-43c2-ba46-146905116a8f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "ba61df24-37e4-4be9-94ba-12fb3d44429f");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d8630b57-974e-431d-937c-b08f9dabb308");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "dad4d9aa-2f3e-4d97-b423-772873960edf");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "df06472a-34f6-45a5-bb60-2df5c30332d9");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "efe7056e-a463-4967-a5ad-0113617d94c6");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "1fa2a70e-69a4-4b03-aebd-def1bab14095");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "385e1a8b-a9d4-495c-8782-650393cbdb76");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "5ec5b33f-0980-49c3-a6be-8a8e108be7fb");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "6ca0c5e6-ee60-4d51-8051-62d59fa1fd53");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b0734d00-3054-4df5-be03-339cdde99736");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "CharacterStatus",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "09167c68-7cdf-4141-837d-9f6bd097c51e", new DateTime(2020, 12, 4, 18, 30, 25, 114, DateTimeKind.Utc).AddTicks(3053), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/04/2020 08:30 PM", null, "PVP" },
                    { "678bc661-d2a9-4e46-9331-de851f6bf30d", new DateTime(2020, 12, 4, 18, 30, 25, 117, DateTimeKind.Utc).AddTicks(86), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/04/2020 08:30 PM", null, "PVE" },
                    { "64f05672-d5f1-4b6d-95a5-f51972a93f04", new DateTime(2020, 12, 4, 18, 30, 25, 117, DateTimeKind.Utc).AddTicks(168), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/04/2020 08:30 PM", null, "RP" },
                    { "a0731313-94a0-40a5-989a-0b96fb74f5f6", new DateTime(2020, 12, 4, 18, 30, 25, 117, DateTimeKind.Utc).AddTicks(182), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/04/2020 08:30 PM", null, "Other" },
                    { "9bd461cd-5d6e-47b6-b028-7a6d2992ba3d", new DateTime(2020, 12, 4, 18, 30, 25, 117, DateTimeKind.Utc).AddTicks(192), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/04/2020 08:30 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "6a6aa58a-64b9-4af6-97e5-ea44a7130982", 1, "Guardian" },
                    { "0f7ddb30-bb86-484c-ae04-c73abbebd0cf", 1, "Sentinel" },
                    { "522d733a-26c2-4dca-9b78-84b800e26045", 1, "Sage" },
                    { "9c6e43a0-d5c9-440a-b94a-ebc71c907408", 1, "Commando" },
                    { "db3d2bab-2cf0-4352-ad77-a343a08431e1", 1, "Vanguard" },
                    { "02e9e065-8ce7-40a0-a355-3b21197a6134", 1, "Scoundrel" },
                    { "db550ff8-c726-4742-8ef4-edda3c318228", 1, "Gunslinger" },
                    { "8ad7f202-218a-4092-8ad6-8206ef5ca1e2", 1, "Shadow" },
                    { "ad6cde2e-fdbc-4ca7-b7fc-8c38f006f2b3", 2, "Powertech" },
                    { "0d83d8e6-f3bd-4e71-a735-9bd72b4edfc2", 2, "Operative" },
                    { "b54f7651-3ba3-4a89-a3ce-ce0c54779a8a", 2, "Sniper" },
                    { "bf1de329-070a-4fdd-a5b4-5099a5377eba", 2, "Assassin" },
                    { "c432e063-1acb-4939-ae23-11f1e5b7db4b", 2, "Sorcerer" },
                    { "39c02d16-25d3-41a0-b6bb-317c36d11cff", 2, "Marauder" },
                    { "e6b33b2e-051c-4d4d-9b77-fa8156669efd", 2, "Juggernaut" },
                    { "00b4e8ee-b621-4846-9319-66855256f6b8", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4401a516-8de7-4ab5-9d93-665debc7e6d3", "Nautolan" },
                    { "2b7c873a-a993-45ac-a8b7-d04984b3d97c", "Togruta" },
                    { "455387b1-e3d4-4606-8a33-6fc3b1425a10", "Cathar" },
                    { "1b1ddab1-68fa-4eb4-a13e-c3020007cb38", "Zabrak" },
                    { "1e178939-8e38-416a-a59f-179884bb6d70", "Twi'lek" },
                    { "655cf164-f535-4418-89ab-eccfd3ffd5fe", "Sith Pureblood" },
                    { "0d069e1f-4a33-4679-8e1d-42afbd8437ae", "Mirialan" },
                    { "747cc447-4ee1-490a-b607-91a1e571349d", "Miraluka" },
                    { "f68de4a0-f3dd-4c5c-a331-205322ab7767", "Human" },
                    { "d6b721e3-ae8d-416b-a980-31a3ddc62291", "Cyborg" },
                    { "f7e00413-9ad5-47bb-ba51-690255feacf0", "Chiss" },
                    { "2d32f234-c9f7-4d3c-ae27-54f39a0d584b", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "561947dd-d167-44b9-9278-f5932f1fa1a5", "Tulak Hord" },
                    { "e9602f3b-5246-4543-8234-6e6243781ce8", "Darth Malgus" },
                    { "b35e54c6-1682-4e7d-b442-00cb428355a4", "Star Forge" },
                    { "9954555c-2cf2-4cfb-a7be-1cc1833c21c8", "Satele Shan" },
                    { "fd908eb9-de71-478c-b9d6-d3e37fe47b04", "The Leviathan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "09167c68-7cdf-4141-837d-9f6bd097c51e");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "64f05672-d5f1-4b6d-95a5-f51972a93f04");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "678bc661-d2a9-4e46-9331-de851f6bf30d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "9bd461cd-5d6e-47b6-b028-7a6d2992ba3d");

            migrationBuilder.DeleteData(
                table: "BaseThreads",
                keyColumn: "Id",
                keyValue: "a0731313-94a0-40a5-989a-0b96fb74f5f6");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "00b4e8ee-b621-4846-9319-66855256f6b8");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "02e9e065-8ce7-40a0-a355-3b21197a6134");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0d83d8e6-f3bd-4e71-a735-9bd72b4edfc2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "0f7ddb30-bb86-484c-ae04-c73abbebd0cf");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "39c02d16-25d3-41a0-b6bb-317c36d11cff");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "522d733a-26c2-4dca-9b78-84b800e26045");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "6a6aa58a-64b9-4af6-97e5-ea44a7130982");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "8ad7f202-218a-4092-8ad6-8206ef5ca1e2");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "9c6e43a0-d5c9-440a-b94a-ebc71c907408");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "ad6cde2e-fdbc-4ca7-b7fc-8c38f006f2b3");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "b54f7651-3ba3-4a89-a3ce-ce0c54779a8a");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "bf1de329-070a-4fdd-a5b4-5099a5377eba");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "c432e063-1acb-4939-ae23-11f1e5b7db4b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "db3d2bab-2cf0-4352-ad77-a343a08431e1");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "db550ff8-c726-4742-8ef4-edda3c318228");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: "e6b33b2e-051c-4d4d-9b77-fa8156669efd");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "0d069e1f-4a33-4679-8e1d-42afbd8437ae");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1b1ddab1-68fa-4eb4-a13e-c3020007cb38");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "1e178939-8e38-416a-a59f-179884bb6d70");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2b7c873a-a993-45ac-a8b7-d04984b3d97c");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "2d32f234-c9f7-4d3c-ae27-54f39a0d584b");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "4401a516-8de7-4ab5-9d93-665debc7e6d3");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "455387b1-e3d4-4606-8a33-6fc3b1425a10");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "655cf164-f535-4418-89ab-eccfd3ffd5fe");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "747cc447-4ee1-490a-b607-91a1e571349d");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "d6b721e3-ae8d-416b-a980-31a3ddc62291");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f68de4a0-f3dd-4c5c-a331-205322ab7767");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: "f7e00413-9ad5-47bb-ba51-690255feacf0");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "561947dd-d167-44b9-9278-f5932f1fa1a5");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "9954555c-2cf2-4cfb-a7be-1cc1833c21c8");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "b35e54c6-1682-4e7d-b442-00cb428355a4");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "e9602f3b-5246-4543-8234-6e6243781ce8");

            migrationBuilder.DeleteData(
                table: "Servers",
                keyColumn: "Id",
                keyValue: "fd908eb9-de71-478c-b9d6-d3e37fe47b04");

            migrationBuilder.DropColumn(
                name: "CharacterStatus",
                table: "Characters");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "BaseThreads",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "NormalizedCreatedOn", "NormalizedDeletedOn", "Title" },
                values: new object[,]
                {
                    { "e2be8a23-f3d8-406c-93be-ecfe3b150c66", new DateTime(2020, 12, 3, 14, 45, 13, 76, DateTimeKind.Utc).AddTicks(8047), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to discuss everything PVP related. From questions about gear, stats, guides, discussions and everything else related to PVP in SWTOR. You can also post about PVP guilds, recruitment and more.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_76.png", false, "12/03/2020 04:45 PM", null, "PVP" },
                    { "d9ff8c35-98e6-4e3f-bf7c-f62bca14d404", new DateTime(2020, 12, 3, 14, 45, 13, 79, DateTimeKind.Utc).AddTicks(4170), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to talk about PVE. Best gear and stats for flashpoints, operations. You can post guides about PVE content here from leveling guides to FP and OP guides. You can also post about PVE guild recruitment and give information about your guild here.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_88.png", false, "12/03/2020 04:45 PM", null, "PVE" },
                    { "1efd7b2b-a3e6-43b2-ba7f-8916afbeb38b", new DateTime(2020, 12, 3, 14, 45, 13, 79, DateTimeKind.Utc).AddTicks(4258), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "If you want to RP on the site this is the place for you. This is the RP section of the forums where you can find all the forum RP you've ever wanted. You can also post about in-game RP and so on.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_423.png", false, "12/03/2020 04:45 PM", null, "RP" },
                    { "a63b76d7-4865-4c18-8318-7695c047a313", new DateTime(2020, 12, 3, 14, 45, 13, 79, DateTimeKind.Utc).AddTicks(4302), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is where you can talk about anything you want. It doesn't need to be just SWTOR or Star Wars. You can post about other games, cars, IT discussions, politics, and everything that can't be found on the other threads.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_8.png", false, "12/03/2020 04:45 PM", null, "Other" },
                    { "679c7a6c-83c3-486a-a022-45d8c85df36f", new DateTime(2020, 12, 3, 14, 45, 13, 79, DateTimeKind.Utc).AddTicks(4312), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the place to show of your character to other people. You can post cool, more modified images of your character. Here you can ask about items and how to combine them to make a cooler character in-game.", "https://cdn-www.swtor.com/sites/all/files/en/forums/forum_245.png", false, "12/03/2020 04:45 PM", null, "Fashion" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Faction", "Name" },
                values: new object[,]
                {
                    { "c2fa2190-828c-42a8-910c-dad922d0f320", 1, "Guardian" },
                    { "6fc65d0f-f000-4166-8807-be60ff5b14d3", 1, "Sentinel" },
                    { "e584e1fe-cedb-48b0-a033-2a00d23493de", 1, "Sage" },
                    { "7a0d9d7f-22d9-4e4e-9d43-a3ed3b55b3c1", 1, "Commando" },
                    { "24616d48-8536-419c-8747-bc8766e3b7c7", 1, "Vanguard" },
                    { "44f91080-b271-4533-9915-96ab659d1908", 1, "Scoundrel" },
                    { "91e28d65-8cef-4e63-b7c3-0f68f95ecc58", 1, "Gunslinger" },
                    { "aa112212-b364-40b2-8383-06b5dd0fc6ec", 1, "Shadow" },
                    { "304d6589-0c34-44ec-9667-09c4cae61ee8", 2, "Powertech" },
                    { "e9a132bd-4c31-45df-adec-49623b6af32c", 2, "Operative" },
                    { "c8e808f1-f75a-41ba-83e6-76b1d776622f", 2, "Sniper" },
                    { "055744d0-6d4a-43b2-b6bd-e1fb3030d77d", 2, "Assassin" },
                    { "b1b94002-4910-4365-88cc-6129884780b3", 2, "Sorcerer" },
                    { "614996b4-ffd1-47b7-bddf-6e3abf4aaf45", 2, "Marauder" },
                    { "c1b9832b-df79-4c92-8ada-6213209e5671", 2, "Juggernaut" },
                    { "894813ab-42da-4ba8-870e-1fd86dd7f721", 2, "Mercenary" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "4096f3f0-1a88-462d-95e0-540147fb9875", "Nautolan" },
                    { "9552dbed-8fe3-43c2-ba46-146905116a8f", "Togruta" },
                    { "8e5c63ab-887a-44cd-9d94-f6bb6df46bba", "Cathar" },
                    { "d8630b57-974e-431d-937c-b08f9dabb308", "Zabrak" },
                    { "1d6b18ac-9a23-4841-a633-7943e367228e", "Twi'lek" },
                    { "ba61df24-37e4-4be9-94ba-12fb3d44429f", "Sith Pureblood" },
                    { "09ace8a1-72b7-4220-945a-844f980245bf", "Mirialan" },
                    { "efe7056e-a463-4967-a5ad-0113617d94c6", "Miraluka" },
                    { "861871be-249e-4f74-9942-5f7086ae8446", "Human" },
                    { "df06472a-34f6-45a5-bb60-2df5c30332d9", "Cyborg" },
                    { "2e9bf790-68ac-4cd4-918b-4bbda58ffe13", "Chiss" },
                    { "dad4d9aa-2f3e-4d97-b423-772873960edf", "Rattaki" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "385e1a8b-a9d4-495c-8782-650393cbdb76", "Tulak Hord" },
                    { "5ec5b33f-0980-49c3-a6be-8a8e108be7fb", "Darth Malgus" },
                    { "b0734d00-3054-4df5-be03-339cdde99736", "Star Forge" },
                    { "6ca0c5e6-ee60-4d51-8051-62d59fa1fd53", "Satele Shan" },
                    { "1fa2a70e-69a4-4b03-aebd-def1bab14095", "The Leviathan" }
                });
        }
    }
}
