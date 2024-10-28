using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchemaWithSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FontesDeEnergia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EficienciaMedia = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FontesDeEnergia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruposPermissoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposPermissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EstadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissoesGruposPermissoes",
                columns: table => new
                {
                    GruposPermissoesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissoesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissoesGruposPermissoes", x => new { x.GruposPermissoesId, x.PermissoesId });
                    table.ForeignKey(
                        name: "FK_PermissoesGruposPermissoes_GruposPermissoes_GruposPermissoesId",
                        column: x => x.GruposPermissoesId,
                        principalTable: "GruposPermissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissoesGruposPermissoes_Permissoes_PermissoesId",
                        column: x => x.PermissoesId,
                        principalTable: "Permissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosGruposPermissoes",
                columns: table => new
                {
                    GruposPermissoesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuariosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosGruposPermissoes", x => new { x.GruposPermissoesId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_UsuariosGruposPermissoes_GruposPermissoes_GruposPermissoesId",
                        column: x => x.GruposPermissoesId,
                        principalTable: "GruposPermissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosGruposPermissoes_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usinas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CapacidadeKW = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusOperacional = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FonteDeEnergiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usinas_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usinas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usinas_FontesDeEnergia_FonteDeEnergiaId",
                        column: x => x.FonteDeEnergiaId,
                        principalTable: "FontesDeEnergia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProducoesDeEnergia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsinaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataProducao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnergiaGeradaKW = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    EficienciaOperacional = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducoesDeEnergia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProducoesDeEnergia_Usinas_UsinaId",
                        column: x => x.UsinaId,
                        principalTable: "Usinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CpfCnpj", "CreatedAt", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7604c4b4-8b17-435e-bbaa-5ed001c5720e"), "12345678901", new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9480), "João Silva", null },
                    { new Guid("7a94550a-eef4-4eae-b820-4cd1b2f07c20"), "34567890123", new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9490), "Carlos Souza", null },
                    { new Guid("dabfdbac-a4b7-4274-8294-340c0dfc4a8d"), "45678901234", new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9490), "Ana Santos", null },
                    { new Guid("e74fcae8-5d2f-421e-88b0-2f32dd70e6e4"), "23456789012", new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9480), "Maria Oliveira", null },
                    { new Guid("f904176b-25ca-43c9-adf1-68e062b7ed6a"), "56789012345", new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9490), "Pedro Costa", null }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "CreatedAt", "Name", "Sigla", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3143acca-2827-4a32-b739-8805edf3af9a"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9360), "São Paulo", "SP", null },
                    { new Guid("4557b4b6-850a-4b93-91a3-aff8d50525dc"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9370), "Minas Gerais", "MG", null },
                    { new Guid("649a1f82-0a64-4914-89d4-45d9118d6806"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9370), "Bahia", "BA", null },
                    { new Guid("f34d025b-01ad-44c5-8948-8097e4f18060"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9370), "Paraná", "PR", null },
                    { new Guid("f3526dfd-19b6-456d-a4f6-68f2d13e086d"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9360), "Rio de Janeiro", "RJ", null }
                });

            migrationBuilder.InsertData(
                table: "FontesDeEnergia",
                columns: new[] { "Id", "CreatedAt", "EficienciaMedia", "Tipo", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4b83e4d7-88ff-4c95-ae0a-1368e8360639"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9520), null, "Eólica", null },
                    { new Guid("6a6e8bb0-82ff-4732-b45b-711a779438bb"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9520), null, "Solar", null },
                    { new Guid("a17dfae0-833c-4337-9d75-8274e6aa9b9a"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9520), null, "Biomassa", null }
                });

            migrationBuilder.InsertData(
                table: "Permissoes",
                columns: new[] { "Id", "CreatedAt", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("13127d6a-0f7d-4a54-8c5e-fb7233e8b35d"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9570), "Usuarios", null },
                    { new Guid("3e6f8f63-8f6e-47ac-b82a-8bdb9e78e3a4"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9580), "Permissoes", null },
                    { new Guid("6a19c718-77e5-497b-8f6c-8e18eba2c710"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9570), "FontesDeEnergia", null },
                    { new Guid("839a397d-0c98-4ec8-a118-c0314f5991ce"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9560), "Usinas", null },
                    { new Guid("a3072ae8-afd3-44b7-b065-fcfa93081306"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9560), "Clientes", null },
                    { new Guid("afa59421-e26e-42f0-8795-35363a8890a5"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9580), "GruposPermissoes", null },
                    { new Guid("cf433852-d379-45f8-bc1d-84c38369fa1d"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9570), "Cidades", null },
                    { new Guid("ecf8a0d2-1007-4871-9605-301ba9531e38"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9570), "Estados", null },
                    { new Guid("fc8df1b5-3795-40d3-af39-b80891b987d3"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9570), "ProducaoDeEnergia", null }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "CreatedAt", "EstadoId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("31897765-7930-4244-8ece-359740eeb16d"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9430), new Guid("3143acca-2827-4a32-b739-8805edf3af9a"), "Campinas", null },
                    { new Guid("645a95a9-a39d-4e64-8cb6-ffd55fc13701"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9440), new Guid("4557b4b6-850a-4b93-91a3-aff8d50525dc"), "Uberlândia", null },
                    { new Guid("8e87e015-52db-495f-a589-0967a902ba26"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9440), new Guid("f34d025b-01ad-44c5-8948-8097e4f18060"), "Curitiba", null },
                    { new Guid("ec559354-6188-4524-90ed-48443c4f6537"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9440), new Guid("649a1f82-0a64-4914-89d4-45d9118d6806"), "Salvador", null },
                    { new Guid("f41a127c-08c9-4252-b506-a579f80baf60"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9430), new Guid("f3526dfd-19b6-456d-a4f6-68f2d13e086d"), "Niterói", null }
                });

            migrationBuilder.InsertData(
                table: "Usinas",
                columns: new[] { "Id", "CapacidadeKW", "CidadeId", "ClienteId", "CreatedAt", "DataInicio", "Endereco", "FonteDeEnergiaId", "Nome", "StatusOperacional", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("59776dd3-5897-4771-adcb-ac588d28f81d"), 1500.0m, new Guid("f41a127c-08c9-4252-b506-a579f80baf60"), new Guid("e74fcae8-5d2f-421e-88b0-2f32dd70e6e4"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9680), new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua B, 456", new Guid("4b83e4d7-88ff-4c95-ae0a-1368e8360639"), "Usina Eólica RJ", "Operando", null },
                    { new Guid("5e5d1725-3417-4611-9860-27dd6cc1ea90"), 1200.0m, new Guid("ec559354-6188-4524-90ed-48443c4f6537"), new Guid("dabfdbac-a4b7-4274-8294-340c0dfc4a8d"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua D, 321", new Guid("6a6e8bb0-82ff-4732-b45b-711a779438bb"), "Usina Solar BA", "Em Manutenção", null },
                    { new Guid("6b3bb259-3854-4e83-9469-6aae4f8ae97c"), 1000.0m, new Guid("31897765-7930-4244-8ece-359740eeb16d"), new Guid("7604c4b4-8b17-435e-bbaa-5ed001c5720e"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua A, 123", new Guid("6a6e8bb0-82ff-4732-b45b-711a779438bb"), "Usina Solar SP", "Operando", null },
                    { new Guid("6e47b6ce-bdd5-44be-ad74-b2f04b3503b1"), 800.0m, new Guid("645a95a9-a39d-4e64-8cb6-ffd55fc13701"), new Guid("7a94550a-eef4-4eae-b820-4cd1b2f07c20"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua C, 789", new Guid("a17dfae0-833c-4337-9d75-8274e6aa9b9a"), "Usina Biomassa MG", "Operando", null },
                    { new Guid("f93fab41-2852-4ed3-bc30-147cde9ab683"), 2000.0m, new Guid("8e87e015-52db-495f-a589-0967a902ba26"), new Guid("f904176b-25ca-43c9-adf1-68e062b7ed6a"), new DateTime(2024, 10, 27, 22, 47, 13, 524, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua E, 654", new Guid("4b83e4d7-88ff-4c95-ae0a-1368e8360639"), "Usina Eólica PR", "Operando", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoId",
                table: "Cidades",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CpfCnpj",
                table: "Clientes",
                column: "CpfCnpj",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesGruposPermissoes_PermissoesId",
                table: "PermissoesGruposPermissoes",
                column: "PermissoesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducoesDeEnergia_UsinaId",
                table: "ProducoesDeEnergia",
                column: "UsinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usinas_CidadeId",
                table: "Usinas",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Usinas_ClienteId",
                table: "Usinas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Usinas_FonteDeEnergiaId",
                table: "Usinas",
                column: "FonteDeEnergiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ClienteId",
                table: "Usuarios",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosGruposPermissoes_UsuariosId",
                table: "UsuariosGruposPermissoes",
                column: "UsuariosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissoesGruposPermissoes");

            migrationBuilder.DropTable(
                name: "ProducoesDeEnergia");

            migrationBuilder.DropTable(
                name: "UsuariosGruposPermissoes");

            migrationBuilder.DropTable(
                name: "Permissoes");

            migrationBuilder.DropTable(
                name: "Usinas");

            migrationBuilder.DropTable(
                name: "GruposPermissoes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "FontesDeEnergia");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
