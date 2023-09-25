using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RetailResaleApi.Migrations
{
    /// <inheritdoc />
    public partial class CreatedConditionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ConditionId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Condition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Condition",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, "Brand New" },
                    { 2, "Like New" },
                    { 3, "Used - Excellent" },
                    { 4, "Used - Good" },
                    { 5, "Used - Fair" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ConditionId",
                table: "Product",
                column: "ConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Condition_ConditionId",
                table: "Product",
                column: "ConditionId",
                principalTable: "Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Condition_ConditionId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropIndex(
                name: "IX_Product_ConditionId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ConditionId",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Product",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
