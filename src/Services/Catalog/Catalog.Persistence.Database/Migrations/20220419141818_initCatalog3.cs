using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initCatalog3 : Migration
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
                    { 1, "Description for Product 1", "Product 1", 566m },
                    { 73, "Description for Product 73", "Product 73", 848m },
                    { 72, "Description for Product 72", "Product 72", 734m },
                    { 71, "Description for Product 71", "Product 71", 331m },
                    { 70, "Description for Product 70", "Product 70", 898m },
                    { 69, "Description for Product 69", "Product 69", 135m },
                    { 68, "Description for Product 68", "Product 68", 919m },
                    { 67, "Description for Product 67", "Product 67", 213m },
                    { 66, "Description for Product 66", "Product 66", 314m },
                    { 65, "Description for Product 65", "Product 65", 847m },
                    { 64, "Description for Product 64", "Product 64", 606m },
                    { 63, "Description for Product 63", "Product 63", 865m },
                    { 62, "Description for Product 62", "Product 62", 531m },
                    { 61, "Description for Product 61", "Product 61", 783m },
                    { 60, "Description for Product 60", "Product 60", 877m },
                    { 59, "Description for Product 59", "Product 59", 168m },
                    { 58, "Description for Product 58", "Product 58", 475m },
                    { 57, "Description for Product 57", "Product 57", 908m },
                    { 56, "Description for Product 56", "Product 56", 832m },
                    { 55, "Description for Product 55", "Product 55", 167m },
                    { 54, "Description for Product 54", "Product 54", 861m },
                    { 53, "Description for Product 53", "Product 53", 403m },
                    { 74, "Description for Product 74", "Product 74", 342m },
                    { 52, "Description for Product 52", "Product 52", 761m },
                    { 75, "Description for Product 75", "Product 75", 205m },
                    { 77, "Description for Product 77", "Product 77", 717m },
                    { 98, "Description for Product 98", "Product 98", 510m },
                    { 97, "Description for Product 97", "Product 97", 380m },
                    { 96, "Description for Product 96", "Product 96", 874m },
                    { 95, "Description for Product 95", "Product 95", 344m },
                    { 94, "Description for Product 94", "Product 94", 513m },
                    { 93, "Description for Product 93", "Product 93", 512m },
                    { 92, "Description for Product 92", "Product 92", 510m },
                    { 91, "Description for Product 91", "Product 91", 394m },
                    { 90, "Description for Product 90", "Product 90", 760m },
                    { 89, "Description for Product 89", "Product 89", 578m },
                    { 88, "Description for Product 88", "Product 88", 149m },
                    { 87, "Description for Product 87", "Product 87", 546m },
                    { 86, "Description for Product 86", "Product 86", 633m },
                    { 85, "Description for Product 85", "Product 85", 612m },
                    { 84, "Description for Product 84", "Product 84", 227m },
                    { 83, "Description for Product 83", "Product 83", 210m },
                    { 82, "Description for Product 82", "Product 82", 880m },
                    { 81, "Description for Product 81", "Product 81", 730m },
                    { 80, "Description for Product 80", "Product 80", 435m },
                    { 79, "Description for Product 79", "Product 79", 416m },
                    { 78, "Description for Product 78", "Product 78", 924m },
                    { 76, "Description for Product 76", "Product 76", 549m },
                    { 51, "Description for Product 51", "Product 51", 894m },
                    { 50, "Description for Product 50", "Product 50", 740m },
                    { 49, "Description for Product 49", "Product 49", 700m },
                    { 22, "Description for Product 22", "Product 22", 734m },
                    { 21, "Description for Product 21", "Product 21", 695m },
                    { 20, "Description for Product 20", "Product 20", 511m },
                    { 19, "Description for Product 19", "Product 19", 369m },
                    { 18, "Description for Product 18", "Product 18", 238m },
                    { 17, "Description for Product 17", "Product 17", 315m },
                    { 16, "Description for Product 16", "Product 16", 216m },
                    { 15, "Description for Product 15", "Product 15", 201m },
                    { 14, "Description for Product 14", "Product 14", 628m },
                    { 13, "Description for Product 13", "Product 13", 565m },
                    { 12, "Description for Product 12", "Product 12", 123m },
                    { 11, "Description for Product 11", "Product 11", 164m },
                    { 10, "Description for Product 10", "Product 10", 241m },
                    { 9, "Description for Product 9", "Product 9", 114m },
                    { 8, "Description for Product 8", "Product 8", 732m },
                    { 7, "Description for Product 7", "Product 7", 342m },
                    { 6, "Description for Product 6", "Product 6", 988m },
                    { 5, "Description for Product 5", "Product 5", 775m },
                    { 4, "Description for Product 4", "Product 4", 295m },
                    { 3, "Description for Product 3", "Product 3", 303m },
                    { 2, "Description for Product 2", "Product 2", 360m },
                    { 23, "Description for Product 23", "Product 23", 451m },
                    { 24, "Description for Product 24", "Product 24", 827m },
                    { 25, "Description for Product 25", "Product 25", 227m },
                    { 26, "Description for Product 26", "Product 26", 897m },
                    { 48, "Description for Product 48", "Product 48", 425m },
                    { 47, "Description for Product 47", "Product 47", 267m },
                    { 46, "Description for Product 46", "Product 46", 791m },
                    { 45, "Description for Product 45", "Product 45", 511m },
                    { 44, "Description for Product 44", "Product 44", 527m },
                    { 43, "Description for Product 43", "Product 43", 116m },
                    { 42, "Description for Product 42", "Product 42", 245m },
                    { 41, "Description for Product 41", "Product 41", 405m },
                    { 40, "Description for Product 40", "Product 40", 127m },
                    { 39, "Description for Product 39", "Product 39", 390m },
                    { 99, "Description for Product 99", "Product 99", 679m },
                    { 38, "Description for Product 38", "Product 38", 580m },
                    { 36, "Description for Product 36", "Product 36", 303m },
                    { 35, "Description for Product 35", "Product 35", 592m },
                    { 34, "Description for Product 34", "Product 34", 645m },
                    { 33, "Description for Product 33", "Product 33", 910m },
                    { 32, "Description for Product 32", "Product 32", 849m },
                    { 31, "Description for Product 31", "Product 31", 394m },
                    { 30, "Description for Product 30", "Product 30", 507m },
                    { 29, "Description for Product 29", "Product 29", 867m },
                    { 28, "Description for Product 28", "Product 28", 811m },
                    { 27, "Description for Product 27", "Product 27", 305m },
                    { 37, "Description for Product 37", "Product 37", 885m },
                    { 100, "Description for Product 100", "Product 100", 296m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 73, 73, 16 },
                    { 72, 72, 2 },
                    { 71, 71, 5 },
                    { 70, 70, 10 },
                    { 69, 69, 0 },
                    { 68, 68, 11 },
                    { 67, 67, 15 },
                    { 66, 66, 3 },
                    { 65, 65, 16 },
                    { 64, 64, 18 },
                    { 63, 63, 1 },
                    { 62, 62, 2 },
                    { 61, 61, 3 },
                    { 60, 60, 8 },
                    { 59, 59, 3 },
                    { 58, 58, 16 },
                    { 57, 57, 14 },
                    { 56, 56, 5 },
                    { 55, 55, 4 },
                    { 54, 54, 6 },
                    { 53, 53, 8 },
                    { 74, 74, 1 },
                    { 52, 52, 10 },
                    { 75, 75, 3 },
                    { 77, 77, 15 },
                    { 98, 98, 5 },
                    { 97, 97, 6 },
                    { 96, 96, 16 },
                    { 95, 95, 6 },
                    { 94, 94, 19 },
                    { 93, 93, 11 },
                    { 92, 92, 15 },
                    { 91, 91, 0 },
                    { 90, 90, 19 },
                    { 89, 89, 5 },
                    { 88, 88, 14 },
                    { 87, 87, 0 },
                    { 86, 86, 1 },
                    { 85, 85, 3 },
                    { 84, 84, 7 },
                    { 83, 83, 8 },
                    { 82, 82, 10 },
                    { 81, 81, 6 },
                    { 80, 80, 16 },
                    { 79, 79, 7 },
                    { 78, 78, 8 },
                    { 76, 76, 10 },
                    { 51, 51, 17 },
                    { 50, 50, 5 },
                    { 49, 49, 4 },
                    { 22, 22, 19 },
                    { 21, 21, 19 },
                    { 20, 20, 2 },
                    { 19, 19, 10 },
                    { 18, 18, 4 },
                    { 17, 17, 18 },
                    { 16, 16, 18 },
                    { 15, 15, 4 },
                    { 14, 14, 5 },
                    { 13, 13, 1 },
                    { 12, 12, 16 },
                    { 11, 11, 12 },
                    { 10, 10, 8 },
                    { 9, 9, 19 },
                    { 8, 8, 14 },
                    { 7, 7, 15 },
                    { 6, 6, 9 },
                    { 5, 5, 0 },
                    { 4, 4, 9 },
                    { 3, 3, 6 },
                    { 2, 2, 14 },
                    { 23, 23, 0 },
                    { 24, 24, 10 },
                    { 25, 25, 5 },
                    { 26, 26, 12 },
                    { 48, 48, 15 },
                    { 47, 47, 5 },
                    { 46, 46, 8 },
                    { 45, 45, 2 },
                    { 44, 44, 12 },
                    { 43, 43, 4 },
                    { 42, 42, 8 },
                    { 41, 41, 19 },
                    { 40, 40, 9 },
                    { 39, 39, 7 },
                    { 99, 99, 15 },
                    { 38, 38, 15 },
                    { 36, 36, 14 },
                    { 35, 35, 4 },
                    { 34, 34, 9 },
                    { 33, 33, 1 },
                    { 32, 32, 8 },
                    { 31, 31, 11 },
                    { 30, 30, 1 },
                    { 29, 29, 12 },
                    { 28, 28, 12 },
                    { 27, 27, 6 },
                    { 37, 37, 12 },
                    { 100, 100, 19 }
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
