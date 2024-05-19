using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BidWheels.Migrations
{
    /// <inheritdoc />
    public partial class sixthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Engine_EngineId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engine",
                table: "Engine");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0913f619-697b-45c6-9df5-a88c7cb888de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee38e08-d6d6-4196-920d-7b1010a67fa9");

            migrationBuilder.RenameTable(
                name: "Engine",
                newName: "Engines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engines",
                table: "Engines",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fc4b452-5392-47e8-a306-74119d30e4eb", null, "admin", "admin" },
                    { "9a3ddda2-a89c-473e-abbd-f4355c01cd94", null, "client", "client" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Engines_EngineId",
                table: "Car",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Engines_EngineId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engines",
                table: "Engines");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fc4b452-5392-47e8-a306-74119d30e4eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a3ddda2-a89c-473e-abbd-f4355c01cd94");

            migrationBuilder.RenameTable(
                name: "Engines",
                newName: "Engine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engine",
                table: "Engine",
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
                name: "FK_Car_Engine_EngineId",
                table: "Car",
                column: "EngineId",
                principalTable: "Engine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
