using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IvanCastronuno.Migrations
{
    public partial class Validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    StoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoryTitle = table.Column<string>(maxLength: 50, nullable: false),
                    StoryTopic = table.Column<string>(maxLength: 25, nullable: false),
                    StoryText = table.Column<string>(maxLength: 250, nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    StoryTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.StoryID);
                    table.ForeignKey(
                        name: "FK_Story_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "UserName" },
                values: new object[,]
                {
                    { "1", "Johnny" },
                    { "2", "Tommy" },
                    { "3", "Danny" },
                    { "4", "Mannly" },
                    { "5", "Conny" },
                    { "6", "Sunny" },
                    { "7", "Diandra" }
                });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryID", "StoryText", "StoryTime", "StoryTitle", "StoryTopic", "UserId" },
                values: new object[] { 1, "To do a travel wearing armor isn't fun", new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Viaje", "Travel", "1" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryID", "StoryText", "StoryTime", "StoryTitle", "StoryTopic", "UserId" },
                values: new object[] { 2, "To redo your costume three times for not follow the instructions is a common noob mistake.", new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Crafting", "Use instructions", "6" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryID", "StoryText", "StoryTime", "StoryTitle", "StoryTopic", "UserId" },
                values: new object[] { 3, "When on a recreation , if u have food , you'll find friends", new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Food", "Find friends", "7" });

            migrationBuilder.CreateIndex(
                name: "IX_Story_UserId",
                table: "Story",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
