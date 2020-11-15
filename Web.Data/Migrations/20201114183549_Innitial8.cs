using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Innitial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TicketName",
                table: "Participants",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4b76e89b-ca83-4719-b391-ded1b50dbf3b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "926c98aa-dd3e-440f-8d19-5fdaefde5f1e", "AQAAAAEAACcQAAAAENS4cg8kRWUGOWFjJXZNSaK2Ty1jC3ytfa+B9w8NJfM8Y5MePAUASoQBiPrNANOH3g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketName",
                table: "Participants");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a237f478-a709-4e71-858e-99096ec10b82");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e98ab06-ea52-4ea2-ba24-ff6ff6c9c63c", "AQAAAAEAACcQAAAAEAeqALVngmRFhJRtKwqGybrFkFwCrdv82tRh1euyg+KCrzHyCG6f0xq4TyvzSciWbQ==" });
        }
    }
}
