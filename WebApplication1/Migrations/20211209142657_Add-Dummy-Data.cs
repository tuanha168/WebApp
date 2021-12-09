using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description", "Picture" },
                values: new object[] { 1, "category 1", null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Discontinued", "ProductName", "QuantityPerUnit", "ReorderLevel", "SupplierId", "UnitInStock", "UnitOnOrder", "UnitPrice" },
                values: new object[] { 1, 1, 0, "product 1", 0, 0, 0, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Discontinued", "ProductName", "QuantityPerUnit", "ReorderLevel", "SupplierId", "UnitInStock", "UnitOnOrder", "UnitPrice" },
                values: new object[] { 2, 1, 0, "product 2", 0, 0, 0, 0, 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
        }
    }
}
