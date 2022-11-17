using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LimeFlightTakeHomeChallenge.Migrations
{
    /// <inheritdoc />
    public partial class FlightEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flightnumber = table.Column<int>(type: "int", nullable: false),
                    Codeshare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Std = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StdLt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaLt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcRegistration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tow = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RotationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepEff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestEff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StdEff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StaEff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StdLtEff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StaLtEff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DepGateEff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestGateEff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotEff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotLtEff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LdtEff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LdtLtEff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LineOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FkUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AcRegistration", "AcType", "Carrier", "Codeshare", "CreatedDate", "Dep", "DepEff", "DepGateEff", "Dest", "DestEff", "DestGateEff", "ExternalId", "FkCreatedBy", "FkUpdatedBy", "Flightnumber", "LdtEff", "LdtLtEff", "LineOfWork", "OperationalSuffix", "Owner", "Remarks", "RotationNumber", "Sta", "StaEff", "StaLt", "StaLtEff", "Std", "StdEff", "StdLt", "StdLtEff", "TotEff", "TotLtEff", "Tow", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "ZH-IJU", "320", "LimeAir", "", new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "ZRH", "ZRH", "D34", "FRA", "FRA", "C3", "201", "info@limeair.ch", null, 1075, new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 12, 30, 46, 343, DateTimeKind.Local).AddTicks(3676), "LineOfWork1", "P", "limeair", "REFER TO limeair MEALPLAN", "ZRH-FRA-ZRH", new DateTime(2022, 11, 18, 11, 30, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 12, 30, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 11, 30, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 12, 30, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 18, 11, 30, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null },
                    { 2, "ZH-IJU", "320", "limeair", null, new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "FRA", null, null, "ZRH", null, null, "202", "info@limeair.ch", null, 1076, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "ZRH-FRA-ZRH", new DateTime(2022, 11, 18, 12, 0, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 13, 0, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 10, 50, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 11, 50, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null, null, null, null },
                    { 3, "ZH-IJU", "320", "limeair", "", new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "ZRH", null, null, "FRA", null, null, "203", "info@limeair.ch", null, 1077, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "ZRH-FRA-ZRH", new DateTime(2022, 11, 18, 12, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 14, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 13, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null, null, null, null },
                    { 4, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "JFK", null, null, "CDG", null, null, "206", "info@limeair.ch", null, 1078, null, null, null, "P", "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 18, 15, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 14, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 4, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 3, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null, null, null, null },
                    { 5, "ZH-IJU", "777", "limeair", "", new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "MUC", null, null, "FRA", null, null, "247", "info@limeair.ch", null, 3598, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "MUC-FRA-MUC", new DateTime(2022, 11, 18, 11, 30, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 12, 30, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 11, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null, null, null, null },
                    { 6, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "CDG", null, null, "YYZ", null, null, "444", "info@limeair.ch", null, 3556, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 19, 9, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 19, 8, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 22, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 18, 21, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null, null, null, null },
                    { 7, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "YYZ", null, null, "SFO", null, null, "555", "info@limeair.ch", null, 4586, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 20, 7, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 20, 6, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 19, 22, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 19, 21, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null, null, null, null },
                    { 8, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "SFO", null, null, "JFK", null, null, "556", "info@limeair.ch", null, 4587, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 20, 15, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 20, 14, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 20, 9, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 20, 8, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null, null, null, null },
                    { 9, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 16, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), "JFK", null, null, "CDG", null, null, "557", "info@limeair.ch", null, 4900, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 21, 22, 50, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 21, 21, 40, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 21, 10, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 21, 9, 20, 46, 343, DateTimeKind.Local).AddTicks(3676), null, new DateTime(2022, 11, 29, 4, 22, 46, 343, DateTimeKind.Local).AddTicks(3676), null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
