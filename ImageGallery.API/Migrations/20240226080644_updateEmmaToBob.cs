using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImageGallery.API.Migrations
{
    public partial class updateEmmaToBob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("136f358d-98fb-4961-855c-59d5a6d1fa19"),
                column: "Title",
                value: "An image by bob");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2645bd94-3624-43fc-b21f-1209d730fc71"),
                column: "Title",
                value: "An image by bob");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f41dc87-e8de-42ee-ac8d-355e4d3e1a2d"),
                column: "Title",
                value: "An image by bob");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5e0e1379-3e8e-4f51-99f1-1fb9ec3a19b0"),
                column: "Title",
                value: "An image by bob");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ab46efdb-0384-400c-89cb-95bba1c500e9"),
                column: "Title",
                value: "An image by bob");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ae03d971-40a6-4350-b8a9-7b12e1d93d71"),
                column: "Title",
                value: "An image by bob");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d3118665-43e3-4905-8848-5e335a428dd5"),
                column: "Title",
                value: "An image by bob");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("136f358d-98fb-4961-855c-59d5a6d1fa19"),
                column: "Title",
                value: "An image by Emma");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2645bd94-3624-43fc-b21f-1209d730fc71"),
                column: "Title",
                value: "An image by Emma");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3f41dc87-e8de-42ee-ac8d-355e4d3e1a2d"),
                column: "Title",
                value: "An image by Emma");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5e0e1379-3e8e-4f51-99f1-1fb9ec3a19b0"),
                column: "Title",
                value: "An image by Emma");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ab46efdb-0384-400c-89cb-95bba1c500e9"),
                column: "Title",
                value: "An image by Emma");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ae03d971-40a6-4350-b8a9-7b12e1d93d71"),
                column: "Title",
                value: "An image by Emma");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d3118665-43e3-4905-8848-5e335a428dd5"),
                column: "Title",
                value: "An image by Emma");
        }
    }
}
