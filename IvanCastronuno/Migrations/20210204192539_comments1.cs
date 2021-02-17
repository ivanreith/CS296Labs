using Microsoft.EntityFrameworkCore.Migrations;

namespace IvanCastronuno.Migrations
{
    public partial class comments1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoriesModelFormStoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Story_StoriesModelFormStoryID",
                        column: x => x.StoriesModelFormStoryID,
                        principalTable: "Story",
                        principalColumn: "StoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StoriesModelFormStoryID",
                table: "Comments",
                column: "StoriesModelFormStoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
