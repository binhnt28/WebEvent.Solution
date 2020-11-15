using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Innitial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3829b2df-1af6-4d83-9575-71e97ab42b3a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a788250-8c2a-4f6c-86d4-70a930c44eca", "AQAAAAEAACcQAAAAELmv1xjo0OQNA9vJJ6iO8jsrlzfGZpeA/+l/nO6YEjWlJWjwwL/1Z9c3PLQpZ0xwTQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4bbdb00d-9e08-409a-919a-a4e308a4f4a4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "191567ee-c70e-4e73-a99f-e3a3d1cd2ac4", "AQAAAAEAACcQAAAAEDFIORJ5WZgd1Q0U58fvjFU4eQZ8z29wiWtxzmOlPXpXkLVaXfGodilmhUox/Ql6Kg==" });
        }
    }
}
