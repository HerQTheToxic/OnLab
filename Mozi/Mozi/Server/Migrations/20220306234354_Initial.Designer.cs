﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mozi.Server.Data;

#nullable disable

namespace Mozi.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220306234354_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mozi.Shared.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Ertekeles")
                        .HasColumnType("float");

                    b.Property<string>("Gyarto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeremId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Filmek");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ertekeles = 6.0,
                            Gyarto = "ASD",
                            Nev = "elso nevu",
                            TeremId = 1
                        },
                        new
                        {
                            Id = 2,
                            Ertekeles = 8.0,
                            Gyarto = "ASDASD",
                            Nev = "masodik nevu",
                            TeremId = 2
                        });
                });

            modelBuilder.Entity("Mozi.Shared.Szek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Foglalt")
                        .HasColumnType("bit");

                    b.Property<int>("Szam")
                        .HasColumnType("int");

                    b.Property<int>("TeremId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Szekek");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Foglalt = false,
                            Szam = 1,
                            TeremId = 1
                        },
                        new
                        {
                            Id = 2,
                            Foglalt = false,
                            Szam = 2,
                            TeremId = 1
                        },
                        new
                        {
                            Id = 3,
                            Foglalt = false,
                            Szam = 3,
                            TeremId = 1
                        },
                        new
                        {
                            Id = 4,
                            Foglalt = true,
                            Szam = 4,
                            TeremId = 1
                        },
                        new
                        {
                            Id = 5,
                            Foglalt = true,
                            Szam = 5,
                            TeremId = 1
                        },
                        new
                        {
                            Id = 6,
                            Foglalt = true,
                            Szam = 6,
                            TeremId = 1
                        },
                        new
                        {
                            Id = 7,
                            Foglalt = false,
                            Szam = 7,
                            TeremId = 1
                        },
                        new
                        {
                            Id = 11,
                            Foglalt = false,
                            Szam = 1,
                            TeremId = 2
                        },
                        new
                        {
                            Id = 12,
                            Foglalt = true,
                            Szam = 2,
                            TeremId = 2
                        },
                        new
                        {
                            Id = 13,
                            Foglalt = false,
                            Szam = 3,
                            TeremId = 2
                        },
                        new
                        {
                            Id = 14,
                            Foglalt = true,
                            Szam = 4,
                            TeremId = 2
                        },
                        new
                        {
                            Id = 15,
                            Foglalt = false,
                            Szam = 5,
                            TeremId = 2
                        },
                        new
                        {
                            Id = 16,
                            Foglalt = true,
                            Szam = 6,
                            TeremId = 2
                        },
                        new
                        {
                            Id = 17,
                            Foglalt = false,
                            Szam = 7,
                            TeremId = 2
                        });
                });

            modelBuilder.Entity("Mozi.Shared.Szinesz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Ertekeles")
                        .HasColumnType("float");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("Kor")
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Szineszek");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ertekeles = 9.0,
                            FilmId = 1,
                            Kor = 24,
                            Nev = "Szinesz1"
                        },
                        new
                        {
                            Id = 2,
                            Ertekeles = 4.0,
                            FilmId = 1,
                            Kor = 54,
                            Nev = "Szinesz2"
                        },
                        new
                        {
                            Id = 3,
                            Ertekeles = 1.0,
                            FilmId = 2,
                            Kor = 28,
                            Nev = "Szinesz3"
                        });
                });

            modelBuilder.Entity("Mozi.Shared.Terem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("TeremNev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Termek");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FilmId = 1,
                            TeremNev = "elso"
                        },
                        new
                        {
                            Id = 2,
                            FilmId = 2,
                            TeremNev = "masodik"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
