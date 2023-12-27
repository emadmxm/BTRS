﻿// <auto-generated />
using System;
using BTRS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTRS.Migrations
{
    [DbContext(typeof(SystemDbContext))]
    [Migration("20231222201136_FirstM")]
    partial class FirstM
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BTRS.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("BTRS.Models.Bus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BusTripID")
                        .HasColumnType("int");

                    b.Property<string>("CaptainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BusTripID");

                    b.ToTable("bus");
                });

            modelBuilder.Entity("BTRS.Models.BusTrip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<string>("BusNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AdminID");

                    b.ToTable("busTrip");
                });

            modelBuilder.Entity("BTRS.Models.Passenger", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("passenger");
                });

            modelBuilder.Entity("BTRS.Models.Passenger_User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BusTripID")
                        .HasColumnType("int");

                    b.Property<int>("PassengerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BusTripID");

                    b.HasIndex("PassengerID");

                    b.ToTable("passenger_Users");
                });

            modelBuilder.Entity("BTRS.Models.Bus", b =>
                {
                    b.HasOne("BTRS.Models.BusTrip", "busTrip")
                        .WithMany("bus")
                        .HasForeignKey("BusTripID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("busTrip");
                });

            modelBuilder.Entity("BTRS.Models.BusTrip", b =>
                {
                    b.HasOne("BTRS.Models.Admin", "Admin")
                        .WithMany("busTrips")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("BTRS.Models.Passenger_User", b =>
                {
                    b.HasOne("BTRS.Models.BusTrip", "busTrip")
                        .WithMany("passenger_User")
                        .HasForeignKey("BusTripID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BTRS.Models.Passenger", "passenger")
                        .WithMany("passenger_User")
                        .HasForeignKey("PassengerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("busTrip");

                    b.Navigation("passenger");
                });

            modelBuilder.Entity("BTRS.Models.Admin", b =>
                {
                    b.Navigation("busTrips");
                });

            modelBuilder.Entity("BTRS.Models.BusTrip", b =>
                {
                    b.Navigation("bus");

                    b.Navigation("passenger_User");
                });

            modelBuilder.Entity("BTRS.Models.Passenger", b =>
                {
                    b.Navigation("passenger_User");
                });
#pragma warning restore 612, 618
        }
    }
}
