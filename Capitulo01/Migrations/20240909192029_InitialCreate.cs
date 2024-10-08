﻿using Microsoft.EntityFrameworkCore.Migrations;
using Modelo.Cadastros;

#nullable disable

namespace Capitulo01.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    InstituicaoID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.InstituicaoID);
                });

            migrationBuilder.InsertData(
                table: "Instituicoes",
                columns: new[] {"Nome", "Endereco"},
                values: new object[,]
                {
                    {"UFRGS","Porto Alegre"},
                    {"Feevale","Novo Hamburgo"},
                    {"Unisinos","São Leopoldo"},
                    {"PUCRS","Porto Alegre"},
                    {"Faccat","Taquara"},

                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstituicaoID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoID);
                    table.ForeignKey(
                        name: "FK_Departamento_Instituicoes_InstituicaoID",
                        column: x => x.InstituicaoID,
                        principalTable: "Instituicoes",
                        principalColumn: "InstituicaoID");
                });

            migrationBuilder.InsertData(
                    table: "Departamento",
                    columns: new[] { "Nome", "InstituicaoID" },
                    values: new object[,]
                    {
                        {"Saúde",1},
                        {"Tecnologia",2},
                        {"Saúde",3}

                    });

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_InstituicaoID",
                table: "Departamento",
                column: "InstituicaoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Instituicoes");
        }
    }
}
