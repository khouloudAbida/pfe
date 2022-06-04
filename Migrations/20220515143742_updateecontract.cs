using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class updateecontract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Contrats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_EmployeeID",
                table: "Contrats",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_Employees_EmployeeID",
                table: "Contrats",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "IdEmployee",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_Employees_EmployeeID",
                table: "Contrats");

            migrationBuilder.DropIndex(
                name: "IX_Contrats_EmployeeID",
                table: "Contrats");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Contrats");

            migrationBuilder.AddColumn<int>(
                name: "ContratID",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ContratID",
                table: "Employees",
                column: "ContratID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Contrats_ContratID",
                table: "Employees",
                column: "ContratID",
                principalTable: "Contrats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
