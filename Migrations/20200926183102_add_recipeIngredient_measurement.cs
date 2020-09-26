using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeBox2.Migrations
{
    public partial class add_recipeIngredient_measurement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Measurement",
                table: "RecipeIngredient",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Measurement",
                table: "RecipeIngredient");
        }
    }
}
