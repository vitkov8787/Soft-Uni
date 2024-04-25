using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddParkingTime1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeAdded",
                value: new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeAdded",
                value: new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeAdded",
                value: new DateTime(2024, 4, 25, 23, 58, 6, 458, DateTimeKind.Local).AddTicks(2163));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeAdded",
                value: new DateTime(2024, 4, 25, 23, 43, 57, 526, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeAdded",
                value: new DateTime(2024, 4, 25, 23, 43, 57, 526, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeAdded",
                value: new DateTime(2024, 4, 25, 23, 43, 57, 526, DateTimeKind.Local).AddTicks(1203));
        }
    }
}
