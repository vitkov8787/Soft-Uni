﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingSystem.Data;

#nullable disable

namespace ParkingSystem.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20240425212859_AddParkingTime2")]
    partial class AddParkingTime2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ParkingSystem.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ParkingStartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeAdded")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mark = "Opel",
                            ParkingStartTime = new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(56),
                            Plate = "P5467BH",
                            TimeAdded = new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(4)
                        },
                        new
                        {
                            Id = 2,
                            Mark = "Nisan",
                            ParkingStartTime = new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(62),
                            Plate = "P5467BH",
                            TimeAdded = new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(61)
                        },
                        new
                        {
                            Id = 3,
                            Mark = "BMW",
                            ParkingStartTime = new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(65),
                            Plate = "P5467BH",
                            TimeAdded = new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(64)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
