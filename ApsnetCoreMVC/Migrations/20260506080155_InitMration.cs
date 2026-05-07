using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApsnetCoreMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitMration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fatture",
                columns: table => new
                {
                    FatturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEmissione = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataScadenza = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Servizio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrezzoUnitario = table.Column<decimal>(type: "decimal(16,2)", precision: 16, scale: 2, nullable: false),
                    Quantita = table.Column<int>(type: "int", nullable: false),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirizzo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatture", x => x.FatturaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fatture");
        }
    }
}
