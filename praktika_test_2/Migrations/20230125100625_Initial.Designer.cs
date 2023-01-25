﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace praktikatest2.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230125100625_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Agreement", b =>
                {
                    b.Property<int>("agreement_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("agreement_id"));

                    b.Property<string>("areaAgreement")
                        .HasColumnType("text");

                    b.Property<int>("codeAgreement")
                        .HasColumnType("integer");

                    b.Property<string>("countryAgreement")
                        .HasColumnType("text");

                    b.Property<int>("countsAgreement")
                        .HasColumnType("integer");

                    b.Property<DateTime>("dateAgreement")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dateEndAgreement")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dateSrokAgreement")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("dayAgreement")
                        .HasColumnType("integer");

                    b.Property<int>("dayDateOfShipment")
                        .HasColumnType("integer");

                    b.Property<int>("dayDatePayement")
                        .HasColumnType("integer");

                    b.Property<string>("nameAgreement")
                        .HasColumnType("text");

                    b.Property<string>("nameProduct")
                        .HasColumnType("text");

                    b.Property<int>("numberAgreement")
                        .HasColumnType("integer");

                    b.Property<string>("relationshipsAgreement")
                        .HasColumnType("text");

                    b.Property<string>("statusAgreement")
                        .HasColumnType("text");

                    b.Property<string>("statusMMZAgreement")
                        .HasColumnType("text");

                    b.Property<int>("sumAgreement")
                        .HasColumnType("integer");

                    b.Property<int>("sumTransAgreement")
                        .HasColumnType("integer");

                    b.Property<string>("typeAgreement")
                        .HasColumnType("text");

                    b.Property<int>("typePayement")
                        .HasColumnType("integer");

                    b.HasKey("agreement_id");

                    b.ToTable("Agreement");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("user_id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("user_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}