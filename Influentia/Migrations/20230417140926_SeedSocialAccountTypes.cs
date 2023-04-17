using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Influentia.Migrations
{
    public partial class SeedSocialAccountTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SocialAccountTypes",
                columns: new[] { "Id", "AccountType" },
                values: new object[,]
                {
                    { 1, "Facebook" },
                    { 2, "Instagram" },
                    { 3, "Twitter" },
                    { 4, "Youtube" },
                    { 5, "LinkedIn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialAccountTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialAccountTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialAccountTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialAccountTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SocialAccountTypes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
