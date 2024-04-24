﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JulianaSosa_Examen1P.Migrations
{
    [DbContext(typeof(JulianaSosa_Examen1PContext))]
    [Migration("20240424162018_JulianaSosa_P1")]
    partial class JulianaSosa_P1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JulianaSosa_Examen1P.Models.JS_Medicinas", b =>
                {
                    b.Property<int>("JS_MedicinasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JS_MedicinasID"));

                    b.Property<bool>("JS_ConReceta")
                        .HasColumnType("bit");

                    b.Property<string>("JS_DescripcionMedicina")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("JS_FechaDeEntrega")
                        .HasColumnType("datetime2");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("JS_MedicinasID");

                    b.ToTable("JS_Medicinas");
                });
#pragma warning restore 612, 618
        }
    }
}