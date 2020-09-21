using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class tableviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8528ce6-37db-43c3-ae37-cdd1e569ea4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c80445b2-a498-4fa7-a190-21835e2144c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7c69e57-8af7-4c28-8e48-939a99ce9afa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68ee4761-3223-4350-95a2-09d981ab8a4e", "74e873f2-ffde-47b0-afbf-d2e0ae68f1c8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db437a0e-88e2-4c10-9d08-5384a538dbc8", "ad423b16-0cca-4c50-9566-041d9eaef8d2", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3018050-6810-4c5c-9055-a8ef0588b3b9", "c8568b70-8412-4123-bf1b-5ca5f53685cc", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68ee4761-3223-4350-95a2-09d981ab8a4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3018050-6810-4c5c-9055-a8ef0588b3b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db437a0e-88e2-4c10-9d08-5384a538dbc8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8528ce6-37db-43c3-ae37-cdd1e569ea4e", "49c15cc6-f127-4aae-bb0a-7c59ef558964", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c80445b2-a498-4fa7-a190-21835e2144c6", "498f5407-a89f-460b-a20b-6797e2722206", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7c69e57-8af7-4c28-8e48-939a99ce9afa", "0129e6e3-d5ee-4d5e-94c9-77ba163293e8", "Customer", "CUSTOMER" });
        }
    }
}
