﻿// <auto-generated />
using System;
using EtFlix_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EtFlix_Api.Migrations
{
    [DbContext(typeof(EtFlixContext))]
    [Migration("20210520195340_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EtFlix_Api.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("LastName");

                    b.HasKey("Id");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("EtFlix_Api.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("EtFlix_Api.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .HasColumnType("text")
                        .HasColumnName("VideoFileLink");

                    b.Property<int>("Rating")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<decimal>("Runtime")
                        .HasColumnType("numeric");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
