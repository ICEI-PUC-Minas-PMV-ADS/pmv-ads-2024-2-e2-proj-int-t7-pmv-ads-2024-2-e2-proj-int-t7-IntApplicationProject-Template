using Microsoft.EntityFrameworkCore.Migrations;

public partial class CreateEtapaTable : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
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
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(name: "Etapas");
    }
}
