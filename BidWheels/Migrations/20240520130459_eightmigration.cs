using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BidWheels.Migrations
{
    /// <inheritdoc />
    public partial class eightmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66040507-5d63-42f3-bec4-4d8611870e1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80cb6037-a622-4139-80ef-172944928a7a");

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d542b7e-82ab-43a4-b429-530e46ac388c", null, "client", "client" },
                    { "ba963ace-bd9b-4bd2-b3c1-7dbcfb5e891f", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d542b7e-82ab-43a4-b429-530e46ac388c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba963ace-bd9b-4bd2-b3c1-7dbcfb5e891f");

            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "66040507-5d63-42f3-bec4-4d8611870e1b", null, "client", "client" },
                    { "80cb6037-a622-4139-80ef-172944928a7a", null, "admin", "admin" }
                });
        }
    }
}
