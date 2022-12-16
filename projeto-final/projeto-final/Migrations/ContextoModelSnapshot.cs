﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto_final;

#nullable disable

namespace projetofinal.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("projeto_final.Models.Aluguel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Aluguelid")
                        .HasColumnType("int");

                    b.Property<int>("Categoriaid")
                        .HasColumnType("int");

                    b.Property<int>("clienteid")
                        .HasColumnType("int");

                    b.Property<string>("quantidadeDiarias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("valorTotal")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("Aluguelid");

                    b.HasIndex("Categoriaid");

                    b.HasIndex("clienteid");

                    b.ToTable("Aluguel");
                });

            modelBuilder.Entity("projeto_final.Models.Carros", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("categoriaId")
                        .HasColumnType("int");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoriaId");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("projeto_final.Models.Categoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("valorDiaria")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("projeto_final.Models.Clientes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("projeto_final.Models.Aluguel", b =>
                {
                    b.HasOne("projeto_final.Models.Aluguel", null)
                        .WithMany("listaAluguel")
                        .HasForeignKey("Aluguelid");

                    b.HasOne("projeto_final.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("Categoriaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projeto_final.Models.Clientes", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("projeto_final.Models.Carros", b =>
                {
                    b.HasOne("projeto_final.Models.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("projeto_final.Models.Aluguel", b =>
                {
                    b.Navigation("listaAluguel");
                });
#pragma warning restore 612, 618
        }
    }
}
