using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItGeek.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedPostContent4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostCategory_Categories_CategoriesId",
                table: "PostCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_PostCategory_Posts_PostsId",
                table: "PostCategory");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "PostCategory",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "PostsId",
                table: "PostCategory",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_PostCategory_CategoriesId",
                table: "PostCategory",
                newName: "IX_PostCategory_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostCategory_Categories_CategoryId",
                table: "PostCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostCategory_Posts_PostId",
                table: "PostCategory",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostCategory_Categories_CategoryId",
                table: "PostCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_PostCategory_Posts_PostId",
                table: "PostCategory");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "PostCategory",
                newName: "CategoriesId");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "PostCategory",
                newName: "PostsId");

            migrationBuilder.RenameIndex(
                name: "IX_PostCategory_CategoryId",
                table: "PostCategory",
                newName: "IX_PostCategory_CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostCategory_Categories_CategoriesId",
                table: "PostCategory",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostCategory_Posts_PostsId",
                table: "PostCategory",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
