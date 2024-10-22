using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablePlanoAlimentar2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Refeicao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tiporefeicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horario = table.Column<DateOnly>(type: "date", nullable: false),
                    ReceitaId = table.Column<int>(type: "int", nullable: true),
                    PlanoAlimentarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refeicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refeicao_PlanosAlimentares_PlanoAlimentarId",
                        column: x => x.PlanoAlimentarId,
                        principalTable: "PlanosAlimentares",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refeicao_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Refeicao_PlanoAlimentarId",
                table: "Refeicao",
                column: "PlanoAlimentarId");

            migrationBuilder.CreateIndex(
                name: "IX_Refeicao_ReceitaId",
                table: "Refeicao",
                column: "ReceitaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Refeicao");
        }
    }
}
