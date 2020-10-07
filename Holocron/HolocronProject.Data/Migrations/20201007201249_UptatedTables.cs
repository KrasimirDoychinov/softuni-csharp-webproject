using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class UptatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountThreads_Thread_ThreadId",
                table: "AccountThreads");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Thread_ThreadId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Thread_BaseThread_BaseThreadId",
                table: "Thread");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Thread",
                table: "Thread");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseThread",
                table: "BaseThread");

            migrationBuilder.RenameTable(
                name: "Thread",
                newName: "Threads");

            migrationBuilder.RenameTable(
                name: "BaseThread",
                newName: "BaseThreads");

            migrationBuilder.RenameIndex(
                name: "IX_Thread_BaseThreadId",
                table: "Threads",
                newName: "IX_Threads_BaseThreadId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BaseThreads",
                newName: "Title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Threads",
                table: "Threads",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseThreads",
                table: "BaseThreads",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountThreads_Threads_ThreadId",
                table: "AccountThreads",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Threads_ThreadId",
                table: "Posts",
                column: "ThreadId",
                principalTable: "Threads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Threads_BaseThreads_BaseThreadId",
                table: "Threads",
                column: "BaseThreadId",
                principalTable: "BaseThreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountThreads_Threads_ThreadId",
                table: "AccountThreads");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Threads_ThreadId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Threads_BaseThreads_BaseThreadId",
                table: "Threads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Threads",
                table: "Threads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseThreads",
                table: "BaseThreads");

            migrationBuilder.RenameTable(
                name: "Threads",
                newName: "Thread");

            migrationBuilder.RenameTable(
                name: "BaseThreads",
                newName: "BaseThread");

            migrationBuilder.RenameIndex(
                name: "IX_Threads_BaseThreadId",
                table: "Thread",
                newName: "IX_Thread_BaseThreadId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "BaseThread",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thread",
                table: "Thread",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseThread",
                table: "BaseThread",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountThreads_Thread_ThreadId",
                table: "AccountThreads",
                column: "ThreadId",
                principalTable: "Thread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Thread_ThreadId",
                table: "Posts",
                column: "ThreadId",
                principalTable: "Thread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Thread_BaseThread_BaseThreadId",
                table: "Thread",
                column: "BaseThreadId",
                principalTable: "BaseThread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
