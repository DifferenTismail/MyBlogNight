using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogNight.DataAccessLayer.Migrations
{
    public partial class newColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleCount",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleCount",
                table: "Categories");
        }
    }
}
