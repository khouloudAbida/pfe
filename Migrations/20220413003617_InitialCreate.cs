using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cin = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Telephone = table.Column<int>(nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Sexe = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    DateEmbauché = table.Column<DateTime>(nullable: false),
                    SoldeCongé = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.IdEmployee);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
