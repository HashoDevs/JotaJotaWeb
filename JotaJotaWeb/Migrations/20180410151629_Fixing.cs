using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace JotaJotaWeb.Migrations
{
    public partial class Fixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopThree",
                table: "Products",
                newName: "Top");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Products",
                newName: "ImagePath");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "AltTag",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Top",
                table: "Services",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AltTag",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltTag",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Top",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "AltTag",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Top",
                table: "Products",
                newName: "TopThree");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Products",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "ImageUrl");
        }
    }
}
