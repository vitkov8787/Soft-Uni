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
    [Migration("20240425205806_AddParkingTime1")]
    partial class AddParkingTime1
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
                            ParkingStartTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Plate = "P5467BH",
                            TimeAdded = new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2101)
                        },
                        new
                        {
                            Id = 2,
                            Mark = "Nisan",
                            ParkingStartTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Plate = "P5467BH",
                            TimeAdded = new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2160)
                        },
                        new
                        {
                            Id = 3,
                            Mark = "BMW",
                            ParkingStartTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Plate = "P5467BH",
                            TimeAdded = new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2163)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
