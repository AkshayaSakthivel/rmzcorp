﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RMZCorp.DataAccess.SQL;

namespace RMZCorp.DataAccess.SQL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.ElectricityMeter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DailyElecticityConsumedCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ElecticityConsumedPerHour")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MeasuringUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeterStartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OperationalHoursPerDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReadingDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SerialNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalUnits")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("WattageRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZoneId");

                    b.ToTable("ElectricityMeters");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Floors");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.WaterMeter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DailyConsumptionCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LitersConsumedPerDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RatePerLiter")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReadingDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SerialNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZoneId");

                    b.ToTable("WaterMeters");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FloorId");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Building", b =>
                {
                    b.HasOne("RMZCorp.DataAccess.SQL.DataModels.Facility", "Facility")
                        .WithMany("Buildings")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.ElectricityMeter", b =>
                {
                    b.HasOne("RMZCorp.DataAccess.SQL.DataModels.Zone", "Zone")
                        .WithMany("ElectricityMeters")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Facility", b =>
                {
                    b.HasOne("RMZCorp.DataAccess.SQL.DataModels.City", "City")
                        .WithMany("Facilities")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Floor", b =>
                {
                    b.HasOne("RMZCorp.DataAccess.SQL.DataModels.Building", "Building")
                        .WithMany("Floors")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.WaterMeter", b =>
                {
                    b.HasOne("RMZCorp.DataAccess.SQL.DataModels.Zone", "Zone")
                        .WithMany("WaterMeters")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Zone", b =>
                {
                    b.HasOne("RMZCorp.DataAccess.SQL.DataModels.Floor", "Floor")
                        .WithMany("Zones")
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Floor");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Building", b =>
                {
                    b.Navigation("Floors");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.City", b =>
                {
                    b.Navigation("Facilities");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Facility", b =>
                {
                    b.Navigation("Buildings");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Floor", b =>
                {
                    b.Navigation("Zones");
                });

            modelBuilder.Entity("RMZCorp.DataAccess.SQL.DataModels.Zone", b =>
                {
                    b.Navigation("ElectricityMeters");

                    b.Navigation("WaterMeters");
                });
#pragma warning restore 612, 618
        }
    }
}
