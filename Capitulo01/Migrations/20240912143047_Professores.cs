﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Capitulo01.Migrations
{
    /// <inheritdoc />
    public partial class Professores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FotoMimeType",
                table: "Academicos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "Academicos",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    ProfessorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.ProfessorID);
                });

            migrationBuilder.InsertData(
               table: "Professores",
               columns: new[] { "Nome" },
               values: new object[,]
               {
                    {"Maria"},
                    {"Joao"},
                    {"Luisa"}

               });

            migrationBuilder.CreateTable(
                name: "CursoProfessor",
                columns: table => new
                {
                    CursoID = table.Column<long>(type: "bigint", nullable: false),
                    ProfessorID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoProfessor", x => new { x.CursoID, x.ProfessorID });
                    table.ForeignKey(
                        name: "FK_CursoProfessor_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoProfessor_Professores_ProfessorID",
                        column: x => x.ProfessorID,
                        principalTable: "Professores",
                        principalColumn: "ProfessorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursoProfessor_ProfessorID",
                table: "CursoProfessor",
                column: "ProfessorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursoProfessor");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.AlterColumn<string>(
                name: "FotoMimeType",
                table: "Academicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "Academicos",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }
    }
}
