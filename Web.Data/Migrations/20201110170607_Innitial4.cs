using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Innitial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "abbadd63-865b-4ecd-a157-9da6fe86ec55");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "48e922d5-4d50-4976-8e56-7279f835b37b", "AQAAAAEAACcQAAAAEHZl3TaFyef7BANjZbCBMi+zRXBONqSc8K5uac1SS8yNv4oSZ4OiIDbFLEqgv768ew==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5c3b126f-b1e5-4e2b-a83b-34e27ff8ca46");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a855852d-7952-411d-bc1e-edb2cd4a1e60", "AQAAAAEAACcQAAAAEFyzCjUhjgghc5elvYNjHjucxu0NHz2xORkLGCZ51bGaK0sFJUluJWKP4XsM5QSpBg==" });
        }
    }
}
