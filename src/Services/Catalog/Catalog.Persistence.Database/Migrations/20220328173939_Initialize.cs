using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
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
                    Price = table.Column<decimal>(nullable: false)
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
                    { 1, "Description for Product 1", "Product 1", 962m },
                    { 73, "Description for Product 73", "Product 73", 960m },
                    { 72, "Description for Product 72", "Product 72", 612m },
                    { 71, "Description for Product 71", "Product 71", 249m },
                    { 70, "Description for Product 70", "Product 70", 117m },
                    { 69, "Description for Product 69", "Product 69", 716m },
                    { 68, "Description for Product 68", "Product 68", 438m },
                    { 67, "Description for Product 67", "Product 67", 753m },
                    { 66, "Description for Product 66", "Product 66", 741m },
                    { 65, "Description for Product 65", "Product 65", 294m },
                    { 64, "Description for Product 64", "Product 64", 532m },
                    { 63, "Description for Product 63", "Product 63", 120m },
                    { 62, "Description for Product 62", "Product 62", 905m },
                    { 61, "Description for Product 61", "Product 61", 110m },
                    { 60, "Description for Product 60", "Product 60", 703m },
                    { 59, "Description for Product 59", "Product 59", 461m },
                    { 58, "Description for Product 58", "Product 58", 112m },
                    { 57, "Description for Product 57", "Product 57", 768m },
                    { 56, "Description for Product 56", "Product 56", 703m },
                    { 55, "Description for Product 55", "Product 55", 118m },
                    { 54, "Description for Product 54", "Product 54", 813m },
                    { 53, "Description for Product 53", "Product 53", 173m },
                    { 74, "Description for Product 74", "Product 74", 893m },
                    { 52, "Description for Product 52", "Product 52", 972m },
                    { 75, "Description for Product 75", "Product 75", 811m },
                    { 77, "Description for Product 77", "Product 77", 703m },
                    { 98, "Description for Product 98", "Product 98", 223m },
                    { 97, "Description for Product 97", "Product 97", 184m },
                    { 96, "Description for Product 96", "Product 96", 505m },
                    { 95, "Description for Product 95", "Product 95", 195m },
                    { 94, "Description for Product 94", "Product 94", 154m },
                    { 93, "Description for Product 93", "Product 93", 851m },
                    { 92, "Description for Product 92", "Product 92", 210m },
                    { 91, "Description for Product 91", "Product 91", 829m },
                    { 90, "Description for Product 90", "Product 90", 184m },
                    { 89, "Description for Product 89", "Product 89", 937m },
                    { 88, "Description for Product 88", "Product 88", 195m },
                    { 87, "Description for Product 87", "Product 87", 504m },
                    { 86, "Description for Product 86", "Product 86", 642m },
                    { 85, "Description for Product 85", "Product 85", 609m },
                    { 84, "Description for Product 84", "Product 84", 426m },
                    { 83, "Description for Product 83", "Product 83", 209m },
                    { 82, "Description for Product 82", "Product 82", 929m },
                    { 81, "Description for Product 81", "Product 81", 773m },
                    { 80, "Description for Product 80", "Product 80", 827m },
                    { 79, "Description for Product 79", "Product 79", 233m },
                    { 78, "Description for Product 78", "Product 78", 409m },
                    { 76, "Description for Product 76", "Product 76", 488m },
                    { 51, "Description for Product 51", "Product 51", 494m },
                    { 50, "Description for Product 50", "Product 50", 737m },
                    { 49, "Description for Product 49", "Product 49", 375m },
                    { 22, "Description for Product 22", "Product 22", 359m },
                    { 21, "Description for Product 21", "Product 21", 593m },
                    { 20, "Description for Product 20", "Product 20", 221m },
                    { 19, "Description for Product 19", "Product 19", 100m },
                    { 18, "Description for Product 18", "Product 18", 719m },
                    { 17, "Description for Product 17", "Product 17", 826m },
                    { 16, "Description for Product 16", "Product 16", 371m },
                    { 15, "Description for Product 15", "Product 15", 616m },
                    { 14, "Description for Product 14", "Product 14", 505m },
                    { 13, "Description for Product 13", "Product 13", 394m },
                    { 12, "Description for Product 12", "Product 12", 663m },
                    { 11, "Description for Product 11", "Product 11", 318m },
                    { 10, "Description for Product 10", "Product 10", 808m },
                    { 9, "Description for Product 9", "Product 9", 535m },
                    { 8, "Description for Product 8", "Product 8", 184m },
                    { 7, "Description for Product 7", "Product 7", 391m },
                    { 6, "Description for Product 6", "Product 6", 267m },
                    { 5, "Description for Product 5", "Product 5", 784m },
                    { 4, "Description for Product 4", "Product 4", 407m },
                    { 3, "Description for Product 3", "Product 3", 472m },
                    { 2, "Description for Product 2", "Product 2", 447m },
                    { 23, "Description for Product 23", "Product 23", 678m },
                    { 24, "Description for Product 24", "Product 24", 460m },
                    { 25, "Description for Product 25", "Product 25", 945m },
                    { 26, "Description for Product 26", "Product 26", 180m },
                    { 48, "Description for Product 48", "Product 48", 326m },
                    { 47, "Description for Product 47", "Product 47", 406m },
                    { 46, "Description for Product 46", "Product 46", 217m },
                    { 45, "Description for Product 45", "Product 45", 327m },
                    { 44, "Description for Product 44", "Product 44", 368m },
                    { 43, "Description for Product 43", "Product 43", 656m },
                    { 42, "Description for Product 42", "Product 42", 205m },
                    { 41, "Description for Product 41", "Product 41", 410m },
                    { 40, "Description for Product 40", "Product 40", 206m },
                    { 39, "Description for Product 39", "Product 39", 758m },
                    { 99, "Description for Product 99", "Product 99", 174m },
                    { 38, "Description for Product 38", "Product 38", 313m },
                    { 36, "Description for Product 36", "Product 36", 598m },
                    { 35, "Description for Product 35", "Product 35", 788m },
                    { 34, "Description for Product 34", "Product 34", 955m },
                    { 33, "Description for Product 33", "Product 33", 909m },
                    { 32, "Description for Product 32", "Product 32", 577m },
                    { 31, "Description for Product 31", "Product 31", 614m },
                    { 30, "Description for Product 30", "Product 30", 103m },
                    { 29, "Description for Product 29", "Product 29", 163m },
                    { 28, "Description for Product 28", "Product 28", 485m },
                    { 27, "Description for Product 27", "Product 27", 256m },
                    { 37, "Description for Product 37", "Product 37", 222m },
                    { 100, "Description for Product 100", "Product 100", 585m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 73, 73, 8 },
                    { 72, 72, 16 },
                    { 71, 71, 17 },
                    { 70, 70, 11 },
                    { 69, 69, 13 },
                    { 68, 68, 16 },
                    { 67, 67, 2 },
                    { 66, 66, 19 },
                    { 65, 65, 18 },
                    { 64, 64, 7 },
                    { 63, 63, 0 },
                    { 62, 62, 6 },
                    { 61, 61, 18 },
                    { 60, 60, 13 },
                    { 59, 59, 6 },
                    { 58, 58, 2 },
                    { 57, 57, 13 },
                    { 56, 56, 13 },
                    { 55, 55, 15 },
                    { 54, 54, 1 },
                    { 53, 53, 3 },
                    { 74, 74, 8 },
                    { 52, 52, 0 },
                    { 75, 75, 2 },
                    { 77, 77, 1 },
                    { 98, 98, 18 },
                    { 97, 97, 16 },
                    { 96, 96, 14 },
                    { 95, 95, 2 },
                    { 94, 94, 11 },
                    { 93, 93, 12 },
                    { 92, 92, 5 },
                    { 91, 91, 9 },
                    { 90, 90, 5 },
                    { 89, 89, 9 },
                    { 88, 88, 6 },
                    { 87, 87, 16 },
                    { 86, 86, 9 },
                    { 85, 85, 11 },
                    { 84, 84, 12 },
                    { 83, 83, 15 },
                    { 82, 82, 15 },
                    { 81, 81, 11 },
                    { 80, 80, 12 },
                    { 79, 79, 4 },
                    { 78, 78, 15 },
                    { 76, 76, 3 },
                    { 51, 51, 8 },
                    { 50, 50, 12 },
                    { 49, 49, 6 },
                    { 22, 22, 7 },
                    { 21, 21, 1 },
                    { 20, 20, 3 },
                    { 19, 19, 8 },
                    { 18, 18, 13 },
                    { 17, 17, 15 },
                    { 16, 16, 6 },
                    { 15, 15, 13 },
                    { 14, 14, 13 },
                    { 13, 13, 1 },
                    { 12, 12, 9 },
                    { 11, 11, 0 },
                    { 10, 10, 8 },
                    { 9, 9, 8 },
                    { 8, 8, 6 },
                    { 7, 7, 7 },
                    { 6, 6, 11 },
                    { 5, 5, 3 },
                    { 4, 4, 1 },
                    { 3, 3, 13 },
                    { 2, 2, 18 },
                    { 23, 23, 5 },
                    { 24, 24, 10 },
                    { 25, 25, 14 },
                    { 26, 26, 9 },
                    { 48, 48, 17 },
                    { 47, 47, 17 },
                    { 46, 46, 1 },
                    { 45, 45, 6 },
                    { 44, 44, 9 },
                    { 43, 43, 5 },
                    { 42, 42, 17 },
                    { 41, 41, 0 },
                    { 40, 40, 0 },
                    { 39, 39, 5 },
                    { 99, 99, 11 },
                    { 38, 38, 19 },
                    { 36, 36, 2 },
                    { 35, 35, 19 },
                    { 34, 34, 5 },
                    { 33, 33, 7 },
                    { 32, 32, 0 },
                    { 31, 31, 9 },
                    { 30, 30, 0 },
                    { 29, 29, 5 },
                    { 28, 28, 1 },
                    { 27, 27, 13 },
                    { 37, 37, 8 },
                    { 100, 100, 6 }
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
