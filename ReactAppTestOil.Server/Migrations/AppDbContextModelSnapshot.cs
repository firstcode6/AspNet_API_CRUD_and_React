﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactAppTestOil.Data;

#nullable disable

namespace ReactAppTestOil.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("ReactAppTestOil.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Company A"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Company B"
                        });
                });

            modelBuilder.Entity("ReactAppTestOil.Models.CompanyWell", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WellId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompanyId", "WellId");

                    b.HasIndex("WellId");

                    b.ToTable("CompanyWells");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            WellId = 1
                        },
                        new
                        {
                            CompanyId = 1,
                            WellId = 2
                        },
                        new
                        {
                            CompanyId = 2,
                            WellId = 1
                        });
                });

            modelBuilder.Entity("ReactAppTestOil.Models.Telemetry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CustomDate")
                        .HasColumnType("TEXT");

                    b.Property<float>("Depth")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Telemetries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomDate = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Depth = 100.5f
                        },
                        new
                        {
                            Id = 2,
                            CustomDate = new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Depth = 200f
                        });
                });

            modelBuilder.Entity("ReactAppTestOil.Models.Well", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TelemetryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TelemetryId");

                    b.ToTable("Wells");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Name = "Well 1",
                            TelemetryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            Name = "Well 2",
                            TelemetryId = 2
                        });
                });

            modelBuilder.Entity("ReactAppTestOil.Models.CompanyWell", b =>
                {
                    b.HasOne("ReactAppTestOil.Models.Company", "Company")
                        .WithMany("CompanyWells")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReactAppTestOil.Models.Well", "Well")
                        .WithMany("CompanyWells")
                        .HasForeignKey("WellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Well");
                });

            modelBuilder.Entity("ReactAppTestOil.Models.Well", b =>
                {
                    b.HasOne("ReactAppTestOil.Models.Telemetry", "Telemetry")
                        .WithMany("Wells")
                        .HasForeignKey("TelemetryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Telemetry");
                });

            modelBuilder.Entity("ReactAppTestOil.Models.Company", b =>
                {
                    b.Navigation("CompanyWells");
                });

            modelBuilder.Entity("ReactAppTestOil.Models.Telemetry", b =>
                {
                    b.Navigation("Wells");
                });

            modelBuilder.Entity("ReactAppTestOil.Models.Well", b =>
                {
                    b.Navigation("CompanyWells");
                });
#pragma warning restore 612, 618
        }
    }
}
