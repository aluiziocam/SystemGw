using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemGw.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regioes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetorMecanicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetorMecanicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusDoServicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusDoServicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoOs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuadroServicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeClienteId = table.Column<int>(nullable: true),
                    DataAbertura = table.Column<DateTime>(nullable: false),
                    Municipio = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: true),
                    StatusDoAtendimento = table.Column<string>(nullable: true),
                    StatusDaMaquina = table.Column<string>(nullable: true),
                    TipoOsId = table.Column<int>(nullable: true),
                    SatisfacaoComServico = table.Column<string>(nullable: true),
                    NomeMecanicoId = table.Column<int>(nullable: true),
                    TempoOsAberta = table.Column<string>(nullable: true),
                    DataDaRota = table.Column<DateTime>(nullable: false),
                    StatusDoServicoId = table.Column<int>(nullable: true),
                    NumeroOs = table.Column<string>(nullable: true),
                    SetorMecanicoId = table.Column<int>(nullable: true),
                    ChassiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuadroServicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuadroServicos_Veiculos_ChassiId",
                        column: x => x.ChassiId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuadroServicos_Pessoas_NomeClienteId",
                        column: x => x.NomeClienteId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuadroServicos_Funcionarios_NomeMecanicoId",
                        column: x => x.NomeMecanicoId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuadroServicos_SetorMecanicos_SetorMecanicoId",
                        column: x => x.SetorMecanicoId,
                        principalTable: "SetorMecanicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuadroServicos_StatusDoServicos_StatusDoServicoId",
                        column: x => x.StatusDoServicoId,
                        principalTable: "StatusDoServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuadroServicos_TipoOs_TipoOsId",
                        column: x => x.TipoOsId,
                        principalTable: "TipoOs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuadroServicos_ChassiId",
                table: "QuadroServicos",
                column: "ChassiId");

            migrationBuilder.CreateIndex(
                name: "IX_QuadroServicos_NomeClienteId",
                table: "QuadroServicos",
                column: "NomeClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_QuadroServicos_NomeMecanicoId",
                table: "QuadroServicos",
                column: "NomeMecanicoId");

            migrationBuilder.CreateIndex(
                name: "IX_QuadroServicos_SetorMecanicoId",
                table: "QuadroServicos",
                column: "SetorMecanicoId");

            migrationBuilder.CreateIndex(
                name: "IX_QuadroServicos_StatusDoServicoId",
                table: "QuadroServicos",
                column: "StatusDoServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_QuadroServicos_TipoOsId",
                table: "QuadroServicos",
                column: "TipoOsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "QuadroServicos");

            migrationBuilder.DropTable(
                name: "Regioes");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "SetorMecanicos");

            migrationBuilder.DropTable(
                name: "StatusDoServicos");

            migrationBuilder.DropTable(
                name: "TipoOs");
        }
    }
}
