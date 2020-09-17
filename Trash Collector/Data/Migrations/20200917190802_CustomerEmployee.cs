﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class CustomerEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab3a124a-9393-4aa2-bdce-00fd70fe84c2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab3a124a-9393-4aa2-bdce-00fd70fe84c2", "ed1cc20b-7f40-4214-8741-45dbc8abb393", "Admin", "ADMIN" });
        }
    }
}