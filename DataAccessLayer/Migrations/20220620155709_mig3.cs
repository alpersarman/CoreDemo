using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlagId",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "FK_comments_blogs_blogBlagId",
                table: "comments",
                column: "blogBlagId",
                principalTable: "blogs",
                principalColumn: "BlagId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_blogBlagId",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_blogBlagId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "BlagId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "blogBlagId",
                table: "comments");
        }
    }
}
