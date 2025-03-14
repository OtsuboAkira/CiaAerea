using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CiaAerea.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passageiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrimeiroNome = table.Column<string>(type: "TEXT", nullable: false),
                    UltimoSobrenome = table.Column<string>(type: "TEXT", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false),
                    Documento = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passageiros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroVoo = table.Column<int>(type: "INTEGER", nullable: false),
                    Origem = table.Column<string>(type: "TEXT", nullable: false),
                    Destino = table.Column<string>(type: "TEXT", nullable: false),
                    HorarioPartida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumeroTotalAssentos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ValorPassagem = table.Column<double>(type: "REAL", nullable: false),
                    Reserve = table.Column<int>(type: "INTEGER", nullable: false),
                    VooId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passagens_Voos_VooId",
                        column: x => x.VooId,
                        principalTable: "Voos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_VooId",
                table: "Passagens",
                column: "VooId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passageiros");

            migrationBuilder.DropTable(
                name: "Passagens");

            migrationBuilder.DropTable(
                name: "Voos");
        }
    }
}
