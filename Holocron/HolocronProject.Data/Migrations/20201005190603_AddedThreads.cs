using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class AddedThreads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_AccountId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_AccountId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "ThreadId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BaseThread",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseThread", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Thread",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseThreadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thread", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thread_BaseThread_BaseThreadId",
                        column: x => x.BaseThreadId,
                        principalTable: "BaseThread",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_AccountThreads_Thread_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Thread",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ThreadId",
                table: "Posts",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountThreads_ThreadId",
                table: "AccountThreads",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Thread_BaseThreadId",
                table: "Thread",
                column: "BaseThreadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Thread_ThreadId",
                table: "Posts",
                column: "ThreadId",
                principalTable: "Thread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Thread_ThreadId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "AccountThreads");

            migrationBuilder.DropTable(
                name: "Thread");

            migrationBuilder.DropTable(
                name: "BaseThread");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ThreadId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ThreadId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountId",
                table: "Accounts",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_AccountId",
                table: "Accounts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
