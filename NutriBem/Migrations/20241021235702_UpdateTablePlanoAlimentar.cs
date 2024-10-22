using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablePlanoAlimentar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "PlanosAlimentares",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "PlanosAlimentares",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "PlanosAlimentares");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "PlanosAlimentares");
        }
    }
}
