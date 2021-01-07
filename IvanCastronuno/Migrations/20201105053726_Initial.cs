using Microsoft.EntityFrameworkCore.Migrations;

namespace IvanCastronuno.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    StoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoryTitle = table.Column<string>(nullable: true),
                    StoryTopic = table.Column<string>(nullable: true),
                    StoryText = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.StoryID);
                    table.ForeignKey(
                        name: "FK_Stories_User_UserId",
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
                table: "Stories",
                columns: new[] { "StoryID", "StoryText", "StoryTitle", "StoryTopic", "UserId" },
                values: new object[] { 1, "To do a travel wearing armor isn't fun", "Viaje", "Travel", "1" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "StoryID", "StoryText", "StoryTitle", "StoryTopic", "UserId" },
                values: new object[] { 2, "To redo your costume three times for not follow the instructions is a common noob mistake.", "Crafting", "Use instructions", "6" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "StoryID", "StoryText", "StoryTitle", "StoryTopic", "UserId" },
                values: new object[] { 3, "When on a recreation , if u have food , you'll find friends", "Food", "Find friends", "7" });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_UserId",
                table: "Stories",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stories");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
