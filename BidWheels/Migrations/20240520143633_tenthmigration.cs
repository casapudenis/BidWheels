using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BidWheels.Migrations
{
    /// <inheritdoc />
    public partial class tenthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "498e7a0a-0c4a-4b89-a59c-683da7406cc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e012cd-d42a-4fb2-91e7-4dc6fbd77f4f");

            migrationBuilder.AlterColumn<string>(
                name: "CurrentBidderId",
                table: "Auctions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18201546-e78c-4ba1-ac35-46e27d136866", null, "admin", "admin" },
                    { "a410fed1-372e-4168-a156-524e9ba06531", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18201546-e78c-4ba1-ac35-46e27d136866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a410fed1-372e-4168-a156-524e9ba06531");

            migrationBuilder.AlterColumn<string>(
                name: "CurrentBidderId",
                table: "Auctions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "498e7a0a-0c4a-4b89-a59c-683da7406cc6", null, "client", "client" },
                    { "73e012cd-d42a-4fb2-91e7-4dc6fbd77f4f", null, "admin", "admin" }
                });
        }
    }
}
