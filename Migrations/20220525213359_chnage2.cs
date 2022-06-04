using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class chnage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
              name: "dateVirement",
              table: "FichePaies");
            migrationBuilder.AddColumn<DateTime>(
                name: "dateVirement",
                table: "FichePaies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "dateVirement",
                table: "FichePaies",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
