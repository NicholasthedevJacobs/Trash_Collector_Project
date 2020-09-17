using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e4716cb-c4ef-4bba-8a71-7cd7eefa040a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab3a124a-9393-4aa2-bdce-00fd70fe84c2", "ed1cc20b-7f40-4214-8741-45dbc8abb393", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab3a124a-9393-4aa2-bdce-00fd70fe84c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e4716cb-c4ef-4bba-8a71-7cd7eefa040a", "c2fae68d-8a3f-48bd-945c-68ad093cc80b", "Admin", "ADMIN" });
        }
    }
}
