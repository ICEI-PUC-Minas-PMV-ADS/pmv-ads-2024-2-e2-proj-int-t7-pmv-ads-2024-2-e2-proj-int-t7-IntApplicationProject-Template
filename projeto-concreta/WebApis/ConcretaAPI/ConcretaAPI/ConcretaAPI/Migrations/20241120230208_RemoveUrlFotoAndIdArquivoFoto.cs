using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcretaAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUrlFotoAndIdArquivoFoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdArquivoFoto",
                table: "Obras");

            migrationBuilder.DropColumn(
                name: "UrlFoto",
                table: "Obras");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdArquivoFoto",
                table: "Obras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlFoto",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
