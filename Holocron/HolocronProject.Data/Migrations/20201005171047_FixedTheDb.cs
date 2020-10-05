using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class FixedTheDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Account_AccountId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Account_AccountId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Class_ClassId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Race_RaceId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Server_ServerId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Account_AccountId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Post_PostId",
                table: "PostTag");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTag_Tag_TagId",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Server",
                table: "Server");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Race",
                table: "Race");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Class",
                table: "Class");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Character",
                table: "Character");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "Server",
                newName: "Servers");

            migrationBuilder.RenameTable(
                name: "Race",
                newName: "Races");

            migrationBuilder.RenameTable(
                name: "PostTag",
                newName: "PostsTags");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Class",
                newName: "Classes");

            migrationBuilder.RenameTable(
                name: "Character",
                newName: "Characters");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "Accounts");

            migrationBuilder.RenameIndex(
                name: "IX_PostTag_TagId",
                table: "PostsTags",
                newName: "IX_PostsTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_AccountId",
                table: "Posts",
                newName: "IX_Posts_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Character_ServerId",
                table: "Characters",
                newName: "IX_Characters_ServerId");

            migrationBuilder.RenameIndex(
                name: "IX_Character_RaceId",
                table: "Characters",
                newName: "IX_Characters_RaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Character_ClassId",
                table: "Characters",
                newName: "IX_Characters_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Character_AccountId",
                table: "Characters",
                newName: "IX_Characters_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_AccountId",
                table: "Accounts",
                newName: "IX_Accounts_AccountId");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servers",
                table: "Servers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Races",
                table: "Races",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostsTags",
                table: "PostsTags",
                columns: new[] { "PostId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_AccountId",
                table: "Accounts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Accounts_AccountId",
                table: "Characters",
                column: "AccountId",
                principalTable: "Accounts",
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
                name: "FK_Posts_Accounts_AccountId",
                table: "Posts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostsTags_Posts_PostId",
                table: "PostsTags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostsTags_Tags_TagId",
                table: "PostsTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_AccountId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Accounts_AccountId",
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
                name: "FK_Posts_Accounts_AccountId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_PostsTags_Posts_PostId",
                table: "PostsTags");

            migrationBuilder.DropForeignKey(
                name: "FK_PostsTags_Tags_TagId",
                table: "PostsTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servers",
                table: "Servers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Races",
                table: "Races");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostsTags",
                table: "PostsTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "Servers",
                newName: "Server");

            migrationBuilder.RenameTable(
                name: "Races",
                newName: "Race");

            migrationBuilder.RenameTable(
                name: "PostsTags",
                newName: "PostTag");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Classes",
                newName: "Class");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "Character");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_PostsTags_TagId",
                table: "PostTag",
                newName: "IX_PostTag_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AccountId",
                table: "Post",
                newName: "IX_Post_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_ServerId",
                table: "Character",
                newName: "IX_Character_ServerId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_RaceId",
                table: "Character",
                newName: "IX_Character_RaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_ClassId",
                table: "Character",
                newName: "IX_Character_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_AccountId",
                table: "Character",
                newName: "IX_Character_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_AccountId",
                table: "Account",
                newName: "IX_Account_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Server",
                table: "Server",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Race",
                table: "Race",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag",
                columns: new[] { "PostId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Class",
                table: "Class",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Character",
                table: "Character",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Account_AccountId",
                table: "Account",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Account_AccountId",
                table: "Character",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Class_ClassId",
                table: "Character",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Race_RaceId",
                table: "Character",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Server_ServerId",
                table: "Character",
                column: "ServerId",
                principalTable: "Server",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Account_AccountId",
                table: "Post",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Post_PostId",
                table: "PostTag",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTag_Tag_TagId",
                table: "PostTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
