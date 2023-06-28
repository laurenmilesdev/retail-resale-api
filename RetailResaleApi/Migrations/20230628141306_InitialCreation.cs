using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RetailResaleApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchasePrice = table.Column<double>(type: "float", nullable: false),
                    Fee = table.Column<double>(type: "float", nullable: true),
                    Shipping = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListingSite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingSite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Size = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SizeType = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PurchasePrice = table.Column<double>(type: "float", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_SubCategory_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListingSiteProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ListingSiteId = table.Column<int>(type: "int", nullable: false),
                    ListedPrice = table.Column<double>(type: "float", nullable: false),
                    DateListed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UrlToListing = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingSiteProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListingSiteProduct_ListingSite_ListingSiteId",
                        column: x => x.ListingSiteId,
                        principalTable: "ListingSite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListingSiteProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sold",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingSiteProductId = table.Column<int>(type: "int", nullable: false),
                    SoldPrice = table.Column<double>(type: "float", nullable: false),
                    Fee = table.Column<double>(type: "float", nullable: true),
                    ShippingCost = table.Column<double>(type: "float", nullable: true),
                    SoldDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sold", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sold_ListingSiteProduct_ListingSiteProductId",
                        column: x => x.ListingSiteProductId,
                        principalTable: "ListingSiteProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, "Accessories" },
                    { 2, "Dresses" },
                    { 3, "Jackets/Coats" },
                    { 4, "Jeans" },
                    { 5, "Pants" },
                    { 6, "Shirts/Tops" },
                    { 7, "Shoes" },
                    { 8, "Shorts" },
                    { 9, "Skirts" },
                    { 10, "Sweaters" },
                    { 11, "Other" }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "CategoryId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Bags" },
                    { 2, 1, "Belt" },
                    { 3, 1, "Hat" },
                    { 4, 1, "Scarf" },
                    { 5, 1, "Sunglasses" },
                    { 6, 1, "Suspenders" },
                    { 7, 1, "Ties" },
                    { 8, 1, "Watch" },
                    { 9, 1, "Other" },
                    { 10, 2, "Asymmetrical" },
                    { 11, 2, "Backless" },
                    { 12, 2, "High Low" },
                    { 13, 2, "Long Sleeve" },
                    { 14, 2, "Maxi" },
                    { 15, 2, "Midi" },
                    { 16, 2, "Mini" },
                    { 17, 2, "One Shoulder" },
                    { 18, 2, "Prom" },
                    { 19, 2, "Strapless" },
                    { 20, 2, "Wedding" },
                    { 21, 2, "Other" },
                    { 22, 3, "Blazer/SuitJacket" },
                    { 23, 3, "Bomber Jacket" },
                    { 24, 3, "Cape" },
                    { 25, 3, "Denim Jacket" },
                    { 26, 3, "Leather Jacket" },
                    { 27, 3, "Pea Coat" },
                    { 28, 3, "Parka" },
                    { 29, 3, "Puffer" },
                    { 30, 3, "Ski/Snow Jacket" },
                    { 31, 3, "Trench Coat" },
                    { 32, 3, "Utility Jacket" },
                    { 33, 3, "Varsity Jacket" },
                    { 34, 3, "Vest" },
                    { 35, 3, "Windbreaker" },
                    { 36, 3, "Other" },
                    { 37, 4, "Ankle/Cropped" },
                    { 38, 4, "Bootcut" },
                    { 39, 4, "Flare" },
                    { 40, 4, "High Waist" },
                    { 41, 4, "Skinny" },
                    { 42, 4, "Straight Leg" },
                    { 43, 4, "Wide Leg" },
                    { 44, 4, "Other" },
                    { 45, 5, "Ankle/Cropped" },
                    { 46, 5, "Bootcut" },
                    { 47, 5, "Cargo" },
                    { 48, 5, "Chino" },
                    { 49, 5, "Corduroy" },
                    { 51, 5, "Flare" },
                    { 52, 5, "Jogger" },
                    { 54, 5, "Leggings" },
                    { 56, 5, "Patterned" },
                    { 57, 5, "Skinny" },
                    { 58, 5, "Straight Leg" },
                    { 59, 5, "Sweatpants" },
                    { 60, 5, "Trousers" },
                    { 61, 5, "Wide Leg" },
                    { 62, 5, "Workwear" },
                    { 63, 5, "Other" },
                    { 64, 6, "Blouse" },
                    { 65, 6, "Bodysuit" },
                    { 66, 6, "Button Down" },
                    { 67, 6, "Crop Top" },
                    { 68, 6, "Cut Off" },
                    { 69, 6, "Hoodie" },
                    { 70, 6, "Polo" },
                    { 71, 6, "Sweatshirt" },
                    { 72, 6, "Tank Top" },
                    { 73, 6, "T-Shirt- Long Sleeve" },
                    { 74, 6, "T-Shirt- Short Sleeve" },
                    { 75, 6, "Other" },
                    { 76, 7, "Ankle Boots" },
                    { 77, 7, "Combat Boot" },
                    { 78, 7, "Cowboy Boots" },
                    { 79, 7, "Flats/Loafers" },
                    { 80, 7, "Heeled Boots" },
                    { 81, 7, "High Heels" },
                    { 82, 7, "Mules/Clogs" },
                    { 83, 7, "Platforms" },
                    { 84, 7, "Sandals" },
                    { 85, 7, "Sneakers" },
                    { 86, 7, "Snow/Rain Boots" },
                    { 87, 7, "Wedges" },
                    { 88, 7, "Other" },
                    { 89, 8, "Athletic" },
                    { 90, 8, "Bermuda" },
                    { 91, 8, "Bike Shorts" },
                    { 92, 8, "Cargo" },
                    { 93, 8, "Denim" },
                    { 94, 8, "High Waist" },
                    { 95, 8, "Skort" },
                    { 96, 8, "Other" },
                    { 97, 9, "A-Line/Full" },
                    { 98, 9, "Asymetrical" },
                    { 99, 9, "Circle/Skater" },
                    { 100, 9, "High Low" },
                    { 101, 9, "Maxi" },
                    { 102, 9, "Midi" },
                    { 103, 9, "Mini" },
                    { 104, 9, "Pencil" },
                    { 105, 9, "Other" },
                    { 106, 10, "Cardigan" },
                    { 107, 10, "Cowl Neck" },
                    { 108, 10, "Crew Neck" },
                    { 109, 10, "Off-the-Shoulder" },
                    { 110, 10, "Poncho" },
                    { 111, 10, "Scoop Neck" },
                    { 112, 10, "Shrugs" },
                    { 113, 10, "Turtleneck" },
                    { 114, 10, "V-Neck" },
                    { 115, 10, "Zip-Up" },
                    { 116, 10, "Other" },
                    { 117, 11, "Jumpsuit" },
                    { 118, 11, "Overalls" },
                    { 119, 11, "Coveralls" },
                    { 120, 11, "Two piece" },
                    { 121, 11, "Track suit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListingSiteProduct_ListingSiteId",
                table: "ListingSiteProduct",
                column: "ListingSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ListingSiteProduct_ProductId",
                table: "ListingSiteProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryId",
                table: "Product",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sold_ListingSiteProductId",
                table: "Sold",
                column: "ListingSiteProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.DropTable(
                name: "Sold");

            migrationBuilder.DropTable(
                name: "ListingSiteProduct");

            migrationBuilder.DropTable(
                name: "ListingSite");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
