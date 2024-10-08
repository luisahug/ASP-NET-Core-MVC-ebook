﻿// <auto-generated />
using System;
using Capitulo01.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Capitulo01.Migrations
{
    [DbContext(typeof(IESContext))]
    [Migration("20240912143047_Professores")]
    partial class Professores
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Modelo.Cadastros.Curso", b =>
                {
                    b.Property<long?>("CursoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("CursoID"));

                    b.Property<long?>("DepartamentoID")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CursoID");

                    b.HasIndex("DepartamentoID");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Modelo.Cadastros.CursoDisciplina", b =>
                {
                    b.Property<long?>("CursoID")
                        .HasColumnType("bigint");

                    b.Property<long?>("DisciplinaID")
                        .HasColumnType("bigint");

                    b.HasKey("CursoID", "DisciplinaID");

                    b.HasIndex("DisciplinaID");

                    b.ToTable("CursoDisciplina");
                });

            modelBuilder.Entity("Modelo.Cadastros.Departamento", b =>
                {
                    b.Property<long?>("DepartamentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("DepartamentoID"));

                    b.Property<long?>("InstituicaoID")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartamentoID");

                    b.HasIndex("InstituicaoID");

                    b.ToTable("Departamento", (string)null);
                });

            modelBuilder.Entity("Modelo.Cadastros.Disciplina", b =>
                {
                    b.Property<long?>("DisciplinaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("DisciplinaID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisciplinaID");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Modelo.Cadastros.Instituicao", b =>
                {
                    b.Property<long?>("InstituicaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("InstituicaoID"));

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstituicaoID");

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("Modelo.Discente.Academico", b =>
                {
                    b.Property<long?>("AcademicoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("AcademicoID"));

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FotoMimeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Nascimento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistroAcademico")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("AcademicoID");

                    b.ToTable("Academicos");
                });

            modelBuilder.Entity("Modelo.Docente.CursoProfessor", b =>
                {
                    b.Property<long?>("CursoID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProfessorID")
                        .HasColumnType("bigint");

                    b.HasKey("CursoID", "ProfessorID");

                    b.HasIndex("ProfessorID");

                    b.ToTable("CursoProfessor");
                });

            modelBuilder.Entity("Modelo.Docente.Professor", b =>
                {
                    b.Property<long?>("ProfessorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("ProfessorID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfessorID");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Modelo.Cadastros.Curso", b =>
                {
                    b.HasOne("Modelo.Cadastros.Departamento", "Departamento")
                        .WithMany("Cursos")
                        .HasForeignKey("DepartamentoID");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Modelo.Cadastros.CursoDisciplina", b =>
                {
                    b.HasOne("Modelo.Cadastros.Curso", "Curso")
                        .WithMany("CursosDisciplinas")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Cadastros.Disciplina", "Disciplina")
                        .WithMany("CursosDisciplinas")
                        .HasForeignKey("DisciplinaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("Modelo.Cadastros.Departamento", b =>
                {
                    b.HasOne("Modelo.Cadastros.Instituicao", "Instituicao")
                        .WithMany("Departamentos")
                        .HasForeignKey("InstituicaoID");

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("Modelo.Docente.CursoProfessor", b =>
                {
                    b.HasOne("Modelo.Cadastros.Curso", "Curso")
                        .WithMany("CursosProfessores")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Docente.Professor", "Professor")
                        .WithMany("CursosProfessores")
                        .HasForeignKey("ProfessorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Modelo.Cadastros.Curso", b =>
                {
                    b.Navigation("CursosDisciplinas");

                    b.Navigation("CursosProfessores");
                });

            modelBuilder.Entity("Modelo.Cadastros.Departamento", b =>
                {
                    b.Navigation("Cursos");
                });

            modelBuilder.Entity("Modelo.Cadastros.Disciplina", b =>
                {
                    b.Navigation("CursosDisciplinas");
                });

            modelBuilder.Entity("Modelo.Cadastros.Instituicao", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Modelo.Docente.Professor", b =>
                {
                    b.Navigation("CursosProfessores");
                });
#pragma warning restore 612, 618
        }
    }
}
