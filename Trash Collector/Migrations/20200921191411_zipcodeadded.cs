using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class zipcodeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "027124c9-8777-4ee7-9441-632707d0805e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b4f595-4a5d-42d2-b9ae-9803bd529b75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc0451bd-a6cf-40c5-8a11-0af6f27b3c44");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7f27e11-ba0f-4460-a782-20daf52911be", "e9096504-87e1-4a27-88ec-519dddbddeab", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f6f1ebf-5c98-4273-8852-c44e79c509af", "9ad59d23-45b1-4e58-86f1-898ee5d32769", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d30c645-a18b-4dae-a197-314e3f9b7ba3", "4d08e0b5-2c57-4ebb-8140-b252be7ebc55", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f6f1ebf-5c98-4273-8852-c44e79c509af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d30c645-a18b-4dae-a197-314e3f9b7ba3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7f27e11-ba0f-4460-a782-20daf52911be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc0451bd-a6cf-40c5-8a11-0af6f27b3c44", "337a1142-7ae4-47f0-91a7-22c3a5176fb5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "027124c9-8777-4ee7-9441-632707d0805e", "68a6501c-0e66-485f-8bc7-fda711827351", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1b4f595-4a5d-42d2-b9ae-9803bd529b75", "fd9c275d-3502-4cc5-8a3e-68cf08b86849", "Customer", "CUSTOMER" });
        }
    }
}
