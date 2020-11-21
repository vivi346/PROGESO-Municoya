using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROGESO.Data.Migrations
{
    public partial class addMoreFieldsToIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Distrito",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductoProveedor",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ced_juridica = table.Column<int>(nullable: false),
                    cod_prod = table.Column<int>(nullable: false),
                    precio = table.Column<float>(nullable: false),
                    cantidad = table.Column<int>(nullable: false),
                    FechaCompra = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoProveedor", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductoProveedor_Proveedores_ced_juridica",
                        column: x => x.ced_juridica,
                        principalTable: "Proveedores",
                        principalColumn: "ced_juridica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoProveedor_Producto_cod_prod",
                        column: x => x.cod_prod,
                        principalTable: "Producto",
                        principalColumn: "cod_prod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProveedor_ced_juridica",
                table: "ProductoProveedor",
                column: "ced_juridica");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProveedor_cod_prod",
                table: "ProductoProveedor",
                column: "cod_prod");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoProveedor");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Distrito",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "AspNetUsers");
        }
    }
}
