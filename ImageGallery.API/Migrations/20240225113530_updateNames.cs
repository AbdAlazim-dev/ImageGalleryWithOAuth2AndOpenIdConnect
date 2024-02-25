using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImageGallery.API.Migrations
{
    public partial class updateNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("1efe7a31-8dcc-4ff0-9b2d-5f148e2989cc"),
                column: "Title",
                value: "An image by Azim");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                column: "Title",
                value: "An image by Azim");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("939df3fd-de57-4caf-96dc-c5e110322a96"),
                column: "Title",
                value: "An image by Azim");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9f35e705-637a-4bbe-8c35-402b2ecf7128"),
                column: "Title",
                value: "An image by Azim");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b24e3df5-0394-468d-9c1d-db1252fea920"),
                column: "Title",
                value: "An image by Azim");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ce1d2b1c-7869-4df5-9a32-2cbaca8c3234"),
                column: "Title",
                value: "An image by Azim");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d70f656d-75a7-45fc-b385-e4daa834e6a8"),
                column: "Title",
                value: "An image by Azim");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("1efe7a31-8dcc-4ff0-9b2d-5f148e2989cc"),
                column: "Title",
                value: "An image by David");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                column: "Title",
                value: "An image by David");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("939df3fd-de57-4caf-96dc-c5e110322a96"),
                column: "Title",
                value: "An image by David");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9f35e705-637a-4bbe-8c35-402b2ecf7128"),
                column: "Title",
                value: "An image by David");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b24e3df5-0394-468d-9c1d-db1252fea920"),
                column: "Title",
                value: "An image by David");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ce1d2b1c-7869-4df5-9a32-2cbaca8c3234"),
                column: "Title",
                value: "An image by David");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d70f656d-75a7-45fc-b385-e4daa834e6a8"),
                column: "Title",
                value: "An image by David");
        }
    }
}
