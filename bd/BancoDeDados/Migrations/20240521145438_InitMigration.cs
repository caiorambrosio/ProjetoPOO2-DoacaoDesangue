using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeDados.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    CPF = table.Column<double>(type: "REAL", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OrgaoExpedidor = table.Column<string>(type: "TEXT", nullable: false),
                    Naturalidade = table.Column<string>(type: "TEXT", nullable: false),
                    Nacionalidade = table.Column<string>(type: "TEXT", nullable: false),
                    NomeDaMae = table.Column<string>(type: "TEXT", nullable: false),
                    NomeDoPai = table.Column<string>(type: "TEXT", nullable: false),
                    Emprego = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<double>(type: "REAL", nullable: false),
                    CEP = table.Column<double>(type: "REAL", nullable: false),
                    ABO = table.Column<string>(type: "TEXT", nullable: false),
                    IsPositivo = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsNegativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    Sexo = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
