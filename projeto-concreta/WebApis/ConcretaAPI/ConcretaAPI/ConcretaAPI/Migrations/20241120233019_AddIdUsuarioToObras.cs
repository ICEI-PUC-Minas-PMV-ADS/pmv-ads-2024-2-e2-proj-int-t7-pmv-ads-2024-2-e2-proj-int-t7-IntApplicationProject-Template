using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcretaAPI.Migrations
{
    public partial class AddIdUsuarioToObras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Adiciona a coluna IdUsuario à tabela Obras
            migrationBuilder.AddColumn<int>(
                name: "IdUsuario", // Nome da coluna
                table: "Obras",    // Tabela em que a coluna será adicionada
                type: "int",       // Tipo de dados da coluna
                nullable: true);   // Define como nullable (pode ser null); se quiser obrigatório, use false
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove a coluna IdUsuario caso a migration seja revertida
            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Obras");
        }
    }
}

