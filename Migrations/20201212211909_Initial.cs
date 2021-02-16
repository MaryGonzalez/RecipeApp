using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrepTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Servings = table.Column<int>(type: "int", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Directions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "B", "Breakfast" },
                    { "D", "Desserts" },
                    { "V", "Main Dishes-Vegetarian" },
                    { "M", "Main Dishes-Meat" },
                    { "BR", "Breads" },
                    { "S", "Soups" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Author", "CategoryId", "Directions", "Image", "Ingredients", "Name", "PrepTime", "Servings", "TotalTime" },
                values: new object[] { 2, "The Salty Marshmallow", "B", "Test Data", "BelgianWaffles.jpg", "Test", "Homemade Belgian Waffles", "15 minutes", 8, "35 minutes" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Author", "CategoryId", "Directions", "Image", "Ingredients", "Name", "PrepTime", "Servings", "TotalTime" },
                values: new object[] { 1, "Betty Crocker Kitchens", "D", "Test Data", "ChocolateChip.jpg", "Test", "Ultimate Chocolate Chip Cookies", "15 minutes", 48, "1 HR 30 MIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
