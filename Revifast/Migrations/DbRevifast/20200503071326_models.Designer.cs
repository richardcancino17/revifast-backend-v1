﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Revifast.Models;

namespace Revifast.Migrations.DbRevifast
{
    [DbContext(typeof(DbRevifastContext))]
    [Migration("20200503071326_models")]
    partial class models
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Revifast.Models.Conductor", b =>
                {
                    b.Property<int>("ConductorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Celular")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Correo")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Dni")
                        .HasColumnName("DNI")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Nombres")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("ConductorId");

                    b.ToTable("Conductor");
                });

            modelBuilder.Entity("Revifast.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Ruc")
                        .HasColumnName("RUC")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Revifast.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("fecha_y_hora")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("ReservaId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Revifast.Models.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int?>("ConductorId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Placa")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("VehiculoId");

                    b.HasIndex("ConductorId");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Revifast.Models.Reserva", b =>
                {
                    b.HasOne("Revifast.Models.Empresa", "Empresa")
                        .WithMany("Reserva")
                        .HasForeignKey("EmpresaId")
                        .HasConstraintName("FK_Reserva_Empresa")
                        .IsRequired();

                    b.HasOne("Revifast.Models.Vehiculo", "Vehiculo")
                        .WithMany("Reserva")
                        .HasForeignKey("VehiculoId")
                        .HasConstraintName("FK_Reserva_Vehiculo")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Revifast.Models.Vehiculo", b =>
                {
                    b.HasOne("Revifast.Models.Conductor", "Conductor")
                        .WithMany("Vehiculo")
                        .HasForeignKey("ConductorId")
                        .HasConstraintName("FK_Vehiculo_Conductor");
                });
#pragma warning restore 612, 618
        }
    }
}