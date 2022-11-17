using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LimeFlightTakeHomeChallenge.Migrations
{
    /// <inheritdoc />
    public partial class AddFlightEntity : Migration
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
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AcRegistration", "AcType", "Carrier", "Codeshare", "CreatedDate", "Dep", "DepEff", "DepGateEff", "Dest", "DestEff", "DestGateEff", "ExternalId", "FkCreatedBy", "FkUpdatedBy", "Flightnumber", "LdtEff", "LdtLtEff", "LineOfWork", "OperationalSuffix", "Owner", "Remarks", "RotationNumber", "Sta", "StaEff", "StaLt", "StaLtEff", "Status", "Std", "StdEff", "StdLt", "StdLtEff", "TotEff", "TotLtEff", "Tow", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "ZH-IJU", "320", "LimeAir", "", new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "ZRH", "ZRH", "D34", "FRA", "FRA", "C3", "201", "info@limeair.ch", null, 1075, new DateTime(2022, 11, 18, 13, 47, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 14, 57, 12, 117, DateTimeKind.Local).AddTicks(916), "LineOfWork1", "P", "limeair", "REFER TO limeair MEALPLAN", "ZRH-FRA-ZRH", new DateTime(2022, 11, 18, 13, 57, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 12, 47, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 14, 57, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 13, 57, 12, 117, DateTimeKind.Local).AddTicks(916), 0, new DateTime(2022, 11, 18, 12, 47, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 13, 47, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 13, 47, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 14, 57, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 12, 47, 12, 117, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 11, 18, 13, 57, 12, 117, DateTimeKind.Local).AddTicks(916), null, null },
                    { 2, "ZH-IJU", "320", "limeair", null, new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "FRA", null, null, "ZRH", null, null, "202", "info@limeair.ch", null, 1076, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "ZRH-FRA-ZRH", new DateTime(2022, 11, 18, 14, 27, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 15, 27, 12, 117, DateTimeKind.Local).AddTicks(916), null, 0, new DateTime(2022, 11, 18, 13, 17, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 14, 17, 12, 117, DateTimeKind.Local).AddTicks(916), null, null, null, null, null },
                    { 3, "ZH-IJU", "320", "limeair", "", new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "ZRH", null, null, "FRA", null, null, "203", "info@limeair.ch", null, 1077, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "ZRH-FRA-ZRH", new DateTime(2022, 11, 18, 15, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 17, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, 0, new DateTime(2022, 11, 18, 13, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 15, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, null, null, null, null },
                    { 4, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "JFK", null, null, "CDG", null, null, "206", "info@limeair.ch", null, 1078, null, null, null, "P", "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 18, 18, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 17, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, 0, new DateTime(2022, 11, 18, 6, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 5, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, null, null, null, null },
                    { 5, "ZH-IJU", "777", "limeair", "", new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "MUC", null, null, "FRA", null, null, "247", "info@limeair.ch", null, 3598, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "MUC-FRA-MUC", new DateTime(2022, 11, 18, 13, 57, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 14, 57, 12, 117, DateTimeKind.Local).AddTicks(916), null, 0, new DateTime(2022, 11, 18, 12, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 13, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, null, null, null, null },
                    { 6, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "CDG", null, null, "YYZ", null, null, "444", "info@limeair.ch", null, 3556, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 19, 12, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 19, 11, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, 0, new DateTime(2022, 11, 19, 0, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 18, 23, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, null, null, null, null },
                    { 7, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "YYZ", null, null, "SFO", null, null, "555", "info@limeair.ch", null, 4586, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 20, 10, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 20, 9, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, 0, new DateTime(2022, 11, 20, 0, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 19, 23, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, null, null, null, null },
                    { 8, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "SFO", null, null, "JFK", null, null, "556", "info@limeair.ch", null, 4587, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 20, 18, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 20, 17, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, 0, new DateTime(2022, 11, 20, 11, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 20, 10, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, null, null, null, null },
                    { 9, "ZH-JHQ", "320", "limeair", "", new DateTime(2022, 11, 17, 18, 47, 12, 117, DateTimeKind.Local).AddTicks(916), "JFK", null, null, "CDG", null, null, "557", "info@limeair.ch", null, 4900, null, null, null, null, "limeair", "REFER TO limeair MEALPLAN", "JDK-CDG-YYZ-SFO-JFK", new DateTime(2022, 11, 22, 1, 17, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 22, 0, 7, 12, 117, DateTimeKind.Local).AddTicks(916), null, 0, new DateTime(2022, 11, 21, 12, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 21, 11, 47, 12, 117, DateTimeKind.Local).AddTicks(916), null, new DateTime(2022, 11, 29, 6, 49, 12, 117, DateTimeKind.Local).AddTicks(916), null, null, null }
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
