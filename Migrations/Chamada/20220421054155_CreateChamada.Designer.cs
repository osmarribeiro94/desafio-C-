﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using challenge.Data;

#nullable disable

namespace challenge.Migrations.Chamada
{
    [DbContext(typeof(ChamadaContext))]
    [Migration("20220421054155_CreateChamada")]
    partial class CreateChamada
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("challenge.Model.Chamada", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("data")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data");

                    b.Property<int>("idAluno")
                        .HasColumnType("integer")
                        .HasColumnName("id_aluno");

                    b.Property<int>("idTurma")
                        .HasColumnType("integer")
                        .HasColumnName("id_turma");

                    b.Property<bool>("presenca")
                        .HasColumnType("boolean")
                        .HasColumnName("presenca");

                    b.HasKey("id");

                    b.ToTable("Chamada", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
