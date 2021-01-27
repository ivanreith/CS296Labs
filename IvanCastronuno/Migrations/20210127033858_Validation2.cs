using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IvanCastronuno.Migrations
{
    public partial class Validation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aab63df-014d-477a-9cfe-37910223d495");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60a427a2-25e6-4df5-a26c-33d31eeef1b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8588e411-47f9-4c7a-929b-3a22f2bfca5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90381cf3-eeef-4af0-bfcc-0fa26497ff0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0dd29b9-f96f-425a-be8a-f2f8a5bcba15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b342a0eb-d623-4ce2-82ba-a2f793e9efec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2f38745-ccf3-4b43-9721-a6a557b2126a");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Story");

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

            migrationBuilder.UpdateData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 1,
                column: "StoryTime",
                value: new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 2,
                column: "StoryTime",
                value: new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 3,
                column: "StoryTime",
                value: new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Story",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Name" },
                values: new object[,]
                {
                    { "60a427a2-25e6-4df5-a26c-33d31eeef1b9", 0, "cc29556a-aede-49a0-82b6-4bf9d7217b82", "AppUser", null, false, false, null, null, null, null, null, false, "4e6990c9-f336-4112-af76-7373edbe5c26", false, null, "Johnny" },
                    { "d2f38745-ccf3-4b43-9721-a6a557b2126a", 0, "5f65b656-fdae-48eb-9108-2ba68e6aa9d8", "AppUser", null, false, false, null, null, null, null, null, false, "fc2ea4a9-0214-4261-9ea7-c74941ef269f", false, null, "Tommy" },
                    { "8588e411-47f9-4c7a-929b-3a22f2bfca5b", 0, "622127fd-ee7c-4e86-ba6c-44f48e684eaa", "AppUser", null, false, false, null, null, null, null, null, false, "d7b9964f-f878-4c45-b8e5-5c432305a3bb", false, null, "Danny" },
                    { "b342a0eb-d623-4ce2-82ba-a2f793e9efec", 0, "06448b97-948a-45f8-8090-126d8c357895", "AppUser", null, false, false, null, null, null, null, null, false, "55217e98-547b-4c83-b93c-2495e5cd88d7", false, null, "Mannly" },
                    { "90381cf3-eeef-4af0-bfcc-0fa26497ff0a", 0, "a414e7d8-87e8-4fcb-af64-54955e60843e", "AppUser", null, false, false, null, null, null, null, null, false, "18cc037a-4e42-44b3-8780-e8b47013d4de", false, null, "Conny" },
                    { "2aab63df-014d-477a-9cfe-37910223d495", 0, "59314fd2-80dc-4d13-85fa-2bce23538c91", "AppUser", null, false, false, null, null, null, null, null, false, "5138b283-b2cc-4763-89a5-5fc79742d3d5", false, null, "Sunny" },
                    { "a0dd29b9-f96f-425a-be8a-f2f8a5bcba15", 0, "50cee1fd-88f7-4921-9246-80d739da532f", "AppUser", null, false, false, null, null, null, null, null, false, "a3325a4f-ea20-48e2-becf-b5ad2cf5d95b", false, null, "Diandra" }
                });

            migrationBuilder.UpdateData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 1,
                columns: new[] { "Name", "StoryTime" },
                values: new object[] { "Johnny", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 2,
                columns: new[] { "Name", "StoryTime" },
                values: new object[] { "Mannly", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Story",
                keyColumn: "StoryID",
                keyValue: 3,
                columns: new[] { "Name", "StoryTime" },
                values: new object[] { "Diandra", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
