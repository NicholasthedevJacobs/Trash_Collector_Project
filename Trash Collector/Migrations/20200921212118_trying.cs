using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class trying : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "094b988c-c73b-4479-b067-df567a9797a7", "b9997fbd-4476-48de-ab16-6002de7b9a08", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73826781-f9eb-4dea-8253-6a2eea0adf84", "b6a699e2-9467-43cd-b322-3afde4bce526", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9a90984-5d58-471d-aa59-581028ccbb6f", "165e1317-85f7-471a-b6f4-cc7f4df24b04", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094b988c-c73b-4479-b067-df567a9797a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73826781-f9eb-4dea-8253-6a2eea0adf84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a90984-5d58-471d-aa59-581028ccbb6f");

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
    }
}
