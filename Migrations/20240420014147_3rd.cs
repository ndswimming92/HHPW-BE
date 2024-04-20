using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HHPW_BE.Migrations
{
    public partial class _3rd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Orders",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "OrderItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Total" },
                values: new object[] { new DateTime(2024, 4, 17, 20, 41, 47, 396, DateTimeKind.Local).AddTicks(2730), 12m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Total" },
                values: new object[] { new DateTime(2024, 4, 14, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(233), 5m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Total" },
                values: new object[] { new DateTime(2024, 4, 4, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(254), 8m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Total" },
                values: new object[] { new DateTime(2024, 4, 13, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(259), 9m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Total" },
                values: new object[] { new DateTime(2024, 4, 9, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(262), 7m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Total" },
                values: new object[] { new DateTime(2024, 4, 10, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(267), 36m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "OrderItems");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: null);
        }
    }
}
