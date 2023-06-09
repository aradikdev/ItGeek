using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItGeek.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedPostContent3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.DropIndex(
                name: "IX_PostContents_PostId",
                table: "PostContents");

            migrationBuilder.CreateTable(
                name: "PostCategory",
                columns: table => new
                {
                    PostsId = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategory", x => new { x.PostsId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_PostCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostCategory_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostContents_PostId",
                table: "PostContents",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_CategoriesId",
                table: "PostCategory",
                column: "CategoriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostCategory");

            migrationBuilder.DropIndex(
                name: "IX_PostContents_PostId",
                table: "PostContents");

            migrationBuilder.CreateTable(
                name: "CategoryPost",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    PostsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPost", x => new { x.CategoriesId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_CategoryPost_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPost_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostContents_PostId",
                table: "PostContents",
                column: "PostId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPost_PostsId",
                table: "CategoryPost",
                column: "PostsId");
        }
    }
}
