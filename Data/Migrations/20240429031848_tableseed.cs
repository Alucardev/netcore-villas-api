using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class tableseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreationDate", "Detail", "ImageUrl", "Name", "Ocuppants", "Rate", "SquareMeters", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8591), "Detalle de la villa", "", "Villa Real", 5, 200.0, 50.0, new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8602) },
                    { 2, "", new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8604), "Detalle de la villa", "", "Premium Vista al Mar", 4, 150.0, 40.0, new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8605) },
                    { 3, "", new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8606), "Detalle de la villa", "", "Premium Vista al Mar", 4, 150.0, 40.0, new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8607) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
