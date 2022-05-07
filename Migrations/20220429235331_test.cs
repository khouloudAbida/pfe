using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CongeID",
                table: "Conges",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CongeID",
                table: "Conges");
        }
    }
}
