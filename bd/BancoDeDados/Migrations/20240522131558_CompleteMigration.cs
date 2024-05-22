using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeDados.Migrations
{
    /// <inheritdoc />
    public partial class CompleteMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BancoDeSangues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdHemocentro = table.Column<int>(type: "INTEGER", nullable: false),
                    IdDoacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BancoDeSangues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DadosMedicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: false),
                    CRM = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosMedicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoDoacao = table.Column<string>(type: "TEXT", nullable: false),
                    HT = table.Column<double>(type: "REAL", nullable: false),
                    PressaoArterialSistolica = table.Column<double>(type: "REAL", nullable: false),
                    PressaoArterialDiastolica = table.Column<double>(type: "REAL", nullable: false),
                    Temperatura = table.Column<int>(type: "INTEGER", nullable: false),
                    VolumeColetar = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hemocentros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CEP = table.Column<double>(type: "REAL", nullable: false),
                    Referencia = table.Column<string>(type: "TEXT", nullable: false),
                    NomeHemocentro = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<double>(type: "REAL", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hemocentros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsInternado = table.Column<bool>(type: "INTEGER", nullable: false),
                    NomeHospital = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroLeito = table.Column<double>(type: "REAL", nullable: false),
                    Diagnostico = table.Column<string>(type: "TEXT", nullable: false),
                    ComponenteSanguineoSolicitado = table.Column<string>(type: "TEXT", nullable: false),
                    QuantidadeSolicitada = table.Column<int>(type: "INTEGER", nullable: false),
                    ModalidadeDaTransfusao = table.Column<string>(type: "TEXT", nullable: false),
                    DataDaTransfusao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IdMedico = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicoSolicitanteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_DadosMedicos_MedicoSolicitanteId",
                        column: x => x.MedicoSolicitanteId,
                        principalTable: "DadosMedicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedimentoAfereseDoadors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdDoador = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoComponenteSanguineo = table.Column<string>(type: "TEXT", nullable: false),
                    VolumeProduto = table.Column<double>(type: "REAL", nullable: false),
                    AnticoagulanteUsado = table.Column<string>(type: "TEXT", nullable: false),
                    HoraDaColeta = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimentoAfereseDoadors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcedimentoAfereseDoadors_Doadores_IdDoador",
                        column: x => x.IdDoador,
                        principalTable: "Doadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SangueColetados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdHemocentro = table.Column<int>(type: "INTEGER", nullable: false),
                    DataColeta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ComponenteSanguineo = table.Column<string>(type: "TEXT", nullable: false),
                    VolumeComponenteSanguineo = table.Column<double>(type: "REAL", nullable: false),
                    IdDoacao = table.Column<int>(type: "INTEGER", nullable: false),
                    NomeAnticoagulantePreservativo = table.Column<string>(type: "TEXT", nullable: false),
                    TemperaturaAdequada = table.Column<int>(type: "INTEGER", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GrupoABO = table.Column<string>(type: "TEXT", nullable: false),
                    FatorRh = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SangueColetados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SangueColetados_Doadores_IdDoacao",
                        column: x => x.IdDoacao,
                        principalTable: "Doadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SangueColetados_Hemocentros_IdHemocentro",
                        column: x => x.IdHemocentro,
                        principalTable: "Hemocentros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedimentoPacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPaciente = table.Column<int>(type: "INTEGER", nullable: false),
                    Diagnostico = table.Column<string>(type: "TEXT", nullable: false),
                    ProcedimentoTerapeutico = table.Column<string>(type: "TEXT", nullable: false),
                    VolumeExtracorporeoProcessado = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoComponente = table.Column<string>(type: "TEXT", nullable: false),
                    VolumeComponente = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoLiquido = table.Column<int>(type: "INTEGER", nullable: false),
                    VolumeLiquido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimentoPacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcedimentoPacientes_Pacientes_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_MedicoSolicitanteId",
                table: "Pacientes",
                column: "MedicoSolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoAfereseDoadors_IdDoador",
                table: "ProcedimentoAfereseDoadors",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoPacientes_IdPaciente",
                table: "ProcedimentoPacientes",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_SangueColetados_IdDoacao",
                table: "SangueColetados",
                column: "IdDoacao");

            migrationBuilder.CreateIndex(
                name: "IX_SangueColetados_IdHemocentro",
                table: "SangueColetados",
                column: "IdHemocentro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BancoDeSangues");

            migrationBuilder.DropTable(
                name: "ProcedimentoAfereseDoadors");

            migrationBuilder.DropTable(
                name: "ProcedimentoPacientes");

            migrationBuilder.DropTable(
                name: "SangueColetados");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Doadores");

            migrationBuilder.DropTable(
                name: "Hemocentros");

            migrationBuilder.DropTable(
                name: "DadosMedicos");
        }
    }
}
