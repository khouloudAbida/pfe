using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApplication.Migrations
{
    public partial class addSalaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "PrimeDeMois",
                table: "Contrats",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "FichePaies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mois = table.Column<int>(nullable: false),
                    Montant = table.Column<float>(nullable: false),
                    prime = table.Column<float>(nullable: false),
                    Annee = table.Column<int>(nullable: false),
                    dateVirement = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichePaies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FichePaies_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FichePaies_EmployeeID",
                table: "FichePaies",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FichePaies");

            migrationBuilder.DropColumn(
                name: "PrimeDeMois",
                table: "Contrats");
        }
    }
}
