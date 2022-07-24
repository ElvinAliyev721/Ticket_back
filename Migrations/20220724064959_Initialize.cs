using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticket.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Sliders",
                newName: "ImageText");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Blogs",
                newName: "Title");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Warrants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "Warrants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Warrants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Blogs",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Warrants");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "Warrants");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Warrants");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "ImageText",
                table: "Sliders",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Blogs",
                newName: "Name");
        }
    }
}
