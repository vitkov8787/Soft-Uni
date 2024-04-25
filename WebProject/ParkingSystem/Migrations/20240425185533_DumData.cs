using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ParkingSystem.Migrations
{
    /// <inheritdoc />
    public partial class DumData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Identifier",
                table: "Cars",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Mark", "Plate" },
                values: new object[,]
                {
                    { 1, "Opel", "P5467BH" },
                    { 2, "Nisan", "P5467BH" },
                    { 3, "BMW", "P5467BH" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "Identifier");
        }
    }
}
