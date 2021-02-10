using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IvanCastronuno.Migrations
{
    public partial class comment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CommentDate",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CommentText",
                table: "Comments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CommenterId",
                table: "Comments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommenterId",
                table: "Comments",
                column: "CommenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CommenterId",
                table: "Comments",
                column: "CommenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommenterId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommenterId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentText",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommenterId",
                table: "Comments");
        }
    }
}
