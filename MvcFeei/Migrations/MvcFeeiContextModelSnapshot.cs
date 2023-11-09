﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcFeei.Data;

#nullable disable

namespace MvcFeei.Migrations
{
    [DbContext(typeof(MvcFeeiContext))]
    partial class MvcFeeiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MvcFeei.Models.Alumno", b =>
                {
                    b.Property<string>("AlumnoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Carrera")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Promedio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AlumnoId");

                    b.ToTable("Alumno");
                });
#pragma warning restore 612, 618
        }
    }
}
