using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _01080312 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "FurnitureProduct");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "FurnitureCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FurnitureProduct",
                table: "FurnitureProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FurnitureCategory",
                table: "FurnitureCategory",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FurnitureProduct",
                table: "FurnitureProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FurnitureCategory",
                table: "FurnitureCategory");

            migrationBuilder.RenameTable(
                name: "FurnitureProduct",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "FurnitureCategory",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");
        }
    }
}
