using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Toons.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tune",
                table: "Tune");

            migrationBuilder.RenameTable(
                name: "Tune",
                newName: "Tunes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tunes",
                table: "Tunes",
                column: "TuneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tunes",
                table: "Tunes");

            migrationBuilder.RenameTable(
                name: "Tunes",
                newName: "Tune");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tune",
                table: "Tune",
                column: "TuneId");
        }
    }
}
