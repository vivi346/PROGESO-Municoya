using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROGESO.Data.Migrations
{
    public partial class AddProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    cod_prod = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.cod_prod);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                 name: "Producto");
        }
    }
}
