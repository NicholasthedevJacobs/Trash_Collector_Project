using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class forgotstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0fc117e9-5c61-4dce-ba7f-ac0b26c41c6c", "5ea8279d-b9fa-4907-bbbd-12bbefd3ca65", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1270cc1-211b-4ddb-95d3-482930841a51", "c8a341ed-e284-40a6-a44a-46acc820f326", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0385bc4a-a6b9-4a13-998a-f27e242a8d58", "11503875-e7cd-4077-ade5-e349b3fdc184", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0385bc4a-a6b9-4a13-998a-f27e242a8d58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fc117e9-5c61-4dce-ba7f-ac0b26c41c6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1270cc1-211b-4ddb-95d3-482930841a51");

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
    }
}
