using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BidWheels.Migrations
{
    /// <inheritdoc />
    public partial class fifthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transmission_TransmissionId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transmission",
                table: "Transmission");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2983d59-3477-4f6d-87cd-c68bcce7393e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c492b3a5-0d0a-4f5b-9645-c8a8c8795406");

            migrationBuilder.RenameTable(
                name: "Transmission",
                newName: "Transmissions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transmissions",
                table: "Transmissions",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0913f619-697b-45c6-9df5-a88c7cb888de", null, "client", "client" },
                    { "1ee38e08-d6d6-4196-920d-7b1010a67fa9", null, "admin", "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transmissions_TransmissionId",
                table: "Car",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transmissions_TransmissionId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transmissions",
                table: "Transmissions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0913f619-697b-45c6-9df5-a88c7cb888de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee38e08-d6d6-4196-920d-7b1010a67fa9");

            migrationBuilder.RenameTable(
                name: "Transmissions",
                newName: "Transmission");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transmission",
                table: "Transmission",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c2983d59-3477-4f6d-87cd-c68bcce7393e", null, "client", "client" },
                    { "c492b3a5-0d0a-4f5b-9645-c8a8c8795406", null, "admin", "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transmission_TransmissionId",
                table: "Car",
                column: "TransmissionId",
                principalTable: "Transmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
