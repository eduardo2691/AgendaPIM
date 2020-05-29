using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NHibernate.Mapping;

namespace Agenda_Pim.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auditorios",
                columns: table => new
                {
                    IdAuditorio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAuditorio = table.Column<string>(nullable: true),
                    Capacidade = table.Column<int>(nullable: false),
                    ObeservacaoAuditorio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditorios", x => x.IdAuditorio);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    TipoUsuario = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    IdAgendamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HorarioInicial = table.Column<DateTime>(nullable: false),
                    HorarioFinal = table.Column<DateTime>(nullable: false),
                    IdAuditorio1 = table.Column<int>(nullable: true),
                    DescricaoEvento = table.Column<string>(nullable: true),
                    SttsTrigger = table.Column<bool>(nullable: false),
                    Proprietario = table.Column<int>(nullable: false),
                    IdUsuario1 = table.Column<int>(nullable: true),
                    ObservacaoAgendamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.IdAgendamento);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Auditorios_IdAuditorio1",
                        column: x => x.IdAuditorio1,
                        principalTable: "Auditorios",
                        principalColumn: "IdAuditorio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Usuarios_IdUsuario1",
                        column: x => x.IdUsuario1,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_IdAuditorio1",
                table: "Agendamentos",
                column: "IdAuditorio1");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_IdUsuario1",
                table: "Agendamentos",
                column: "IdUsuario1");
        }
       

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Auditorios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
