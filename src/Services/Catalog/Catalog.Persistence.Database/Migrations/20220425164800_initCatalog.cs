using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for Product 1", "Product 1", 366m },
                    { 73, "Description for Product 73", "Product 73", 118m },
                    { 72, "Description for Product 72", "Product 72", 118m },
                    { 71, "Description for Product 71", "Product 71", 946m },
                    { 70, "Description for Product 70", "Product 70", 237m },
                    { 69, "Description for Product 69", "Product 69", 544m },
                    { 68, "Description for Product 68", "Product 68", 739m },
                    { 67, "Description for Product 67", "Product 67", 394m },
                    { 66, "Description for Product 66", "Product 66", 530m },
                    { 65, "Description for Product 65", "Product 65", 625m },
                    { 64, "Description for Product 64", "Product 64", 694m },
                    { 63, "Description for Product 63", "Product 63", 370m },
                    { 62, "Description for Product 62", "Product 62", 838m },
                    { 61, "Description for Product 61", "Product 61", 439m },
                    { 60, "Description for Product 60", "Product 60", 404m },
                    { 59, "Description for Product 59", "Product 59", 880m },
                    { 58, "Description for Product 58", "Product 58", 703m },
                    { 57, "Description for Product 57", "Product 57", 761m },
                    { 56, "Description for Product 56", "Product 56", 968m },
                    { 55, "Description for Product 55", "Product 55", 780m },
                    { 54, "Description for Product 54", "Product 54", 587m },
                    { 53, "Description for Product 53", "Product 53", 878m },
                    { 74, "Description for Product 74", "Product 74", 896m },
                    { 52, "Description for Product 52", "Product 52", 193m },
                    { 75, "Description for Product 75", "Product 75", 580m },
                    { 77, "Description for Product 77", "Product 77", 586m },
                    { 98, "Description for Product 98", "Product 98", 216m },
                    { 97, "Description for Product 97", "Product 97", 380m },
                    { 96, "Description for Product 96", "Product 96", 498m },
                    { 95, "Description for Product 95", "Product 95", 614m },
                    { 94, "Description for Product 94", "Product 94", 569m },
                    { 93, "Description for Product 93", "Product 93", 521m },
                    { 92, "Description for Product 92", "Product 92", 803m },
                    { 91, "Description for Product 91", "Product 91", 477m },
                    { 90, "Description for Product 90", "Product 90", 346m },
                    { 89, "Description for Product 89", "Product 89", 685m },
                    { 88, "Description for Product 88", "Product 88", 123m },
                    { 87, "Description for Product 87", "Product 87", 520m },
                    { 86, "Description for Product 86", "Product 86", 192m },
                    { 85, "Description for Product 85", "Product 85", 718m },
                    { 84, "Description for Product 84", "Product 84", 169m },
                    { 83, "Description for Product 83", "Product 83", 254m },
                    { 82, "Description for Product 82", "Product 82", 440m },
                    { 81, "Description for Product 81", "Product 81", 184m },
                    { 80, "Description for Product 80", "Product 80", 645m },
                    { 79, "Description for Product 79", "Product 79", 439m },
                    { 78, "Description for Product 78", "Product 78", 777m },
                    { 76, "Description for Product 76", "Product 76", 309m },
                    { 51, "Description for Product 51", "Product 51", 389m },
                    { 50, "Description for Product 50", "Product 50", 413m },
                    { 49, "Description for Product 49", "Product 49", 113m },
                    { 22, "Description for Product 22", "Product 22", 397m },
                    { 21, "Description for Product 21", "Product 21", 860m },
                    { 20, "Description for Product 20", "Product 20", 816m },
                    { 19, "Description for Product 19", "Product 19", 849m },
                    { 18, "Description for Product 18", "Product 18", 892m },
                    { 17, "Description for Product 17", "Product 17", 420m },
                    { 16, "Description for Product 16", "Product 16", 454m },
                    { 15, "Description for Product 15", "Product 15", 376m },
                    { 14, "Description for Product 14", "Product 14", 759m },
                    { 13, "Description for Product 13", "Product 13", 205m },
                    { 12, "Description for Product 12", "Product 12", 906m },
                    { 11, "Description for Product 11", "Product 11", 828m },
                    { 10, "Description for Product 10", "Product 10", 811m },
                    { 9, "Description for Product 9", "Product 9", 702m },
                    { 8, "Description for Product 8", "Product 8", 754m },
                    { 7, "Description for Product 7", "Product 7", 105m },
                    { 6, "Description for Product 6", "Product 6", 753m },
                    { 5, "Description for Product 5", "Product 5", 561m },
                    { 4, "Description for Product 4", "Product 4", 398m },
                    { 3, "Description for Product 3", "Product 3", 476m },
                    { 2, "Description for Product 2", "Product 2", 327m },
                    { 23, "Description for Product 23", "Product 23", 566m },
                    { 24, "Description for Product 24", "Product 24", 772m },
                    { 25, "Description for Product 25", "Product 25", 517m },
                    { 26, "Description for Product 26", "Product 26", 257m },
                    { 48, "Description for Product 48", "Product 48", 973m },
                    { 47, "Description for Product 47", "Product 47", 172m },
                    { 46, "Description for Product 46", "Product 46", 871m },
                    { 45, "Description for Product 45", "Product 45", 433m },
                    { 44, "Description for Product 44", "Product 44", 788m },
                    { 43, "Description for Product 43", "Product 43", 811m },
                    { 42, "Description for Product 42", "Product 42", 651m },
                    { 41, "Description for Product 41", "Product 41", 336m },
                    { 40, "Description for Product 40", "Product 40", 953m },
                    { 39, "Description for Product 39", "Product 39", 873m },
                    { 99, "Description for Product 99", "Product 99", 262m },
                    { 38, "Description for Product 38", "Product 38", 401m },
                    { 36, "Description for Product 36", "Product 36", 238m },
                    { 35, "Description for Product 35", "Product 35", 315m },
                    { 34, "Description for Product 34", "Product 34", 466m },
                    { 33, "Description for Product 33", "Product 33", 611m },
                    { 32, "Description for Product 32", "Product 32", 398m },
                    { 31, "Description for Product 31", "Product 31", 285m },
                    { 30, "Description for Product 30", "Product 30", 107m },
                    { 29, "Description for Product 29", "Product 29", 483m },
                    { 28, "Description for Product 28", "Product 28", 267m },
                    { 27, "Description for Product 27", "Product 27", 414m },
                    { 37, "Description for Product 37", "Product 37", 507m },
                    { 100, "Description for Product 100", "Product 100", 903m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 18 },
                    { 73, 73, 0 },
                    { 72, 72, 5 },
                    { 71, 71, 6 },
                    { 70, 70, 17 },
                    { 69, 69, 5 },
                    { 68, 68, 12 },
                    { 67, 67, 7 },
                    { 66, 66, 11 },
                    { 65, 65, 11 },
                    { 64, 64, 15 },
                    { 63, 63, 1 },
                    { 62, 62, 8 },
                    { 61, 61, 11 },
                    { 60, 60, 14 },
                    { 59, 59, 8 },
                    { 58, 58, 16 },
                    { 57, 57, 14 },
                    { 56, 56, 5 },
                    { 55, 55, 15 },
                    { 54, 54, 15 },
                    { 53, 53, 6 },
                    { 74, 74, 10 },
                    { 52, 52, 3 },
                    { 75, 75, 12 },
                    { 77, 77, 8 },
                    { 98, 98, 8 },
                    { 97, 97, 15 },
                    { 96, 96, 15 },
                    { 95, 95, 4 },
                    { 94, 94, 17 },
                    { 93, 93, 8 },
                    { 92, 92, 3 },
                    { 91, 91, 6 },
                    { 90, 90, 1 },
                    { 89, 89, 7 },
                    { 88, 88, 7 },
                    { 87, 87, 13 },
                    { 86, 86, 3 },
                    { 85, 85, 8 },
                    { 84, 84, 16 },
                    { 83, 83, 16 },
                    { 82, 82, 10 },
                    { 81, 81, 1 },
                    { 80, 80, 10 },
                    { 79, 79, 9 },
                    { 78, 78, 15 },
                    { 76, 76, 11 },
                    { 51, 51, 12 },
                    { 50, 50, 4 },
                    { 49, 49, 19 },
                    { 22, 22, 13 },
                    { 21, 21, 8 },
                    { 20, 20, 16 },
                    { 19, 19, 6 },
                    { 18, 18, 13 },
                    { 17, 17, 1 },
                    { 16, 16, 6 },
                    { 15, 15, 19 },
                    { 14, 14, 12 },
                    { 13, 13, 15 },
                    { 12, 12, 10 },
                    { 11, 11, 10 },
                    { 10, 10, 18 },
                    { 9, 9, 16 },
                    { 8, 8, 2 },
                    { 7, 7, 3 },
                    { 6, 6, 16 },
                    { 5, 5, 0 },
                    { 4, 4, 7 },
                    { 3, 3, 11 },
                    { 2, 2, 18 },
                    { 23, 23, 4 },
                    { 24, 24, 15 },
                    { 25, 25, 19 },
                    { 26, 26, 5 },
                    { 48, 48, 14 },
                    { 47, 47, 4 },
                    { 46, 46, 8 },
                    { 45, 45, 6 },
                    { 44, 44, 8 },
                    { 43, 43, 4 },
                    { 42, 42, 17 },
                    { 41, 41, 3 },
                    { 40, 40, 16 },
                    { 39, 39, 12 },
                    { 99, 99, 17 },
                    { 38, 38, 16 },
                    { 36, 36, 1 },
                    { 35, 35, 6 },
                    { 34, 34, 3 },
                    { 33, 33, 3 },
                    { 32, 32, 19 },
                    { 31, 31, 7 },
                    { 30, 30, 0 },
                    { 29, 29, 1 },
                    { 28, 28, 15 },
                    { 27, 27, 4 },
                    { 37, 37, 19 },
                    { 100, 100, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
