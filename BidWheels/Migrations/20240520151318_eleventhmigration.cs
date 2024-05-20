using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BidWheels.Migrations
{
    /// <inheritdoc />
    public partial class eleventhmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18201546-e78c-4ba1-ac35-46e27d136866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a410fed1-372e-4168-a156-524e9ba06531");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9f6fd3f3-0109-4335-aada-c08677729563", null, "admin", "admin" },
                    { "f0861ce5-3737-4a10-a317-3f6841c69ebf", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f6fd3f3-0109-4335-aada-c08677729563");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0861ce5-3737-4a10-a317-3f6841c69ebf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18201546-e78c-4ba1-ac35-46e27d136866", null, "admin", "admin" },
                    { "a410fed1-372e-4168-a156-524e9ba06531", null, "client", "client" }
                });
        }
    }
}
