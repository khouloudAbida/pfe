using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class addEmployeeUserRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserID",
                table: "Employees",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_UserID",
                table: "Employees",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_UserID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Employees");
        }
    }
}
