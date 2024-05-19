using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BidWheels.Migrations
{
    /// <inheritdoc />
    public partial class forthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6142c351-c467-45c8-960c-e8ed4c80f871");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1a2fac5-90b6-44f2-9be4-d148372ba0e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c2983d59-3477-4f6d-87cd-c68bcce7393e", null, "client", "client" },
                    { "c492b3a5-0d0a-4f5b-9645-c8a8c8795406", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2983d59-3477-4f6d-87cd-c68bcce7393e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c492b3a5-0d0a-4f5b-9645-c8a8c8795406");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6142c351-c467-45c8-960c-e8ed4c80f871", null, "client", "client" },
                    { "b1a2fac5-90b6-44f2-9be4-d148372ba0e7", null, "admin", "admin" }
                });
        }
    }
}
