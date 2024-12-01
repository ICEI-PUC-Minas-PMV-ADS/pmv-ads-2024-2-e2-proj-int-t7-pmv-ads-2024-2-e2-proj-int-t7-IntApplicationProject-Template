using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcretaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddEstaConcluidoToObra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstaConcluido",
                table: "Obras",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaConcluido",
                table: "Obras");
        }
    }
}
