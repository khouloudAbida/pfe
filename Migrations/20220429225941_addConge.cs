using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class addConge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeConges",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeConges", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Conges",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DU = table.Column<DateTime>(nullable: false),
                    AU = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: false),
                    IdType = table.Column<int>(nullable: false),
                    TypeCongeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conges", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Conges_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conges_TypeConges_TypeCongeID",
                        column: x => x.TypeCongeID,
                        principalTable: "TypeConges",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conges_EmployeeID",
                table: "Conges",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Conges_TypeCongeID",
                table: "Conges",
                column: "TypeCongeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conges");

            migrationBuilder.DropTable(
                name: "TypeConges");
        }
    }
}
