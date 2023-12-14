using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetailResaleApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSoldListingSiteProductRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sold_ListingSiteProduct_ListingSiteProductId",
                table: "Sold");

            migrationBuilder.DropIndex(
                name: "IX_Sold_ListingSiteProductId",
                table: "Sold");

            migrationBuilder.DropColumn(
                name: "ListingSiteProductId",
                table: "Sold");

            migrationBuilder.AddColumn<int>(
                name: "SoldId",
                table: "ListingSiteProduct",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListingSiteProduct_SoldId",
                table: "ListingSiteProduct",
                column: "SoldId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListingSiteProduct_Sold_SoldId",
                table: "ListingSiteProduct",
                column: "SoldId",
                principalTable: "Sold",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListingSiteProduct_Sold_SoldId",
                table: "ListingSiteProduct");

            migrationBuilder.DropIndex(
                name: "IX_ListingSiteProduct_SoldId",
                table: "ListingSiteProduct");

            migrationBuilder.DropColumn(
                name: "SoldId",
                table: "ListingSiteProduct");

            migrationBuilder.AddColumn<int>(
                name: "ListingSiteProductId",
                table: "Sold",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sold_ListingSiteProductId",
                table: "Sold",
                column: "ListingSiteProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sold_ListingSiteProduct_ListingSiteProductId",
                table: "Sold",
                column: "ListingSiteProductId",
                principalTable: "ListingSiteProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
