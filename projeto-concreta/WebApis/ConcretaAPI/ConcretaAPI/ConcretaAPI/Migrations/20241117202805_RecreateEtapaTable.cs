using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcretaAPI.Migrations
{
    /// <inheritdoc />
    public partial class RecreateEtapaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Etapas",
                columns: table => new
                {
                    IdEtapa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEtapa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataConclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdObra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapas", x => x.IdEtapa);
                    table.ForeignKey(
                        name: "FK_Etapas_Obras_IdObra",
                        column: x => x.IdObra,
                        principalTable: "Obras",
                        principalColumn: "IdObra",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etapas_IdObra",
                table: "Etapas",
                column: "IdObra");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etapas");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
