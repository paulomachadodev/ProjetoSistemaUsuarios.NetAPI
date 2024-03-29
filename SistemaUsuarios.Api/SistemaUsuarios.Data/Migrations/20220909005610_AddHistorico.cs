﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaUsuarios.Data.Migrations
{
    public partial class AddHistorico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HISTORICO",
                columns: table => new
                {
                    IDHISTORICO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUSUARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OPERACAO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DATAHORA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DETALHES = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HISTORICO", x => x.IDHISTORICO);
                    table.ForeignKey(
                        name: "FK_HISTORICO_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "IDUSUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HISTORICO_IDUSUARIO",
                table: "HISTORICO",
                column: "IDUSUARIO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HISTORICO");
        }
    }
}
