using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BlogCategory",
                columns: table => new
                {
                    blogsBlagId = table.Column<int>(type: "int", nullable: false),
                    categoriesCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategory", x => new { x.blogsBlagId, x.categoriesCategoryId });
                    table.ForeignKey(
                        name: "FK_BlogCategory_blogs_blogsBlagId",
                        column: x => x.blogsBlagId,
                        principalTable: "blogs",
                        principalColumn: "BlagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogCategory_categories_categoriesCategoryId",
                        column: x => x.categoriesCategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategory_categoriesCategoryId",
                table: "BlogCategory",
                column: "categoriesCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "blogs");
        }
    }
}
