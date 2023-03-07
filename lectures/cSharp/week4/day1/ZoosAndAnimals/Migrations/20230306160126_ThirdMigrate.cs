using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZoosAndAnimals.Migrations
{
    public partial class ThirdMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Assign",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Assign");
        }
    }
}
