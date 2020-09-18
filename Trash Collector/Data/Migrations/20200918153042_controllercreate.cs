using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class controllercreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05daa207-8f99-4931-95c0-4bec474ac6a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "294b7ce6-0aa8-4a73-bc0e-a8cd3c63f229");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e36ea1a7-ef31-45be-ad34-005d533a1108");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PickupDay = table.Column<string>(nullable: true),
                    ExtraPickup = table.Column<string>(nullable: true),
                    MoneyOwed = table.Column<double>(nullable: false),
                    TrashCollected = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d02db08-93b9-4f63-8d91-751fd2583d70", "d624505c-0f8d-4906-b8fc-b2062277c437", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "648a4cbd-1282-457b-a8c8-1c73876146dc", "1a8863dc-7584-497f-a469-b2f867e30a24", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "591cbd57-7590-45e2-b6bd-aa483be495f6", "e8c22d51-7a76-4ecb-891c-59824a752e3a", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d02db08-93b9-4f63-8d91-751fd2583d70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "591cbd57-7590-45e2-b6bd-aa483be495f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "648a4cbd-1282-457b-a8c8-1c73876146dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05daa207-8f99-4931-95c0-4bec474ac6a4", "6067ad5d-972a-48be-a61f-ec2c867727a9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "294b7ce6-0aa8-4a73-bc0e-a8cd3c63f229", "858954a4-83da-4c15-bfff-d4f7095fc644", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e36ea1a7-ef31-45be-ad34-005d533a1108", "9b9b6ece-fc9f-419f-8398-7cd2bab927dc", "Customer", "CUSTOMER" });
        }
    }
}
