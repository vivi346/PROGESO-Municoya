using Microsoft.EntityFrameworkCore.Migrations;

namespace PROGESO.Data.Migrations
{
    public partial class AddEncDeparrtamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EncDepartamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido1 = table.Column<string>(nullable: false),
                    Apellido2 = table.Column<string>(nullable: false),
                    DepartamentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncDepartamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncDepartamento_Departament_DepartamentID",
                        column: x => x.DepartamentID,
                        principalTable: "Departament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncDepartamento_DepartamentID",
                table: "EncDepartamento",
                column: "DepartamentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncDepartamento");
        }
    }
}
