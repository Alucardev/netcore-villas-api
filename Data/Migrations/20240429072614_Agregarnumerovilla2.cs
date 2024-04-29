using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Agregarnumerovilla2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NumberVilla_Villas_VillaId",
                table: "NumberVilla");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NumberVilla",
                table: "NumberVilla");

            migrationBuilder.RenameTable(
                name: "NumberVilla",
                newName: "NumberVillas");

            migrationBuilder.RenameColumn(
                name: "UpdateData",
                table: "NumberVillas",
                newName: "UpdateDate");

            migrationBuilder.RenameIndex(
                name: "IX_NumberVilla_VillaId",
                table: "NumberVillas",
                newName: "IX_NumberVillas_VillaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NumberVillas",
                table: "NumberVillas",
                column: "VillaNumber");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 4, 26, 14, 18, DateTimeKind.Local).AddTicks(2693), new DateTime(2024, 4, 29, 4, 26, 14, 18, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 4, 26, 14, 18, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 4, 29, 4, 26, 14, 18, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 4, 29, 4, 26, 14, 18, DateTimeKind.Local).AddTicks(2706), new DateTime(2024, 4, 29, 4, 26, 14, 18, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.AddForeignKey(
                name: "FK_NumberVillas_Villas_VillaId",
                table: "NumberVillas",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NumberVillas_Villas_VillaId",
                table: "NumberVillas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NumberVillas",
                table: "NumberVillas");

            migrationBuilder.RenameTable(
                name: "NumberVillas",
                newName: "NumberVilla");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "NumberVilla",
                newName: "UpdateData");

            migrationBuilder.RenameIndex(
                name: "IX_NumberVillas_VillaId",
                table: "NumberVilla",
                newName: "IX_NumberVilla_VillaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NumberVilla",
                table: "NumberVilla",
                column: "VillaNumber");

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

            migrationBuilder.AddForeignKey(
                name: "FK_NumberVilla_Villas_VillaId",
                table: "NumberVilla",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
