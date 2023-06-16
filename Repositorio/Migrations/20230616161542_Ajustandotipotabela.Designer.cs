﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositorio;

#nullable disable

namespace Repositorio.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230616161542_Ajustandotipotabela")]
    partial class Ajustandotipotabela
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entidade.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("alunoid");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("email");

                    b.Property<int>("Matricula")
                        .HasColumnType("int")
                        .HasColumnName("matricula");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("telefone");

                    b.HasKey("AlunoId");

                    b.ToTable("aluno");
                });

            modelBuilder.Entity("Entidade.AtividadeComplementar", b =>
                {
                    b.Property<int>("AtividadeComplementarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("atividadecomplementarid");

                    b.Property<int>("AlunoId")
                        .HasColumnType("int")
                        .HasColumnName("alunoid");

                    b.Property<int>("AnoConclusao")
                        .HasColumnType("int")
                        .HasColumnName("anoconclusao");

                    b.Property<byte[]>("Arquivo")
                        .HasColumnType("longblob")
                        .HasColumnName("arquivo");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int")
                        .HasColumnName("cargahoraria");

                    b.Property<string>("DescricaoAtividade")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("descricaoatividade");

                    b.Property<string>("Institiuicao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("instituicao");

                    b.Property<string>("NomeArquivo")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("nomearquivo");

                    b.Property<string>("Observacao")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("observacao");

                    b.Property<int>("TipoAtividadeId")
                        .HasColumnType("int")
                        .HasColumnName("tipoatividadeid");

                    b.HasKey("AtividadeComplementarId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("TipoAtividadeId");

                    b.ToTable("atividadecomplementar");
                });

            modelBuilder.Entity("Entidade.TipoAtividade", b =>
                {
                    b.Property<int>("TipoAtividadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tipoatividadeid");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.HasKey("TipoAtividadeId");

                    b.ToTable("tipoatividade");
                });

            modelBuilder.Entity("Entidade.AtividadeComplementar", b =>
                {
                    b.HasOne("Entidade.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidade.TipoAtividade", "TipoAtividade")
                        .WithMany()
                        .HasForeignKey("TipoAtividadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("TipoAtividade");
                });
#pragma warning restore 612, 618
        }
    }
}
