using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBem.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Refeicao_PlanosAlimentares_PlanoAlimentarId",
                table: "Refeicao");

            migrationBuilder.DropForeignKey(
                name: "FK_Refeicao_Receitas_ReceitaId",
                table: "Refeicao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refeicao",
                table: "Refeicao");

            migrationBuilder.RenameTable(
                name: "Refeicao",
                newName: "Refeicoes");

            migrationBuilder.RenameIndex(
                name: "IX_Refeicao_ReceitaId",
                table: "Refeicoes",
                newName: "IX_Refeicoes_ReceitaId");

            migrationBuilder.RenameIndex(
                name: "IX_Refeicao_PlanoAlimentarId",
                table: "Refeicoes",
                newName: "IX_Refeicoes_PlanoAlimentarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refeicoes",
                table: "Refeicoes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refeicoes_PlanosAlimentares_PlanoAlimentarId",
                table: "Refeicoes",
                column: "PlanoAlimentarId",
                principalTable: "PlanosAlimentares",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refeicoes_Receitas_ReceitaId",
                table: "Refeicoes",
                column: "ReceitaId",
                principalTable: "Receitas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Refeicoes_PlanosAlimentares_PlanoAlimentarId",
                table: "Refeicoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Refeicoes_Receitas_ReceitaId",
                table: "Refeicoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refeicoes",
                table: "Refeicoes");

            migrationBuilder.RenameTable(
                name: "Refeicoes",
                newName: "Refeicao");

            migrationBuilder.RenameIndex(
                name: "IX_Refeicoes_ReceitaId",
                table: "Refeicao",
                newName: "IX_Refeicao_ReceitaId");

            migrationBuilder.RenameIndex(
                name: "IX_Refeicoes_PlanoAlimentarId",
                table: "Refeicao",
                newName: "IX_Refeicao_PlanoAlimentarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refeicao",
                table: "Refeicao",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refeicao_PlanosAlimentares_PlanoAlimentarId",
                table: "Refeicao",
                column: "PlanoAlimentarId",
                principalTable: "PlanosAlimentares",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refeicao_Receitas_ReceitaId",
                table: "Refeicao",
                column: "ReceitaId",
                principalTable: "Receitas",
                principalColumn: "Id");
        }
    }
}
