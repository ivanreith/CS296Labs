using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IvanCastronuno.Migrations
{
    public partial class seedless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14517817-2c79-4e06-9fd0-5f549a9d549a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "420a9fe5-981a-4043-b947-959037d6cc0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65bd40b3-a7ce-4414-9749-dce37b221db8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97a426c8-0dee-4ac8-a70d-1725e6b9ee94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf56465b-d047-486e-9012-9a9188cf09a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c39d63a3-b37e-44ab-844e-05a1848dbcb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14715e4-5e86-4d4c-8583-eb640f640d46");

            migrationBuilder.DeleteData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Name" },
                values: new object[,]
                {
                    { "bf56465b-d047-486e-9012-9a9188cf09a9", 0, "e9c5315a-1f77-4dce-890f-ea069a6a66fc", "AppUser", null, false, false, null, null, null, null, null, false, "d624e8d4-43cc-4bea-b92d-b62b7aa19a9e", false, "Johnny", "Johnny" },
                    { "65bd40b3-a7ce-4414-9749-dce37b221db8", 0, "deb44eb6-8d54-4fb6-8f25-d201c4a7fe41", "AppUser", null, false, false, null, null, null, null, null, false, "c1179e99-b0aa-489e-bd3f-7c87b99c7435", false, "Tommy", "Tommy" },
                    { "14517817-2c79-4e06-9fd0-5f549a9d549a", 0, "7a4e13d4-377c-4e21-989d-fc6fd452c123", "AppUser", null, false, false, null, null, null, null, null, false, "aa17a7cd-dbce-4b1a-8c08-053836feb8b1", false, "Danny", "Danny" },
                    { "97a426c8-0dee-4ac8-a70d-1725e6b9ee94", 0, "712f6233-d5b1-48de-bb52-ea1b2c2755e7", "AppUser", null, false, false, null, null, null, null, null, false, "ba43cdeb-b64f-4bb1-9934-fb225094c7e8", false, "Mannly", "Mannly" },
                    { "e14715e4-5e86-4d4c-8583-eb640f640d46", 0, "4b3fdf63-f535-48e2-bcdf-951359902f63", "AppUser", null, false, false, null, null, null, null, null, false, "8c4bb9fa-f0d5-4b13-815b-c00410bd95d9", false, "Conny", "Conny" },
                    { "c39d63a3-b37e-44ab-844e-05a1848dbcb1", 0, "3103ac96-b29c-4ed9-b09d-ab857c3c75f5", "AppUser", null, false, false, null, null, null, null, null, false, "57588d5f-1411-492f-a834-c2b23d4d4723", false, "Sunny", "Sunny" },
                    { "420a9fe5-981a-4043-b947-959037d6cc0e", 0, "f0dbecbc-8709-4533-b64b-5af441f0626e", "AppUser", null, false, false, null, null, null, null, null, false, "4a0ce6bc-ecb1-4e9d-8da3-672208ab7099", false, "Diandra", "Diandra" }
                });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryID", "PosterId", "StoryText", "StoryTime", "StoryTitle", "StoryTopic" },
                values: new object[,]
                {
                    { 1, null, "To do a travel wearing armor isn't fun", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Viaje", "Travel" },
                    { 2, null, "To redo your costume three times for not follow the instructions is a common noob mistake.", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Crafting", "Use instructions" },
                    { 3, null, "When on a recreation , if u have food , you'll find friends", new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Food", "Find friends" }
                });
        }
    }
}
