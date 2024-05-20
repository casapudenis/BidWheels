using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BidWheels.Migrations
{
    /// <inheritdoc />
    public partial class seventhmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Brands_BrandId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Colors_ColorId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Engines_EngineId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transmissions_TransmissionId",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fc4b452-5392-47e8-a306-74119d30e4eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a3ddda2-a89c-473e-abbd-f4355c01cd94");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");

            migrationBuilder.RenameIndex(
                name: "IX_Car_TransmissionId",
                table: "Cars",
                newName: "IX_Cars_TransmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_EngineId",
                table: "Cars",
                newName: "IX_Cars_EngineId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_ColorId",
                table: "Cars",
                newName: "IX_Cars_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_BrandId",
                table: "Cars",
                newName: "IX_Cars_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "66040507-5d63-42f3-bec4-4d8611870e1b", null, "client", "client" },
                    { "80cb6037-a622-4139-80ef-172944928a7a", null, "admin", "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Engines_EngineId",
                table: "Cars",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Transmissions_TransmissionId",
                table: "Cars",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Engines_EngineId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Transmissions_TransmissionId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66040507-5d63-42f3-bec4-4d8611870e1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80cb6037-a622-4139-80ef-172944928a7a");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Car");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_TransmissionId",
                table: "Car",
                newName: "IX_Car_TransmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_EngineId",
                table: "Car",
                newName: "IX_Car_EngineId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ColorId",
                table: "Car",
                newName: "IX_Car_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandId",
                table: "Car",
                newName: "IX_Car_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
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
                name: "FK_Car_Brands_BrandId",
                table: "Car",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Colors_ColorId",
                table: "Car",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Engines_EngineId",
                table: "Car",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transmissions_TransmissionId",
                table: "Car",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
