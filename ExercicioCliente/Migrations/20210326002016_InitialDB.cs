using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExercicioCliente.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Aniversario = table.Column<DateTime>(nullable: false),
                    Identificacao = table.Column<string>(nullable: true),
                    DiasRetorno = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "veiculosLeves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Cor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculosLeves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "veiculosPesados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Restricoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculosPesados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "locacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    DataLocacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_locacoes_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "locacoesVeiculosLeves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdLocacao = table.Column<int>(nullable: false),
                    locacaoId = table.Column<int>(nullable: true),
                    IdVeiculoLeve = table.Column<int>(nullable: false),
                    veiculoLeveId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locacoesVeiculosLeves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_locacoesVeiculosLeves_locacoes_locacaoId",
                        column: x => x.locacaoId,
                        principalTable: "locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_locacoesVeiculosLeves_veiculosLeves_veiculoLeveId",
                        column: x => x.veiculoLeveId,
                        principalTable: "veiculosLeves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "locacoesVeiculosPesados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdLocacao = table.Column<int>(nullable: false),
                    locacaoId = table.Column<int>(nullable: true),
                    IdVeiculoPesado = table.Column<int>(nullable: false),
                    veiculoPesadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locacoesVeiculosPesados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_locacoesVeiculosPesados_locacoes_locacaoId",
                        column: x => x.locacaoId,
                        principalTable: "locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_locacoesVeiculosPesados_veiculosPesados_veiculoPesadoId",
                        column: x => x.veiculoPesadoId,
                        principalTable: "veiculosPesados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_locacoes_ClienteId",
                table: "locacoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_locacoesVeiculosLeves_locacaoId",
                table: "locacoesVeiculosLeves",
                column: "locacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_locacoesVeiculosLeves_veiculoLeveId",
                table: "locacoesVeiculosLeves",
                column: "veiculoLeveId");

            migrationBuilder.CreateIndex(
                name: "IX_locacoesVeiculosPesados_locacaoId",
                table: "locacoesVeiculosPesados",
                column: "locacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_locacoesVeiculosPesados_veiculoPesadoId",
                table: "locacoesVeiculosPesados",
                column: "veiculoPesadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "locacoesVeiculosLeves");

            migrationBuilder.DropTable(
                name: "locacoesVeiculosPesados");

            migrationBuilder.DropTable(
                name: "veiculosLeves");

            migrationBuilder.DropTable(
                name: "locacoes");

            migrationBuilder.DropTable(
                name: "veiculosPesados");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
