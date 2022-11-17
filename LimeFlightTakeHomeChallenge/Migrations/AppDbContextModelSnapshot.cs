﻿// <auto-generated />
using System;
using LimeFlightTakeHomeChallenge.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LimeFlightTakeHomeChallenge.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LimeFlightTakeHomeChallenge.DAL.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcRegistration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AcType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carrier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codeshare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepEff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepGateEff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestEff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestGateEff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FkCreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FkUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Flightnumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LdtEff")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LdtLtEff")
                        .HasColumnType("datetime2");

                    b.Property<string>("LineOfWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationalSuffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RotationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Sta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StaEff")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StaLt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StaLtEff")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Std")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StdEff")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StdLt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StdLtEff")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TotEff")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TotLtEff")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Tow")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AcRegistration = "ZH-IJU",
                            AcType = "320",
                            Carrier = "LimeAir",
                            Codeshare = "",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "ZRH",
                            DepEff = "ZRH",
                            DepGateEff = "D34",
                            Dest = "FRA",
                            DestEff = "FRA",
                            DestGateEff = "C3",
                            ExternalId = "201",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 1075,
                            LdtEff = new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            LdtLtEff = new DateTime(2022, 11, 18, 12, 30, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            LineOfWork = "LineOfWork1",
                            OperationalSuffix = "P",
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "ZRH-FRA-ZRH",
                            Sta = new DateTime(2022, 11, 18, 11, 30, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaEff = new DateTime(2022, 11, 18, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 18, 12, 30, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLtEff = new DateTime(2022, 11, 18, 11, 30, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 18, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdEff = new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLtEff = new DateTime(2022, 11, 18, 12, 30, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            TotEff = new DateTime(2022, 11, 18, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            TotLtEff = new DateTime(2022, 11, 18, 11, 30, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            Id = 2,
                            AcRegistration = "ZH-IJU",
                            AcType = "320",
                            Carrier = "limeair",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "FRA",
                            Dest = "ZRH",
                            ExternalId = "202",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 1076,
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "ZRH-FRA-ZRH",
                            Sta = new DateTime(2022, 11, 18, 12, 0, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 18, 13, 0, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 18, 10, 50, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 18, 11, 50, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            Id = 3,
                            AcRegistration = "ZH-IJU",
                            AcType = "320",
                            Carrier = "limeair",
                            Codeshare = "",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "ZRH",
                            Dest = "FRA",
                            ExternalId = "203",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 1077,
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "ZRH-FRA-ZRH",
                            Sta = new DateTime(2022, 11, 18, 12, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 18, 14, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 18, 13, 20, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            Id = 4,
                            AcRegistration = "ZH-JHQ",
                            AcType = "320",
                            Carrier = "limeair",
                            Codeshare = "",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "JFK",
                            Dest = "CDG",
                            ExternalId = "206",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 1078,
                            OperationalSuffix = "P",
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "JDK-CDG-YYZ-SFO-JFK",
                            Sta = new DateTime(2022, 11, 18, 15, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 18, 14, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 18, 4, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 18, 3, 20, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            Id = 5,
                            AcRegistration = "ZH-IJU",
                            AcType = "777",
                            Carrier = "limeair",
                            Codeshare = "",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "MUC",
                            Dest = "FRA",
                            ExternalId = "247",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 3598,
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "MUC-FRA-MUC",
                            Sta = new DateTime(2022, 11, 18, 11, 30, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 18, 12, 30, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 18, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            Id = 6,
                            AcRegistration = "ZH-JHQ",
                            AcType = "320",
                            Carrier = "limeair",
                            Codeshare = "",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "CDG",
                            Dest = "YYZ",
                            ExternalId = "444",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 3556,
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "JDK-CDG-YYZ-SFO-JFK",
                            Sta = new DateTime(2022, 11, 19, 9, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 19, 8, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 18, 22, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 18, 21, 20, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            Id = 7,
                            AcRegistration = "ZH-JHQ",
                            AcType = "320",
                            Carrier = "limeair",
                            Codeshare = "",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "YYZ",
                            Dest = "SFO",
                            ExternalId = "555",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 4586,
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "JDK-CDG-YYZ-SFO-JFK",
                            Sta = new DateTime(2022, 11, 20, 7, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 20, 6, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 19, 22, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 19, 21, 20, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            Id = 8,
                            AcRegistration = "ZH-JHQ",
                            AcType = "320",
                            Carrier = "limeair",
                            Codeshare = "",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "SFO",
                            Dest = "JFK",
                            ExternalId = "556",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 4587,
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "JDK-CDG-YYZ-SFO-JFK",
                            Sta = new DateTime(2022, 11, 20, 15, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 20, 14, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 20, 9, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 20, 8, 20, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            Id = 9,
                            AcRegistration = "ZH-JHQ",
                            AcType = "320",
                            Carrier = "limeair",
                            Codeshare = "",
                            CreatedDate = new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Dep = "JFK",
                            Dest = "CDG",
                            ExternalId = "557",
                            FkCreatedBy = "info@limeair.ch",
                            Flightnumber = 4900,
                            Owner = "limeair",
                            Remarks = "REFER TO limeair MEALPLAN",
                            RotationNumber = "JDK-CDG-YYZ-SFO-JFK",
                            Sta = new DateTime(2022, 11, 21, 22, 50, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StaLt = new DateTime(2022, 11, 21, 21, 40, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            Std = new DateTime(2022, 11, 21, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            StdLt = new DateTime(2022, 11, 21, 9, 20, 46, 343, DateTimeKind.Local).AddTicks(3676),
                            TotEff = new DateTime(2022, 11, 29, 4, 22, 46, 343, DateTimeKind.Local).AddTicks(3676)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
