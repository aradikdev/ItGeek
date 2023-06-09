﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItGeek.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedPostContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PostContents_PostId",
                table: "PostContents");

            migrationBuilder.CreateIndex(
                name: "IX_PostContents_PostId",
                table: "PostContents",
                column: "PostId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PostContents_PostId",
                table: "PostContents");

            migrationBuilder.CreateIndex(
                name: "IX_PostContents_PostId",
                table: "PostContents",
                column: "PostId");
        }
    }
}
