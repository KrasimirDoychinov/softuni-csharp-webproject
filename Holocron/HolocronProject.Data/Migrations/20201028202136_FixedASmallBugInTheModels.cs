using Microsoft.EntityFrameworkCore.Migrations;

namespace HolocronProject.Data.Migrations
{
    public partial class FixedASmallBugInTheModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faction",
                table: "Characters");

            migrationBuilder.AddColumn<bool>(
                name: "IsResolved",
                table: "PostReports",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsResolved",
                table: "PostReports");

            migrationBuilder.AddColumn<int>(
                name: "Faction",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
