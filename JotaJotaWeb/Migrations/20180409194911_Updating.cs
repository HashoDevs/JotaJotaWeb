using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace JotaJotaWeb.Migrations
{
    public partial class Updating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductsGen_ProductGenId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "ProductsGen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductGenId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductGenId",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "Enabled",
                table: "Products",
                newName: "TopThree");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "ShortDescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "TopThree",
                table: "Product",
                newName: "Enabled");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Product",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "ProductGenId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductsGen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    TopThree = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsGen", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductGenId",
                table: "Product",
                column: "ProductGenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductsGen_ProductGenId",
                table: "Product",
                column: "ProductGenId",
                principalTable: "ProductsGen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
