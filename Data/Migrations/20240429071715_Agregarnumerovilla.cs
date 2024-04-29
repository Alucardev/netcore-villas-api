using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Agregarnumerovilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NumberVilla",
                columns: table => new
                {
                    VillaNumber = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberVilla", x => x.VillaNumber);
                    table.ForeignKey(
                        name: "FK_NumberVilla_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 4, 17, 15, 29, DateTimeKind.Local).AddTicks(7231), new DateTime(2024, 4, 29, 4, 17, 15, 29, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 4, 17, 15, 29, DateTimeKind.Local).AddTicks(7246), new DateTime(2024, 4, 29, 4, 17, 15, 29, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 4, 17, 15, 29, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 4, 29, 4, 17, 15, 29, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.CreateIndex(
                name: "IX_NumberVilla_VillaId",
                table: "NumberVilla",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NumberVilla");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8591), new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 4, 29, 0, 18, 48, 607, DateTimeKind.Local).AddTicks(8607) });
        }
    }
}
