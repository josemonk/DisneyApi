﻿// <auto-generated />
using System;
using DisneyApiSoftka.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DisneyApiSoftka.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DisneyApiSoftka.Models.Pelicula", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("idPersonaje")
                        .HasColumnType("int");

                    b.Property<int?>("personajeid")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("personajeid");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("DisneyApiSoftka.Models.Personaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("personajes");
                });

            modelBuilder.Entity("DisneyApiSoftka.Models.Pelicula", b =>
                {
                    b.HasOne("DisneyApiSoftka.Models.Personaje", "personaje")
                        .WithMany("Peliculas")
                        .HasForeignKey("personajeid");

                    b.Navigation("personaje");
                });

            modelBuilder.Entity("DisneyApiSoftka.Models.Personaje", b =>
                {
                    b.Navigation("Peliculas");
                });
#pragma warning restore 612, 618
        }
    }
}