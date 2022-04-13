using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initialize : Migration
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
                    { 1, "Description for Product 1", "Product 1", 435m },
                    { 73, "Description for Product 73", "Product 73", 642m },
                    { 72, "Description for Product 72", "Product 72", 440m },
                    { 71, "Description for Product 71", "Product 71", 518m },
                    { 70, "Description for Product 70", "Product 70", 170m },
                    { 69, "Description for Product 69", "Product 69", 931m },
                    { 68, "Description for Product 68", "Product 68", 941m },
                    { 67, "Description for Product 67", "Product 67", 180m },
                    { 66, "Description for Product 66", "Product 66", 641m },
                    { 65, "Description for Product 65", "Product 65", 370m },
                    { 64, "Description for Product 64", "Product 64", 447m },
                    { 63, "Description for Product 63", "Product 63", 848m },
                    { 62, "Description for Product 62", "Product 62", 799m },
                    { 61, "Description for Product 61", "Product 61", 255m },
                    { 60, "Description for Product 60", "Product 60", 405m },
                    { 59, "Description for Product 59", "Product 59", 234m },
                    { 58, "Description for Product 58", "Product 58", 732m },
                    { 57, "Description for Product 57", "Product 57", 102m },
                    { 56, "Description for Product 56", "Product 56", 374m },
                    { 55, "Description for Product 55", "Product 55", 479m },
                    { 54, "Description for Product 54", "Product 54", 175m },
                    { 53, "Description for Product 53", "Product 53", 966m },
                    { 74, "Description for Product 74", "Product 74", 375m },
                    { 52, "Description for Product 52", "Product 52", 982m },
                    { 75, "Description for Product 75", "Product 75", 626m },
                    { 77, "Description for Product 77", "Product 77", 521m },
                    { 98, "Description for Product 98", "Product 98", 292m },
                    { 97, "Description for Product 97", "Product 97", 211m },
                    { 96, "Description for Product 96", "Product 96", 448m },
                    { 95, "Description for Product 95", "Product 95", 984m },
                    { 94, "Description for Product 94", "Product 94", 642m },
                    { 93, "Description for Product 93", "Product 93", 950m },
                    { 92, "Description for Product 92", "Product 92", 418m },
                    { 91, "Description for Product 91", "Product 91", 866m },
                    { 90, "Description for Product 90", "Product 90", 840m },
                    { 89, "Description for Product 89", "Product 89", 628m },
                    { 88, "Description for Product 88", "Product 88", 105m },
                    { 87, "Description for Product 87", "Product 87", 235m },
                    { 86, "Description for Product 86", "Product 86", 758m },
                    { 85, "Description for Product 85", "Product 85", 183m },
                    { 84, "Description for Product 84", "Product 84", 883m },
                    { 83, "Description for Product 83", "Product 83", 211m },
                    { 82, "Description for Product 82", "Product 82", 719m },
                    { 81, "Description for Product 81", "Product 81", 124m },
                    { 80, "Description for Product 80", "Product 80", 291m },
                    { 79, "Description for Product 79", "Product 79", 329m },
                    { 78, "Description for Product 78", "Product 78", 102m },
                    { 76, "Description for Product 76", "Product 76", 588m },
                    { 51, "Description for Product 51", "Product 51", 687m },
                    { 50, "Description for Product 50", "Product 50", 829m },
                    { 49, "Description for Product 49", "Product 49", 944m },
                    { 22, "Description for Product 22", "Product 22", 161m },
                    { 21, "Description for Product 21", "Product 21", 548m },
                    { 20, "Description for Product 20", "Product 20", 773m },
                    { 19, "Description for Product 19", "Product 19", 515m },
                    { 18, "Description for Product 18", "Product 18", 591m },
                    { 17, "Description for Product 17", "Product 17", 525m },
                    { 16, "Description for Product 16", "Product 16", 569m },
                    { 15, "Description for Product 15", "Product 15", 939m },
                    { 14, "Description for Product 14", "Product 14", 145m },
                    { 13, "Description for Product 13", "Product 13", 948m },
                    { 12, "Description for Product 12", "Product 12", 261m },
                    { 11, "Description for Product 11", "Product 11", 743m },
                    { 10, "Description for Product 10", "Product 10", 110m },
                    { 9, "Description for Product 9", "Product 9", 217m },
                    { 8, "Description for Product 8", "Product 8", 561m },
                    { 7, "Description for Product 7", "Product 7", 854m },
                    { 6, "Description for Product 6", "Product 6", 158m },
                    { 5, "Description for Product 5", "Product 5", 672m },
                    { 4, "Description for Product 4", "Product 4", 529m },
                    { 3, "Description for Product 3", "Product 3", 171m },
                    { 2, "Description for Product 2", "Product 2", 301m },
                    { 23, "Description for Product 23", "Product 23", 299m },
                    { 24, "Description for Product 24", "Product 24", 438m },
                    { 25, "Description for Product 25", "Product 25", 394m },
                    { 26, "Description for Product 26", "Product 26", 366m },
                    { 48, "Description for Product 48", "Product 48", 283m },
                    { 47, "Description for Product 47", "Product 47", 341m },
                    { 46, "Description for Product 46", "Product 46", 203m },
                    { 45, "Description for Product 45", "Product 45", 209m },
                    { 44, "Description for Product 44", "Product 44", 296m },
                    { 43, "Description for Product 43", "Product 43", 639m },
                    { 42, "Description for Product 42", "Product 42", 959m },
                    { 41, "Description for Product 41", "Product 41", 247m },
                    { 40, "Description for Product 40", "Product 40", 240m },
                    { 39, "Description for Product 39", "Product 39", 948m },
                    { 99, "Description for Product 99", "Product 99", 926m },
                    { 38, "Description for Product 38", "Product 38", 185m },
                    { 36, "Description for Product 36", "Product 36", 868m },
                    { 35, "Description for Product 35", "Product 35", 214m },
                    { 34, "Description for Product 34", "Product 34", 107m },
                    { 33, "Description for Product 33", "Product 33", 181m },
                    { 32, "Description for Product 32", "Product 32", 201m },
                    { 31, "Description for Product 31", "Product 31", 740m },
                    { 30, "Description for Product 30", "Product 30", 770m },
                    { 29, "Description for Product 29", "Product 29", 713m },
                    { 28, "Description for Product 28", "Product 28", 155m },
                    { 27, "Description for Product 27", "Product 27", 902m },
                    { 37, "Description for Product 37", "Product 37", 150m },
                    { 100, "Description for Product 100", "Product 100", 568m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 18 },
                    { 73, 73, 13 },
                    { 72, 72, 11 },
                    { 71, 71, 12 },
                    { 70, 70, 0 },
                    { 69, 69, 14 },
                    { 68, 68, 4 },
                    { 67, 67, 19 },
                    { 66, 66, 6 },
                    { 65, 65, 7 },
                    { 64, 64, 4 },
                    { 63, 63, 7 },
                    { 62, 62, 3 },
                    { 61, 61, 9 },
                    { 60, 60, 0 },
                    { 59, 59, 7 },
                    { 58, 58, 17 },
                    { 57, 57, 9 },
                    { 56, 56, 7 },
                    { 55, 55, 3 },
                    { 54, 54, 14 },
                    { 53, 53, 6 },
                    { 74, 74, 9 },
                    { 52, 52, 8 },
                    { 75, 75, 4 },
                    { 77, 77, 1 },
                    { 98, 98, 6 },
                    { 97, 97, 18 },
                    { 96, 96, 13 },
                    { 95, 95, 8 },
                    { 94, 94, 15 },
                    { 93, 93, 9 },
                    { 92, 92, 19 },
                    { 91, 91, 11 },
                    { 90, 90, 10 },
                    { 89, 89, 2 },
                    { 88, 88, 10 },
                    { 87, 87, 2 },
                    { 86, 86, 2 },
                    { 85, 85, 4 },
                    { 84, 84, 16 },
                    { 83, 83, 10 },
                    { 82, 82, 7 },
                    { 81, 81, 13 },
                    { 80, 80, 14 },
                    { 79, 79, 6 },
                    { 78, 78, 14 },
                    { 76, 76, 17 },
                    { 51, 51, 18 },
                    { 50, 50, 2 },
                    { 49, 49, 11 },
                    { 22, 22, 11 },
                    { 21, 21, 3 },
                    { 20, 20, 1 },
                    { 19, 19, 7 },
                    { 18, 18, 8 },
                    { 17, 17, 8 },
                    { 16, 16, 9 },
                    { 15, 15, 2 },
                    { 14, 14, 11 },
                    { 13, 13, 9 },
                    { 12, 12, 4 },
                    { 11, 11, 15 },
                    { 10, 10, 18 },
                    { 9, 9, 7 },
                    { 8, 8, 6 },
                    { 7, 7, 5 },
                    { 6, 6, 11 },
                    { 5, 5, 14 },
                    { 4, 4, 17 },
                    { 3, 3, 12 },
                    { 2, 2, 11 },
                    { 23, 23, 2 },
                    { 24, 24, 14 },
                    { 25, 25, 9 },
                    { 26, 26, 14 },
                    { 48, 48, 14 },
                    { 47, 47, 0 },
                    { 46, 46, 15 },
                    { 45, 45, 8 },
                    { 44, 44, 8 },
                    { 43, 43, 10 },
                    { 42, 42, 5 },
                    { 41, 41, 17 },
                    { 40, 40, 18 },
                    { 39, 39, 15 },
                    { 99, 99, 0 },
                    { 38, 38, 17 },
                    { 36, 36, 1 },
                    { 35, 35, 17 },
                    { 34, 34, 5 },
                    { 33, 33, 5 },
                    { 32, 32, 9 },
                    { 31, 31, 11 },
                    { 30, 30, 3 },
                    { 29, 29, 18 },
                    { 28, 28, 1 },
                    { 27, 27, 1 },
                    { 37, 37, 17 },
                    { 100, 100, 1 }
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
