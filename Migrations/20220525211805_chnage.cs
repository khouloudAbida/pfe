using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class chnage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NbDays",
                table: "Conges");

            migrationBuilder.AlterColumn<float>(
                name: "SoldeCongé",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<float>(
                name: "NbHours",
                table: "Conges",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NbHours",
                table: "Conges");

            migrationBuilder.AlterColumn<int>(
                name: "SoldeCongé",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<int>(
                name: "NbDays",
                table: "Conges",
                nullable: false,
                defaultValue: 0);
        }
    }
}
