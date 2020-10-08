using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class DeletedAccountThreadTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountThreads");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Threads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ForceAffiliation",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Threads_AccountId",
                table: "Threads",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Threads_Accounts_AccountId",
                table: "Threads",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Threads_Accounts_AccountId",
                table: "Threads");

            migrationBuilder.DropIndex(
                name: "IX_Threads_AccountId",
                table: "Threads");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Threads");

            migrationBuilder.DropColumn(
                name: "ForceAffiliation",
                table: "Characters");

            migrationBuilder.CreateTable(
                name: "AccountThreads",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    ThreadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountThreads", x => new { x.AccountId, x.ThreadId });
                    table.ForeignKey(
                        name: "FK_AccountThreads_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountThreads_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountThreads_ThreadId",
                table: "AccountThreads",
                column: "ThreadId");
        }
    }
}
