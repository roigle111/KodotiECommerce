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
                    { 1, "Description for Product 1", "Product 1", 453m },
                    { 73, "Description for Product 73", "Product 73", 981m },
                    { 72, "Description for Product 72", "Product 72", 740m },
                    { 71, "Description for Product 71", "Product 71", 489m },
                    { 70, "Description for Product 70", "Product 70", 360m },
                    { 69, "Description for Product 69", "Product 69", 236m },
                    { 68, "Description for Product 68", "Product 68", 125m },
                    { 67, "Description for Product 67", "Product 67", 265m },
                    { 66, "Description for Product 66", "Product 66", 772m },
                    { 65, "Description for Product 65", "Product 65", 776m },
                    { 64, "Description for Product 64", "Product 64", 514m },
                    { 63, "Description for Product 63", "Product 63", 546m },
                    { 62, "Description for Product 62", "Product 62", 434m },
                    { 61, "Description for Product 61", "Product 61", 253m },
                    { 60, "Description for Product 60", "Product 60", 692m },
                    { 59, "Description for Product 59", "Product 59", 576m },
                    { 58, "Description for Product 58", "Product 58", 521m },
                    { 57, "Description for Product 57", "Product 57", 609m },
                    { 56, "Description for Product 56", "Product 56", 920m },
                    { 55, "Description for Product 55", "Product 55", 417m },
                    { 54, "Description for Product 54", "Product 54", 364m },
                    { 53, "Description for Product 53", "Product 53", 727m },
                    { 74, "Description for Product 74", "Product 74", 630m },
                    { 52, "Description for Product 52", "Product 52", 153m },
                    { 75, "Description for Product 75", "Product 75", 253m },
                    { 77, "Description for Product 77", "Product 77", 428m },
                    { 98, "Description for Product 98", "Product 98", 690m },
                    { 97, "Description for Product 97", "Product 97", 158m },
                    { 96, "Description for Product 96", "Product 96", 547m },
                    { 95, "Description for Product 95", "Product 95", 516m },
                    { 94, "Description for Product 94", "Product 94", 427m },
                    { 93, "Description for Product 93", "Product 93", 191m },
                    { 92, "Description for Product 92", "Product 92", 894m },
                    { 91, "Description for Product 91", "Product 91", 544m },
                    { 90, "Description for Product 90", "Product 90", 788m },
                    { 89, "Description for Product 89", "Product 89", 146m },
                    { 88, "Description for Product 88", "Product 88", 525m },
                    { 87, "Description for Product 87", "Product 87", 875m },
                    { 86, "Description for Product 86", "Product 86", 547m },
                    { 85, "Description for Product 85", "Product 85", 685m },
                    { 84, "Description for Product 84", "Product 84", 349m },
                    { 83, "Description for Product 83", "Product 83", 734m },
                    { 82, "Description for Product 82", "Product 82", 580m },
                    { 81, "Description for Product 81", "Product 81", 873m },
                    { 80, "Description for Product 80", "Product 80", 647m },
                    { 79, "Description for Product 79", "Product 79", 484m },
                    { 78, "Description for Product 78", "Product 78", 236m },
                    { 76, "Description for Product 76", "Product 76", 434m },
                    { 51, "Description for Product 51", "Product 51", 184m },
                    { 50, "Description for Product 50", "Product 50", 728m },
                    { 49, "Description for Product 49", "Product 49", 868m },
                    { 22, "Description for Product 22", "Product 22", 532m },
                    { 21, "Description for Product 21", "Product 21", 939m },
                    { 20, "Description for Product 20", "Product 20", 136m },
                    { 19, "Description for Product 19", "Product 19", 300m },
                    { 18, "Description for Product 18", "Product 18", 101m },
                    { 17, "Description for Product 17", "Product 17", 407m },
                    { 16, "Description for Product 16", "Product 16", 804m },
                    { 15, "Description for Product 15", "Product 15", 413m },
                    { 14, "Description for Product 14", "Product 14", 846m },
                    { 13, "Description for Product 13", "Product 13", 489m },
                    { 12, "Description for Product 12", "Product 12", 955m },
                    { 11, "Description for Product 11", "Product 11", 375m },
                    { 10, "Description for Product 10", "Product 10", 378m },
                    { 9, "Description for Product 9", "Product 9", 284m },
                    { 8, "Description for Product 8", "Product 8", 524m },
                    { 7, "Description for Product 7", "Product 7", 937m },
                    { 6, "Description for Product 6", "Product 6", 197m },
                    { 5, "Description for Product 5", "Product 5", 185m },
                    { 4, "Description for Product 4", "Product 4", 763m },
                    { 3, "Description for Product 3", "Product 3", 505m },
                    { 2, "Description for Product 2", "Product 2", 189m },
                    { 23, "Description for Product 23", "Product 23", 580m },
                    { 24, "Description for Product 24", "Product 24", 984m },
                    { 25, "Description for Product 25", "Product 25", 287m },
                    { 26, "Description for Product 26", "Product 26", 492m },
                    { 48, "Description for Product 48", "Product 48", 463m },
                    { 47, "Description for Product 47", "Product 47", 619m },
                    { 46, "Description for Product 46", "Product 46", 640m },
                    { 45, "Description for Product 45", "Product 45", 600m },
                    { 44, "Description for Product 44", "Product 44", 444m },
                    { 43, "Description for Product 43", "Product 43", 204m },
                    { 42, "Description for Product 42", "Product 42", 604m },
                    { 41, "Description for Product 41", "Product 41", 882m },
                    { 40, "Description for Product 40", "Product 40", 669m },
                    { 39, "Description for Product 39", "Product 39", 120m },
                    { 99, "Description for Product 99", "Product 99", 667m },
                    { 38, "Description for Product 38", "Product 38", 667m },
                    { 36, "Description for Product 36", "Product 36", 153m },
                    { 35, "Description for Product 35", "Product 35", 709m },
                    { 34, "Description for Product 34", "Product 34", 463m },
                    { 33, "Description for Product 33", "Product 33", 790m },
                    { 32, "Description for Product 32", "Product 32", 602m },
                    { 31, "Description for Product 31", "Product 31", 601m },
                    { 30, "Description for Product 30", "Product 30", 770m },
                    { 29, "Description for Product 29", "Product 29", 978m },
                    { 28, "Description for Product 28", "Product 28", 602m },
                    { 27, "Description for Product 27", "Product 27", 944m },
                    { 37, "Description for Product 37", "Product 37", 415m },
                    { 100, "Description for Product 100", "Product 100", 827m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 14 },
                    { 73, 73, 2 },
                    { 72, 72, 8 },
                    { 71, 71, 18 },
                    { 70, 70, 5 },
                    { 69, 69, 11 },
                    { 68, 68, 0 },
                    { 67, 67, 8 },
                    { 66, 66, 5 },
                    { 65, 65, 12 },
                    { 64, 64, 2 },
                    { 63, 63, 16 },
                    { 62, 62, 11 },
                    { 61, 61, 16 },
                    { 60, 60, 16 },
                    { 59, 59, 5 },
                    { 58, 58, 2 },
                    { 57, 57, 11 },
                    { 56, 56, 5 },
                    { 55, 55, 11 },
                    { 54, 54, 12 },
                    { 53, 53, 2 },
                    { 74, 74, 2 },
                    { 52, 52, 2 },
                    { 75, 75, 13 },
                    { 77, 77, 2 },
                    { 98, 98, 4 },
                    { 97, 97, 14 },
                    { 96, 96, 9 },
                    { 95, 95, 17 },
                    { 94, 94, 12 },
                    { 93, 93, 19 },
                    { 92, 92, 17 },
                    { 91, 91, 19 },
                    { 90, 90, 15 },
                    { 89, 89, 8 },
                    { 88, 88, 0 },
                    { 87, 87, 7 },
                    { 86, 86, 17 },
                    { 85, 85, 4 },
                    { 84, 84, 15 },
                    { 83, 83, 11 },
                    { 82, 82, 10 },
                    { 81, 81, 0 },
                    { 80, 80, 14 },
                    { 79, 79, 0 },
                    { 78, 78, 9 },
                    { 76, 76, 5 },
                    { 51, 51, 9 },
                    { 50, 50, 16 },
                    { 49, 49, 12 },
                    { 22, 22, 9 },
                    { 21, 21, 15 },
                    { 20, 20, 14 },
                    { 19, 19, 15 },
                    { 18, 18, 11 },
                    { 17, 17, 13 },
                    { 16, 16, 18 },
                    { 15, 15, 16 },
                    { 14, 14, 11 },
                    { 13, 13, 19 },
                    { 12, 12, 1 },
                    { 11, 11, 16 },
                    { 10, 10, 13 },
                    { 9, 9, 16 },
                    { 8, 8, 7 },
                    { 7, 7, 15 },
                    { 6, 6, 10 },
                    { 5, 5, 17 },
                    { 4, 4, 7 },
                    { 3, 3, 0 },
                    { 2, 2, 19 },
                    { 23, 23, 7 },
                    { 24, 24, 18 },
                    { 25, 25, 2 },
                    { 26, 26, 0 },
                    { 48, 48, 3 },
                    { 47, 47, 19 },
                    { 46, 46, 7 },
                    { 45, 45, 17 },
                    { 44, 44, 17 },
                    { 43, 43, 7 },
                    { 42, 42, 10 },
                    { 41, 41, 1 },
                    { 40, 40, 13 },
                    { 39, 39, 9 },
                    { 99, 99, 4 },
                    { 38, 38, 5 },
                    { 36, 36, 10 },
                    { 35, 35, 0 },
                    { 34, 34, 19 },
                    { 33, 33, 12 },
                    { 32, 32, 10 },
                    { 31, 31, 0 },
                    { 30, 30, 13 },
                    { 29, 29, 11 },
                    { 28, 28, 4 },
                    { 27, 27, 14 },
                    { 37, 37, 19 },
                    { 100, 100, 11 }
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
