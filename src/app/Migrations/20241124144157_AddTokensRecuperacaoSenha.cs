using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class AddTokensRecuperacaoSenha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("13127d6a-0f7d-4a54-8c5e-fb7233e8b35d"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("3e6f8f63-8f6e-47ac-b82a-8bdb9e78e3a4"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("6a19c718-77e5-497b-8f6c-8e18eba2c710"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("839a397d-0c98-4ec8-a118-c0314f5991ce"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("a3072ae8-afd3-44b7-b065-fcfa93081306"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("afa59421-e26e-42f0-8795-35363a8890a5"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("cf433852-d379-45f8-bc1d-84c38369fa1d"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("ecf8a0d2-1007-4871-9605-301ba9531e38"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("fc8df1b5-3795-40d3-af39-b80891b987d3"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("59776dd3-5897-4771-adcb-ac588d28f81d"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("5e5d1725-3417-4611-9860-27dd6cc1ea90"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("6b3bb259-3854-4e83-9469-6aae4f8ae97c"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("6e47b6ce-bdd5-44be-ad74-b2f04b3503b1"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("f93fab41-2852-4ed3-bc30-147cde9ab683"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("31897765-7930-4244-8ece-359740eeb16d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("645a95a9-a39d-4e64-8cb6-ffd55fc13701"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8e87e015-52db-495f-a589-0967a902ba26"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ec559354-6188-4524-90ed-48443c4f6537"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f41a127c-08c9-4252-b506-a579f80baf60"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("7604c4b4-8b17-435e-bbaa-5ed001c5720e"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("7a94550a-eef4-4eae-b820-4cd1b2f07c20"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("dabfdbac-a4b7-4274-8294-340c0dfc4a8d"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("e74fcae8-5d2f-421e-88b0-2f32dd70e6e4"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("f904176b-25ca-43c9-adf1-68e062b7ed6a"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("4b83e4d7-88ff-4c95-ae0a-1368e8360639"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("6a6e8bb0-82ff-4732-b45b-711a779438bb"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("a17dfae0-833c-4337-9d75-8274e6aa9b9a"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("3143acca-2827-4a32-b739-8805edf3af9a"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("4557b4b6-850a-4b93-91a3-aff8d50525dc"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("649a1f82-0a64-4914-89d4-45d9118d6806"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("f34d025b-01ad-44c5-8948-8097e4f18060"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("f3526dfd-19b6-456d-a4f6-68f2d13e086d"));

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TokensRecuperacaoSenha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId1 = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataExpiracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokensRecuperacaoSenha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TokensRecuperacaoSenha_Usuario_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CpfCnpj", "CreatedAt", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("31cb83e6-f32c-41ad-8e88-c22803237a14"), "45678901234", new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(495), "Ana Santos", null },
                    { new Guid("5deb620c-a234-4081-8cec-134bfb883a70"), "12345678901", new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(488), "João Silva", null },
                    { new Guid("5f2bc1db-b967-4a34-ba21-04e92b375877"), "23456789012", new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(492), "Maria Oliveira", null },
                    { new Guid("72fd29bd-e52d-49b0-aa43-ff911c2d4156"), "56789012345", new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(496), "Pedro Costa", null },
                    { new Guid("d9dff179-b1ff-40bf-8e57-45ab6bbf5080"), "34567890123", new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(493), "Carlos Souza", null }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "CreatedAt", "Name", "Sigla", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("160508a5-3ccf-42db-92ef-c9e670ba1dd0"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(293), "Bahia", "BA", null },
                    { new Guid("6c1e2141-6780-43f5-b6e5-4b37da741854"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(290), "Rio de Janeiro", "RJ", null },
                    { new Guid("753f4629-103b-4ae6-9dbb-18fcc5b5dabc"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(292), "Minas Gerais", "MG", null },
                    { new Guid("c9aa1db8-c29e-400c-a775-34e173f636cd"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(285), "São Paulo", "SP", null },
                    { new Guid("cee3eb34-a202-4f4a-9091-6e998b6667d6"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(295), "Paraná", "PR", null }
                });

            migrationBuilder.InsertData(
                table: "FontesDeEnergia",
                columns: new[] { "Id", "CreatedAt", "EficienciaMedia", "Tipo", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("27ab4595-594f-44c0-a7be-d0d3aef5d64a"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(537), null, "Biomassa", null },
                    { new Guid("2a5f4e1a-ea3c-4c46-b0a7-38ca857e4ca5"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(533), null, "Solar", null },
                    { new Guid("c60dcc51-3c2b-4db8-88a0-f2d088c4c56c"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(536), null, "Eólica", null }
                });

            migrationBuilder.InsertData(
                table: "Permissoes",
                columns: new[] { "Id", "CreatedAt", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0abe8067-f9c7-483b-bca3-8289fc794f6e"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(566), "Clientes", null },
                    { new Guid("19456c4d-915a-4c12-9deb-77f15d1aeca2"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(576), "Permissoes", null },
                    { new Guid("1ca65f82-1d80-4f33-a89a-160a14e016fb"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(568), "Estados", null },
                    { new Guid("34b1c2e9-976d-4bec-bbc9-1fbaaa4054f6"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(564), "Usinas", null },
                    { new Guid("4451eb3f-651f-4e41-9cee-fe0f185c862f"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(572), "ProducaoDeEnergia", null },
                    { new Guid("75dee31e-eba8-4e06-b81e-30196fd47d85"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(575), "GruposPermissoes", null },
                    { new Guid("b4f872ec-0275-4b64-b2f6-f60a95f4ba75"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(570), "FontesDeEnergia", null },
                    { new Guid("ba63cfa7-d3f4-4b3d-aab6-178f0b4e9722"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(567), "Cidades", null },
                    { new Guid("fff549f9-7ca5-43d5-8676-44d0d64aad7c"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(573), "Usuarios", null }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "CreatedAt", "EstadoId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2747e60e-7d49-4928-9900-c0f18359e104"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(444), new Guid("6c1e2141-6780-43f5-b6e5-4b37da741854"), "Niterói", null },
                    { new Guid("acc23d64-be08-47e3-8dda-0390ecae9b82"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(445), new Guid("753f4629-103b-4ae6-9dbb-18fcc5b5dabc"), "Uberlândia", null },
                    { new Guid("b45eb88a-7229-47ce-8495-f55c0385200b"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(448), new Guid("cee3eb34-a202-4f4a-9091-6e998b6667d6"), "Curitiba", null },
                    { new Guid("c04a635d-dbd4-49ae-98f3-1e5b4aff2418"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(440), new Guid("c9aa1db8-c29e-400c-a775-34e173f636cd"), "Campinas", null },
                    { new Guid("ff5fa089-e460-4b1e-9a33-e35597d8094a"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(447), new Guid("160508a5-3ccf-42db-92ef-c9e670ba1dd0"), "Salvador", null }
                });

            migrationBuilder.InsertData(
                table: "Usinas",
                columns: new[] { "Id", "CapacidadeKW", "CidadeId", "ClienteId", "CreatedAt", "DataInicio", "Endereco", "FonteDeEnergiaId", "Nome", "StatusOperacional", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4b1f5708-1d85-4e3d-a0dd-298a5fd82e56"), 1200.0m, new Guid("ff5fa089-e460-4b1e-9a33-e35597d8094a"), new Guid("31cb83e6-f32c-41ad-8e88-c22803237a14"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(729), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua D, 321", new Guid("2a5f4e1a-ea3c-4c46-b0a7-38ca857e4ca5"), "Usina Solar BA", "Em Manutenção", null },
                    { new Guid("4ea8167f-8858-4fb3-b3df-2ee30b62b619"), 1500.0m, new Guid("2747e60e-7d49-4928-9900-c0f18359e104"), new Guid("5f2bc1db-b967-4a34-ba21-04e92b375877"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(721), new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua B, 456", new Guid("c60dcc51-3c2b-4db8-88a0-f2d088c4c56c"), "Usina Eólica RJ", "Operando", null },
                    { new Guid("4ef9a52e-e74c-48e4-abde-124262346ba8"), 2000.0m, new Guid("b45eb88a-7229-47ce-8495-f55c0385200b"), new Guid("72fd29bd-e52d-49b0-aa43-ff911c2d4156"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(733), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua E, 654", new Guid("c60dcc51-3c2b-4db8-88a0-f2d088c4c56c"), "Usina Eólica PR", "Operando", null },
                    { new Guid("6c12ac42-e86b-48a5-b194-215ff3f55d82"), 800.0m, new Guid("acc23d64-be08-47e3-8dda-0390ecae9b82"), new Guid("d9dff179-b1ff-40bf-8e57-45ab6bbf5080"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(725), new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua C, 789", new Guid("27ab4595-594f-44c0-a7be-d0d3aef5d64a"), "Usina Biomassa MG", "Operando", null },
                    { new Guid("e3bbf2b7-7537-4974-b376-7cc37f1e465d"), 1000.0m, new Guid("c04a635d-dbd4-49ae-98f3-1e5b4aff2418"), new Guid("5deb620c-a234-4081-8cec-134bfb883a70"), new DateTime(2024, 11, 24, 11, 41, 57, 406, DateTimeKind.Local).AddTicks(712), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua A, 123", new Guid("2a5f4e1a-ea3c-4c46-b0a7-38ca857e4ca5"), "Usina Solar SP", "Operando", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TokensRecuperacaoSenha_UsuarioId1",
                table: "TokensRecuperacaoSenha",
                column: "UsuarioId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TokensRecuperacaoSenha");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("0abe8067-f9c7-483b-bca3-8289fc794f6e"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("19456c4d-915a-4c12-9deb-77f15d1aeca2"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("1ca65f82-1d80-4f33-a89a-160a14e016fb"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("34b1c2e9-976d-4bec-bbc9-1fbaaa4054f6"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("4451eb3f-651f-4e41-9cee-fe0f185c862f"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("75dee31e-eba8-4e06-b81e-30196fd47d85"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("b4f872ec-0275-4b64-b2f6-f60a95f4ba75"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("ba63cfa7-d3f4-4b3d-aab6-178f0b4e9722"));

            migrationBuilder.DeleteData(
                table: "Permissoes",
                keyColumn: "Id",
                keyValue: new Guid("fff549f9-7ca5-43d5-8676-44d0d64aad7c"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("4b1f5708-1d85-4e3d-a0dd-298a5fd82e56"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("4ea8167f-8858-4fb3-b3df-2ee30b62b619"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("4ef9a52e-e74c-48e4-abde-124262346ba8"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("6c12ac42-e86b-48a5-b194-215ff3f55d82"));

            migrationBuilder.DeleteData(
                table: "Usinas",
                keyColumn: "Id",
                keyValue: new Guid("e3bbf2b7-7537-4974-b376-7cc37f1e465d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2747e60e-7d49-4928-9900-c0f18359e104"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("acc23d64-be08-47e3-8dda-0390ecae9b82"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b45eb88a-7229-47ce-8495-f55c0385200b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c04a635d-dbd4-49ae-98f3-1e5b4aff2418"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff5fa089-e460-4b1e-9a33-e35597d8094a"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("31cb83e6-f32c-41ad-8e88-c22803237a14"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("5deb620c-a234-4081-8cec-134bfb883a70"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("5f2bc1db-b967-4a34-ba21-04e92b375877"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("72fd29bd-e52d-49b0-aa43-ff911c2d4156"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("d9dff179-b1ff-40bf-8e57-45ab6bbf5080"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("27ab4595-594f-44c0-a7be-d0d3aef5d64a"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("2a5f4e1a-ea3c-4c46-b0a7-38ca857e4ca5"));

            migrationBuilder.DeleteData(
                table: "FontesDeEnergia",
                keyColumn: "Id",
                keyValue: new Guid("c60dcc51-3c2b-4db8-88a0-f2d088c4c56c"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("160508a5-3ccf-42db-92ef-c9e670ba1dd0"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("6c1e2141-6780-43f5-b6e5-4b37da741854"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("753f4629-103b-4ae6-9dbb-18fcc5b5dabc"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("c9aa1db8-c29e-400c-a775-34e173f636cd"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("cee3eb34-a202-4f4a-9091-6e998b6667d6"));

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
        }
    }
}
