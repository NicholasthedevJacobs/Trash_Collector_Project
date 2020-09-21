using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class updatedviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6d84d910-6ff6-40cd-9f33-966e7f3bf742", "46049115-c4fc-4669-9c0e-49c4a2967afa", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f50cfaf-2041-4dee-ab49-34b718b4f904", "7966e45c-96c2-4590-97f1-8ef32d582256", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae6b8718-5d34-424c-a85e-3e5686e9d91a", "0636ee9f-58fc-4a49-9643-5352916611c4", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d84d910-6ff6-40cd-9f33-966e7f3bf742");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f50cfaf-2041-4dee-ab49-34b718b4f904");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae6b8718-5d34-424c-a85e-3e5686e9d91a");

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
    }
}
