using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategory_blogs_blogsBlagId",
                table: "BlogCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_blogBlagId",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_blogBlagId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "blogBlagId",
                table: "comments");

            migrationBuilder.RenameColumn(
                name: "BlagId",
                table: "comments",
                newName: "BlogId");

            migrationBuilder.RenameColumn(
                name: "BlagId",
                table: "blogs",
                newName: "BlogId");

            migrationBuilder.RenameColumn(
                name: "blogsBlagId",
                table: "BlogCategory",
                newName: "blogsBlogId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_BlogId",
                table: "comments",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategory_blogs_blogsBlogId",
                table: "BlogCategory",
                column: "blogsBlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_BlogId",
                table: "comments",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategory_blogs_blogsBlogId",
                table: "BlogCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_BlogId",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_BlogId",
                table: "comments");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "comments",
                newName: "BlagId");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "blogs",
                newName: "BlagId");

            migrationBuilder.RenameColumn(
                name: "blogsBlogId",
                table: "BlogCategory",
                newName: "blogsBlagId");

            migrationBuilder.AddColumn<int>(
                name: "blogBlagId",
                table: "comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_comments_blogBlagId",
                table: "comments",
                column: "blogBlagId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategory_blogs_blogsBlagId",
                table: "BlogCategory",
                column: "blogsBlagId",
                principalTable: "blogs",
                principalColumn: "BlagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_blogBlagId",
                table: "comments",
                column: "blogBlagId",
                principalTable: "blogs",
                principalColumn: "BlagId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
