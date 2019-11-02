using Microsoft.EntityFrameworkCore.Migrations;

namespace Cuentas_x_Cobrar_Carol.Migrations
{
    public partial class InitialMigratin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(nullable: true),
                    Vendedor = table.Column<string>(nullable: true),
                    Producto = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    TipoTransaccion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");
        }
    }
}
