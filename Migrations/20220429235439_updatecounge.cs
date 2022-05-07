using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class updatecounge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conges_TypeConges_TypeCongeID",
                table: "Conges");

            migrationBuilder.DropColumn(
                name: "CongeID",
                table: "Conges");

            migrationBuilder.AlterColumn<int>(
                name: "TypeCongeID",
                table: "Conges",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Conges_TypeConges_TypeCongeID",
                table: "Conges",
                column: "TypeCongeID",
                principalTable: "TypeConges",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conges_TypeConges_TypeCongeID",
                table: "Conges");

            migrationBuilder.AlterColumn<int>(
                name: "TypeCongeID",
                table: "Conges",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CongeID",
                table: "Conges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Conges_TypeConges_TypeCongeID",
                table: "Conges",
                column: "TypeCongeID",
                principalTable: "TypeConges",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
