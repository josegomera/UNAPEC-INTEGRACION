using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeachTreeApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsientosExternos",
                columns: table => new
                {
                    IdAsiento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: false),
                    NoAsiento = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Cuenta = table.Column<string>(nullable: true),
                    TipoMovimiento = table.Column<int>(nullable: false),
                    MontoMovimiento = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsientosExternos", x => x.IdAsiento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsientosExternos");
        }
    }
}
