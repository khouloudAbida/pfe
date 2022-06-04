using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class updateemployee2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AlterColumn<int>(
                name: "ContratID",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Contrats_ContratID",
                table: "Employees",
                column: "ContratID",
                principalTable: "Contrats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Contrats_ContratID",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "ContratID",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Contrats_ContratID",
                table: "Employees",
                column: "ContratID",
                principalTable: "Contrats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
