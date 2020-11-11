using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Innitial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nguoitoida",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nguoitoithieu",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "561fd4a0-6f3a-4b39-8a71-662a8edfd7c5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03ecdc98-068f-4f31-9dd1-6475eecd0fb8", "AQAAAAEAACcQAAAAENdgFwsNkwrkqy1zjXSZj5LcQTjVRcggRYc7q9el59NFQjcsH8npk1eYC+iHfLIqbQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nguoitoida",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "nguoitoithieu",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a8cba191-17f2-4549-9979-81c1fee08f5a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78c9cba1-90ee-42f9-a54c-427a04966f6b", "AQAAAAEAACcQAAAAEACF4nHQUayTHvbVIWACGRAeCzgGyxhr9hx5kRurU7CKBl5NZXwx1+KiMzIDpz3m4A==" });
        }
    }
}
