using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddParkingTime2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ParkingStartTime", "TimeAdded" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(56), new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ParkingStartTime", "TimeAdded" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ParkingStartTime", "TimeAdded" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 4, 26, 0, 28, 58, 974, DateTimeKind.Local).AddTicks(64) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ParkingStartTime", "TimeAdded" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ParkingStartTime", "TimeAdded" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ParkingStartTime", "TimeAdded" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2163) });
        }
    }
}
